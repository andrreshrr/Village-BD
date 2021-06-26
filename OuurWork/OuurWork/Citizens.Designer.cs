namespace OuurWork
{
    partial class Citizens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citizens));
            this.ourWorkDataSet = new OuurWork.OurWorkDataSet();
            this.citizensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizensTableAdapter = new OuurWork.OurWorkDataSetTableAdapters.CitizensTableAdapter();
            this.tableAdapterManager = new OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager();
            this.citizensDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminAddCitizen = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateCitizen = new System.Windows.Forms.RadioButton();
            this.AddCitizen = new System.Windows.Forms.RadioButton();
            this.idForUp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SexCitizenFemale = new System.Windows.Forms.RadioButton();
            this.sexCitizenMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUpBut = new System.Windows.Forms.Button();
            this.AdminDateOfBirthAdd = new System.Windows.Forms.DateTimePicker();
            this.adminMiddleNameAdd = new System.Windows.Forms.TextBox();
            this.adminLastnameAdd = new System.Windows.Forms.TextBox();
            this.adminAdd = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteBoxAdmin = new System.Windows.Forms.GroupBox();
            this.deleteAdmin = new System.Windows.Forms.Button();
            this.idDeleted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensDataGridView)).BeginInit();
            this.AdminAddCitizen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DeleteBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ourWorkDataSet
            // 
            this.ourWorkDataSet.DataSetName = "OurWorkDataSet";
            this.ourWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citizensBindingSource
            // 
            this.citizensBindingSource.DataMember = "Citizens";
            this.citizensBindingSource.DataSource = this.ourWorkDataSet;
            // 
            // citizensTableAdapter
            // 
            this.citizensTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitizensTableAdapter = this.citizensTableAdapter;
            this.tableAdapterManager.Global_ContractsTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = null;
            this.tableAdapterManager.SouvenirTableAdapter = null;
            this.tableAdapterManager.Turism_ContractsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Village_ContractsTableAdapter = null;
            // 
            // citizensDataGridView
            // 
            this.citizensDataGridView.AllowUserToAddRows = false;
            this.citizensDataGridView.AllowUserToDeleteRows = false;
            this.citizensDataGridView.AutoGenerateColumns = false;
            this.citizensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citizensDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.citizensDataGridView.DataSource = this.citizensBindingSource;
            this.citizensDataGridView.Location = new System.Drawing.Point(1, 1);
            this.citizensDataGridView.Name = "citizensDataGridView";
            this.citizensDataGridView.RowHeadersWidth = 51;
            this.citizensDataGridView.RowTemplate.Height = 24;
            this.citizensDataGridView.Size = new System.Drawing.Size(1024, 199);
            this.citizensDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_citizen";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_citizen";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Middle_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Middle_Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_of_birth";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date_of_birth";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // AdminAddCitizen
            // 
            this.AdminAddCitizen.Controls.Add(this.panel1);
            this.AdminAddCitizen.Controls.Add(this.idForUp);
            this.AdminAddCitizen.Controls.Add(this.label7);
            this.AdminAddCitizen.Controls.Add(this.label5);
            this.AdminAddCitizen.Controls.Add(this.SexCitizenFemale);
            this.AdminAddCitizen.Controls.Add(this.sexCitizenMale);
            this.AdminAddCitizen.Controls.Add(this.label4);
            this.AdminAddCitizen.Controls.Add(this.label3);
            this.AdminAddCitizen.Controls.Add(this.label2);
            this.AdminAddCitizen.Controls.Add(this.label1);
            this.AdminAddCitizen.Controls.Add(this.AddUpBut);
            this.AdminAddCitizen.Controls.Add(this.AdminDateOfBirthAdd);
            this.AdminAddCitizen.Controls.Add(this.adminMiddleNameAdd);
            this.AdminAddCitizen.Controls.Add(this.adminLastnameAdd);
            this.AdminAddCitizen.Controls.Add(this.adminAdd);
            this.AdminAddCitizen.Location = new System.Drawing.Point(12, 206);
            this.AdminAddCitizen.Name = "AdminAddCitizen";
            this.AdminAddCitizen.Size = new System.Drawing.Size(302, 263);
            this.AdminAddCitizen.TabIndex = 1;
            this.AdminAddCitizen.TabStop = false;
            this.AdminAddCitizen.Text = "Добавление жителя";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpdateCitizen);
            this.panel1.Controls.Add(this.AddCitizen);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 21);
            this.panel1.TabIndex = 4;
            // 
            // UpdateCitizen
            // 
            this.UpdateCitizen.AutoSize = true;
            this.UpdateCitizen.Location = new System.Drawing.Point(151, 3);
            this.UpdateCitizen.Name = "UpdateCitizen";
            this.UpdateCitizen.Size = new System.Drawing.Size(140, 20);
            this.UpdateCitizen.TabIndex = 5;
            this.UpdateCitizen.Text = "Обновить жителя";
            this.UpdateCitizen.UseVisualStyleBackColor = true;
            this.UpdateCitizen.CheckedChanged += new System.EventHandler(this.UpdateCitizen_CheckedChanged);
            // 
            // AddCitizen
            // 
            this.AddCitizen.AutoSize = true;
            this.AddCitizen.Checked = true;
            this.AddCitizen.Location = new System.Drawing.Point(0, 3);
            this.AddCitizen.Name = "AddCitizen";
            this.AddCitizen.Size = new System.Drawing.Size(139, 20);
            this.AddCitizen.TabIndex = 4;
            this.AddCitizen.TabStop = true;
            this.AddCitizen.Text = "Добавить жителя";
            this.AddCitizen.UseVisualStyleBackColor = true;
            this.AddCitizen.CheckedChanged += new System.EventHandler(this.AddCitizen_CheckedChanged);
            // 
            // idForUp
            // 
            this.idForUp.Location = new System.Drawing.Point(100, 42);
            this.idForUp.Name = "idForUp";
            this.idForUp.Size = new System.Drawing.Size(51, 22);
            this.idForUp.TabIndex = 4;
            this.idForUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idForUp_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата рождения";
            // 
            // SexCitizenFemale
            // 
            this.SexCitizenFemale.AutoSize = true;
            this.SexCitizenFemale.Location = new System.Drawing.Point(232, 163);
            this.SexCitizenFemale.Name = "SexCitizenFemale";
            this.SexCitizenFemale.Size = new System.Drawing.Size(39, 20);
            this.SexCitizenFemale.TabIndex = 2;
            this.SexCitizenFemale.Text = "Ж";
            this.SexCitizenFemale.UseVisualStyleBackColor = true;
            // 
            // sexCitizenMale
            // 
            this.sexCitizenMale.AutoSize = true;
            this.sexCitizenMale.Location = new System.Drawing.Point(166, 163);
            this.sexCitizenMale.Name = "sexCitizenMale";
            this.sexCitizenMale.Size = new System.Drawing.Size(37, 20);
            this.sexCitizenMale.TabIndex = 2;
            this.sexCitizenMale.Text = "М";
            this.sexCitizenMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя ";
            // 
            // AddUpBut
            // 
            this.AddUpBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddUpBut.Location = new System.Drawing.Point(0, 217);
            this.AddUpBut.Name = "AddUpBut";
            this.AddUpBut.Size = new System.Drawing.Size(302, 46);
            this.AddUpBut.TabIndex = 2;
            this.AddUpBut.Text = "Добавить жителя";
            this.AddUpBut.UseVisualStyleBackColor = false;
            this.AddUpBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDateOfBirthAdd
            // 
            this.AdminDateOfBirthAdd.Location = new System.Drawing.Point(122, 190);
            this.AdminDateOfBirthAdd.Name = "AdminDateOfBirthAdd";
            this.AdminDateOfBirthAdd.Size = new System.Drawing.Size(174, 22);
            this.AdminDateOfBirthAdd.TabIndex = 3;
            // 
            // adminMiddleNameAdd
            // 
            this.adminMiddleNameAdd.Location = new System.Drawing.Point(100, 134);
            this.adminMiddleNameAdd.Name = "adminMiddleNameAdd";
            this.adminMiddleNameAdd.Size = new System.Drawing.Size(196, 22);
            this.adminMiddleNameAdd.TabIndex = 2;
            // 
            // adminLastnameAdd
            // 
            this.adminLastnameAdd.Location = new System.Drawing.Point(100, 104);
            this.adminLastnameAdd.Name = "adminLastnameAdd";
            this.adminLastnameAdd.Size = new System.Drawing.Size(196, 22);
            this.adminLastnameAdd.TabIndex = 2;
            // 
            // adminAdd
            // 
            this.adminAdd.Location = new System.Drawing.Point(100, 72);
            this.adminAdd.Name = "adminAdd";
            this.adminAdd.Size = new System.Drawing.Size(196, 22);
            this.adminAdd.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackButton.Location = new System.Drawing.Point(873, 393);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 46);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteBoxAdmin
            // 
            this.DeleteBoxAdmin.Controls.Add(this.deleteAdmin);
            this.DeleteBoxAdmin.Controls.Add(this.idDeleted);
            this.DeleteBoxAdmin.Controls.Add(this.label6);
            this.DeleteBoxAdmin.Location = new System.Drawing.Point(846, 246);
            this.DeleteBoxAdmin.Name = "DeleteBoxAdmin";
            this.DeleteBoxAdmin.Size = new System.Drawing.Size(147, 73);
            this.DeleteBoxAdmin.TabIndex = 3;
            this.DeleteBoxAdmin.TabStop = false;
            this.DeleteBoxAdmin.Text = "Удаление жителя";
            this.DeleteBoxAdmin.Enter += new System.EventHandler(this.DeleteBoxAdmin_Enter);
            // 
            // deleteAdmin
            // 
            this.deleteAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteAdmin.Location = new System.Drawing.Point(0, 44);
            this.deleteAdmin.Name = "deleteAdmin";
            this.deleteAdmin.Size = new System.Drawing.Size(147, 29);
            this.deleteAdmin.TabIndex = 4;
            this.deleteAdmin.Text = "Изгнать жителя";
            this.deleteAdmin.UseVisualStyleBackColor = false;
            this.deleteAdmin.Click += new System.EventHandler(this.deleteAdmin_Click);
            // 
            // idDeleted
            // 
            this.idDeleted.Location = new System.Drawing.Point(89, 18);
            this.idDeleted.Name = "idDeleted";
            this.idDeleted.Size = new System.Drawing.Size(47, 22);
            this.idDeleted.TabIndex = 1;
            this.idDeleted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idDeleted_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID жителя:";
            // 
            // Citizens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 566);
            this.Controls.Add(this.DeleteBoxAdmin);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AdminAddCitizen);
            this.Controls.Add(this.citizensDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Citizens";
            this.Text = "Citizens";
            this.Load += new System.EventHandler(this.Citizens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensDataGridView)).EndInit();
            this.AdminAddCitizen.ResumeLayout(false);
            this.AdminAddCitizen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DeleteBoxAdmin.ResumeLayout(false);
            this.DeleteBoxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OurWorkDataSet ourWorkDataSet;
        private System.Windows.Forms.BindingSource citizensBindingSource;
        private OurWorkDataSetTableAdapters.CitizensTableAdapter citizensTableAdapter;
        private OurWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView citizensDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox AdminAddCitizen;
        private System.Windows.Forms.Button AddUpBut;
        private System.Windows.Forms.DateTimePicker AdminDateOfBirthAdd;
        private System.Windows.Forms.TextBox adminMiddleNameAdd;
        private System.Windows.Forms.TextBox adminLastnameAdd;
        private System.Windows.Forms.TextBox adminAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton SexCitizenFemale;
        private System.Windows.Forms.RadioButton sexCitizenMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox DeleteBoxAdmin;
        private System.Windows.Forms.Button deleteAdmin;
        private System.Windows.Forms.TextBox idDeleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton AddCitizen;
        private System.Windows.Forms.RadioButton UpdateCitizen;
        private System.Windows.Forms.TextBox idForUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}