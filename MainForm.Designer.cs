﻿namespace flashback_emulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            screenViewPanel = new Panel();
            SuspendLayout();
            // 
            // screenViewPanel
            // 
            screenViewPanel.BackColor = Color.Black;
            screenViewPanel.Location = new Point(0, 0);
            screenViewPanel.Name = "screenViewPanel";
            screenViewPanel.Size = new Size(1425, 773);
            screenViewPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1424, 771);
            Controls.Add(screenViewPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Flashback";
            ResumeLayout(false);
        }

        #endregion

        private Panel screenViewPanel;
    }
}