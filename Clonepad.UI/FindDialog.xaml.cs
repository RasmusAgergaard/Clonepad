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
using System.Windows.Shapes;

namespace Clonepad.UI
{
    public partial class FindDialog : Window
    {
        private MainWindow _window;

        public FindDialog(MainWindow mainWindow)
        {
            InitializeComponent();
            _window = mainWindow;
        }

        private void Button_Click_Find(object sender, RoutedEventArgs e)
        {
            _window.Find(TextBoxFind.Text);

        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
