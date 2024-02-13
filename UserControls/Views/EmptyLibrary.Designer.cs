namespace flashback_emulator.UserControls
{
    partial class EmptyLibrary
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
            panel5 = new Panel();
            libLabel = new Label();
            userButton = new Button();
            storeButton = new Button();
            panel1 = new Panel();
            addGameButton = new Button();
            noGamesLabel = new Label();
            panel1.SuspendLayout();
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
            // libLabel
            // 
            libLabel.AutoSize = true;
            libLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            libLabel.ForeColor = Color.White;
            libLabel.Location = new Point(202, 58);
            libLabel.Name = "libLabel";
            libLabel.Size = new Size(74, 21);
            libLabel.TabIndex = 27;
            libLabel.Text = "LIBRARY";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 9, 17);
            panel1.Controls.Add(addGameButton);
            panel1.Controls.Add(noGamesLabel);
            panel1.Location = new Point(0, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(1425, 634);
            panel1.TabIndex = 28;
            // 
            // addGameButton
            // 
            addGameButton.BackColor = Color.FromArgb(39, 79, 135);
            addGameButton.FlatAppearance.BorderSize = 0;
            addGameButton.FlatStyle = FlatStyle.Flat;
            addGameButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addGameButton.ForeColor = Color.White;
            addGameButton.Location = new Point(619, 298);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(127, 49);
            addGameButton.TabIndex = 2;
            addGameButton.Text = "ADD GAME";
            addGameButton.UseVisualStyleBackColor = false;
            addGameButton.Click += addGameButton_Click;
            // 
            // noGamesLabel
            // 
            noGamesLabel.AutoSize = true;
            noGamesLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            noGamesLabel.ForeColor = Color.White;
            noGamesLabel.Location = new Point(429, 249);
            noGamesLabel.Name = "noGamesLabel";
            noGamesLabel.Size = new Size(496, 32);
            noGamesLabel.TabIndex = 0;
            noGamesLabel.Text = "It seems you do not have any games here. :(";
            // 
            // EmptyLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(panel1);
            Controls.Add(libLabel);
            Controls.Add(userButton);
            Controls.Add(storeButton);
            Controls.Add(panel5);
            Name = "EmptyLibrary";
            Size = new Size(1425, 773);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Label libLabel;
        private Button userButton;
        private Button storeButton;
        private Panel panel1;
        private Label noGamesLabel;
        private Button addGameButton;
    }
}
