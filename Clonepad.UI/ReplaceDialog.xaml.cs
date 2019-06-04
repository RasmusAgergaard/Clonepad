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
    /// <summary>
    /// Interaction logic for ReplaceDialog.xaml
    /// </summary>
    public partial class ReplaceDialog : Window
    {
        private MainWindow _window;

        public ReplaceDialog(MainWindow mainWindow)
        {
            InitializeComponent();
            _window = mainWindow;
        }

        private void Button_Click_FindNext(object sender, RoutedEventArgs e)
        {
            ReplaceDialogFindNext();
        }

        private void Button_Click_Replace(object sender, RoutedEventArgs e)
        {
            ReplaceDialogReplace();
        }

        private void Button_Click_ReplaceAll(object sender, RoutedEventArgs e)
        {
            ReplaceDialogReplaceAll();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            ReplaceDialogCancel();
        }
    }
}
