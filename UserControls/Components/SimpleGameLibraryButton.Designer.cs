namespace flashback_emulator.UserControls
{
    partial class SimpleGameLibraryButton
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
            logoPicturebox = new PictureBox();
            displayNameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPicturebox).BeginInit();
            SuspendLayout();
            // 
            // logoPicturebox
            // 
            logoPicturebox.BackColor = Color.FromArgb(36, 40, 47);
            logoPicturebox.BackgroundImage = Properties.Resources.default_simple_game_logo;
            logoPicturebox.BackgroundImageLayout = ImageLayout.Stretch;
            logoPicturebox.Location = new Point(0, 0);
            logoPicturebox.Name = "logoPicturebox";
            logoPicturebox.Size = new Size(23, 23);
            logoPicturebox.TabIndex = 0;
            logoPicturebox.TabStop = false;
            // 
            // displayNameButton
            // 
            displayNameButton.FlatAppearance.BorderSize = 0;
            displayNameButton.FlatStyle = FlatStyle.Flat;
            displayNameButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            displayNameButton.ForeColor = Color.White;
            displayNameButton.Location = new Point(22, 0);
            displayNameButton.Name = "displayNameButton";
            displayNameButton.Size = new Size(175, 23);
            displayNameButton.TabIndex = 1;
            displayNameButton.Text = "Some Game's Display Name";
            displayNameButton.TextAlign = ContentAlignment.MiddleLeft;
            displayNameButton.UseVisualStyleBackColor = true;
            displayNameButton.Click += displayNameButton_Click;
            // 
            // SimpleGameLibraryButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 40, 47);
            Controls.Add(displayNameButton);
            Controls.Add(logoPicturebox);
            Name = "SimpleGameLibraryButton";
            Size = new Size(197, 23);
            ((System.ComponentModel.ISupportInitialize)logoPicturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoPicturebox;
        private Button displayNameButton;
    }
}
