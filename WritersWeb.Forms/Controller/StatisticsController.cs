using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WritersWeb.Base;

namespace WritersWeb.Forms.Controller
{
    public class StatisticsController 
    {
        private SqlConnection connect = new SqlConnection(DatabaseManager.GetConnectionString("WWConStrings"));

        private void RefreshConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public int getCountLeads
        {
            get
            {
                var cmd = new SqlCommand()
                {
                    Connection = connect,
                    CommandText = "select COUNT(IdAuthor)TotalLeads from tblAuthorDictionary",
                    CommandType = CommandType.Text
                };
                RefreshConnection();
                int leads = (int)cmd.ExecuteScalar();
                connect.Close();

                return leads;

            }
        }
    }
}
