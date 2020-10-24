using CheckBoxDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CheckBoxDemo.ViewModels
{
    public class MultiSelectDemoViewModel : INotifyPropertyChanged
    {

        #region Propertites
        private string _selectedButtonText = "Check All";
        public string SelectedButtonText
        {
            get => _selectedButtonText;
            set { _selectedButtonText = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Employee> Employees { get; set; }
        #endregion

        public MultiSelectDemoViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            BindData();
        }

        #region Methods
        private void BindData()
        {
            Employee emp = new Employee();
            emp.Email = "abc@gmail.com";
            emp.Name = "Pragnesh";
            emp.Gender = "Male";
            Employees.Add(emp);

            emp = new Employee();
            emp.Email = "abc@gmail.com";
            emp.Name = "Vishal";
            emp.Gender = "Male";
            Employees.Add(emp);

            emp = new Employee();
            emp.Email = "abc@gmail.com";
            emp.Name = "Jharna";
            emp.Gender = "Female";
            Employees.Add(emp);


            emp = new Employee();
            emp.Email = "abc@gmail.com";
            emp.Name = "Rupali";
            emp.Gender = "Female";
            Employees.Add(emp);

            emp = new Employee();
            emp.Email = "abc@gmail.com";
            emp.Name = "Jignesh";
            emp.Gender = "Male";
            Employees.Add(emp);

            emp = new Employee();
            emp.Email = "abc@gmail.com";
            emp.Name = "Nirav";
            emp.Gender = "Male";
            Employees.Add(emp);

            emp = new Employee();
            emp.Email = "abc@gmail.com";
            emp.Name = "Viral";
            emp.Gender = "Male";
            Employees.Add(emp);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        #region Commands
        public ICommand SelectAllCommand
        {
            get
            {
                return new Command(() =>
                {
                    if (SelectedButtonText == "Check All")
                    {
                        Employees.ForEach(f => { f.IsChecked = true; });
                        SelectedButtonText = "UnCheck All";
                    }
                    else
                    {
                        Employees.ForEach(f => { f.IsChecked = false; });
                        SelectedButtonText = "Check All";

                    }
                });
            }
        }

        public ICommand FetchSelectedItemCommand
        {
            get
            {
                return new Command(() =>
                {
                    var selectedItem = Employees.Where(f => f.IsChecked == true).ToList();
                    App.Current.MainPage.DisplayAlert("Selected Item Count", selectedItem.Count + "", "OK");
                });
            }
        }
        #endregion
    }
}
