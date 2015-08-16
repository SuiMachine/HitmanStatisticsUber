namespace HitmanStatistics
{
    partial class Initial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.B_HitmanBloodMoney = new System.Windows.Forms.Button();
            this.B_HitmanContracts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Hitman2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.B_HitmanBloodMoney, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_HitmanContracts, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.B_Hitman2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // B_HitmanBloodMoney
            // 
            this.B_HitmanBloodMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_HitmanBloodMoney.Location = new System.Drawing.Point(88, 125);
            this.B_HitmanBloodMoney.Name = "B_HitmanBloodMoney";
            this.B_HitmanBloodMoney.Size = new System.Drawing.Size(134, 42);
            this.B_HitmanBloodMoney.TabIndex = 3;
            this.B_HitmanBloodMoney.Text = "Hitman: Blood Money";
            this.B_HitmanBloodMoney.UseVisualStyleBackColor = true;
            this.B_HitmanBloodMoney.Click += new System.EventHandler(this.B_HitmanBloodMoney_Click);
            // 
            // B_HitmanContracts
            // 
            this.B_HitmanContracts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_HitmanContracts.Location = new System.Drawing.Point(88, 76);
            this.B_HitmanContracts.Name = "B_HitmanContracts";
            this.B_HitmanContracts.Size = new System.Drawing.Size(134, 42);
            this.B_HitmanContracts.TabIndex = 2;
            this.B_HitmanContracts.Text = "Hitman: Contracts";
            this.B_HitmanContracts.UseVisualStyleBackColor = true;
            this.B_HitmanContracts.Click += new System.EventHandler(this.B_HitmanContracts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a game:";
            // 
            // B_Hitman2
            // 
            this.B_Hitman2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Hitman2.Location = new System.Drawing.Point(88, 27);
            this.B_Hitman2.Name = "B_Hitman2";
            this.B_Hitman2.Size = new System.Drawing.Size(134, 42);
            this.B_Hitman2.TabIndex = 1;
            this.B_Hitman2.Text = "Hitman 2: Silent Assassin";
            this.B_Hitman2.UseVisualStyleBackColor = true;
            this.B_Hitman2.Click += new System.EventHandler(this.B_Hitman2_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Initial";
            this.Size = new System.Drawing.Size(311, 188);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Hitman2;
        private System.Windows.Forms.Button B_HitmanBloodMoney;
        private System.Windows.Forms.Button B_HitmanContracts;
    }
}
