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
using System.Windows.Threading;
using System.Data;
using System.Data.SqlClient;

namespace TransportCompany
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Login login = new Classes.Login();
            login.login(this);
        }

        private void authorizationCloseButton_Click(object sender, RoutedEventArgs e)
        {
            base.OnClosed(e);
            App.Current.Shutdown();
        }

        private void showPasswordCheckBox_Click(object sender, RoutedEventArgs e)
        {
            Classes.ShowPassword showPassword = new Classes.ShowPassword();
            showPassword.showPassword(this);
        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Refresh refresh = new Classes.Refresh();
            refresh.refresh(this);
        }

        private void authorizationBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
