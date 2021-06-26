namespace OuurWork
{
    partial class Souvenir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Souvenir));
            this.ourWorkDataSet = new OuurWork.OurWorkDataSet();
            this.souvenirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.souvenirTableAdapter = new OuurWork.OurWorkDataSetTableAdapters.SouvenirTableAdapter();
            this.tableAdapterManager = new OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager();
            this.souvenirDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupInterface = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSouvenir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioUp = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.AddUpSouvenir = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IdSouvenir = new System.Windows.Forms.TextBox();
            this.labelIdSouvenir = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IdResp = new System.Windows.Forms.TextBox();
            this.DeleteBoxAdmin = new System.Windows.Forms.GroupBox();
            this.deleteHouse = new System.Windows.Forms.Button();
            this.idDeleted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirDataGridView)).BeginInit();
            this.groupInterface.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DeleteBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ourWorkDataSet
            // 
            this.ourWorkDataSet.DataSetName = "OurWorkDataSet";
            this.ourWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // souvenirBindingSource
            // 
            this.souvenirBindingSource.DataMember = "Souvenir";
            this.souvenirBindingSource.DataSource = this.ourWorkDataSet;
            // 
            // souvenirTableAdapter
            // 
            this.souvenirTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitizensTableAdapter = null;
            this.tableAdapterManager.Global_ContractsTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = null;
            this.tableAdapterManager.SouvenirTableAdapter = this.souvenirTableAdapter;
            this.tableAdapterManager.Turism_ContractsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Village_ContractsTableAdapter = null;
            // 
            // souvenirDataGridView
            // 
            this.souvenirDataGridView.AllowUserToAddRows = false;
            this.souvenirDataGridView.AllowUserToDeleteRows = false;
            this.souvenirDataGridView.AutoGenerateColumns = false;
            this.souvenirDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.souvenirDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.souvenirDataGridView.DataSource = this.souvenirBindingSource;
            this.souvenirDataGridView.Location = new System.Drawing.Point(2, 1);
            this.souvenirDataGridView.Name = "souvenirDataGridView";
            this.souvenirDataGridView.RowHeadersWidth = 51;
            this.souvenirDataGridView.RowTemplate.Height = 24;
            this.souvenirDataGridView.Size = new System.Drawing.Size(739, 232);
            this.souvenirDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Souvenir";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Souvenir";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_of";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_of";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_Producer";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_Producer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // groupInterface
            // 
            this.groupInterface.Controls.Add(this.label2);
            this.groupInterface.Controls.Add(this.nameSouvenir);
            this.groupInterface.Controls.Add(this.panel1);
            this.groupInterface.Controls.Add(this.AddUpSouvenir);
            this.groupInterface.Controls.Add(this.price);
            this.groupInterface.Controls.Add(this.label13);
            this.groupInterface.Controls.Add(this.IdSouvenir);
            this.groupInterface.Controls.Add(this.labelIdSouvenir);
            this.groupInterface.Controls.Add(this.label10);
            this.groupInterface.Controls.Add(this.IdResp);
            this.groupInterface.Location = new System.Drawing.Point(12, 239);
            this.groupInterface.Name = "groupInterface";
            this.groupInterface.Size = new System.Drawing.Size(338, 228);
            this.groupInterface.TabIndex = 8;
            this.groupInterface.TabStop = false;
            this.groupInterface.Text = "Добавление сувенира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название";
            // 
            // nameSouvenir
            // 
            this.nameSouvenir.Location = new System.Drawing.Point(170, 77);
            this.nameSouvenir.Name = "nameSouvenir";
            this.nameSouvenir.Size = new System.Drawing.Size(157, 22);
            this.nameSouvenir.TabIndex = 13;
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
            this.radioUp.Size = new System.Drawing.Size(148, 20);
            this.radioUp.TabIndex = 5;
            this.radioUp.Text = "Обновить сувенир";
            this.radioUp.UseVisualStyleBackColor = true;
            this.radioUp.CheckedChanged += new System.EventHandler(this.radioUp_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Checked = true;
            this.radioAdd.Location = new System.Drawing.Point(0, 3);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(147, 20);
            this.radioAdd.TabIndex = 4;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Добавить сувенир";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // AddUpSouvenir
            // 
            this.AddUpSouvenir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddUpSouvenir.Location = new System.Drawing.Point(0, 180);
            this.AddUpSouvenir.Name = "AddUpSouvenir";
            this.AddUpSouvenir.Size = new System.Drawing.Size(337, 48);
            this.AddUpSouvenir.TabIndex = 8;
            this.AddUpSouvenir.Text = "Добавить сувенир";
            this.AddUpSouvenir.UseVisualStyleBackColor = false;
            this.AddUpSouvenir.Click += new System.EventHandler(this.AddUpHouse_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(170, 135);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(157, 22);
            this.price.TabIndex = 12;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Цена";
            // 
            // IdSouvenir
            // 
            this.IdSouvenir.Location = new System.Drawing.Point(171, 49);
            this.IdSouvenir.Name = "IdSouvenir";
            this.IdSouvenir.Size = new System.Drawing.Size(156, 22);
            this.IdSouvenir.TabIndex = 4;
            this.IdSouvenir.TextChanged += new System.EventHandler(this.IdSouvenir_TextChanged);
            this.IdSouvenir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdSouvenir_KeyPress);
            // 
            // labelIdSouvenir
            // 
            this.labelIdSouvenir.AutoSize = true;
            this.labelIdSouvenir.Location = new System.Drawing.Point(8, 52);
            this.labelIdSouvenir.Name = "labelIdSouvenir";
            this.labelIdSouvenir.Size = new System.Drawing.Size(87, 16);
            this.labelIdSouvenir.TabIndex = 4;
            this.labelIdSouvenir.Text = "ID сувенира";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID куратора";
            // 
            // IdResp
            // 
            this.IdResp.Location = new System.Drawing.Point(170, 106);
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
            this.DeleteBoxAdmin.Location = new System.Drawing.Point(578, 348);
            this.DeleteBoxAdmin.Name = "DeleteBoxAdmin";
            this.DeleteBoxAdmin.Size = new System.Drawing.Size(152, 73);
            this.DeleteBoxAdmin.TabIndex = 9;
            this.DeleteBoxAdmin.TabStop = false;
            this.DeleteBoxAdmin.Text = "Удаление сувенира";
            // 
            // deleteHouse
            // 
            this.deleteHouse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteHouse.Location = new System.Drawing.Point(0, 44);
            this.deleteHouse.Name = "deleteHouse";
            this.deleteHouse.Size = new System.Drawing.Size(152, 29);
            this.deleteHouse.TabIndex = 4;
            this.deleteHouse.Text = "Удалить сувенир";
            this.deleteHouse.UseVisualStyleBackColor = false;
            this.deleteHouse.Click += new System.EventHandler(this.deleteHouse_Click);
            // 
            // idDeleted
            // 
            this.idDeleted.Location = new System.Drawing.Point(99, 18);
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
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID сувенира:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackButton.Location = new System.Drawing.Point(610, 500);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 46);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Souvenir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 847);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteBoxAdmin);
            this.Controls.Add(this.groupInterface);
            this.Controls.Add(this.souvenirDataGridView);
            this.Name = "Souvenir";
            this.Text = "Souvenir";
            this.Load += new System.EventHandler(this.Souvenir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.souvenirDataGridView)).EndInit();
            this.groupInterface.ResumeLayout(false);
            this.groupInterface.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DeleteBoxAdmin.ResumeLayout(false);
            this.DeleteBoxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OurWorkDataSet ourWorkDataSet;
        private System.Windows.Forms.BindingSource souvenirBindingSource;
        private OurWorkDataSetTableAdapters.SouvenirTableAdapter souvenirTableAdapter;
        private OurWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView souvenirDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupInterface;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioUp;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.Button AddUpSouvenir;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IdSouvenir;
        private System.Windows.Forms.Label labelIdSouvenir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdResp;
        private System.Windows.Forms.GroupBox DeleteBoxAdmin;
        private System.Windows.Forms.Button deleteHouse;
        private System.Windows.Forms.TextBox idDeleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSouvenir;
        private System.Windows.Forms.Button BackButton;
    }
}