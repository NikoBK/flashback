namespace flashback_emulator.UserControls
{
    partial class GameView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameView));
            panel5 = new Panel();
            userButton = new Button();
            storeButton = new Button();
            libButton = new Button();
            panel1 = new Panel();
            gameNameLabel = new Label();
            horizontalSplitterPictureBox = new PictureBox();
            descriptionPanel = new Panel();
            descriptionTextLabel = new Label();
            descriptionLabel = new Label();
            achievementsCounterLabel = new Label();
            achievementsLabel = new Label();
            playTimeCounterLabel = new Label();
            playTimeLabel = new Label();
            lastPlayedCounterLabel = new Label();
            lastPlayedLabel = new Label();
            playButton = new Button();
            gameCoverPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)horizontalSplitterPictureBox).BeginInit();
            descriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameCoverPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(13, 19, 27);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1425, 32);
            panel5.TabIndex = 24;
            // 
            // userButton
            // 
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userButton.ForeColor = SystemColors.ButtonHighlight;
            userButton.Location = new Point(341, 38);
            userButton.Name = "userButton";
            userButton.Size = new Size(127, 60);
            userButton.TabIndex = 26;
            userButton.Text = "USERNAME";
            userButton.UseVisualStyleBackColor = true;
            userButton.Click += userButton_Click;
            // 
            // storeButton
            // 
            storeButton.FlatAppearance.BorderSize = 0;
            storeButton.FlatStyle = FlatStyle.Flat;
            storeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            storeButton.ForeColor = SystemColors.ButtonHighlight;
            storeButton.Location = new Point(18, 38);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(127, 60);
            storeButton.TabIndex = 25;
            storeButton.Text = "ADD GAME";
            storeButton.UseVisualStyleBackColor = true;
            storeButton.Click += storeButton_Click;
            // 
            // libButton
            // 
            libButton.FlatAppearance.BorderSize = 0;
            libButton.FlatStyle = FlatStyle.Flat;
            libButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libButton.ForeColor = SystemColors.ButtonHighlight;
            libButton.Location = new Point(170, 38);
            libButton.Name = "libButton";
            libButton.Size = new Size(127, 60);
            libButton.TabIndex = 28;
            libButton.Text = "LIBRARY";
            libButton.UseVisualStyleBackColor = true;
            libButton.Click += libButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 9, 17);
            panel1.Controls.Add(gameNameLabel);
            panel1.Controls.Add(horizontalSplitterPictureBox);
            panel1.Controls.Add(descriptionPanel);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(achievementsCounterLabel);
            panel1.Controls.Add(achievementsLabel);
            panel1.Controls.Add(playTimeCounterLabel);
            panel1.Controls.Add(playTimeLabel);
            panel1.Controls.Add(lastPlayedCounterLabel);
            panel1.Controls.Add(lastPlayedLabel);
            panel1.Controls.Add(playButton);
            panel1.Controls.Add(gameCoverPictureBox);
            panel1.Location = new Point(0, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(1425, 634);
            panel1.TabIndex = 29;
            // 
            // gameNameLabel
            // 
            gameNameLabel.AutoSize = true;
            gameNameLabel.BackColor = Color.Transparent;
            gameNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gameNameLabel.ForeColor = Color.White;
            gameNameLabel.Location = new Point(18, 205);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(315, 32);
            gameNameLabel.TabIndex = 11;
            gameNameLabel.Text = "Some Game's Display Name";
            // 
            // horizontalSplitterPictureBox
            // 
            horizontalSplitterPictureBox.BackColor = Color.DimGray;
            horizontalSplitterPictureBox.Location = new Point(0, 320);
            horizontalSplitterPictureBox.Name = "horizontalSplitterPictureBox";
            horizontalSplitterPictureBox.Size = new Size(1425, 1);
            horizontalSplitterPictureBox.TabIndex = 10;
            horizontalSplitterPictureBox.TabStop = false;
            // 
            // descriptionPanel
            // 
            descriptionPanel.BackColor = Color.FromArgb(13, 19, 27);
            descriptionPanel.Controls.Add(descriptionTextLabel);
            descriptionPanel.Location = new Point(18, 382);
            descriptionPanel.Name = "descriptionPanel";
            descriptionPanel.Size = new Size(559, 187);
            descriptionPanel.TabIndex = 9;
            // 
            // descriptionTextLabel
            // 
            descriptionTextLabel.AutoSize = true;
            descriptionTextLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextLabel.ForeColor = Color.Gray;
            descriptionTextLabel.Location = new Point(13, 10);
            descriptionTextLabel.MaximumSize = new Size(540, 0);
            descriptionTextLabel.Name = "descriptionTextLabel";
            descriptionTextLabel.Size = new Size(538, 102);
            descriptionTextLabel.TabIndex = 10;
            descriptionTextLabel.Text = resources.GetString("descriptionTextLabel.Text");
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.ForeColor = Color.Silver;
            descriptionLabel.Location = new Point(18, 362);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(92, 17);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "DESCRIPTION";
            // 
            // achievementsCounterLabel
            // 
            achievementsCounterLabel.AutoSize = true;
            achievementsCounterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            achievementsCounterLabel.ForeColor = Color.Gray;
            achievementsCounterLabel.Location = new Point(471, 281);
            achievementsCounterLabel.Name = "achievementsCounterLabel";
            achievementsCounterLabel.Size = new Size(106, 15);
            achievementsCounterLabel.TabIndex = 7;
            achievementsCounterLabel.Text = "No Achievements";
            // 
            // achievementsLabel
            // 
            achievementsLabel.AutoSize = true;
            achievementsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            achievementsLabel.ForeColor = Color.Silver;
            achievementsLabel.Location = new Point(471, 263);
            achievementsLabel.Name = "achievementsLabel";
            achievementsLabel.Size = new Size(106, 17);
            achievementsLabel.TabIndex = 6;
            achievementsLabel.Text = "ACHIEVEMENTS";
            // 
            // playTimeCounterLabel
            // 
            playTimeCounterLabel.AutoSize = true;
            playTimeCounterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playTimeCounterLabel.ForeColor = Color.Gray;
            playTimeCounterLabel.Location = new Point(323, 281);
            playTimeCounterLabel.Name = "playTimeCounterLabel";
            playTimeCounterLabel.Size = new Size(48, 15);
            playTimeCounterLabel.TabIndex = 5;
            playTimeCounterLabel.Text = "0 hours";
            // 
            // playTimeLabel
            // 
            playTimeLabel.AutoSize = true;
            playTimeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            playTimeLabel.ForeColor = Color.Silver;
            playTimeLabel.Location = new Point(323, 263);
            playTimeLabel.Name = "playTimeLabel";
            playTimeLabel.Size = new Size(74, 17);
            playTimeLabel.TabIndex = 4;
            playTimeLabel.Text = "PLAY TIME";
            // 
            // lastPlayedCounterLabel
            // 
            lastPlayedCounterLabel.AutoSize = true;
            lastPlayedCounterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lastPlayedCounterLabel.ForeColor = Color.Gray;
            lastPlayedCounterLabel.Location = new Point(170, 281);
            lastPlayedCounterLabel.Name = "lastPlayedCounterLabel";
            lastPlayedCounterLabel.Size = new Size(44, 15);
            lastPlayedCounterLabel.TabIndex = 3;
            lastPlayedCounterLabel.Text = "Feb 10";
            // 
            // lastPlayedLabel
            // 
            lastPlayedLabel.AutoSize = true;
            lastPlayedLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lastPlayedLabel.ForeColor = Color.Silver;
            lastPlayedLabel.Location = new Point(170, 263);
            lastPlayedLabel.Name = "lastPlayedLabel";
            lastPlayedLabel.Size = new Size(91, 17);
            lastPlayedLabel.TabIndex = 2;
            lastPlayedLabel.Text = "LAST PLAYED";
            // 
            // playButton
            // 
            playButton.BackColor = Color.FromArgb(71, 197, 52);
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            playButton.ForeColor = Color.White;
            playButton.Location = new Point(18, 254);
            playButton.Name = "playButton";
            playButton.Size = new Size(127, 49);
            playButton.TabIndex = 1;
            playButton.Text = "ADD TO LIBRARY";
            playButton.UseVisualStyleBackColor = false;
            // 
            // gameCoverPictureBox
            // 
            gameCoverPictureBox.BackColor = Color.White;
            gameCoverPictureBox.Image = Properties.Resources.default_game_coverart;
            gameCoverPictureBox.Location = new Point(0, 0);
            gameCoverPictureBox.Name = "gameCoverPictureBox";
            gameCoverPictureBox.Size = new Size(1425, 248);
            gameCoverPictureBox.TabIndex = 0;
            gameCoverPictureBox.TabStop = false;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(panel1);
            Controls.Add(libButton);
            Controls.Add(userButton);
            Controls.Add(storeButton);
            Controls.Add(panel5);
            Name = "GameView";
            Size = new Size(1425, 773);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)horizontalSplitterPictureBox).EndInit();
            descriptionPanel.ResumeLayout(false);
            descriptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gameCoverPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button userButton;
        private Button storeButton;
        private Button libButton;
        private Panel panel1;
        private Button playButton;
        private PictureBox gameCoverPictureBox;
        private Label lastPlayedCounterLabel;
        private Label lastPlayedLabel;
        private Panel descriptionPanel;
        private Label descriptionLabel;
        private Label achievementsCounterLabel;
        private Label achievementsLabel;
        private Label playTimeCounterLabel;
        private Label playTimeLabel;
        private PictureBox horizontalSplitterPictureBox;
        private Label descriptionTextLabel;
        private Label gameNameLabel;
    }
}
