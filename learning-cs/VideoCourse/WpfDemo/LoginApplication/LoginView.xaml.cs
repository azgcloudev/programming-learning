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

namespace LoginApplication
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void ButtonLogin(object sender, RoutedEventArgs e)
        {
            // gets the password from the PasswordBox
            var passwordEntered = InputLoginPassword.Password;

            // read the password from the env variable in the system
            string? envPass = Environment.GetEnvironmentVariable("APP_PASS");

            if (envPass != null)
            {
                // check if password is correct
                if (passwordEntered == envPass)
                {
                    MessageBox.Show("Correct password.");
                }
                else
                {
                    MessageBox.Show("Login failed.");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found.");
            }
        }
    }
}
