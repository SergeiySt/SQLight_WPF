using Microsoft.EntityFrameworkCore;
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

namespace WpfApp23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AplicationContext db = new AplicationContext();
        public MainWindow()
        {
            InitializeComponent();


            Loaded += Window_Loaded;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow(new User());
            if(userWindow.ShowDialog() == true)
            {
                User user = userWindow.User;
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (usersList.SelectedItem != null && TextBoxUser())
            {
                User? user = usersList.SelectedItem as User;
                if(user != null)
                {
                    user.Name = textBoxName.Text;
                    user.Age = int.Parse(textBoxAge.Text);

                    db.SaveChanges();
                    usersList.ItemsSource = db.Users.ToList();
                    TextBoxClear();
                }
            }
            else
            {
                MessageBox.Show("Неможливо оновити запис. Перевірте, чи всі поля заповнені та вибрано запис в таблиці.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TextBoxClear()
        {
            textBoxName.Text = "";
            textBoxAge.Text = "";
        }
        private bool TextBoxUser()
        {
            return !string.IsNullOrEmpty(textBoxName.Text)
                && int.TryParse(textBoxAge.Text, out int age);
        }
        private void Delite_Click(object sender, RoutedEventArgs e)
        {
            if (usersList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть користувача для видалення.", "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            User? user = usersList.SelectedItem as User;
            if (user is null) return;
            db.Users.Remove(user);
            db.SaveChanges();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Database.EnsureCreated();

            db.Users.Load();

            DataContext = db.Users.Local.ToObservableCollection();
        }

        private void usersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (usersList.SelectedItem != null)
            {
                if (usersList.SelectedItem is User userSelected)
                {
                    textBoxName.Text = userSelected.Name;
                    textBoxAge.Text = userSelected.Age.ToString();

                }
                else
                {

                }
            }
        }
    }
}
