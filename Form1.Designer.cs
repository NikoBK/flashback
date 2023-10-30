namespace flashback_emulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnExit = new Button();
            btnDebug = new Button();
            btnGames = new Button();
            panel1 = new Panel();
            btnMenuToggle = new Button();
            pictureBoxPfp = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPfp).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(36, 40, 47);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnDebug);
            panelMenu.Controls.Add(btnGames);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 561);
            panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(0, 501);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(0, 0, 0, 15);
            btnExit.Size = new Size(230, 60);
            btnExit.TabIndex = 8;
            btnExit.Tag = "EXIT";
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDebug
            // 
            btnDebug.Dock = DockStyle.Top;
            btnDebug.FlatAppearance.BorderSize = 0;
            btnDebug.FlatStyle = FlatStyle.Flat;
            btnDebug.ForeColor = SystemColors.ButtonHighlight;
            btnDebug.Location = new Point(0, 174);
            btnDebug.Name = "btnDebug";
            btnDebug.Padding = new Padding(10, 0, 0, 0);
            btnDebug.Size = new Size(230, 60);
            btnDebug.TabIndex = 3;
            btnDebug.Tag = "DEBUG";
            btnDebug.Text = "DEBUG";
            btnDebug.UseVisualStyleBackColor = true;
            // 
            // btnGames
            // 
            btnGames.Dock = DockStyle.Top;
            btnGames.FlatAppearance.BorderSize = 0;
            btnGames.FlatStyle = FlatStyle.Flat;
            btnGames.ForeColor = SystemColors.ButtonHighlight;
            btnGames.Location = new Point(0, 114);
            btnGames.Name = "btnGames";
            btnGames.Padding = new Padding(10, 0, 0, 0);
            btnGames.Size = new Size(230, 60);
            btnGames.TabIndex = 2;
            btnGames.Tag = "GAMES";
            btnGames.Text = "GAMES";
            btnGames.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenuToggle);
            panel1.Controls.Add(pictureBoxPfp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 114);
            panel1.TabIndex = 0;
            // 
            // btnMenuToggle
            // 
            btnMenuToggle.FlatAppearance.BorderSize = 0;
            btnMenuToggle.FlatStyle = FlatStyle.Flat;
            btnMenuToggle.ForeColor = SystemColors.ButtonHighlight;
            btnMenuToggle.Location = new Point(106, 12);
            btnMenuToggle.Name = "btnMenuToggle";
            btnMenuToggle.Size = new Size(60, 60);
            btnMenuToggle.TabIndex = 1;
            btnMenuToggle.Text = "Expand";
            btnMenuToggle.UseVisualStyleBackColor = true;
            btnMenuToggle.Click += btnMenuToggle_Click;
            // 
            // pictureBoxPfp
            // 
            pictureBoxPfp.Image = Properties.Resources.avatar;
            pictureBoxPfp.Location = new Point(12, 12);
            pictureBoxPfp.Name = "pictureBoxPfp";
            pictureBoxPfp.Size = new Size(60, 60);
            pictureBoxPfp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPfp.TabIndex = 0;
            pictureBoxPfp.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(23, 29, 37);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(230, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(904, 60);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(23, 29, 37);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.FromArgb(103, 112, 123);
            btnMinimize.Location = new Point(757, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 25);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(23, 29, 37);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.FromArgb(103, 112, 123);
            btnMaximize.Location = new Point(808, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 25);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(23, 29, 37);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(103, 112, 123);
            btnClose.Location = new Point(859, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 25);
            btnClose.TabIndex = 2;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(44, 50, 59);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(230, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(904, 501);
            panelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 561);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Resize += Form1_Resize;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPfp).EndInit();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private Button btnExit;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button btnGames;
        private Panel panel1;
        private Button btnMenuToggle;
        private PictureBox pictureBoxPfp;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnDebug;
    }
}