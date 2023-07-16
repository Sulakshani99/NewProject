using Desktop_4035.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Automation;
using DevExpress.XtraReports.Design;
using Desktop_4035;
using System.Windows.Media.TextFormatting;
using DevExpress.Utils;
using DevExpress.Utils.CommonDialogs.Internal;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using DevExpress.Xpo.DB;

namespace Destop
{
    public partial class AddStudentVM : ObservableObject

    {


        [ObservableProperty]
        public string firstname;


        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;


        //To change the tile

        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public BitmapImage selectedImage;



        public AddStudentVM(Student u)
        {
            User = u;

            firstname = User.FirstName;
            lastname = User.LastName;
            age = User.Age;
            gpa = User.GPA;
            dateofbirth = User.DateOfBirth;
            selectedImage = User.Image;

        }
        public AddStudentVM()
        {

        }


        //get image 
        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(dialog.FileName));

                MessageBox.Show("Image is uploded successfully!", "successfull");
                
            }
        }

        public Student User { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Back()
        {
            {
                if (User != null)
                {
                    DialogResult result = (DialogResult)MessageBox.Show($"Are you sure you want to back", "Back Window", MessageBoxButton.YesNo);
                    {
                        if (result == DevExpress.Utils.CommonDialogs.Internal.DialogResult.Yes)
                        {
                            CloseAction();
                            Application.Current.MainWindow.Show();
                        }
                    }
                }
                else
                {

                    DialogResult result = (DialogResult)MessageBox.Show("You can't go to the back window.", "Warning Message");
                    return;
                }
            }
        }


        [RelayCommand]
        public void Save()
        {



            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "Error Message");
                return;
            }
            if (User == null)
            {

                User = new Student()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                    DateOfBirth = dateofbirth,
                    Image = selectedImage,
                    GPA = gpa

                };


            }
            else
            {

                User.FirstName = firstname;
                User.LastName = lastname;
                User.Age = age;
                User.GPA = gpa;
                User.Image = selectedImage;
                User.DateOfBirth = dateofbirth;



            }

            if (User.FirstName != null)
            {

                CloseAction();
            }
            Application.Current.MainWindow.Show();


        }
    }
}