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
    class LoadStatements
    {
        public class statements
        {
            public string id { get; set; }
            public string sender { get; set; }
            public string recipient { get; set; }
            public string passport { get; set; }
            public string number { get; set; }
            public string placeOfDispatch { get; set; }
            public string placeOfDelivery { get; set; }
            public string wishes { get; set; }
            public string weight { get; set; }
            public string cost { get; set; }
        }

        public void loadStatements(TransportCompanyWindow TCwin)
        {
            TCwin.statementsListView.Items.Clear();
            Classes.Connection connection = new Classes.Connection();
            DataTable dt_TransportCompany = connection.Select("SELECT * FROM [dbo].[Table_statements]"); // данные из БД
            for (int i = 0; i < dt_TransportCompany.Rows.Count; i++) // перебираем данные
            {
                statements dataStatements = new statements() // создаём экземпляр класса
                {
                    id = dt_TransportCompany.Rows[i][0].ToString(),
                    sender = dt_TransportCompany.Rows[i][1].ToString(),
                    recipient = dt_TransportCompany.Rows[i][2].ToString(),
                    passport = dt_TransportCompany.Rows[i][3].ToString(),
                    number = dt_TransportCompany.Rows[i][4].ToString(),
                    placeOfDispatch = dt_TransportCompany.Rows[i][5].ToString(),
                    placeOfDelivery = dt_TransportCompany.Rows[i][6].ToString(),
                    wishes = dt_TransportCompany.Rows[i][7].ToString(),
                    weight = dt_TransportCompany.Rows[i][8].ToString(),
                    cost = dt_TransportCompany.Rows[i][9].ToString(),
                };
                TCwin.statementsListView.Items.Add(dataStatements); // выводим строку в список
            }
        }
    }
}
