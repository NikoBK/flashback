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
            usernameButton = new Button();
            label1 = new Label();
            libraryButton = new Button();
            storePanel = new Panel();
            gameBoxFlowLayoutPanel = new FlowLayoutPanel();
            storeSortPanel = new Panel();
            panel5 = new Panel();
            storePanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameButton
            // 
            usernameButton.FlatAppearance.BorderSize = 0;
            usernameButton.FlatStyle = FlatStyle.Flat;
            usernameButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameButton.ForeColor = SystemColors.ButtonHighlight;
            usernameButton.Location = new Point(341, 38);
            usernameButton.Name = "usernameButton";
            usernameButton.Size = new Size(127, 60);
            usernameButton.TabIndex = 17;
            usernameButton.Text = "USERNAME";
            usernameButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 58);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 19;
            label1.Text = "ADD GAME";
            // 
            // libraryButton
            // 
            libraryButton.FlatAppearance.BorderSize = 0;
            libraryButton.FlatStyle = FlatStyle.Flat;
            libraryButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libraryButton.ForeColor = SystemColors.ButtonHighlight;
            libraryButton.Location = new Point(174, 38);
            libraryButton.Name = "libraryButton";
            libraryButton.Size = new Size(127, 60);
            libraryButton.TabIndex = 20;
            libraryButton.Text = "LIBRARY";
            libraryButton.UseVisualStyleBackColor = true;
            libraryButton.Click += libraryButton_Click;
            // 
            // storePanel
            // 
            storePanel.BackColor = Color.FromArgb(3, 9, 17);
            storePanel.Controls.Add(gameBoxFlowLayoutPanel);
            storePanel.Controls.Add(storeSortPanel);
            storePanel.Location = new Point(0, 104);
            storePanel.Name = "storePanel";
            storePanel.Size = new Size(1425, 634);
            storePanel.TabIndex = 21;
            // 
            // gameBoxFlowLayoutPanel
            // 
            gameBoxFlowLayoutPanel.AutoScroll = true;
            gameBoxFlowLayoutPanel.BackColor = Color.FromArgb(3, 9, 17);
            gameBoxFlowLayoutPanel.Location = new Point(0, 73);
            gameBoxFlowLayoutPanel.Name = "gameBoxFlowLayoutPanel";
            gameBoxFlowLayoutPanel.Size = new Size(1425, 561);
            gameBoxFlowLayoutPanel.TabIndex = 0;
            // 
            // storeSortPanel
            // 
            storeSortPanel.BackColor = Color.FromArgb(39, 79, 135);
            storeSortPanel.Location = new Point(296, 14);
            storeSortPanel.Name = "storeSortPanel";
            storeSortPanel.Size = new Size(753, 30);
            storeSortPanel.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(13, 19, 27);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1425, 32);
            panel5.TabIndex = 22;
            // 
            // storeLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(panel5);
            Controls.Add(storePanel);
            Controls.Add(libraryButton);
            Controls.Add(label1);
            Controls.Add(usernameButton);
            Name = "storeLabel";
            Size = new Size(1425, 773);
            storePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button usernameButton;
        private Label label1;
        private Button libraryButton;
        private Panel storePanel;
        private Panel panel5;
        private Panel storeSortPanel;
        private FlowLayoutPanel gameBoxFlowLayoutPanel;
    }
}
