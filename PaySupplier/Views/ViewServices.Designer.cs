namespace PaySupplier.Views
{
    partial class ViewServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscarServices = new System.Windows.Forms.TextBox();
            this.idServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesDataSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.AutoGenerateColumns = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceDataGridViewTextBoxColumn,
            this.nameServiceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusServiceDataGridViewTextBoxColumn,
            this.idTypeServiceDataGridViewTextBoxColumn});
            this.dgvServicios.DataSource = this.ServicesDataSource;
            this.dgvServicios.Location = new System.Drawing.Point(12, 161);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(974, 349);
            this.dgvServicios.TabIndex = 1;
            this.dgvServicios.DoubleClick += new System.EventHandler(this.dgvServicios_DoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(65, 539);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(144, 41);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscarServices
            // 
            this.txtBuscarServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarServices.Location = new System.Drawing.Point(12, 104);
            this.txtBuscarServices.Name = "txtBuscarServices";
            this.txtBuscarServices.Size = new System.Drawing.Size(974, 30);
            this.txtBuscarServices.TabIndex = 3;
            // 
            // idServiceDataGridViewTextBoxColumn
            // 
            this.idServiceDataGridViewTextBoxColumn.DataPropertyName = "idService";
            this.idServiceDataGridViewTextBoxColumn.HeaderText = "idService";
            this.idServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idServiceDataGridViewTextBoxColumn.Name = "idServiceDataGridViewTextBoxColumn";
            this.idServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idServiceDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameServiceDataGridViewTextBoxColumn
            // 
            this.nameServiceDataGridViewTextBoxColumn.DataPropertyName = "nameService";
            this.nameServiceDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nameServiceDataGridViewTextBoxColumn.HeaderText = "nameService";
            this.nameServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameServiceDataGridViewTextBoxColumn.Name = "nameServiceDataGridViewTextBoxColumn";
            this.nameServiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 190F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusServiceDataGridViewTextBoxColumn
            // 
            this.statusServiceDataGridViewTextBoxColumn.DataPropertyName = "statusService";
            this.statusServiceDataGridViewTextBoxColumn.HeaderText = "statusService";
            this.statusServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusServiceDataGridViewTextBoxColumn.Name = "statusServiceDataGridViewTextBoxColumn";
            this.statusServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusServiceDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTypeServiceDataGridViewTextBoxColumn
            // 
            this.idTypeServiceDataGridViewTextBoxColumn.DataPropertyName = "idTypeService";
            this.idTypeServiceDataGridViewTextBoxColumn.HeaderText = "idTypeService";
            this.idTypeServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTypeServiceDataGridViewTextBoxColumn.Name = "idTypeServiceDataGridViewTextBoxColumn";
            this.idTypeServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTypeServiceDataGridViewTextBoxColumn.Visible = false;
            // 
            // ServicesDataSource
            // 
            this.ServicesDataSource.DataSource = typeof(PaySupplier.Models.Service);
            // 
            // ViewServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 610);
            this.Controls.Add(this.txtBuscarServices);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.label1);
            this.Name = "ViewServices";
            this.Text = "ViewServices";
            this.Load += new System.EventHandler(this.ViewServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.BindingSource ServicesDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscarServices;
    }
}