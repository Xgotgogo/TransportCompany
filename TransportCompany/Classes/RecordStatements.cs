using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace TransportCompany.Classes
{
    class RecordStatements
    {
        public void recordStatements(TransportCompanyWindow TCwin)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-7NIK29D\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=TransportCompany;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Insert into Table_statements (Отправитель,Получатель,Паспортные_данные,Номер_телефона,Место_отправки,Место_доставки,Пожелания_к_отправлению,Вес_отправления,Стоимость)values(@Отправитель,@Получатель,@Паспортные_данные,@Номер_телефона,@Место_отправки,@Место_доставки,@Пожелания_к_отправлению,@Вес_отправления,@Стоимость)";
            sqlCommand.Parameters.AddWithValue("@Отправитель", TCwin.senderTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Получатель", TCwin.recipientTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Паспортные_данные", TCwin.passportTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Номер_телефона", TCwin.numberTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Место_отправки", TCwin.placeOfDispatchTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Место_доставки", TCwin.placeOfDeliveryTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Пожелания_к_отправлению", TCwin.wishesTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Вес_отправления", TCwin.weightTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Стоимость", TCwin.costTextBox.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
        }
    }
}
