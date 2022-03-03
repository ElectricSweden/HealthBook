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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void TextBox_Username(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_Email(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordBox_ConfirmPassword(object sender, RoutedEventArgs e)
        {

        }
        private void PasswordBox_Password(object sender, RoutedEventArgs e)
        {

        }

        //Register Button on PeterPage
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Close();
        }


    }
}
