using System.Windows;
using System.Windows.Controls;

namespace Clonepad.UI
{
    public partial class MainWindow : Window
    {
        public void MenuNewFile()
        {
            if (_fileSaved == true)
            {
                ResetApp(); 
            }
            else
            {
                switch (DoYouWantToSaveDialog())
                {
                    case MessageBoxResult.Cancel:
                        break;
                    case MessageBoxResult.Yes:
                        MenuSaveFile();
                        ResetApp();
                        break;
                    case MessageBoxResult.No:
                        ResetApp();
                        break;
                }
            }
        }

        public void MenuOpenFile()
        {
            if (_fileSaved == true)
            {
                OpenFile();
            }
            else
            {
                switch (DoYouWantToSaveDialog())
                {
                    case MessageBoxResult.Cancel:
                        break;
                    case MessageBoxResult.Yes:
                        MenuSaveFile();
                        OpenFile();
                        break;
                    case MessageBoxResult.No:
                        OpenFile();
                        break;
                }
            }
        }

        public void MenuSaveFile()
        {
            if (_fileSavePath != null)
            {
                SaveFile();
            }
            else
            {
                SaveFileAs(); ;
            }
        }

        public void MenuSaveFileAs()
        {
            SaveFileAs();
        }
    }
}
