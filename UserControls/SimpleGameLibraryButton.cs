/*
*  File: SimpleGameLibraryButton.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class SimpleGameLibraryButton : UserControl
    {
        public SimpleGameLibraryButton(GameData game)
        {
            InitializeComponent();
            displayNameButton.Text = game.Name;
        }
    }
}
