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
            libUsernameButton = new Button();
            libAddGameButton = new Button();
            libLibraryLabel = new Label();
            panel5 = new Panel();
            gamesFlowLayoutPanel = new FlowLayoutPanel();
            simpleLibListFlowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
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
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(13, 19, 27);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1425, 32);
            panel5.TabIndex = 23;
            // 
            // gamesFlowLayoutPanel
            // 
            gamesFlowLayoutPanel.BackColor = Color.FromArgb(39, 35, 43);
            gamesFlowLayoutPanel.Location = new Point(212, 104);
            gamesFlowLayoutPanel.Name = "gamesFlowLayoutPanel";
            gamesFlowLayoutPanel.Size = new Size(1206, 630);
            gamesFlowLayoutPanel.TabIndex = 1;
            // 
            // simpleLibListFlowLayoutPanel
            // 
            simpleLibListFlowLayoutPanel.BackColor = Color.FromArgb(36, 40, 47);
            simpleLibListFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            simpleLibListFlowLayoutPanel.Location = new Point(6, 104);
            simpleLibListFlowLayoutPanel.Name = "simpleLibListFlowLayoutPanel";
            simpleLibListFlowLayoutPanel.Size = new Size(200, 630);
            simpleLibListFlowLayoutPanel.TabIndex = 2;
            simpleLibListFlowLayoutPanel.WrapContents = false;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(simpleLibListFlowLayoutPanel);
            Controls.Add(gamesFlowLayoutPanel);
            Controls.Add(panel5);
            Controls.Add(libLibraryLabel);
            Controls.Add(libUsernameButton);
            Controls.Add(libAddGameButton);
            Name = "LibraryView";
            Size = new Size(1425, 773);
            Load += LibraryView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button libUsernameButton;
        private Button libAddGameButton;
        private Label libLibraryLabel;
        private Panel panel5;
        private FlowLayoutPanel gamesFlowLayoutPanel;
        private FlowLayoutPanel simpleLibListFlowLayoutPanel;
    }
}
