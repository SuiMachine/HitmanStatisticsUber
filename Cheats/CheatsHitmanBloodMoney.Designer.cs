namespace CheatsForms
{
    partial class CheatsHitmanBloodMoney
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
            this.CheckIfRunning = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_GameRunning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Deactivate = new System.Windows.Forms.Button();
            this.B_Activate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckIfRunning
            // 
            this.CheckIfRunning.Interval = 500;
            this.CheckIfRunning.Tick += new System.EventHandler(this.CheckIfRunning_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.L_GameRunning, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_GameRunning
            // 
            this.L_GameRunning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_GameRunning.AutoSize = true;
            this.L_GameRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_GameRunning.ForeColor = System.Drawing.Color.Red;
            this.L_GameRunning.Location = new System.Drawing.Point(11, 13);
            this.L_GameRunning.Name = "L_GameRunning";
            this.L_GameRunning.Size = new System.Drawing.Size(288, 25);
            this.L_GameRunning.TabIndex = 1;
            this.L_GameRunning.Text = "Blood Money is NOT running";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The following unlocker is for version 1.2 of a game.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.B_Deactivate);
            this.panel1.Controls.Add(this.B_Activate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 52);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "After activating cheats press \"C\" to open the Cheat Menu.";
            // 
            // B_Deactivate
            // 
            this.B_Deactivate.Location = new System.Drawing.Point(187, 23);
            this.B_Deactivate.Name = "B_Deactivate";
            this.B_Deactivate.Size = new System.Drawing.Size(75, 23);
            this.B_Deactivate.TabIndex = 1;
            this.B_Deactivate.Text = "Deactivate";
            this.B_Deactivate.UseVisualStyleBackColor = true;
            this.B_Deactivate.Click += new System.EventHandler(this.B_Deactivate_Click);
            // 
            // B_Activate
            // 
            this.B_Activate.Location = new System.Drawing.Point(52, 23);
            this.B_Activate.Name = "B_Activate";
            this.B_Activate.Size = new System.Drawing.Size(75, 23);
            this.B_Activate.TabIndex = 0;
            this.B_Activate.Text = "Activate";
            this.B_Activate.UseVisualStyleBackColor = true;
            this.B_Activate.Click += new System.EventHandler(this.B_Activate_Click);
            // 
            // CheatsHitmanBloodMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 134);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheatsHitmanBloodMoney";
            this.ShowIcon = false;
            this.Text = "Hitman: Blood Money - Cheats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheatsHitmanBloodMoney_FormClosing);
            this.Load += new System.EventHandler(this.CheatsHitmanBloodMoney_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CheckIfRunning;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_GameRunning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Deactivate;
        private System.Windows.Forms.Button B_Activate;
    }
}