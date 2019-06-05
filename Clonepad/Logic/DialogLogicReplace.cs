using System.Windows;

namespace Clonepad.UI
{
    public partial class ReplaceDialog : Window
    {
        public void ReplaceDialogFindNext()
        {
            _window.Find(TextBoxFind.Text, directions.Down);
        }

        public void ReplaceDialogReplace()
        {
            if (_window.TextBox.SelectionLength > 0)
            {
                _window.Replace(TextBoxReplace.Text);
                _window.Find(TextBoxFind.Text, directions.Down);
            }
            else
            {
                _window.Find(TextBoxFind.Text, directions.Down);
            } 
        }

        public void ReplaceDialogReplaceAll()
        {
            _window.ReplaceAll(TextBoxFind.Text, TextBoxReplace.Text);
        }

        public void ReplaceDialogCancel()
        {
            Close();
        }
    }
}
