namespace OuurWork
{
    partial class Houses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Houses));
            this.ourWorkDataSet = new OuurWork.OurWorkDataSet();
            this.housesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesTableAdapter = new OuurWork.OurWorkDataSetTableAdapters.HousesTableAdapter();
            this.tableAdapterManager = new OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager();
            this.housesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioNoVip = new System.Windows.Forms.RadioButton();
            this.radioVip = new System.Windows.Forms.RadioButton();
            this.groupInterface = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioUp = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.AddUpHouse = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.IdHouse = new System.Windows.Forms.TextBox();
            this.labelIdHouse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IdResp = new System.Windows.Forms.TextBox();
            this.DeleteBoxAdmin = new System.Windows.Forms.GroupBox();
            this.deleteHouse = new System.Windows.Forms.Button();
            this.idDeleted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesDataGridView)).BeginInit();
            this.groupInterface.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.DeleteBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ourWorkDataSet
            // 
            this.ourWorkDataSet.DataSetName = "OurWorkDataSet";
            this.ourWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // housesBindingSource
            // 
            this.housesBindingSource.DataMember = "Houses";
            this.housesBindingSource.DataSource = this.ourWorkDataSet;
            // 
            // housesTableAdapter
            // 
            this.housesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitizensTableAdapter = null;
            this.tableAdapterManager.Global_ContractsTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = this.housesTableAdapter;
            this.tableAdapterManager.SouvenirTableAdapter = null;
            this.tableAdapterManager.Turism_ContractsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Village_ContractsTableAdapter = null;
            // 
            // housesDataGridView
            // 
            this.housesDataGridView.AllowUserToAddRows = false;
            this.housesDataGridView.AllowUserToDeleteRows = false;
            this.housesDataGridView.AutoGenerateColumns = false;
            this.housesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.housesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.housesDataGridView.DataSource = this.housesBindingSource;
            this.housesDataGridView.Location = new System.Drawing.Point(0, -1);
            this.housesDataGridView.Name = "housesDataGridView";
            this.housesDataGridView.RowHeadersWidth = 51;
            this.housesDataGridView.RowTemplate.Height = 24;
            this.housesDataGridView.Size = new System.Drawing.Size(911, 214);
            this.housesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_house";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_house";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_Resp_Citizen";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_Resp_Citizen";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Count_Of_Room";
            this.dataGridViewTextBoxColumn3.HeaderText = "Count_Of_Room";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price_Per_Day";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price_Per_Day";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VIP";
            this.dataGridViewTextBoxColumn5.HeaderText = "VIP";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // radioNoVip
            // 
            this.radioNoVip.AutoSize = true;
            this.radioNoVip.Location = new System.Drawing.Point(273, 165);
            this.radioNoVip.Name = "radioNoVip";
            this.radioNoVip.Size = new System.Drawing.Size(51, 20);
            this.radioNoVip.TabIndex = 2;
            this.radioNoVip.TabStop = true;
            this.radioNoVip.Text = "Нет";
            this.radioNoVip.UseVisualStyleBackColor = true;
            // 
            // radioVip
            // 
            this.radioVip.AutoSize = true;
            this.radioVip.Location = new System.Drawing.Point(170, 165);
            this.radioVip.Name = "radioVip";
            this.radioVip.Size = new System.Drawing.Size(43, 20);
            this.radioVip.TabIndex = 3;
            this.radioVip.TabStop = true;
            this.radioVip.Text = "Да";
            this.radioVip.UseVisualStyleBackColor = true;
            // 
            // groupInterface
            // 
            this.groupInterface.Controls.Add(this.panel1);
            this.groupInterface.Controls.Add(this.AddUpHouse);
            this.groupInterface.Controls.Add(this.radioNoVip);
            this.groupInterface.Controls.Add(this.radioVip);
            this.groupInterface.Controls.Add(this.price);
            this.groupInterface.Controls.Add(this.label13);
            this.groupInterface.Controls.Add(this.Count);
            this.groupInterface.Controls.Add(this.IdHouse);
            this.groupInterface.Controls.Add(this.labelIdHouse);
            this.groupInterface.Controls.Add(this.label6);
            this.groupInterface.Controls.Add(this.label9);
            this.groupInterface.Controls.Add(this.label10);
            this.groupInterface.Controls.Add(this.IdResp);
            this.groupInterface.Location = new System.Drawing.Point(12, 219);
            this.groupInterface.Name = "groupInterface";
            this.groupInterface.Size = new System.Drawing.Size(338, 238);
            this.groupInterface.TabIndex = 7;
            this.groupInterface.TabStop = false;
            this.groupInterface.Text = "Добавление дома";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioUp);
            this.panel1.Controls.Add(this.radioAdd);
            this.panel1.Location = new System.Drawing.Point(11, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 27);
            this.panel1.TabIndex = 8;
            // 
            // radioUp
            // 
            this.radioUp.AutoSize = true;
            this.radioUp.Location = new System.Drawing.Point(160, 3);
            this.radioUp.Name = "radioUp";
            this.radioUp.Size = new System.Drawing.Size(118, 20);
            this.radioUp.TabIndex = 5;
            this.radioUp.Text = "Обновить дом";
            this.radioUp.UseVisualStyleBackColor = true;
            this.radioUp.CheckedChanged += new System.EventHandler(this.radioUp_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Checked = true;
            this.radioAdd.Location = new System.Drawing.Point(0, 3);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(117, 20);
            this.radioAdd.TabIndex = 4;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Добавить дом";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // AddUpHouse
            // 
            this.AddUpHouse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddUpHouse.Location = new System.Drawing.Point(0, 192);
            this.AddUpHouse.Name = "AddUpHouse";
            this.AddUpHouse.Size = new System.Drawing.Size(337, 46);
            this.AddUpHouse.TabIndex = 8;
            this.AddUpHouse.Text = "Добавить дом";
            this.AddUpHouse.UseVisualStyleBackColor = false;
            this.AddUpHouse.Click += new System.EventHandler(this.AddUpHouse_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(170, 134);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(157, 22);
            this.price.TabIndex = 12;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Цена";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(170, 106);
            this.Count.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Size = new System.Drawing.Size(157, 22);
            this.Count.TabIndex = 7;
            this.Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IdHouse
            // 
            this.IdHouse.Location = new System.Drawing.Point(171, 49);
            this.IdHouse.Name = "IdHouse";
            this.IdHouse.Size = new System.Drawing.Size(156, 22);
            this.IdHouse.TabIndex = 4;
            this.IdHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdHouse_KeyPress);
            // 
            // labelIdHouse
            // 
            this.labelIdHouse.AutoSize = true;
            this.labelIdHouse.Location = new System.Drawing.Point(8, 52);
            this.labelIdHouse.Name = "labelIdHouse";
            this.labelIdHouse.Size = new System.Drawing.Size(57, 16);
            this.labelIdHouse.TabIndex = 4;
            this.labelIdHouse.Text = "ID дома";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "VIP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Число комнат";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID куратора";
            // 
            // IdResp
            // 
            this.IdResp.Location = new System.Drawing.Point(170, 77);
            this.IdResp.Name = "IdResp";
            this.IdResp.Size = new System.Drawing.Size(157, 22);
            this.IdResp.TabIndex = 0;
            this.IdResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdResp_KeyPress);
            // 
            // DeleteBoxAdmin
            // 
            this.DeleteBoxAdmin.Controls.Add(this.deleteHouse);
            this.DeleteBoxAdmin.Controls.Add(this.idDeleted);
            this.DeleteBoxAdmin.Controls.Add(this.label1);
            this.DeleteBoxAdmin.Location = new System.Drawing.Point(12, 497);
            this.DeleteBoxAdmin.Name = "DeleteBoxAdmin";
            this.DeleteBoxAdmin.Size = new System.Drawing.Size(147, 73);
            this.DeleteBoxAdmin.TabIndex = 8;
            this.DeleteBoxAdmin.TabStop = false;
            this.DeleteBoxAdmin.Text = "Удаление дома";
            // 
            // deleteHouse
            // 
            this.deleteHouse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteHouse.Location = new System.Drawing.Point(0, 44);
            this.deleteHouse.Name = "deleteHouse";
            this.deleteHouse.Size = new System.Drawing.Size(147, 29);
            this.deleteHouse.TabIndex = 4;
            this.deleteHouse.Text = "Снести дом";
            this.deleteHouse.UseVisualStyleBackColor = false;
            this.deleteHouse.Click += new System.EventHandler(this.deleteHouse_Click);
            // 
            // idDeleted
            // 
            this.idDeleted.Location = new System.Drawing.Point(89, 18);
            this.idDeleted.Name = "idDeleted";
            this.idDeleted.Size = new System.Drawing.Size(47, 22);
            this.idDeleted.TabIndex = 1;
            this.idDeleted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idDeleted_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID дома:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackButton.Location = new System.Drawing.Point(777, 524);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 46);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Houses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(909, 650);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteBoxAdmin);
            this.Controls.Add(this.groupInterface);
            this.Controls.Add(this.housesDataGridView);
            this.Name = "Houses";
            this.Text = "Houses";
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesDataGridView)).EndInit();
            this.groupInterface.ResumeLayout(false);
            this.groupInterface.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.DeleteBoxAdmin.ResumeLayout(false);
            this.DeleteBoxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OurWorkDataSet ourWorkDataSet;
        private System.Windows.Forms.BindingSource housesBindingSource;
        private OurWorkDataSetTableAdapters.HousesTableAdapter housesTableAdapter;
        private OurWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView housesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.RadioButton radioNoVip;
        private System.Windows.Forms.RadioButton radioVip;
        private System.Windows.Forms.GroupBox groupInterface;
        private System.Windows.Forms.Button AddUpHouse;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.RadioButton radioUp;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.TextBox IdHouse;
        private System.Windows.Forms.Label labelIdHouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdResp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox DeleteBoxAdmin;
        private System.Windows.Forms.Button deleteHouse;
        private System.Windows.Forms.TextBox idDeleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
    }
}