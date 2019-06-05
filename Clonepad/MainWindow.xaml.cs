using System.Windows;
using System.Windows.Input;

namespace Clonepad.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetTitle();
            OpenFileOnLoad();
            TextBox.IsInactiveSelectionHighlightEnabled = true;
        }

        //Files
        private void MenuItem_New_Click(object sender, RoutedEventArgs e)
        {
            MenuNewFile();
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            MenuOpenFile();
        }

        private void MenuItem_Save_Click(object sender, RoutedEventArgs e)
        {
            MenuSaveFile();
        }

        private void MenuItem_SaveAs_Click(object sender, RoutedEventArgs e)
        {
            MenuSaveFileAs();
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            ExitApplication();
        }

        //Edit
        private void MenuItem_Find_Click(object sender, RoutedEventArgs e)
        {
            MenuFind();
        }

        private void MenuItem_Replace_Click(object sender, RoutedEventArgs e)
        {
            MenuReplace();
        }

        private void MenuItem_SelectAll_Click(object sender, RoutedEventArgs e)
        {
            MenuSelectAll();
        }

        private void MenuItem_DateTime_Click(object sender, RoutedEventArgs e)
        {
            MenuDateTime();
        }

        //Format
        private void MenuItem_WordWrap_Checked(object sender, RoutedEventArgs e)
        {
            MenuWordWrap(true);
        }

        private void MenuItem_WordWrap_UnChecked(object sender, RoutedEventArgs e)
        {
            MenuWordWrap(false);
        }

        //Help
        private void MenuItem_About_Click(object sender, RoutedEventArgs e)
        {
            MenuAbout();
        }

        private void MenuItem_ViewDocumentation_Click(object sender, RoutedEventArgs e)
        {
            MenuViewDocumentation();
        }

        //Other events
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _fileSaved = false;
            SetTitle();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ExitSaveCheck(e);
        }


    }
}
