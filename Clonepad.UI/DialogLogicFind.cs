using System.Windows;

namespace Clonepad.UI
{
    public partial class FindDialog : Window
    {
        public void FindDialogFindNext()
        {
            directions direction;

            if (RadioButtonUp.IsChecked == true)
            {
                direction = directions.Up;
            }
            else
            {
                direction = directions.Down;
            }

            _window.Find(TextBoxFind.Text, direction);
        }

        public void FindDialogCancel()
        {
            Close();
        }
    }
}
