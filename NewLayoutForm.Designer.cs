namespace flashback_emulator
{
    partial class NewLayoutForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            libLabelNoGames = new Label();
            btnMenuToggle = new Button();
            libraryButton = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 40, 47);
            panel1.Location = new Point(0, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 577);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 35, 43);
            panel2.Controls.Add(libLabelNoGames);
            panel2.Location = new Point(206, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1206, 615);
            panel2.TabIndex = 1;
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
            // btnMenuToggle
            // 
            btnMenuToggle.FlatAppearance.BorderSize = 0;
            btnMenuToggle.FlatStyle = FlatStyle.Flat;
            btnMenuToggle.ForeColor = SystemColors.ButtonHighlight;
            btnMenuToggle.Location = new Point(12, 30);
            btnMenuToggle.Name = "btnMenuToggle";
            btnMenuToggle.Size = new Size(127, 60);
            btnMenuToggle.TabIndex = 2;
            btnMenuToggle.Text = "ADD GAME";
            btnMenuToggle.UseVisualStyleBackColor = true;
            // 
            // libraryButton
            // 
            libraryButton.FlatAppearance.BorderSize = 0;
            libraryButton.FlatStyle = FlatStyle.Flat;
            libraryButton.ForeColor = SystemColors.ButtonHighlight;
            libraryButton.Location = new Point(174, 30);
            libraryButton.Name = "libraryButton";
            libraryButton.Size = new Size(127, 60);
            libraryButton.TabIndex = 3;
            libraryButton.Text = "LIBRARY";
            libraryButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(348, 30);
            button2.Name = "button2";
            button2.Size = new Size(127, 60);
            button2.TabIndex = 4;
            button2.Text = "USERNAME";
            button2.UseVisualStyleBackColor = true;
            // 
            // NewLayoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            ClientSize = new Size(1424, 771);
            Controls.Add(button2);
            Controls.Add(libraryButton);
            Controls.Add(btnMenuToggle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NewLayoutForm";
            Text = "Flashback";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnMenuToggle;
        private Button libraryButton;
        private Button button2;
        private Label libLabelNoGames;
    }
}