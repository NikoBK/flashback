namespace flashback_emulator.UserControls.Components
{
    partial class LibraryGameArtBox
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
            artworkButton = new Button();
            SuspendLayout();
            // 
            // artworkButton
            // 
            artworkButton.BackgroundImage = Properties.Resources.default_game_artwork;
            artworkButton.FlatAppearance.BorderColor = Color.FromArgb(16, 18, 23);
            artworkButton.FlatStyle = FlatStyle.Flat;
            artworkButton.Location = new Point(0, 0);
            artworkButton.Name = "artworkButton";
            artworkButton.Size = new Size(160, 235);
            artworkButton.TabIndex = 0;
            artworkButton.UseVisualStyleBackColor = true;
            artworkButton.Click += artworkButton_Click;
            // 
            // LibraryGameArtBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(artworkButton);
            Margin = new Padding(11, 11, 0, 0);
            Name = "LibraryGameArtBox";
            Size = new Size(160, 235);
            ResumeLayout(false);
        }

        #endregion

        private Button artworkButton;
    }
}
