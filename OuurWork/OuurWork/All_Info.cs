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


namespace OuurWork
{
    public partial class All_Info : Form
    {
        string connectString = "Data Source=RRESHRRPC;Initial Catalog=OurWork;Integrated Security  = True";
        public All_Info(string info)
        {
            InitializeComponent();
            if (info == "admin")
            {

                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    string command = "SELECT * FROM Profiles";
                    SqlDataAdapter SDA = new SqlDataAdapter(command, connection);
                    DataSet DS = new DataSet();
                    SDA.Fill(DS, "Profiles");
                    dataGridView.DataSource = DS.Tables["Profiles"];
                    HelpfulClass.UpdateTable("Profiles", connection, dataGridView);
                }
            } else if (info=="citizen")
            {

                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    string command = "SELECT * FROM Profile";
                    SqlDataAdapter SDA = new SqlDataAdapter(command, connection);
                    DataSet DS = new DataSet();
                    SDA.Fill(DS, "Profile");
                    dataGridView.DataSource = DS.Tables["Profile"];
                    HelpfulClass.UpdateTable("Profile", connection, dataGridView);
                }
            }
        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void citizensProfilesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
