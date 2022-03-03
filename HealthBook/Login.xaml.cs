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

namespace Recept_UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            //if (i == 2) Om jag kan fixa, så kan jag ändra färg på alla pages/windows
            {

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        //Login button on PeterPage
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            //Mainwindow.username.Text = user; //RIP
            //Kan inte komma åt variabeln för att den inte ligger i rätt klass. //Därför skapade jag ett nytt MainWindow och assignade username
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            mainwindow.username.Text = user;
            Close();
        }
    }
}

