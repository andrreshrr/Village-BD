using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OuurWork
{
    class HelpfulClass
    {
        public static string   connectString = ConfigurationManager.ConnectionStrings["OuurWork.Properties.Settings.OurWorkConnectionString"].ConnectionString;
        public static void UpdateTable(string nameTable, SqlConnection connection, System.Windows.Forms.DataGridView DGV)
        {

            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM " + nameTable, connection);
            DataSet DS = new DataSet();
            SDA.Fill(DS, nameTable);

            DGV.DataSource = DS.Tables[nameTable];

        }
        
        public static string GetValidDateForSql(System.Windows.Forms.DateTimePicker date)
        {
            string res = date.Value.Year.ToString();
            if (date.Value.Month < 10)
            {
                res += '0' + date.Value.Month.ToString();
            }
            else
            {
                res += date.Value.Month.ToString();
            }
            if (date.Value.Day < 10)
            {
                res += '0' + date.Value.Day.ToString();
            }
            else
            {
                res += date.Value.Day.ToString();
            }
            return res;
        }
    }
}
