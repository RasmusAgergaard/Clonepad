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

        public void MenuReplace()
        {
            var replaceDialog = new ReplaceDialog(this);
            replaceDialog.Show();
        }

        public void MenuSelectAll()
        {
            TextBox.SelectAll();
        }

        public void MenuDateTime()
        {
            InsertDateTime();
        }
    }
}
