using Models;
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

namespace WpfBrokenToaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declare toaster
        Toaster wpfToaster;
        
        public MainWindow()
        {
            InitializeComponent();
            //initialize toaster
            
        }

        private void btnFillToaster_Click(object sender, RoutedEventArgs e)
        {
            //fill toaster
            tbToaster.Text = "Toaster Filled!!"; //TODO replace with text of real toaster filling
        }


        private void chkBreakToaster_Unchecked(object sender, RoutedEventArgs e)
        {
            this.BrokenCheckBoxChanged((CheckBox)sender);
        }

        private void chkBreakToaster_Checked(object sender, RoutedEventArgs e)
        {
            this.BrokenCheckBoxChanged(sender as CheckBox);
        }

        private void BrokenCheckBoxChanged(CheckBox cb)
        {
            wpfToaster.isBroken = cb.IsChecked.Value;
        }

        
    }
}
