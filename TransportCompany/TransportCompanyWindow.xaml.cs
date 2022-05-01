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

namespace TransportCompany
{
    /// <summary>
    /// Логика взаимодействия для TransportCompanyWindow.xaml
    /// </summary>
    public partial class TransportCompanyWindow : Window
    {
        public TransportCompanyWindow()
        {
            InitializeComponent();
        }

        private void transportCompanyExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwin = new MainWindow();
            mwin.Show();
            this.Close();
        }

        private void transportCompanyCloseButton_Click(object sender, RoutedEventArgs e)
        {
            base.OnClosed(e);
            App.Current.Shutdown();
        }

        private void transportCompanyBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void homePageButton_Click(object sender, RoutedEventArgs e)
        {
            transportCompanyInfoBorder.Visibility = Visibility.Hidden;
            statementsListView.Visibility = Visibility.Hidden;
            statementsDeleteButton.Visibility = Visibility.Hidden;
        }

        private void createStatementButton_Click(object sender, RoutedEventArgs e)
        {
            statementsListView.Visibility = Visibility.Hidden;
            statementsDeleteButton.Visibility = Visibility.Hidden;
            transportCompanyInfoBorder.Visibility = Visibility.Visible;
        }

        private void viewStatementButton_Click(object sender, RoutedEventArgs e)
        {
            transportCompanyInfoBorder.Visibility = Visibility.Hidden;
            statementsListView.Visibility = Visibility.Visible;
            statementsDeleteButton.Visibility = Visibility.Visible;

            Classes.LoadStatements loadStatements = new Classes.LoadStatements();
            loadStatements.loadStatements(this);
        }

        private void statementsDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            dynamic itemSelectList = statementsListView.SelectedItem;
            if (itemSelectList != null)
            {
                Classes.DeleteStatements deleteStatements = new Classes.DeleteStatements();
                deleteStatements.deleteStatements(this);
            }
        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.RecordStatements recordStatements = new Classes.RecordStatements();
            recordStatements.recordStatements(this);

            senderTextBox.Clear();
            recipientTextBox.Clear();
            passportTextBox.Clear();
            numberTextBox.Clear();
            placeOfDispatchTextBox.Clear();
            placeOfDeliveryTextBox.Clear();
            wishesTextBox.Clear();
            weightTextBox.Clear();
            costTextBox.Clear();

            MessageBox.Show("Заявление оформлено");
        }
    }
}
