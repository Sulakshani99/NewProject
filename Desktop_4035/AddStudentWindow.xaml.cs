using Desktop_4035;
using Desktop_4035.Model;
using Destop;
using DevExpress.Internal;
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
using System.Windows.Shapes;

namespace Desktop_4035
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
        }

        public AddStudentWindow(AddStudentVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult result = (DialogResult)MessageBox.Show($"Are you sure you want to exit", "Exit Window", MessageBoxButton.YesNo);
            {
                if (result == DevExpress.Utils.CommonDialogs.Internal.DialogResult.Yes)
                {
                    Application.Current.Shutdown();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
