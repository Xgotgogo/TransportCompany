using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.Classes
{
    class ShowPassword
    {
        public void showPassword(MainWindow MW)
        {
            if (MW.showPasswordCheckBox.IsChecked == true)
            {
                MW.passwordTextBox.Text = MW.passwordBox.Password;
                MW.passwordTextBox.Visibility = Visibility.Visible;
                MW.passwordBox.Visibility = Visibility.Hidden;
            }
            else
            {
                MW.passwordBox.Password = MW.passwordTextBox.Text;
                MW.passwordTextBox.Visibility = Visibility.Hidden;
                MW.passwordBox.Visibility = Visibility.Visible;
            }
        }
    }
}
