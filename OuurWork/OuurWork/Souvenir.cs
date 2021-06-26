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

    public partial class Souvenir : Form
    {

        
        public Souvenir(bool admin)
        {
            InitializeComponent();
            labelIdSouvenir.Visible = false;
            IdSouvenir.Visible = false;
            radioAdd.Checked = true;
            groupInterface.Text = "Добавление сувенира";
            AddUpSouvenir.Text = "Добавить сувенир";
            if (!admin)
            {
                radioUp.Enabled = false;
                DeleteBoxAdmin.Visible = false;
            }



        }

        private void souvenirBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.souvenirBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ourWorkDataSet);

        }

        private void Souvenir_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ourWorkDataSet.Souvenir". При необходимости она может быть перемещена или удалена.
            this.souvenirTableAdapter.Fill(this.ourWorkDataSet.Souvenir);

        }

        private void AddUpHouse_Click(object sender, EventArgs e)
        {
            if ((String.Empty==IdResp.Text)|| (String.Empty == price.Text)|| (String.Empty == nameSouvenir.Text))
                    {
                MessageBox.Show("Заполните поля корректно", "Пожайлуста", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (radioAdd.Checked)

            {
                using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
                {
                    connection.Open();
                    string command = "INSERT INTO Souvenir(id_Producer, Price, Name_of) VALUES (";
                    command += Convert.ToInt32(IdResp.Text) + ", " + (Convert.ToDecimal(price.Text)).ToString().Replace(",", ".") + ", " + '\'' + nameSouvenir.Text + '\'' + ");";
                    SqlDataAdapter SDA = new SqlDataAdapter(command, connection);
                    DataSet DS = new DataSet();
                    SDA.Fill(DS, "Souvenir");
                    souvenirDataGridView.DataSource = DS.Tables["Souvenir"];
                    HelpfulClass.UpdateTable("Souvenir", connection, souvenirDataGridView);
                }
            }
            else
            {

                if (String.Empty == IdSouvenir.Text)
                {
                    MessageBox.Show("Заполните поля корректно", "Прошу", MessageBoxButtons.OK);
                    return;
                }
                using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
                {
                    connection.Open();
                    string command = "UPDATE Souvenir SET ";
                    command += "Id_Producer=" + Convert.ToInt32(IdResp.Text) + ", Price=" + (Convert.ToDecimal(price.Text)).ToString().Replace(",", ".")
                        + ",Name_of= " + '\'' + nameSouvenir.Text + '\'' +

                    "WHERE id_souvenir=" + Convert.ToInt32(IdSouvenir.Text) + ";";
                    SqlDataAdapter SDA = new SqlDataAdapter(command, connection);
                    DataSet DS = new DataSet();
                    SDA.Fill(DS, "Souvenir");
                    souvenirDataGridView.DataSource = DS.Tables["Souvenir"];
                    HelpfulClass.UpdateTable("Souvenir", connection, souvenirDataGridView);
                }

            }
        }

        private void deleteHouse_Click(object sender, EventArgs e)
        {

            if (idDeleted.Text == String.Empty)
            {
                MessageBox.Show("Заполните поля корректно", "Умоляю", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = new SqlConnection(HelpfulClass.connectString))
            {
                connection.Open();
                string command = "DELETE FROM Souvenir WHERE id_souvenir=" + Convert.ToInt32(idDeleted.Text);
                SqlDataAdapter SDA = new SqlDataAdapter(command, connection);
                DataSet DS = new DataSet();
                SDA.Fill(DS, "Souvenir");
                souvenirDataGridView.DataSource = DS.Tables["Souvenir"];
                HelpfulClass.UpdateTable("Souvenir", connection, souvenirDataGridView);
                
            }
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdd.Checked)
            {

                labelIdSouvenir.Visible = false;
                IdSouvenir.Visible = false;

                groupInterface.Text = "Добавление сувенира";
                AddUpSouvenir.Text = "Добавить сувенир";

            }
        }

        private void radioUp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUp.Checked)
            {

                labelIdSouvenir.Visible = true;
                IdSouvenir.Visible = true;

                groupInterface.Text = "Обновление сувенира";
                AddUpSouvenir.Text = "Обновить сувенир";

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idDeleted_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }
        }

        private void IdSouvenir_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdResp_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }
        }


        private void IdSouvenir_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symb = e.KeyChar;
            if (!Char.IsDigit(symb) && !Char.IsControl(symb))
            {
                e.Handled = true;
            }
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
