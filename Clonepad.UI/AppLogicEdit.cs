using System.Windows;

namespace Clonepad.UI
{
    public partial class MainWindow : Window
    {
        //TODO: The "Delete" function in the menu dosen't work - Change that!

        public void MenuFind()
        {
            var findDialog = new FindDialog(this);
            findDialog.Show();
        }

        public void MenuFindNext()
        {
            //TODO: MenuFindNext()
        }

        public void MenuReplace()
        {
            //TODO: MenuReplace()
        }

        public void MenuGoTo()
        {
            //TODO: MenuGoTo()
        }

        public void MenuSelectAll()
        {
            //TODO: MenuSelectAll()
        }

        public void MenuTimeDate()
        {
            //TODO: MenuTimeDate()
        }
    }
}
