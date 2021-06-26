
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
    public partial class mainForm : Form
    {

        //string connectString = "Data Source=RRESHRRPC;Initial Catalog=OurWork;Integrated Security  = True"; 
        public mainForm()
        {
            InitializeComponent();
            GroupLogin.Visible = true;
            AdminBox.Visible = false;
            Exit.Visible = false;
            somefunctions.Visible = false;
            CitizInfoBut.Visible = false;
            Logout.Visible = false;
        }


        bool admin;
        //Старейшина
        //логин - Oskin Andrey
        //пароль - 2000.20.07
        // Помощник
        //логин - Good Boy
        //пароль - iamhelper
        // житель
        //логин - Grandfather Sergey
        //пароль - ilikepotato



        private void buttonIn_Click(object sender, EventArgs e)
        {
            if ((loginText.Text == "Oskin Andrey") && (pass_text.Text == "2000.20.07"))
            {
                
                AdminBox.Visible = true;
                Exit.Visible = true;
                Logout.Visible = true;
                GroupLogin.Visible = false;
                admin = true;
                somefunctions.Visible = true;
                monthBox.SelectedItem = "Январь";

            }
            else if ((loginText.Text == "Good Boy") && (pass_text.Text == "iamhelper"))
            {

                AdminBox.Visible = true;
                GroupLogin.Visible = false;
                Exit.Visible = true;
                Logout.Visible = true;
                admin = false;
            }
            else if ((loginText.Text == "Rodion Romanovich") && (pass_text.Text == "ilikepotato"))
            {


                Exit.Visible = true;
                Logout.Visible = true;
                GroupLogin.Visible = false;
                CitizInfoBut.Visible = true;
            } else
            {
                MessageBox.Show("Неправильно введён логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK);
            }

        }

    

        

      

        private void AdminCitizens_Click(object sender, EventArgs e)
        {
            Citizens citizensForm = new Citizens(admin);
            citizensForm.Show();
        }

        private void AdminVILContracts_Click(object sender, EventArgs e)
        {
            Village_Contracts formVC = new Village_Contracts(admin);
            formVC.Show();
        }

        private void ADMINView_Click(object sender, EventArgs e)
        {
            All_Info formALL = new All_Info("admin");
            formALL.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AdminHouses_Click(object sender, EventArgs e)
        {
            Houses form = new Houses(admin);
            form.Show();
        }

        private void AdminSouvenir_Click(object sender, EventArgs e)
        {
            Souvenir form = new Souvenir(admin);
            form.Show();
        }

        private void AdminBox_Enter(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {

            Exit.Visible = false;
            Logout.Visible = false;
            GroupLogin.Visible = true;
            AdminBox.Visible = false;
            CitizInfoBut.Visible = false;

            somefunctions.Visible = false;

        }

        private void CitizInfoBut_Click(object sender, EventArgs e)
        {
            All_Info form = new All_Info("citizen");
            form.Show();
        }

        private void HowMuch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(HelpfulClass.connectString);
            connection.Open();
            string command = "SELECT dbo.Capital();";
            var res = new SqlCommand(command, connection);
            var data = res.ExecuteScalar();

            string finalres = "На данный момент мы зарaботали: " + data.ToString() + " рубля";
            MessageBox.Show(finalres, "Сколько мы зарабатываем?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = monthBox.Items.IndexOf(monthBox.SelectedItem) + 1;
            SqlConnection connection = new SqlConnection(HelpfulClass.connectString);
            connection.Open();
            string command = "SELECT dbo.TurContractInMonth(" + month.ToString() + ");";
            var res = new SqlCommand(command, connection);
            var data = res.ExecuteScalar();

            string finalres;
            if (Convert.ToInt32(data) > 0)
            {
                finalres = "В " + month + "м месяце заселилось туристов:" + data.ToString();
            }
            else
                finalres = "В " + month + "м месяце туристы не заселялись";
            MessageBox.Show(finalres, "Количество туристов в месяц", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        



        //Старейшина
        //логин - Oskin Andrey
        //пароль - 2000.20.07
        // Помощник
        //логин - Good Boy
        //пароль - iamhelper
        // житель
        //логин - Rodion Romanovich
        //пароль - ilikepotato



    }
}
