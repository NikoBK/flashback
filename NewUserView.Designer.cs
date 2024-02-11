namespace flashback_emulator
{
    partial class NewUserView
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
            introTitleLabel = new Label();
            introNameLabel = new Label();
            introUsernameTextBox = new TextBox();
            introUsernameLabel = new Label();
            introConfirmButton = new Button();
            introExitButton = new Button();
            invalidUsernameLabel = new Label();
            SuspendLayout();
            // 
            // introTitleLabel
            // 
            introTitleLabel.AutoSize = true;
            introTitleLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            introTitleLabel.ForeColor = Color.White;
            introTitleLabel.Location = new Point(582, 101);
            introTitleLabel.Name = "introTitleLabel";
            introTitleLabel.Size = new Size(221, 50);
            introTitleLabel.TabIndex = 0;
            introTitleLabel.Text = "Welcome To";
            // 
            // introNameLabel
            // 
            introNameLabel.AutoSize = true;
            introNameLabel.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            introNameLabel.ForeColor = Color.White;
            introNameLabel.Location = new Point(573, 151);
            introNameLabel.Name = "introNameLabel";
            introNameLabel.Size = new Size(240, 65);
            introNameLabel.TabIndex = 1;
            introNameLabel.Text = "Flashback";
            // 
            // introUsernameTextBox
            // 
            introUsernameTextBox.BackColor = Color.FromArgb(31, 64, 126);
            introUsernameTextBox.BorderStyle = BorderStyle.None;
            introUsernameTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            introUsernameTextBox.ForeColor = Color.White;
            introUsernameTextBox.Location = new Point(556, 364);
            introUsernameTextBox.Name = "introUsernameTextBox";
            introUsernameTextBox.Size = new Size(277, 28);
            introUsernameTextBox.TabIndex = 2;
            introUsernameTextBox.TextAlign = HorizontalAlignment.Center;
            introUsernameTextBox.TextChanged += introUsernameTextBox_TextChanged;
            // 
            // introUsernameLabel
            // 
            introUsernameLabel.AutoSize = true;
            introUsernameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            introUsernameLabel.ForeColor = Color.White;
            introUsernameLabel.Location = new Point(592, 329);
            introUsernameLabel.Name = "introUsernameLabel";
            introUsernameLabel.Size = new Size(211, 32);
            introUsernameLabel.TabIndex = 3;
            introUsernameLabel.Text = "Select a Username";
            // 
            // introConfirmButton
            // 
            introConfirmButton.BackColor = Color.FromArgb(62, 64, 71);
            introConfirmButton.FlatAppearance.BorderSize = 0;
            introConfirmButton.FlatStyle = FlatStyle.Flat;
            introConfirmButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            introConfirmButton.ForeColor = Color.White;
            introConfirmButton.Location = new Point(556, 455);
            introConfirmButton.Name = "introConfirmButton";
            introConfirmButton.Size = new Size(137, 57);
            introConfirmButton.TabIndex = 4;
            introConfirmButton.Text = "Confirm";
            introConfirmButton.UseVisualStyleBackColor = false;
            introConfirmButton.Click += introConfirmButton_Click;
            // 
            // introExitButton
            // 
            introExitButton.BackColor = Color.FromArgb(62, 64, 71);
            introExitButton.FlatAppearance.BorderSize = 0;
            introExitButton.FlatStyle = FlatStyle.Flat;
            introExitButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            introExitButton.ForeColor = Color.White;
            introExitButton.Location = new Point(696, 455);
            introExitButton.Name = "introExitButton";
            introExitButton.Size = new Size(137, 57);
            introExitButton.TabIndex = 5;
            introExitButton.Text = "Exit";
            introExitButton.UseVisualStyleBackColor = false;
            introExitButton.Click += introExitButton_Click;
            // 
            // invalidUsernameLabel
            // 
            invalidUsernameLabel.AutoSize = true;
            invalidUsernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            invalidUsernameLabel.ForeColor = Color.DarkRed;
            invalidUsernameLabel.Location = new Point(613, 395);
            invalidUsernameLabel.Name = "invalidUsernameLabel";
            invalidUsernameLabel.Size = new Size(164, 17);
            invalidUsernameLabel.TabIndex = 6;
            invalidUsernameLabel.Text = "Invalid Username, try again.";
            // 
            // NewUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 12, 15);
            Controls.Add(invalidUsernameLabel);
            Controls.Add(introExitButton);
            Controls.Add(introConfirmButton);
            Controls.Add(introUsernameLabel);
            Controls.Add(introUsernameTextBox);
            Controls.Add(introNameLabel);
            Controls.Add(introTitleLabel);
            Name = "NewUserView";
            Size = new Size(1440, 810);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label introTitleLabel;
        private Label introNameLabel;
        private TextBox introUsernameTextBox;
        private Label introUsernameLabel;
        private Button introConfirmButton;
        private Button introExitButton;
        private Label invalidUsernameLabel;
    }
}
