using Desktop_4035;
using Desktop_4035.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Destop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using DevExpress.Utils.CommonDialogs.Internal;

namespace Desktop_4035
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> students;
        [ObservableProperty]
        public Student selectedStudent = null;



        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }




        [RelayCommand]
        public void message()
        {

            MessageBox.Show($"{selectedStudent.FirstName} GPA value must be between 0 and 4.", "Error Message");
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddStudentVM();
            vm.title = "ADD STUDENT";
            AddStudentWindow window = new AddStudentWindow(vm);
            window.ShowDialog();

            if (vm.User.FirstName != null)
            {
                students.Add(vm.User);
            }
        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedStudent != null)
            {
                string name = selectedStudent.FirstName;
                DialogResult result = (DialogResult)MessageBox.Show($"Are you sure you want to delete {name}", "Delete Student", MessageBoxButton.YesNo);
                {
                    if (result == DevExpress.Utils.CommonDialogs.Internal.DialogResult.Yes)
                    {
                        students.Remove(selectedStudent);
                        MessageBox.Show($"{name} is deleted successfulLy.", "DELETED \a ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the related student before delete.", "Error Message");


            }
        }


        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if (selectedStudent != null)
            {
                var vm = new AddStudentVM(selectedStudent);
                vm.title = "EDIT STUDENT";
                var window = new AddStudentWindow(vm);

                window.ShowDialog();

                int index = students.IndexOf(selectedStudent);
                students.RemoveAt(index);
                students.Insert(index, vm.User);

            }
            else
            {
                MessageBox.Show("Please select the related student before edit", "Warning!!!");
            }
        }

        public MainWindowVM()
        {
            students = new ObservableCollection<Student>();
            BitmapImage image1 = new BitmapImage(new Uri("/Model/Images/figure1.png", UriKind.Relative));
            students.Add(new Student(25, "Sandun", "Basnayake", "12/01/1998", 2.5, image1));
            BitmapImage image2 = new BitmapImage(new Uri("/Model/Images/figure2.jpg", UriKind.Relative));
            students.Add(new Student(22, "Kasun", "Jayasooriya", "02/05/2000", 3.1,image2));
            BitmapImage image3 = new BitmapImage(new Uri("/Model/Images/figure3.jpg", UriKind.Relative));
            students.Add(new Student(25, "Hansi", "Wedagedara", "15/07/1997", 2.8, image3));
            BitmapImage image4 = new BitmapImage(new Uri("/Model/Images/figure4.jpg", UriKind.Relative));
            students.Add(new Student(23, "Tasheena", "Dissanayake", "15/12/1999", 3.2, image4));
            BitmapImage image5 = new BitmapImage(new Uri("/Model/Images/figure5.jpg", UriKind.Relative));
            students.Add(new Student(24, "Bawantha", "Rathnayake", "15/05/1998", 2.9, image5));
            BitmapImage image6 = new BitmapImage(new Uri("/Model/Images/figure6.jpg", UriKind.Relative));
            students.Add(new Student(22, "Meena", "Prasadhini", "28/09/2000", 2.4, image6));
            BitmapImage image7 = new BitmapImage(new Uri("/Model/Images/figure7.jpg", UriKind.Relative));
            students.Add(new Student(23, "Chathura", "Wikramage", "03/10/1999", 2.8, image7));
            BitmapImage image8 = new BitmapImage(new Uri("/Model/Images/figure8.jpg", UriKind.Relative));
            students.Add(new Student(23, "Akalanka", "Gamage", "17/06/1999", 3.2, image8));
            BitmapImage image9 = new BitmapImage(new Uri("/Model/Images/figure9.jpg", UriKind.Relative));
            students.Add(new Student(26, "Chinthaka", "Abewikrama", "30/03/1997", 2.8, image9));
            BitmapImage image10 = new BitmapImage(new Uri("/Model/Images/figure10.jpg", UriKind.Relative));
            students.Add(new Student(23, "Gayesha", "Sinhawansha", "05/09/1999", 3.2, image10));


        }
    }
}



