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
            this.hitmanBloodMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codename47ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silentAssassinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metronomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Menu_Game_HC,
            this.hitmanBloodMoneyToolStripMenuItem});
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
            // hitmanBloodMoneyToolStripMenuItem
            // 
            this.hitmanBloodMoneyToolStripMenuItem.Name = "hitmanBloodMoneyToolStripMenuItem";
            this.hitmanBloodMoneyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.hitmanBloodMoneyToolStripMenuItem.Text = "Hitman: Blood Money";
            this.hitmanBloodMoneyToolStripMenuItem.Click += new System.EventHandler(this.hitmanBloodMoneyToolStripMenuItem_Click);
            // 
            // uberToolStripMenuItem
            // 
            this.uberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheatsToolStripMenuItem,
            this.metronomeToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.uberToolStripMenuItem.Name = "uberToolStripMenuItem";
            this.uberToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.uberToolStripMenuItem.Text = "Uber";
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codename47ToolStripMenuItem,
            this.silentAssassinToolStripMenuItem,
            this.contractsToolStripMenuItem,
            this.bloodMoneyToolStripMenuItem});
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // bloodMoneyToolStripMenuItem
            // 
            this.bloodMoneyToolStripMenuItem.Name = "bloodMoneyToolStripMenuItem";
            this.bloodMoneyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bloodMoneyToolStripMenuItem.Text = "Blood Money";
            this.bloodMoneyToolStripMenuItem.Click += new System.EventHandler(this.bloodMoneyToolStripMenuItem_Click);
            // 
            // metronomeToolStripMenuItem
            // 
            this.metronomeToolStripMenuItem.Name = "metronomeToolStripMenuItem";
            this.metronomeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.metronomeToolStripMenuItem.Text = "Metronome";
            this.metronomeToolStripMenuItem.Click += new System.EventHandler(this.metronomeToolStripMenuItem_Click);
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
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.CheckOnClick = true;
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.darkToolStripMenuItem.Text = "Dark Mode";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 378);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hitman Statistics";
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
        private System.Windows.Forms.ToolStripMenuItem bloodMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hitmanBloodMoneyToolStripMenuItem;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
    }
}

