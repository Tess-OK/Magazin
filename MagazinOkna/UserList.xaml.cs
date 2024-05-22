using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace UserList
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Загружаем данные из текстового файла
            LoadUsersFromFile("Employees.txt");

            // Связываем список пользователей с ListView
            DataContext = this;
        }

        private void LoadUsersFromFile(string filePath)
        {
            Users = new ObservableCollection<User>();

            // Читаем данные из файла
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            Users.Add(new User { Name = parts[0].Trim(), UserName = int.Parse(parts[1].Trim()) });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }

    // Класс для представления пользователя
    public class User
    {
        public string Name { get; set; }
        public int UserName { get; set; }
    }
}
