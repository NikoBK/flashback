namespace flashback_emulator.UserControls
{
    partial class GameStoreBox
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
            gameBoxNamePanel = new Panel();
            gameBoxNameLabel = new Label();
            gameBoxArtButton = new Button();
            panel1 = new Panel();
            gameBoxNamePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gameBoxNamePanel
            // 
            gameBoxNamePanel.BackColor = Color.Black;
            gameBoxNamePanel.Controls.Add(gameBoxNameLabel);
            gameBoxNamePanel.Location = new Point(0, 140);
            gameBoxNamePanel.Name = "gameBoxNamePanel";
            gameBoxNamePanel.Size = new Size(285, 35);
            gameBoxNamePanel.TabIndex = 1;
            // 
            // gameBoxNameLabel
            // 
            gameBoxNameLabel.AutoSize = true;
            gameBoxNameLabel.BackColor = Color.Transparent;
            gameBoxNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            gameBoxNameLabel.ForeColor = Color.White;
            gameBoxNameLabel.Location = new Point(10, 10);
            gameBoxNameLabel.Name = "gameBoxNameLabel";
            gameBoxNameLabel.Size = new Size(155, 20);
            gameBoxNameLabel.TabIndex = 0;
            gameBoxNameLabel.Text = "Some Game's Name...";
            // 
            // gameBoxArtButton
            // 
            gameBoxArtButton.FlatStyle = FlatStyle.Popup;
            gameBoxArtButton.Image = Properties.Resources.default_store_artwork;
            gameBoxArtButton.Location = new Point(0, 0);
            gameBoxArtButton.Name = "gameBoxArtButton";
            gameBoxArtButton.Size = new Size(285, 140);
            gameBoxArtButton.TabIndex = 2;
            gameBoxArtButton.UseVisualStyleBackColor = true;
            gameBoxArtButton.Click += gameBoxArtButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(gameBoxArtButton);
            panel1.Controls.Add(gameBoxNamePanel);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 175);
            panel1.TabIndex = 3;
            // 
            // GameStoreBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Name = "GameStoreBox";
            Size = new Size(275, 175);
            gameBoxNamePanel.ResumeLayout(false);
            gameBoxNamePanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel gameBoxNamePanel;
        private Label gameBoxNameLabel;
        private Button gameBoxArtButton;
        private Panel panel1;
    }
}
