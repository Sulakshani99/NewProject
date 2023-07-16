using Desktop_4035;
using Desktop_4035.Model;
using Destop;
using DevExpress.Utils.CommonDialogs.Internal;
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
using System.Xml.Linq;

namespace Desktop_4035
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowVM();
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Listview_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Listview_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DialogResult result = (DialogResult)MessageBox.Show($"Are you sure you want to exit", "Exit Window", MessageBoxButton.YesNo);
            {
                if (result == DevExpress.Utils.CommonDialogs.Internal.DialogResult.Yes)
                {
                    Application.Current.Shutdown();
                }
            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
