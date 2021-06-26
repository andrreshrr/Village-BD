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
   
    public partial class Citizens : Form
    {
       
        public Citizens(bool admin)
        {
            InitializeComponent();

            idForUp.Visible = false;
            label7.Visible = false;
            sexCitizenMale.Checked = true;
            AdminAddCitizen.Text = AddUpBut.Text;
            if (!admin)
            {
                DeleteBoxAdmin.Visible = false;
                AdminAddCitizen.Visible = false;

            }
        }
       
        
        private void citizensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citizensBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ourWorkDataSet);

        }

        private void Citizens_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ourWorkDataSet.Citizens". При необходимости она может быть перемещена или удалена.
            this.citizensTableAdapter.Fill(this.ourWorkDataSet.Citizens);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((String.Empty == adminMiddleNameAdd.Text)||(String.Empty == adminLastnameAdd.Text)
                    ||(String.Empty == adminAdd.Text))
            {
                MessageBox.Show("Заполните поля корректно");
                return;
            }
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                if (AddCitizen.Checked)
                {

                    string sqlExp = "AddCitizen";
                    SqlCommand command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter Name = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = adminAdd.Text
                    };
                    SqlParameter LastName = new SqlParameter
                    {
                        ParameterName = "@LastName",
                        Value = adminLastnameAdd.Text
                    };
                    SqlParameter MiddleName = new SqlParameter
                    {
                        ParameterName = "@MiddleName",
                        Value = adminMiddleNameAdd.Text
                    };
                    string s = "";
                    if (sexCitizenMale.Checked)
                    {
                        s = "Мужчина";
                    } else
                    {
                        s = "Женщина";
                    } 
                    SqlParameter Sex = new SqlParameter
                    {
                        ParameterName = "@Sex",
                        Value = s
                    };

                    SqlParameter DateOfBirth = new SqlParameter
                    {
                        ParameterName = "@Date_of_birth",
                        Value = HelpfulClass.GetValidDateForSql(AdminDateOfBirthAdd)
                    };
                    command.Parameters.Add(Name);
                    command.Parameters.Add(LastName);
                    command.Parameters.Add(MiddleName);
                    command.Parameters.Add(Sex);
                    command.Parameters.Add(DateOfBirth);
                    command.ExecuteNonQuery();
                } else
                {
                    if (String.Empty == idForUp.Text)
                    {
                        MessageBox.Show("Заполните поля корректно");
                        return;
                    }
                    string sqlExp = "UpdateCitizen";
                    SqlCommand command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter pr1 = new SqlParameter
                    {
                        ParameterName = "@new_name",
                        Value = adminAdd.Text
                    };
                    SqlParameter pr2 = new SqlParameter
                    {
                        ParameterName = "@new_lname",
                        Value = adminLastnameAdd.Text
                    };
                    SqlParameter pr3 = new SqlParameter
                    {
                        ParameterName = "@new_mname",
                        Value = adminMiddleNameAdd.Text
                    };
                    string s = "";
                    if (sexCitizenMale.Checked)
                    {
                        s = "Мужчина";
                    } else
                    {
                        s = "Женщина";
                    }
                    SqlParameter pr4 = new SqlParameter
                    {
                        ParameterName = "@new_sex",
                        Value = s
                    };

                    SqlParameter pr5 = new SqlParameter
                    {
                        ParameterName = "@new_born",
                        Value = HelpfulClass.GetValidDateForSql(AdminDateOfBirthAdd)
                    };
                    SqlParameter pr6 = new SqlParameter
                    {
                        ParameterName = "@id",
                        Value = Convert.ToInt32(idForUp.Text)
                    };
                    command.Parameters.Add(pr1);
                    command.Parameters.Add(pr2);
                    command.Parameters.Add(pr3);
                    command.Parameters.Add(pr4);
                    command.Parameters.Add(pr5);
                    command.Parameters.Add(pr6);
                    command.ExecuteNonQuery();

                }
                HelpfulClass.UpdateTable("Citizens", connection, citizensDataGridView);
                connection.Close();
                                  
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void deleteAdmin_Click(object sender, EventArgs e)
        {

            if (idDeleted.Text == String.Empty)
            {
                MessageBox.Show("Заполните поля конректно");
                return;
            }
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                string sqlExp = "DeleteCitizen";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = Convert.ToInt32(idDeleted.Text)
                };


                command.Parameters.Add(id);
                command.ExecuteNonQuery();
                HelpfulClass.UpdateTable("Citizens", connection, citizensDataGridView);
                connection.Close();
            }


        }

        private void UpdateCitizen_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateCitizen.Checked)
            {
                AddUpBut.Text = "Обновить жителя";
                idForUp.Visible = true;
                label7.Visible = true;
                AdminAddCitizen.Text = AddUpBut.Text;
            }
        }

        private void AddCitizen_CheckedChanged(object sender, EventArgs e)
        {
            if (AddCitizen.Checked)
            {
                AddUpBut.Text = "Добавить жителя";
                idForUp.Visible = false;
                label7.Visible = false;
                AdminAddCitizen.Text = AddUpBut.Text;
            }
        }

        private void DeleteBoxAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void idForUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled=true;
            }
        }

        private void idDeleted_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }

        }
    }
}
