namespace HitmanStatistics
{
    partial class Metronome
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.RB_CustomBPM = new System.Windows.Forms.RadioButton();
            this.RB_HC = new System.Windows.Forms.RadioButton();
            this.RB_H2SA = new System.Windows.Forms.RadioButton();
            this.TB_CustomBPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_UsedKey = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaySoundInterval = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.R2_OneSound = new System.Windows.Forms.RadioButton();
            this.R2_ThreeSound = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RB_CustomBPM, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.RB_HC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.RB_H2SA, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TB_CustomBPM, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 76);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(152, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "(not implemented)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RB_CustomBPM
            // 
            this.RB_CustomBPM.AutoSize = true;
            this.RB_CustomBPM.Location = new System.Drawing.Point(4, 52);
            this.RB_CustomBPM.Name = "RB_CustomBPM";
            this.RB_CustomBPM.Size = new System.Drawing.Size(60, 17);
            this.RB_CustomBPM.TabIndex = 2;
            this.RB_CustomBPM.TabStop = true;
            this.RB_CustomBPM.Text = "Custom";
            this.RB_CustomBPM.UseVisualStyleBackColor = true;
            this.RB_CustomBPM.CheckedChanged += new System.EventHandler(this.RB_CustomBPM_CheckedChanged);
            // 
            // RB_HC
            // 
            this.RB_HC.AutoSize = true;
            this.RB_HC.Checked = true;
            this.RB_HC.Location = new System.Drawing.Point(4, 28);
            this.RB_HC.Name = "RB_HC";
            this.RB_HC.Size = new System.Drawing.Size(109, 17);
            this.RB_HC.TabIndex = 1;
            this.RB_HC.TabStop = true;
            this.RB_HC.Text = "Hitman: Contracts";
            this.RB_HC.UseVisualStyleBackColor = true;
            this.RB_HC.CheckedChanged += new System.EventHandler(this.RB_HC_CheckedChanged);
            // 
            // RB_H2SA
            // 
            this.RB_H2SA.AutoSize = true;
            this.RB_H2SA.Dock = System.Windows.Forms.DockStyle.Left;
            this.RB_H2SA.Enabled = false;
            this.RB_H2SA.Location = new System.Drawing.Point(4, 4);
            this.RB_H2SA.Name = "RB_H2SA";
            this.RB_H2SA.Size = new System.Drawing.Size(141, 17);
            this.RB_H2SA.TabIndex = 0;
            this.RB_H2SA.TabStop = true;
            this.RB_H2SA.Text = "Hitman 2: Silent Assassin";
            this.RB_H2SA.UseVisualStyleBackColor = true;
            this.RB_H2SA.CheckedChanged += new System.EventHandler(this.RB_H2SA_CheckedChanged);
            // 
            // TB_CustomBPM
            // 
            this.TB_CustomBPM.Enabled = false;
            this.TB_CustomBPM.Location = new System.Drawing.Point(152, 52);
            this.TB_CustomBPM.MaxLength = 3;
            this.TB_CustomBPM.Name = "TB_CustomBPM";
            this.TB_CustomBPM.Size = new System.Drawing.Size(115, 20);
            this.TB_CustomBPM.TabIndex = 3;
            this.TB_CustomBPM.TextChanged += new System.EventHandler(this.TB_CustomBPM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "220BPM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preset:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_UsedKey);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 35);
            this.panel1.TabIndex = 2;
            // 
            // B_UsedKey
            // 
            this.B_UsedKey.Appearance = System.Windows.Forms.Appearance.Button;
            this.B_UsedKey.Location = new System.Drawing.Point(162, 2);
            this.B_UsedKey.Name = "B_UsedKey";
            this.B_UsedKey.Size = new System.Drawing.Size(104, 24);
            this.B_UsedKey.TabIndex = 4;
            this.B_UsedKey.Text = "X";
            this.B_UsedKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_UsedKey.UseVisualStyleBackColor = true;
            this.B_UsedKey.CheckedChanged += new System.EventHandler(this.B_UsedKey_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Used key:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Playback:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlaySoundInterval
            // 
            this.PlaySoundInterval.Interval = 500;
            this.PlaySoundInterval.Tick += new System.EventHandler(this.PlaySoundInterval_Tick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.R2_OneSound, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.R2_ThreeSound, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 127);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 27);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // R2_OneSound
            // 
            this.R2_OneSound.AutoSize = true;
            this.R2_OneSound.Checked = true;
            this.R2_OneSound.Location = new System.Drawing.Point(4, 4);
            this.R2_OneSound.Name = "R2_OneSound";
            this.R2_OneSound.Size = new System.Drawing.Size(79, 17);
            this.R2_OneSound.TabIndex = 0;
            this.R2_OneSound.TabStop = true;
            this.R2_OneSound.Text = "One Sound";
            this.R2_OneSound.UseVisualStyleBackColor = true;
            this.R2_OneSound.CheckedChanged += new System.EventHandler(this.R2_OneSound_CheckedChanged);
            // 
            // R2_ThreeSound
            // 
            this.R2_ThreeSound.AutoSize = true;
            this.R2_ThreeSound.Location = new System.Drawing.Point(142, 4);
            this.R2_ThreeSound.Name = "R2_ThreeSound";
            this.R2_ThreeSound.Size = new System.Drawing.Size(92, 17);
            this.R2_ThreeSound.TabIndex = 1;
            this.R2_ThreeSound.TabStop = true;
            this.R2_ThreeSound.Text = "Three Sounds";
            this.R2_ThreeSound.UseVisualStyleBackColor = true;
            this.R2_ThreeSound.CheckedChanged += new System.EventHandler(this.R2_ThreeSound_CheckedChanged);
            // 
            // Metronome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Metronome";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Metronome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Metronome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Metronome_FormClosed);
            this.Load += new System.EventHandler(this.Metronome_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton RB_CustomBPM;
        private System.Windows.Forms.RadioButton RB_HC;
        private System.Windows.Forms.RadioButton RB_H2SA;
        private System.Windows.Forms.TextBox TB_CustomBPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer PlaySoundInterval;
        private System.Windows.Forms.CheckBox B_UsedKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton R2_OneSound;
        private System.Windows.Forms.RadioButton R2_ThreeSound;
    }
}