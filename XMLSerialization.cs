using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace HitmanStatistics
{
	[Serializable]
	public class FontStorage
	{
		[Serializable]
		public class FontInfo
		{
			public string FontName;
			public float FontHeight;
			public FontStyle Style;

			public FontInfo()
			{
				FontName = "";
				FontHeight = 12;
				Style = FontStyle.Regular;
			}

			public static implicit operator Font(FontInfo fontInfo)
			{
				return new Font(fontInfo.FontName, fontInfo.FontHeight, fontInfo.Style);
			}

			public static implicit operator FontInfo(Font font)
			{
				return new FontInfo() { FontName = font.Name, FontHeight = font.Size, Style = font.Style };
			}
		}

		public bool DarkMode;
		public FontInfo MapName;
		public FontInfo TimerText;
		public FontInfo LevelTime;
		public FontInfo ValuesFont;
		public FontInfo ValuesTextFont;
		public FontInfo SilentAssassin;


		public FontStorage()
		{
			MapName = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);
			TimerText = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
			LevelTime = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
			ValuesFont = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
			ValuesTextFont = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
			SilentAssassin = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
		}
	}

	public class XMLSerialization
	{
		public static T ReadFromXMLFile<T>(string filePath) where T : new()
		{
			StreamReader reader = null;
			try
			{
				if (!File.Exists(filePath))
					return new T();

				XmlSerializer serializer = new XmlSerializer(typeof(T));
				reader = new StreamReader(filePath);
				return (T)serializer.Deserialize(reader);
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
		}

		public static void SaveObjectToXML<T>(T objectToStore, string filePath) where T : new()
		{
			if (!Directory.Exists(Directory.GetParent(filePath).FullName))
				Directory.CreateDirectory(Directory.GetParent(filePath).FullName);

			StreamWriter writter = null;

			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				writter = new StreamWriter(filePath);
				serializer.Serialize(writter, objectToStore);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				if (writter != null)
					writter.Close();
			}
		}
	}
}
