/*
*  File: StoreView.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class StoreView : UserControl
    {
        // Singleton pattern for the main form to do callbacks on button clicks so
        // that the screenview panel can be updated per button click.
        private static NewLayoutForm _mainForm { get; set; }

        public StoreView(NewLayoutForm mainForm, AppData appData)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
    }
}
