/*
*  File: EmptyLibrary.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class EmptyLibrary : UserControl
    {
        private static NewLayoutForm _mainForm { get; set; }

        public EmptyLibrary(NewLayoutForm mainForm, AppData appData)
        {
            InitializeComponent();
            _mainForm = mainForm;

            userButton.Text = appData.Username.ToUpper();
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenStore();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement something here...
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenStore();
        }
    }
}
