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
    public partial class Houses : Form
    {
       
        public Houses(bool admin)
        {
            InitializeComponent();
            if (admin)
            {
                radioAdd.Checked = true;
               
                labelIdHouse.Visible = false;
                IdHouse.Visible = false;
            }
            radioVip.Checked = true;
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                HelpfulClass.UpdateTable("Houses", connection, housesDataGridView);
                connection.Close();
            }

            if (!admin)
            {
                radioUp.Checked = true;
                radioAdd.Enabled = false;
                labelIdHouse.Visible = true;
                IdHouse.Visible =true;
                DeleteBoxAdmin.Visible = false;
            }
        }





        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddUpHouse_Click(object sender, EventArgs e)
        {

            if ((String.Empty == price.Text)|| (String.Empty == IdResp.Text)){
                MessageBox.Show("Заполните поля корректно", "Прошу", MessageBoxButtons.OK);
                return;
            }


            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                if (radioAdd.Checked)
                {

                    string sqlExp = "AddHouse";
                    SqlCommand command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idResp",
                        Value = Convert.ToInt32(IdResp.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@CountRoom",
                        Value = Count.Value
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@PriceDay",
                        Value = Convert.ToDecimal(price.Text)
                    };
                    string s = "";
                    if (radioVip.Checked)
                    {
                        s = "Да";
                    }
                    else
                    {
                        s = "Нет";
                    }
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@Vip",
                        Value = s
                    };

                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);

                    command.ExecuteNonQuery();

                }
                else
                {
                    if (String.Empty == IdHouse.Text){
                        MessageBox.Show("Заполните поля корректно", "Прошу", MessageBoxButtons.OK);
                        return;
                    }

                    string sqlExp = "UpdateHouse";
                    SqlCommand command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idResp",
                        Value = Convert.ToInt32(IdResp.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@CountRoom",
                        Value = Count.Value
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@PriceDay",
                        Value = Convert.ToDecimal(price.Text)
                    };
                    string s = "";
                    if (radioVip.Checked)
                    {
                        s = "Да";
                    }
                    else
                    {
                        s = "Нет";
                    }
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@Vip",
                        Value = s
                    };

                    SqlParameter prm5 = new SqlParameter
                    {
                        ParameterName = "@id",
                        Value = Convert.ToInt32(IdHouse.Text)
                    };
                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);
                    command.Parameters.Add(prm5);
                    command.ExecuteNonQuery();
                }
                HelpfulClass.UpdateTable("Houses", connection, housesDataGridView);
                connection.Close();

            }


        }

        private void radioUp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUp.Checked)
            {
                labelIdHouse.Visible = true;
                IdHouse.Visible = true;
                groupInterface.Text = "Обновление дома";
                AddUpHouse.Text = "Обновить инфо о доме";
            }
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {

            if (radioAdd.Checked)
            {

                groupInterface.Text = "Добавление дома";
                AddUpHouse.Text = "Добавить дом";
                labelIdHouse.Visible = false;
                IdHouse.Visible = false;
            }
        }

        private void deleteHouse_Click(object sender, EventArgs e)
        {
            if (idDeleted.Text == String.Empty)
            {
                MessageBox.Show("Заполните поля корректно");
                return;
            }
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                string sqlExp = "DeleteHouse";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = Convert.ToInt32(idDeleted.Text)
                };


                command.Parameters.Add(id);
                command.ExecuteNonQuery();
                HelpfulClass.UpdateTable("Houses", connection, housesDataGridView);
                connection.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdHouse_KeyPress(object sender, KeyPressEventArgs e)
        {

            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb) )
            {
                e.Handled = true;
            }
        }

        private void IdResp_KeyPress(object sender, KeyPressEventArgs e)
        {

            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb) )
            {
                e.Handled = true;
            }
        }

        private void idDeleted_KeyPress(object sender, KeyPressEventArgs e)
        {

            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb) )
            {
                e.Handled = true;
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb) && symb != ',')
            {
                e.Handled = true;
            }
        }
    }
}
