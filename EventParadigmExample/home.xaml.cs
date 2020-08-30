using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventParadigmExample
{
    /// <summary>
    /// Lógica de interacción para home.xaml
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string porfa = pres.Text;

        }
        private void che1_Checked(object sender, RoutedEventArgs e)
        {
            lblCategory.Content = che1.Content.ToString();
            shuchu.Content = lblCategory.Content;
        }

        private void che2_Checked(object sender, RoutedEventArgs e)
        {
            lblCategory.Content = che2.Content.ToString();
            shuchu.Content = lblCategory.Content;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string v = txtProductName.Text;
            shuchu.Content = shuchu.Content + "\n" + "$" + pres.Text + " " + v; 
            txtResults.Text = shuchu.Content.ToString();
        }
        private void btnSalida_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new login());
        }




    }
}
