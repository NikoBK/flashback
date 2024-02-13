namespace flashback_emulator.UserControls
{
    partial class StoreView
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
            libLibraryLabel = new Label();
            libUsernameButton = new Button();
            libAddGameButton = new Button();
            SuspendLayout();
            // 
            // libLibraryLabel
            // 
            libLibraryLabel.AutoSize = true;
            libLibraryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            libLibraryLabel.ForeColor = Color.White;
            libLibraryLabel.Location = new Point(202, 58);
            libLibraryLabel.Name = "libLibraryLabel";
            libLibraryLabel.Size = new Size(74, 21);
            libLibraryLabel.TabIndex = 18;
            libLibraryLabel.Text = "LIBRARY";
            // 
            // libUsernameButton
            // 
            libUsernameButton.FlatAppearance.BorderSize = 0;
            libUsernameButton.FlatStyle = FlatStyle.Flat;
            libUsernameButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libUsernameButton.ForeColor = SystemColors.ButtonHighlight;
            libUsernameButton.Location = new Point(810, 356);
            libUsernameButton.Name = "libUsernameButton";
            libUsernameButton.Size = new Size(127, 60);
            libUsernameButton.TabIndex = 17;
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
            libAddGameButton.TabIndex = 16;
            libAddGameButton.Text = "ADD GAME";
            libAddGameButton.UseVisualStyleBackColor = true;
            // 
            // StoreView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(libLibraryLabel);
            Controls.Add(libUsernameButton);
            Controls.Add(libAddGameButton);
            Name = "StoreView";
            Size = new Size(1425, 773);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label libLibraryLabel;
        private Button libUsernameButton;
        private Button libAddGameButton;
    }
}
