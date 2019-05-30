using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Clonepad.UI
{
    public partial class MainWindow : Window
    {
        private bool _fileSaved = true;

        public void NewFile()
        {
            if (_fileSaved)
            {
                ResetTextBox();
            }
            else
            {
                DoYouWantToSave();
                //ResetTextBox();
            }
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
            }
        }

        private void DoYouWantToSave()
        {
            //Should be a Yes/No dialog her

            //Yes
            SaveFileAs();
        }

        private void SaveFileAs()
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.FileName = "";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "TXT files (*.txt)|*.txt";

            bool? result = saveFileDialog.ShowDialog();

            if (result == true)
            {
                File.WriteAllText(saveFileDialog.FileName, TextBox.Text);
            }
        }

        public void ResetTextBox()
        {
            TextBox.Text = "";
        }

        public void CloseApp()
        {
            Application.Current.Shutdown();
        }
    }
}
