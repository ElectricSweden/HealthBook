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

namespace Recept_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i;
        public MainWindow()
        {
            InitializeComponent();
            DarkColor1.Color = Colors.Teal;
            DarkColor2.Color = Color.FromRgb(0, 78, 154);
            BarColor.Background = Brushes.CadetBlue;
        }

        //Click on Login
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login loginwindow = new Login();
            loginwindow.Show();
            Close();
        }

        //Click on Register
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Register registerwindow = new Register();
            registerwindow.Show();
            Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchPage searchwindow = new SearchPage();
            Content = searchwindow;
        }

        private void Recipes_Click(object sender, RoutedEventArgs e)
        {
            HealthBook.RecipePage recipewindow = new HealthBook.RecipePage();
            Content = recipewindow;
        }

        private void DarkMode_Click(object sender, RoutedEventArgs e)
        {
            DarkColor1.Color = Color.FromRgb(18, 18, 18); //Teal
            DarkColor2.Color = Color.FromRgb(18, 18, 18); //#004E9A
            BarColor.Background = Brushes.Gray;
            i = 2;
        }

        private void Ukraine_Click(object sender, RoutedEventArgs e)
        {
            DarkColor1.Color = Colors.Blue;
            DarkColor2.Color = Colors.Yellow;
            BarColor.Background = Brushes.DarkBlue;
            i = 3;
        }

        private void StandardMode_Click(object sender, RoutedEventArgs e)
        {
            DarkColor1.Color = Colors.Teal;
            DarkColor2.Color = Color.FromRgb(0, 78, 154);
            BarColor.Background = Brushes.CadetBlue;
            i = 1;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            HealthBook.About about = new HealthBook.About();
            Content = about;
        }
    }
}
