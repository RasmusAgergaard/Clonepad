using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clonepad.UI
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_New_Click(object sender, RoutedEventArgs e)
        {
            NewFile();
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            CloseApp();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            _fileSaved = false;
        }

        private void MenuItem_SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileAs();
        }
    }
}
