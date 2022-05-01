using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace TransportCompany.Classes
{
    class Login
    {
        string log;
        int index;
        public void login(MainWindow MW)
        {
            if (MW.loginTextBox.Text.Length > 0)
            {
                if (MW.passwordBox.Password.Length > 0)
                {
                    if (MW.captchaTextBox.Text == MW.captchaGenTextBox.Text || MW.captchaGenTextBox.Text.Length == 0)
                    {
                        Classes.Connection connection = new Classes.Connection();
                        DataTable dt_TransportCompany = connection.Select("SELECT * FROM [dbo].[Table_users] WHERE [Логин] = '" + MW.loginTextBox.Text + "' AND [Пароль] = '" + MW.passwordBox.Password + "'");
                        if (dt_TransportCompany.Rows.Count > 0)
                        {
                            dt_TransportCompany = connection.Select("SELECT * FROM [dbo].[Table_users]"); // данные из БД
                            for (int i = 0; i < dt_TransportCompany.Rows.Count; i++) // перебираем данные
                            {
                                log = dt_TransportCompany.Rows[i][0].ToString();
                                if (log == MW.loginTextBox.Text.ToString())
                                {
                                    index = i;
                                }

                            }
                            TransportCompanyWindow TCwin = new TransportCompanyWindow();
                            TCwin.Owner = MW;
                            TCwin.userLabel.Content = dt_TransportCompany.Rows[index][2].ToString() + " " + dt_TransportCompany.Rows[index][3].ToString() + " " + dt_TransportCompany.Rows[index][4].ToString();
                            TCwin.Show();
                            MW.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                            {
                                Classes.CaptchaGenerator captchaGenerator = new Classes.CaptchaGenerator();
                                captchaGenerator.captchaGenerator(MW);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Каптча неверная");
                        {
                            Classes.CaptchaGenerator captchaGenerator = new Classes.CaptchaGenerator();
                            captchaGenerator.captchaGenerator(MW);
                        }
                    }
                }
            }
        }
    }
}
