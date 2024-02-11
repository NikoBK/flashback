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
            panel2 = new Panel();
            libLabelNoGames = new Label();
            panel1 = new Panel();
            button2 = new Button();
            btnMenuToggle = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 35, 43);
            panel2.Controls.Add(libLabelNoGames);
            panel2.Location = new Point(212, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1206, 615);
            panel2.TabIndex = 11;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 40, 47);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 615);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(341, 38);
            button2.Name = "button2";
            button2.Size = new Size(127, 60);
            button2.TabIndex = 14;
            button2.Text = "USERNAME";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnMenuToggle
            // 
            btnMenuToggle.FlatAppearance.BorderSize = 0;
            btnMenuToggle.FlatStyle = FlatStyle.Flat;
            btnMenuToggle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuToggle.ForeColor = SystemColors.ButtonHighlight;
            btnMenuToggle.Location = new Point(18, 38);
            btnMenuToggle.Name = "btnMenuToggle";
            btnMenuToggle.Size = new Size(127, 60);
            btnMenuToggle.TabIndex = 12;
            btnMenuToggle.Text = "ADD GAME";
            btnMenuToggle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "No games to show";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 58);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 15;
            label2.Text = "LIBRARY";
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnMenuToggle);
            Name = "LibraryView";
            Size = new Size(1425, 773);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label libLabelNoGames;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button btnMenuToggle;
        private Label label2;
    }
}
