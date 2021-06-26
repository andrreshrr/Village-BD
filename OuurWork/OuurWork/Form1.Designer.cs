namespace OuurWork
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttonIn = new System.Windows.Forms.Button();
            this.GroupLogin = new System.Windows.Forms.GroupBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.ourWorkDataSet = new OuurWork.OurWorkDataSet();
            this.global_ContractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.global_ContractsTableAdapter = new OuurWork.OurWorkDataSetTableAdapters.Global_ContractsTableAdapter();
            this.tableAdapterManager = new OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager();
            this.citizensProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizensProfilesTableAdapter = new OuurWork.OurWorkDataSetTableAdapters.CitizensProfilesTableAdapter();
            this.ADMINView = new System.Windows.Forms.Button();
            this.AdminCitizens = new System.Windows.Forms.Button();
            this.AdminVILContracts = new System.Windows.Forms.Button();
            this.AdminSouvenir = new System.Windows.Forms.Button();
            this.AdminHouses = new System.Windows.Forms.Button();
            this.AdminBox = new System.Windows.Forms.GroupBox();
            this.Logout = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.CitizInfoBut = new System.Windows.Forms.Button();
            this.somefunctions = new System.Windows.Forms.GroupBox();
            this.TurForMonth = new System.Windows.Forms.Button();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.HowMuch = new System.Windows.Forms.Button();
            this.GroupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.global_ContractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensProfilesBindingSource)).BeginInit();
            this.AdminBox.SuspendLayout();
            this.somefunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIn
            // 
            this.buttonIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIn.Location = new System.Drawing.Point(0, 122);
            this.buttonIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(450, 41);
            this.buttonIn.TabIndex = 0;
            this.buttonIn.Text = "Вход";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // GroupLogin
            // 
            this.GroupLogin.BackColor = System.Drawing.SystemColors.Info;
            this.GroupLogin.Controls.Add(this.pass_text);
            this.GroupLogin.Controls.Add(this.loginText);
            this.GroupLogin.Controls.Add(this.label1);
            this.GroupLogin.Controls.Add(this.login);
            this.GroupLogin.Controls.Add(this.buttonIn);
            this.GroupLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupLogin.Location = new System.Drawing.Point(220, 192);
            this.GroupLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupLogin.Size = new System.Drawing.Size(450, 162);
            this.GroupLogin.TabIndex = 1;
            this.GroupLogin.TabStop = false;
            // 
            // pass_text
            // 
            this.pass_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_text.Location = new System.Drawing.Point(122, 65);
            this.pass_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass_text.MaxLength = 20;
            this.pass_text.Name = "pass_text";
            this.pass_text.PasswordChar = '●';
            this.pass_text.Size = new System.Drawing.Size(306, 32);
            this.pass_text.TabIndex = 4;
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.Location = new System.Drawing.Point(122, 15);
            this.loginText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginText.MaxLength = 20;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(306, 32);
            this.loginText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(18, 15);
            this.login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(77, 26);
            this.login.TabIndex = 1;
            this.login.Text = "Логин";
            // 
            // ourWorkDataSet
            // 
            this.ourWorkDataSet.DataSetName = "OurWorkDataSet";
            this.ourWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // global_ContractsBindingSource
            // 
            this.global_ContractsBindingSource.DataMember = "Global_Contracts";
            this.global_ContractsBindingSource.DataSource = this.ourWorkDataSet;
            // 
            // global_ContractsTableAdapter
            // 
            this.global_ContractsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitizensTableAdapter = null;
            this.tableAdapterManager.Global_ContractsTableAdapter = this.global_ContractsTableAdapter;
            this.tableAdapterManager.HousesTableAdapter = null;
            this.tableAdapterManager.SouvenirTableAdapter = null;
            this.tableAdapterManager.Turism_ContractsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Village_ContractsTableAdapter = null;
            // 
            // citizensProfilesBindingSource
            // 
            this.citizensProfilesBindingSource.DataMember = "CitizensProfiles";
            this.citizensProfilesBindingSource.DataSource = this.ourWorkDataSet;
            // 
            // citizensProfilesTableAdapter
            // 
            this.citizensProfilesTableAdapter.ClearBeforeFill = true;
            // 
            // ADMINView
            // 
            this.ADMINView.BackColor = System.Drawing.Color.DarkGray;
            this.ADMINView.Location = new System.Drawing.Point(0, 78);
            this.ADMINView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ADMINView.Name = "ADMINView";
            this.ADMINView.Size = new System.Drawing.Size(406, 58);
            this.ADMINView.TabIndex = 3;
            this.ADMINView.Text = "Открыть ВСЮ информацию о жителях деревни";
            this.ADMINView.UseVisualStyleBackColor = false;
            this.ADMINView.Click += new System.EventHandler(this.ADMINView_Click);
            // 
            // AdminCitizens
            // 
            this.AdminCitizens.BackColor = System.Drawing.Color.DarkGray;
            this.AdminCitizens.Location = new System.Drawing.Point(0, 0);
            this.AdminCitizens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminCitizens.Name = "AdminCitizens";
            this.AdminCitizens.Size = new System.Drawing.Size(85, 73);
            this.AdminCitizens.TabIndex = 4;
            this.AdminCitizens.Text = "Открыть информацию о жителях";
            this.AdminCitizens.UseVisualStyleBackColor = false;
            this.AdminCitizens.Click += new System.EventHandler(this.AdminCitizens_Click);
            // 
            // AdminVILContracts
            // 
            this.AdminVILContracts.BackColor = System.Drawing.Color.DarkGray;
            this.AdminVILContracts.Location = new System.Drawing.Point(89, 0);
            this.AdminVILContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminVILContracts.Name = "AdminVILContracts";
            this.AdminVILContracts.Size = new System.Drawing.Size(123, 73);
            this.AdminVILContracts.TabIndex = 5;
            this.AdminVILContracts.Text = "Открыть информацию о контрактах жителей с деревней";
            this.AdminVILContracts.UseVisualStyleBackColor = false;
            this.AdminVILContracts.Click += new System.EventHandler(this.AdminVILContracts_Click);
            // 
            // AdminSouvenir
            // 
            this.AdminSouvenir.BackColor = System.Drawing.Color.DarkGray;
            this.AdminSouvenir.Location = new System.Drawing.Point(217, 0);
            this.AdminSouvenir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminSouvenir.Name = "AdminSouvenir";
            this.AdminSouvenir.Size = new System.Drawing.Size(98, 73);
            this.AdminSouvenir.TabIndex = 7;
            this.AdminSouvenir.Text = "Открыть информацию о сувенирной лавке";
            this.AdminSouvenir.UseVisualStyleBackColor = false;
            this.AdminSouvenir.Click += new System.EventHandler(this.AdminSouvenir_Click);
            // 
            // AdminHouses
            // 
            this.AdminHouses.BackColor = System.Drawing.Color.DarkGray;
            this.AdminHouses.Location = new System.Drawing.Point(319, 0);
            this.AdminHouses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminHouses.Name = "AdminHouses";
            this.AdminHouses.Size = new System.Drawing.Size(87, 73);
            this.AdminHouses.TabIndex = 8;
            this.AdminHouses.Text = "Открыть информацию о домах";
            this.AdminHouses.UseVisualStyleBackColor = false;
            this.AdminHouses.Click += new System.EventHandler(this.AdminHouses_Click);
            // 
            // AdminBox
            // 
            this.AdminBox.BackColor = System.Drawing.Color.White;
            this.AdminBox.Controls.Add(this.ADMINView);
            this.AdminBox.Controls.Add(this.AdminHouses);
            this.AdminBox.Controls.Add(this.AdminCitizens);
            this.AdminBox.Controls.Add(this.AdminVILContracts);
            this.AdminBox.Controls.Add(this.AdminSouvenir);
            this.AdminBox.Location = new System.Drawing.Point(238, 30);
            this.AdminBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminBox.Size = new System.Drawing.Size(408, 139);
            this.AdminBox.TabIndex = 9;
            this.AdminBox.TabStop = false;
            this.AdminBox.Text = "groupBox1";
            this.AdminBox.Enter += new System.EventHandler(this.AdminBox_Enter);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Logout.Location = new System.Drawing.Point(760, 10);
            this.Logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(133, 52);
            this.Logout.TabIndex = 10;
            this.Logout.Text = "Перезайти";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Exit.Location = new System.Drawing.Point(760, 67);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 52);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CitizInfoBut
            // 
            this.CitizInfoBut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CitizInfoBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CitizInfoBut.Location = new System.Drawing.Point(238, 168);
            this.CitizInfoBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CitizInfoBut.Name = "CitizInfoBut";
            this.CitizInfoBut.Size = new System.Drawing.Size(408, 33);
            this.CitizInfoBut.TabIndex = 5;
            this.CitizInfoBut.Text = "Открыть информацию о себе";
            this.CitizInfoBut.UseVisualStyleBackColor = false;
            this.CitizInfoBut.Click += new System.EventHandler(this.CitizInfoBut_Click);
            // 
            // somefunctions
            // 
            this.somefunctions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("somefunctions.BackgroundImage")));
            this.somefunctions.Controls.Add(this.TurForMonth);
            this.somefunctions.Controls.Add(this.monthBox);
            this.somefunctions.Controls.Add(this.HowMuch);
            this.somefunctions.Location = new System.Drawing.Point(16, 20);
            this.somefunctions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.somefunctions.Name = "somefunctions";
            this.somefunctions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.somefunctions.Size = new System.Drawing.Size(150, 132);
            this.somefunctions.TabIndex = 12;
            this.somefunctions.TabStop = false;
            // 
            // TurForMonth
            // 
            this.TurForMonth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TurForMonth.Location = new System.Drawing.Point(0, 80);
            this.TurForMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TurForMonth.Name = "TurForMonth";
            this.TurForMonth.Size = new System.Drawing.Size(150, 51);
            this.TurForMonth.TabIndex = 15;
            this.TurForMonth.Text = "Число заселившихся туристов в данный месяц (за всё время)";
            this.TurForMonth.UseVisualStyleBackColor = false;
            this.TurForMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthBox
            // 
            this.monthBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.monthBox.Location = new System.Drawing.Point(0, 56);
            this.monthBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(151, 21);
            this.monthBox.TabIndex = 14;
            // 
            // HowMuch
            // 
            this.HowMuch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HowMuch.Location = new System.Drawing.Point(0, 0);
            this.HowMuch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HowMuch.Name = "HowMuch";
            this.HowMuch.Size = new System.Drawing.Size(150, 42);
            this.HowMuch.TabIndex = 13;
            this.HowMuch.Text = "Сколько мы заработали";
            this.HowMuch.UseVisualStyleBackColor = false;
            this.HowMuch.Click += new System.EventHandler(this.HowMuch_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 404);
            this.Controls.Add(this.somefunctions);
            this.Controls.Add(this.CitizInfoBut);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.GroupLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "Вход";
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.global_ContractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensProfilesBindingSource)).EndInit();
            this.AdminBox.ResumeLayout(false);
            this.somefunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.GroupBox GroupLogin;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login;
        private OurWorkDataSet ourWorkDataSet;
        private System.Windows.Forms.BindingSource global_ContractsBindingSource;
        private OurWorkDataSetTableAdapters.Global_ContractsTableAdapter global_ContractsTableAdapter;
        private OurWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource citizensProfilesBindingSource;
        private OurWorkDataSetTableAdapters.CitizensProfilesTableAdapter citizensProfilesTableAdapter;
        private System.Windows.Forms.Button ADMINView;
        private System.Windows.Forms.Button AdminCitizens;
        private System.Windows.Forms.Button AdminVILContracts;
        private System.Windows.Forms.Button AdminSouvenir;
        private System.Windows.Forms.Button AdminHouses;
        private System.Windows.Forms.GroupBox AdminBox;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button CitizInfoBut;
        private System.Windows.Forms.GroupBox somefunctions;
        private System.Windows.Forms.Button TurForMonth;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Button HowMuch;
    }
}

