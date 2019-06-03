using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Clonepad.UI
{
    public partial class MainWindow : Window
    {
        private string _appTitle = "Clonepad";
        private bool _fileSaved = true;
        private string _fileSavePath;
        private string _fileSaveName = "Untitled";

        public void SetTitle()
        {
            Title = $"{_fileSaveName} - {_appTitle}";

            if (_fileSaved == false)
            {
                Title = Title + "*";
            }
        }

        public void ResetApp()
        {
            TextBox.Text = "";
            _fileSaved = true;
            _fileSaveName = "Untitled";
            _fileSavePath = null;
            SetTitle();
        }

        public void OpenFile()
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "TXT files (*.txt)|*.txt";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                TextBox.Text = File.ReadAllText(openFileDialog.FileName);
                _fileSaved = true;
                _fileSaveName = openFileDialog.SafeFileName;
                _fileSavePath = openFileDialog.FileName;

                SetTitle();
            }
        }

        public void SaveFile()
        {
            File.WriteAllText(_fileSavePath, TextBox.Text);
            _fileSaved = true;
            SetTitle();
        }

        public void SaveFileAs()
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.FileName = "";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "TXT files (*.txt)|*.txt";

            bool? result = saveFileDialog.ShowDialog();

            if (result == true)
            {
                _fileSaveName = saveFileDialog.SafeFileName;
                _fileSavePath = saveFileDialog.FileName;

                SaveFile();
            }
        }

        public void Find(string textToFind)
        {
            var selectionLenght = TextBox.SelectedText.Length;
            var index = TextBox.Text.IndexOf(textToFind, TextBox.CaretIndex + selectionLenght);

            if (index != -1)
            {
                TextBox.Select(index, textToFind.Length);
                Focus();
            }
            else
            {
                //TODO: Show a "cannot find" box
            }
        }

        public MessageBoxResult DoYouWantToSaveDialog()
        {
            var messageBoxText = $"Do you want to save changes to {_fileSaveName}";

            var messageBoxButton = MessageBoxButton.YesNoCancel;
            var messageBoxImage = MessageBoxImage.Warning;
            var messageBoxResult = MessageBox.Show(messageBoxText, _appTitle, messageBoxButton, messageBoxImage);

            return messageBoxResult;
        }

        public void ExitSaveCheck(System.ComponentModel.CancelEventArgs e)
        {
            if (_fileSaved == false)
            {
                switch (DoYouWantToSaveDialog())
                {
                    case MessageBoxResult.Cancel:
                        e.Cancel = true;
                        break;
                    case MessageBoxResult.Yes:
                        MenuSaveFile();
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }
        }

        public static void ExitApplication()
        {
            Application.Current.Shutdown();
        }
    }
}
