namespace flashback_emulator.UserControls
{
    partial class LibraryView
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
            gamesArtPanel = new Panel();
            libLabelNoGames = new Label();
            gamesListPanel = new Panel();
            libLabelNoGamesList = new Label();
            libUsernameButton = new Button();
            libAddGameButton = new Button();
            libLibraryLabel = new Label();
            gamesArtPanel.SuspendLayout();
            gamesListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gamesArtPanel
            // 
            gamesArtPanel.BackColor = Color.FromArgb(39, 35, 43);
            gamesArtPanel.Controls.Add(libLabelNoGames);
            gamesArtPanel.Location = new Point(212, 119);
            gamesArtPanel.Name = "gamesArtPanel";
            gamesArtPanel.Size = new Size(1206, 615);
            gamesArtPanel.TabIndex = 11;
            // 
            // libLabelNoGames
            // 
            libLabelNoGames.AutoSize = true;
            libLabelNoGames.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            libLabelNoGames.ForeColor = Color.White;
            libLabelNoGames.Location = new Point(372, 284);
            libLabelNoGames.Name = "libLabelNoGames";
            libLabelNoGames.Size = new Size(561, 47);
            libLabelNoGames.TabIndex = 0;
            libLabelNoGames.Text = "You have no games in your library";
            // 
            // gamesListPanel
            // 
            gamesListPanel.BackColor = Color.FromArgb(36, 40, 47);
            gamesListPanel.Controls.Add(libLabelNoGamesList);
            gamesListPanel.Location = new Point(6, 119);
            gamesListPanel.Name = "gamesListPanel";
            gamesListPanel.Size = new Size(200, 615);
            gamesListPanel.TabIndex = 10;
            // 
            // libLabelNoGamesList
            // 
            libLabelNoGamesList.AutoSize = true;
            libLabelNoGamesList.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            libLabelNoGamesList.ForeColor = Color.White;
            libLabelNoGamesList.Location = new Point(49, 15);
            libLabelNoGamesList.Name = "libLabelNoGamesList";
            libLabelNoGamesList.Size = new Size(106, 15);
            libLabelNoGamesList.TabIndex = 0;
            libLabelNoGamesList.Text = "No games to show";
            // 
            // libUsernameButton
            // 
            libUsernameButton.FlatAppearance.BorderSize = 0;
            libUsernameButton.FlatStyle = FlatStyle.Flat;
            libUsernameButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libUsernameButton.ForeColor = SystemColors.ButtonHighlight;
            libUsernameButton.Location = new Point(341, 38);
            libUsernameButton.Name = "libUsernameButton";
            libUsernameButton.Size = new Size(127, 60);
            libUsernameButton.TabIndex = 14;
            libUsernameButton.Text = "USERNAME";
            libUsernameButton.UseVisualStyleBackColor = true;
            // 
            // libAddGameButton
            // 
            libAddGameButton.FlatAppearance.BorderSize = 0;
            libAddGameButton.FlatStyle = FlatStyle.Flat;
            libAddGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libAddGameButton.ForeColor = SystemColors.ButtonHighlight;
            libAddGameButton.Location = new Point(18, 38);
            libAddGameButton.Name = "libAddGameButton";
            libAddGameButton.Size = new Size(127, 60);
            libAddGameButton.TabIndex = 12;
            libAddGameButton.Text = "ADD GAME";
            libAddGameButton.UseVisualStyleBackColor = true;
            libAddGameButton.Click += libAddGameButton_Click;
            // 
            // libLibraryLabel
            // 
            libLibraryLabel.AutoSize = true;
            libLibraryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            libLibraryLabel.ForeColor = Color.White;
            libLibraryLabel.Location = new Point(202, 58);
            libLibraryLabel.Name = "libLibraryLabel";
            libLibraryLabel.Size = new Size(74, 21);
            libLibraryLabel.TabIndex = 15;
            libLibraryLabel.Text = "LIBRARY";
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(libLibraryLabel);
            Controls.Add(gamesArtPanel);
            Controls.Add(gamesListPanel);
            Controls.Add(libUsernameButton);
            Controls.Add(libAddGameButton);
            Name = "LibraryView";
            Size = new Size(1425, 773);
            gamesArtPanel.ResumeLayout(false);
            gamesArtPanel.PerformLayout();
            gamesListPanel.ResumeLayout(false);
            gamesListPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel gamesArtPanel;
        private Label libLabelNoGames;
        private Panel gamesListPanel;
        private Label libLabelNoGamesList;
        private Button libUsernameButton;
        private Button libAddGameButton;
        private Label libLibraryLabel;
    }
}
