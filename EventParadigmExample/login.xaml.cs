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
    /// Lógica de interacción para login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "user" && txtPassword.Password == "password")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new home());
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
