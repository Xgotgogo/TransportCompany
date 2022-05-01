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
    class DeleteStatements
    {
        public void deleteStatements(TransportCompanyWindow TCwin)
        {
            dynamic itemSelectList = TCwin.statementsListView.SelectedItem;
            var id = itemSelectList.id;
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-7NIK29D\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=TransportCompany;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = "DELETE FROM Table_statements WHERE [ID] = @id";
            sqlCommand.Parameters.AddWithValue("@id", id); // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable); ;
            TCwin.statementsListView.Items.Clear();
            Classes.LoadStatements loadStatements = new Classes.LoadStatements();
            loadStatements.loadStatements(TCwin);

        }
    }
}
