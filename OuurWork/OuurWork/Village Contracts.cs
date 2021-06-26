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
    public partial class Village_Contracts : Form
    {
        
        public Village_Contracts(bool admin)
        {
            InitializeComponent();
            radioVillageContract.Checked = true;

            groupGlobalBox.Visible = false;
            groupVilContractAddUp.Visible = true;
            groupAddUpTurBox.Visible = false;

            radioAddVilContract.Checked = true;
            label7.Visible = false;
            tboxVilContractID.Visible = false;

            radioAddTurContr.Checked = true;
            idTurContract.Visible = false;
            labelForIDTur.Visible = false;

            radioAddGlobal.Checked = true;
            label4.Visible = false;
            IdContrGlobal.Visible = false;

            radioSexTurMale.Checked = true;

            TypeGlobal.SelectedItem = "Молоко";
            ProductionVil.SelectedItem = "Молоко";
            if (!admin)
            {
                radioUpdGlobal.Enabled = false;
                DeleteBoxAdmin.Visible = false;
                radioUpTurContr.Enabled = false;
                radioUpdateVilContract.Enabled = false;
            }

            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                HelpfulClass.UpdateTable("Village_contracts", connection, DataGridForContracts);
                connection.Close();

            }
        }

        private void village_ContractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.village_ContractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ourWorkDataSet);

        }

        private void Village_Contracts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ourWorkDataSet.Village_Contracts". При необходимости она может быть перемещена или удалена.
            this.village_ContractsTableAdapter.Fill(this.ourWorkDataSet.Village_Contracts);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioVillageContract_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                HelpfulClass.UpdateTable("Village_contracts", connection, DataGridForContracts);
                connection.Close();
                if (radioVillageContract.Checked)
                {
                    groupGlobalBox.Visible = false;
                    groupVilContractAddUp.Visible = true;
                    groupAddUpTurBox.Visible = false;
                }
            }
        }

        private void radioGlobalContracts_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                HelpfulClass.UpdateTable("Global_contracts", connection, DataGridForContracts);
                connection.Close();

            }
            if (radioGlobalContracts.Checked)
            {
                groupGlobalBox.Visible = true;
                groupVilContractAddUp.Visible = false;
                groupAddUpTurBox.Visible = false;
            }

        }

        private void radioTurismContract_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                HelpfulClass.UpdateTable("Turism_contracts", connection, DataGridForContracts);
                connection.Close();

            }

            if (radioTurismContract.Checked)
            {
                groupGlobalBox.Visible = false;
                groupVilContractAddUp.Visible = false;
                groupAddUpTurBox.Visible = true;
            }
        }




        private void AddUpContractVil_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                if (tBoxVilIDResp.Text=="")
                {
                    MessageBox.Show("Заполните необходимые поля", "Пустое поле", MessageBoxButtons.OK);
                    return;
                }

                connection.Open();
                SqlCommand command;
                if (radioAddVilContract.Checked)
                {

                    string sqlExp = "AddVillageContract";
                    command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idRespCitizen",
                        Value = Convert.ToInt32(tBoxVilIDResp.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@ProductionOf",
                        Value = ProductionVil.SelectedItem.ToString()
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@Weight",
                        Value = Convert.ToInt32(WeightVil.Value)
                    };
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@Time",
                        Value = HelpfulClass.GetValidDateForSql(DateVil)
                    };
                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);

                }
                else
                {

                    if (tboxVilContractID.Text == "")
                    {
                        MessageBox.Show("Заполните необходимые поля", "Пустое поле", MessageBoxButtons.OK);
                        return;
                    }
                    string sqlExp = "UpdateVillageContract";
                    command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idRespCitizen",
                        Value = Convert.ToInt32(tBoxVilIDResp.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@ProductionOf",
                        Value = ProductionVil.SelectedItem.ToString()
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@Weight",
                        Value = Convert.ToInt32(WeightVil.Value)
                    };
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@Time",
                        Value = HelpfulClass.GetValidDateForSql(DateVil)
                    };

                    SqlParameter prm5 = new SqlParameter
                    {
                        ParameterName = "@id_Contract",
                        Value = Convert.ToInt32(tboxVilContractID.Text)
                    };
                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);
                    command.Parameters.Add(prm5);
                }
                command.ExecuteNonQuery();
                HelpfulClass.UpdateTable("Village_Contracts", connection, DataGridForContracts);
                connection.Close();

            }
        }

        private void radioUpdateVilContract_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdateVilContract.Checked)
            {
                label7.Visible = true;
                tboxVilContractID.Visible = true;
                groupVilContractAddUp.Text = "Обновление контракта";
                AddUpContractVil.Text = "Обновить контракт";
            }


        }

        private void radioAddVilContract_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVillageContract.Checked)
            {
                label7.Visible = false;
                tboxVilContractID.Visible = false;
                groupVilContractAddUp.Text = "Добавление контракта";
                AddUpContractVil.Text = "Добавить контракт";
            }
        }

        private void AddUpGlobal_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                if ((IdRespGlobal.Text == "")|| ("" == OrganizationGlobal.Text) || ("" == AdressGlobal.Text) || ("" == priceGlobal.Text)){
                    MessageBox.Show("Заполните необходимые поля", "Пустое поле", MessageBoxButtons.OK);
                    return;
                }
                SqlCommand command;
                if (radioAddGlobal.Checked)
                {
                    
                    string sqlExp = "AddGlobalContract";
                    command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idRespCitizen",
                        Value = Convert.ToInt32(IdRespGlobal.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@ProductionOf",
                        Value = TypeGlobal.SelectedItem.ToString()
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@Weight",
                        Value = Convert.ToInt32(WeightGlobal.Value)
                    };
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@Time",
                        Value = HelpfulClass.GetValidDateForSql(dateGlobal)
                    };

                    SqlParameter prm5 = new SqlParameter
                    {
                        ParameterName = "@Organ",
                        Value = OrganizationGlobal.Text
                    };

                    SqlParameter prm6 = new SqlParameter
                    {
                        ParameterName = "@Address",
                        Value = AdressGlobal.Text
                    };

                    SqlParameter prm7 = new SqlParameter
                    {
                        ParameterName = "@Price",
                        Value = Convert.ToDecimal(priceGlobal.Text)
                    };
                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);
                    command.Parameters.Add(prm5);
                    command.Parameters.Add(prm6);
                    command.Parameters.Add(prm7);

                }
                else
                {
                    if (IdContrGlobal.Text == "")
                    {
                        MessageBox.Show("Заполните необходимые поля", "Пустое поле", MessageBoxButtons.OK);
                        return;
                    }
                    string sqlExp = "UpdateGlobalContract";
                    command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idRespCitizen",
                        Value = Convert.ToInt32(IdRespGlobal.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@ProductionOf",
                        Value = TypeGlobal.SelectedItem.ToString()
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@Weight",
                        Value = Convert.ToInt32(WeightGlobal.Value)
                    };
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@Time",
                        Value = HelpfulClass.GetValidDateForSql(dateGlobal)
                    };

                    SqlParameter prm5 = new SqlParameter
                    {
                        ParameterName = "@Organ",
                        Value = OrganizationGlobal.Text
                    };

                    SqlParameter prm6 = new SqlParameter
                    {
                        ParameterName = "@Address",
                        Value = AdressGlobal.Text
                    };

                    SqlParameter prm7 = new SqlParameter
                    {
                        ParameterName = "@Price",
                        Value = Convert.ToDecimal(priceGlobal.Text)
                    };

                    SqlParameter prm8 = new SqlParameter
                    {
                        ParameterName = "@id_contract",
                        Value = Convert.ToInt32(IdContrGlobal.Text)
                    };
                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);
                    command.Parameters.Add(prm5);
                    command.Parameters.Add(prm6);
                    command.Parameters.Add(prm7);
                    command.Parameters.Add(prm8);
                }
                command.ExecuteNonQuery();
                HelpfulClass.UpdateTable("Global_Contracts", connection, DataGridForContracts);
                connection.Close();

            }
        }

        private void radioAddGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAddGlobal.Checked)
            {
                label4.Visible = false;
                IdContrGlobal.Visible = false;
                AddUpGlobal.Text = "Добавление контракта";
                groupGlobalBox.Text = "Добавить контракт";
            }
        }

        private void radioUpdGlobal_CheckedChanged(object sender, EventArgs e)
        {

            if (radioUpdGlobal.Checked)
            {
                label4.Visible = true;
                IdContrGlobal.Visible = true;
                AddUpGlobal.Text = "Обновление контракта";
                groupGlobalBox.Text = "Обновить контракт";
            }
        }

        private void AddUpTur_Click(object sender, EventArgs e)
        {
            if ((idHouseTur.Text=="")||(""==NameTur.Text)||(LastnameTur.Text=="")||(MiddleNameTur.Text=="")||(TurAddress.Text=="")){
                MessageBox.Show("Не оставляйте поля пустыми", "Внимание", MessageBoxButtons.OK);
                return;

            }




            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                SqlCommand command;
                if (radioAddTurContr.Checked)
                {

                    string sqlExp = "AddTurismContract";
                    command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idHouse",
                        Value = Convert.ToInt32(idHouseTur.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = NameTur.Text
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@LName",
                        Value = LastnameTur.Text
                    };
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@MName",
                        Value = MiddleNameTur.Text
                    };
                    string sx = "";
                    if (radioSexTurMale.Checked) { sx = "Мужчина"; }
                    else { sx = "Женщина"; }
                    SqlParameter prm5 = new SqlParameter
                    {
                        ParameterName = "@Sex",
                        Value = sx
                    };
                    SqlParameter prm6 = new SqlParameter
                    {
                        ParameterName = "@DateOfBirth",
                        Value = HelpfulClass.GetValidDateForSql(DateOfBirthTur)
                    };
                    SqlParameter prm7 = new SqlParameter
                    {
                        ParameterName = "@Begin",
                        Value = HelpfulClass.GetValidDateForSql(dateBegTur)
                    };

                    SqlParameter prm8 = new SqlParameter
                    {
                        ParameterName = "@End",
                        Value = HelpfulClass.GetValidDateForSql(dateEndTur)
                    };
                    SqlParameter prm9 = new SqlParameter
                    {
                        ParameterName = "@Count",
                        Value = CountTur.Value
                    };

                    SqlParameter prm10 = new SqlParameter
                    {
                        ParameterName = "@Address",
                        Value = TurAddress.Text
                    };
                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);
                    command.Parameters.Add(prm5);
                    command.Parameters.Add(prm6);
                    command.Parameters.Add(prm7);
                    command.Parameters.Add(prm8);
                    command.Parameters.Add(prm9);
                    command.Parameters.Add(prm10);

                }
                else
                {

                    if (""== idTurContract.Text)
                    {
                        MessageBox.Show("Не оставляйте поля пустыми", "Внимание", MessageBoxButtons.OK);
                        return;

                    }
                    string sqlExp = "UpdateTurismContract";
                    command = new SqlCommand(sqlExp, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                    SqlParameter prm1 = new SqlParameter
                    {
                        ParameterName = "@idHouse",
                        Value = Convert.ToInt32(idHouseTur.Text)
                    };
                    SqlParameter prm2 = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = NameTur.Text
                    };
                    SqlParameter prm3 = new SqlParameter
                    {
                        ParameterName = "@LName",
                        Value = LastnameTur.Text
                    };
                    SqlParameter prm4 = new SqlParameter
                    {
                        ParameterName = "@MName",
                        Value = MiddleNameTur.Text
                    };
                    string sx = "";
                    if (radioSexTurMale.Checked) { sx = "Мужчина"; }
                    else { sx = "Женщина"; }
                    SqlParameter prm5 = new SqlParameter
                    {
                        ParameterName = "@Sex",
                        Value = sx
                    };

                    SqlParameter prm6 = new SqlParameter
                    {
                        ParameterName = "@DateOfBirth",
                        Value = HelpfulClass.GetValidDateForSql(DateOfBirthTur)
                    };

                    SqlParameter prm7 = new SqlParameter
                    {
                        ParameterName = "@Begin",
                        Value = HelpfulClass.GetValidDateForSql(dateBegTur)
                    };

                    SqlParameter prm8 = new SqlParameter
                    {
                        ParameterName = "@End",
                        Value = HelpfulClass.GetValidDateForSql(dateEndTur)
                    };
                    SqlParameter prm9 = new SqlParameter
                    {
                        ParameterName = "@Count",
                        Value = CountTur.Value
                    };

                    SqlParameter prm10 = new SqlParameter
                    {
                        ParameterName = "@Address",
                        Value = TurAddress.Text
                    };
                    SqlParameter prm11 = new SqlParameter
                    {
                        ParameterName = "@idContr",
                        Value = Convert.ToInt32(idTurContract.Text)
                    };
                    command.Parameters.Add(prm1);
                    command.Parameters.Add(prm2);
                    command.Parameters.Add(prm3);
                    command.Parameters.Add(prm4);
                    command.Parameters.Add(prm5);
                    command.Parameters.Add(prm6);
                    command.Parameters.Add(prm7);
                    command.Parameters.Add(prm8);
                    command.Parameters.Add(prm9);
                    command.Parameters.Add(prm10);
                    command.Parameters.Add(prm11);
                }

                command.ExecuteNonQuery();
                HelpfulClass.UpdateTable("Turism_Contracts", connection, DataGridForContracts);
                connection.Close();

            }



        }

        private void radioUpTurContr_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpTurContr.Checked)
            {
                idTurContract.Visible = true;
                labelForIDTur.Visible = true;
                groupAddUpTurBox.Text = "Обновление контракта";
                AddUpTur.Text = "Обновление контракта";
            }
        }

        private void radioAddTurContr_CheckedChanged(object sender, EventArgs e)
        {

            if (radioAddTurContr.Checked)
            {
                idTurContract.Visible = false;
                labelForIDTur.Visible = false;
                groupAddUpTurBox.Text = "Добавление контракта";
                AddUpTur.Text = "Добавление контракта";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteHouse_Click(object sender, EventArgs e)
        {
            if (idDeleted.Text == String.Empty)
            {
                MessageBox.Show("Заполняйте поля корректно");
                return;
            }
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                string sqlExp = "Delete";
                string table = "";
                if (radioGlobalContracts.Checked)
                {
                    sqlExp += "GlobalContract";
                    table = "Global_Contracts";
                }
                if (radioVillageContract.Checked)
                {
                    sqlExp += "VillageContract";
                    table = "Village_Contracts";

                }
                if (radioTurismContract.Checked)
                {
                    sqlExp += "TurismContract";
                    table = "Turism_Contracts";

                }

                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure; //хранимые процедуры
                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = Convert.ToInt32(idDeleted.Text)
                };


                command.Parameters.Add(id);
                command.ExecuteNonQuery();
                HelpfulClass.UpdateTable(table, connection, DataGridForContracts);
            }
        }

        private void IdContrGlobal_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }
        }

        private void IdRespGlobal_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }
        }

        private void idTurContract_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }
        }

        private void idHouseTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
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

        private void tboxVilContractID_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }
        }
    }
}
