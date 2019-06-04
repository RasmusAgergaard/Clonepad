using System.Windows;

namespace Clonepad.UI
{
    public partial class MainWindow : Window
    {
        public void MenuAbout()
        {
            var aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }

        public void MenuViewDocumentation()
        {
            System.Diagnostics.Process.Start("https://github.com/RasmusAgergaard/Clonepad");
        }
    }
}
