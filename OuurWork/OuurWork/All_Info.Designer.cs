namespace OuurWork
{
    partial class All_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Info));
            this.ourWorkDataSet = new OuurWork.OurWorkDataSet();
            this.citizensProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizensProfilesTableAdapter = new OuurWork.OurWorkDataSetTableAdapters.CitizensProfilesTableAdapter();
            this.tableAdapterManager = new OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensProfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ourWorkDataSet
            // 
            this.ourWorkDataSet.DataSetName = "OurWorkDataSet";
            this.ourWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitizensTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Global_ContractsTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = null;
            this.tableAdapterManager.SouvenirTableAdapter = null;
            this.tableAdapterManager.Turism_ContractsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OuurWork.OurWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Village_ContractsTableAdapter = null;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Back.Location = new System.Drawing.Point(0, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(780, 74);
            this.Back.TabIndex = 2;
            this.Back.Text = "Выход";
            this.Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 79);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(780, 373);
            this.dataGridView.TabIndex = 3;
            // 
            // All_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "All_Info";
            this.Text = "Полная информация";
            ((System.ComponentModel.ISupportInitialize)(this.ourWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensProfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OurWorkDataSet ourWorkDataSet;
        private System.Windows.Forms.BindingSource citizensProfilesBindingSource;
        private OurWorkDataSetTableAdapters.CitizensProfilesTableAdapter citizensProfilesTableAdapter;
        private OurWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}