using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.Classes
{
    class CaptchaGenerator
    {
        public void captchaGenerator(MainWindow MW)
        {
            MW.captchaGenTextBox.Visibility = System.Windows.Visibility.Visible;
            MW.captchaTextBox.Visibility = System.Windows.Visibility.Visible;
            MW.refreshButton.Visibility = System.Windows.Visibility.Visible;
            MW.captchaLabel.Visibility = System.Windows.Visibility.Visible;

            char[] chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789".ToCharArray();
            string randomString = "";
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomString += chars[ran.Next(0, chars.Length)];
            }
            MW.captchaGenTextBox.Text = randomString;
        }
    }
}
