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
        private void MenuItem_Undo_Click(object sender, RoutedEventArgs e)
        {
            MenuUndo();
        }

        private void MenuItem_Cut_Click(object sender, RoutedEventArgs e)
        {
            MenuCut();
        }

        private void MenuItem_Copy_Click(object sender, RoutedEventArgs e)
        {
            MenuCopy();
        }

        private void MenuItem_Paste_Click(object sender, RoutedEventArgs e)
        {
            MenuPaste();
        }

        private void MenuItem_Delete_Click(object sender, RoutedEventArgs e)
        {
            MenuDelete();
        }

        private void MenuItem_Find_Click(object sender, RoutedEventArgs e)
        {
            MenuFind();
        }

        private void MenuItem_FindNext_Click(object sender, RoutedEventArgs e)
        {
            MenuFindNext();
        }

        private void MenuItem_Replace_Click(object sender, RoutedEventArgs e)
        {
            MenuFindNext();
        }

        private void MenuItem_GoTo_Click(object sender, RoutedEventArgs e)
        {
            MenuGoTo();
        }

        private void MenuItem_SelectAll_Click(object sender, RoutedEventArgs e)
        {
            MenuSelectAll();
        }

        private void MenuItem_TimeDate_Click(object sender, RoutedEventArgs e)
        {
            MenuTimeDate();
        }

        //Format

        //View

        //Help

        //Other events
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _fileSaved = false;
            SetTitle();
        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            UpdateUndoList();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ExitSaveCheck(e);
        }
    }
}
