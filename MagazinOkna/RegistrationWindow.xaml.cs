using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Xml.Linq;

namespace MagazinOkna
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
           
                string name = NameTextBox.Text;
                string surname = SurnameTextBox.Text;
                string role = RoleTextBox.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(role))
                {
                MessageBox.Show("Введите имя, фамилию и роль.");
                return;
                }

            if (role != "User" && role != "Admin")
            {
                MessageBox.Show("Роль должна быть 'User' или 'Admin'.");
                return;
            }
            File.AppendAllText("Employees.txt", $"{name} {surname} {role}\n");

            MessageBox.Show("Регистрация прошла успешно!");
            this.Close();

        }
    }
}
