namespace HitmanStatistics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.Menu_Game = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Game_H2 = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Game_HC = new System.Windows.Forms.ToolStripMenuItem();
			this.uberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.codename47ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.silentAssassinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.metronomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.levelNameFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timerFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.valuesFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.valuesTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DisplayPanel = new System.Windows.Forms.Panel();
			this.timerTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.silentAssassinTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Game,
            this.uberToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(291, 24);
			this.MainMenu.TabIndex = 34;
			this.MainMenu.Text = "menuStrip1";
			// 
			// Menu_Game
			// 
			this.Menu_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Game_H2,
            this.Menu_Game_HC});
			this.Menu_Game.Name = "Menu_Game";
			this.Menu_Game.Size = new System.Drawing.Size(50, 20);
			this.Menu_Game.Text = "Game";
			// 
			// Menu_Game_H2
			// 
			this.Menu_Game_H2.Name = "Menu_Game_H2";
			this.Menu_Game_H2.Size = new System.Drawing.Size(205, 22);
			this.Menu_Game_H2.Text = "Hitman 2: Silent Assassin";
			this.Menu_Game_H2.Click += new System.EventHandler(this.Menu_Game_H2_Click);
			// 
			// Menu_Game_HC
			// 
			this.Menu_Game_HC.Name = "Menu_Game_HC";
			this.Menu_Game_HC.Size = new System.Drawing.Size(205, 22);
			this.Menu_Game_HC.Text = "Hitman: Contracts";
			this.Menu_Game_HC.Click += new System.EventHandler(this.Menu_Game_HC_Click);
			// 
			// uberToolStripMenuItem
			// 
			this.uberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheatsToolStripMenuItem,
            this.metronomeToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.fontSelectionToolStripMenuItem});
			this.uberToolStripMenuItem.Name = "uberToolStripMenuItem";
			this.uberToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.uberToolStripMenuItem.Text = "Uber";
			// 
			// cheatsToolStripMenuItem
			// 
			this.cheatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codename47ToolStripMenuItem,
            this.silentAssassinToolStripMenuItem,
            this.contractsToolStripMenuItem});
			this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
			this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cheatsToolStripMenuItem.Text = "Cheats";
			// 
			// codename47ToolStripMenuItem
			// 
			this.codename47ToolStripMenuItem.Enabled = false;
			this.codename47ToolStripMenuItem.Name = "codename47ToolStripMenuItem";
			this.codename47ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.codename47ToolStripMenuItem.Text = "Codename 47";
			// 
			// silentAssassinToolStripMenuItem
			// 
			this.silentAssassinToolStripMenuItem.Name = "silentAssassinToolStripMenuItem";
			this.silentAssassinToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.silentAssassinToolStripMenuItem.Text = "Silent Assassin";
			this.silentAssassinToolStripMenuItem.Click += new System.EventHandler(this.silentAssassinToolStripMenuItem_Click);
			// 
			// contractsToolStripMenuItem
			// 
			this.contractsToolStripMenuItem.Enabled = false;
			this.contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
			this.contractsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.contractsToolStripMenuItem.Text = "Contracts";
			// 
			// metronomeToolStripMenuItem
			// 
			this.metronomeToolStripMenuItem.Name = "metronomeToolStripMenuItem";
			this.metronomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.metronomeToolStripMenuItem.Text = "Metronome";
			this.metronomeToolStripMenuItem.Click += new System.EventHandler(this.metronomeToolStripMenuItem_Click);
			// 
			// darkToolStripMenuItem
			// 
			this.darkToolStripMenuItem.CheckOnClick = true;
			this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
			this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.darkToolStripMenuItem.Text = "Dark Mode";
			this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
			// 
			// fontSelectionToolStripMenuItem
			// 
			this.fontSelectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelNameFontToolStripMenuItem,
            this.timerTextToolStripMenuItem,
            this.timerFontToolStripMenuItem,
            this.valuesFontToolStripMenuItem,
            this.valuesTextToolStripMenuItem,
            this.silentAssassinTextToolStripMenuItem});
			this.fontSelectionToolStripMenuItem.Name = "fontSelectionToolStripMenuItem";
			this.fontSelectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fontSelectionToolStripMenuItem.Text = "Font selection";
			// 
			// levelNameFontToolStripMenuItem
			// 
			this.levelNameFontToolStripMenuItem.Name = "levelNameFontToolStripMenuItem";
			this.levelNameFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.levelNameFontToolStripMenuItem.Text = "Level name font";
			this.levelNameFontToolStripMenuItem.Click += new System.EventHandler(this.levelNameFontToolStripMenuItem_Click);
			// 
			// timerFontToolStripMenuItem
			// 
			this.timerFontToolStripMenuItem.Name = "timerFontToolStripMenuItem";
			this.timerFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.timerFontToolStripMenuItem.Text = "Timer font";
			this.timerFontToolStripMenuItem.Click += new System.EventHandler(this.timerFontToolStripMenuItem_Click);
			// 
			// valuesFontToolStripMenuItem
			// 
			this.valuesFontToolStripMenuItem.Name = "valuesFontToolStripMenuItem";
			this.valuesFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.valuesFontToolStripMenuItem.Text = "Values font";
			this.valuesFontToolStripMenuItem.Click += new System.EventHandler(this.valuesFontToolStripMenuItem_Click);
			// 
			// valuesTextToolStripMenuItem
			// 
			this.valuesTextToolStripMenuItem.Name = "valuesTextToolStripMenuItem";
			this.valuesTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.valuesTextToolStripMenuItem.Text = "Values text font";
			this.valuesTextToolStripMenuItem.Click += new System.EventHandler(this.valuesTextToolStripMenuItem_Click);
			// 
			// DisplayPanel
			// 
			this.DisplayPanel.AutoSize = true;
			this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.DisplayPanel.Location = new System.Drawing.Point(0, 24);
			this.DisplayPanel.Name = "DisplayPanel";
			this.DisplayPanel.Size = new System.Drawing.Size(291, 0);
			this.DisplayPanel.TabIndex = 0;
			// 
			// timerTextToolStripMenuItem
			// 
			this.timerTextToolStripMenuItem.Name = "timerTextToolStripMenuItem";
			this.timerTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.timerTextToolStripMenuItem.Text = "Timer text";
			this.timerTextToolStripMenuItem.Click += new System.EventHandler(this.timerTextToolStripMenuItem_Click);
			// 
			// silentAssassinTextToolStripMenuItem
			// 
			this.silentAssassinTextToolStripMenuItem.Name = "silentAssassinTextToolStripMenuItem";
			this.silentAssassinTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.silentAssassinTextToolStripMenuItem.Text = "Silent Assassin text";
			this.silentAssassinTextToolStripMenuItem.Click += new System.EventHandler(this.silentAssassinTextToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 265);
			this.Controls.Add(this.DisplayPanel);
			this.Controls.Add(this.MainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Hitman Statistics";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game_H2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game_HC;
        private System.Windows.Forms.ToolStripMenuItem uberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metronomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codename47ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silentAssassinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractsToolStripMenuItem;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontSelectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem levelNameFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem timerFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem valuesFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem valuesTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem timerTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem silentAssassinTextToolStripMenuItem;
	}
}

