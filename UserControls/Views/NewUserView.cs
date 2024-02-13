/*
*  File: NewUserView.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator
{
    public partial class NewUserView : UserControl
    {
        private MainForm _mainForm { get; set; }

        public NewUserView(MainForm mainform)
        {
            InitializeComponent();
            _mainForm = mainform;
            invalidUsernameLabel.Visible = false;
        }

        private void introExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void introUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidUsernameLabel.Visible = false;
        }

        private void introConfirmButton_Click(object sender, EventArgs e)
        {
            introConfirmButton.Enabled = false;

            // Make sure a username is selected.
            if (string.IsNullOrEmpty(introUsernameTextBox.Text))
            {
                invalidUsernameLabel.Visible = true;
                introConfirmButton.Enabled = true;
                return;
            }

            // Save the username through the DataManager.
            DataManager.SaveUsername(introUsernameTextBox.Text);
            _mainForm.OpenLibrary();
        }
    }
}
