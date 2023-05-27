using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp23
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {

        public User User { get; set; }
        public UserWindow(User user)
        {
            InitializeComponent();
            User = user;
            DataContext = User;
        }   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxName.Text)
                && int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
