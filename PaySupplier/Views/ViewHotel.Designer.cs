namespace PaySupplier.Views
{
    partial class ViewHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHotel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HotelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearchHotel = new System.Windows.Forms.TextBox();
            this.dgvHotels = new System.Windows.Forms.DataGridView();
            this.idHotelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bntNewHotel = new System.Windows.Forms.Button();
            this.btnSeeHotel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelBindingNavigator)).BeginInit();
            this.HotelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HotelBindingNavigator);
            this.panel2.Controls.Add(this.txtSearchHotel);
            this.panel2.Controls.Add(this.dgvHotels);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(221, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 535);
            this.panel2.TabIndex = 2;
            // 
            // HotelBindingNavigator
            // 
            this.HotelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.HotelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.HotelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.HotelBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HotelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.HotelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.HotelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.HotelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.HotelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.HotelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.HotelBindingNavigator.Name = "HotelBindingNavigator";
            this.HotelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.HotelBindingNavigator.Size = new System.Drawing.Size(1058, 31);
            this.HotelBindingNavigator.TabIndex = 2;
            this.HotelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // txtSearchHotel
            // 
            this.txtSearchHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHotel.Location = new System.Drawing.Point(3, 45);
            this.txtSearchHotel.Multiline = true;
            this.txtSearchHotel.Name = "txtSearchHotel";
            this.txtSearchHotel.Size = new System.Drawing.Size(1043, 47);
            this.txtSearchHotel.TabIndex = 1;
            this.txtSearchHotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchHotel.TextChanged += new System.EventHandler(this.txtSearchHotel_TextChanged);
            // 
            // dgvHotels
            // 
            this.dgvHotels.AllowUserToAddRows = false;
            this.dgvHotels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvHotels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHotels.AutoGenerateColumns = false;
            this.dgvHotels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHotels.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHotels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHotelsDataGridViewTextBoxColumn,
            this.Edit,
            this.nameCityDataGridViewTextBoxColumn,
            this.categoryHotelDataGridViewTextBoxColumn,
            this.nameHotelDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.statusHotelDataGridViewTextBoxColumn,
            this.descriptionHotelDataGridViewTextBoxColumn,
            this.idCityDataGridViewTextBoxColumn});
            this.dgvHotels.DataSource = this.HotelsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHotels.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHotels.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHotels.Location = new System.Drawing.Point(3, 98);
            this.dgvHotels.Name = "dgvHotels";
            this.dgvHotels.ReadOnly = true;
            this.dgvHotels.RowHeadersVisible = false;
            this.dgvHotels.RowHeadersWidth = 51;
            this.dgvHotels.RowTemplate.Height = 24;
            this.dgvHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHotels.Size = new System.Drawing.Size(1043, 419);
            this.dgvHotels.TabIndex = 0;
            this.dgvHotels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotels_CellClick);
            this.dgvHotels.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHotels_CellFormatting);
            this.dgvHotels.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvHotels_RowPrePaint);
            // 
            // idHotelsDataGridViewTextBoxColumn
            // 
            this.idHotelsDataGridViewTextBoxColumn.DataPropertyName = "idHotels";
            this.idHotelsDataGridViewTextBoxColumn.HeaderText = "idHotels";
            this.idHotelsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idHotelsDataGridViewTextBoxColumn.Name = "idHotelsDataGridViewTextBoxColumn";
            this.idHotelsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHotelsDataGridViewTextBoxColumn.Visible = false;
            // 
            // Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Edit.HeaderText = "Editar Hotel";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Editar";
            this.Edit.ToolTipText = "Editar";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // nameCityDataGridViewTextBoxColumn
            // 
            this.nameCityDataGridViewTextBoxColumn.DataPropertyName = "nameCity";
            this.nameCityDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.nameCityDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameCityDataGridViewTextBoxColumn.Name = "nameCityDataGridViewTextBoxColumn";
            this.nameCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryHotelDataGridViewTextBoxColumn
            // 
            this.categoryHotelDataGridViewTextBoxColumn.DataPropertyName = "categoryHotel";
            this.categoryHotelDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoryHotelDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.categoryHotelDataGridViewTextBoxColumn.Name = "categoryHotelDataGridViewTextBoxColumn";
            this.categoryHotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameHotelDataGridViewTextBoxColumn
            // 
            this.nameHotelDataGridViewTextBoxColumn.DataPropertyName = "nameHotel";
            this.nameHotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.nameHotelDataGridViewTextBoxColumn.MinimumWidth = 180;
            this.nameHotelDataGridViewTextBoxColumn.Name = "nameHotelDataGridViewTextBoxColumn";
            this.nameHotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "mobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusHotelDataGridViewTextBoxColumn
            // 
            this.statusHotelDataGridViewTextBoxColumn.DataPropertyName = "statusHotel";
            this.statusHotelDataGridViewTextBoxColumn.HeaderText = "statusHotel";
            this.statusHotelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusHotelDataGridViewTextBoxColumn.Name = "statusHotelDataGridViewTextBoxColumn";
            this.statusHotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusHotelDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionHotelDataGridViewTextBoxColumn
            // 
            this.descriptionHotelDataGridViewTextBoxColumn.DataPropertyName = "descriptionHotel";
            this.descriptionHotelDataGridViewTextBoxColumn.HeaderText = "descriptionHotel";
            this.descriptionHotelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionHotelDataGridViewTextBoxColumn.Name = "descriptionHotelDataGridViewTextBoxColumn";
            this.descriptionHotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionHotelDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCityDataGridViewTextBoxColumn
            // 
            this.idCityDataGridViewTextBoxColumn.DataPropertyName = "idCity";
            this.idCityDataGridViewTextBoxColumn.HeaderText = "idCity";
            this.idCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
            this.idCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCityDataGridViewTextBoxColumn.Visible = false;
            // 
            // HotelsBindingSource
            // 
            this.HotelsBindingSource.DataSource = typeof(PaySupplier.Models.Hotel);
            // 
            // bntNewHotel
            // 
            this.bntNewHotel.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntNewHotel.FlatAppearance.BorderSize = 0;
            this.bntNewHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNewHotel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNewHotel.ForeColor = System.Drawing.Color.White;
            this.bntNewHotel.Location = new System.Drawing.Point(12, 109);
            this.bntNewHotel.Name = "bntNewHotel";
            this.bntNewHotel.Size = new System.Drawing.Size(191, 56);
            this.bntNewHotel.TabIndex = 3;
            this.bntNewHotel.Text = "Nuevo Hotel";
            this.bntNewHotel.UseVisualStyleBackColor = false;
            this.bntNewHotel.Click += new System.EventHandler(this.bntNewHotel_Click);
            // 
            // btnSeeHotel
            // 
            this.btnSeeHotel.Location = new System.Drawing.Point(12, 191);
            this.btnSeeHotel.Name = "btnSeeHotel";
            this.btnSeeHotel.Size = new System.Drawing.Size(191, 46);
            this.btnSeeHotel.TabIndex = 3;
            this.btnSeeHotel.Text = "Ver Hotel";
            this.btnSeeHotel.UseVisualStyleBackColor = true;
            // 
            // ViewHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 619);
            this.Controls.Add(this.btnSeeHotel);
            this.Controls.Add(this.bntNewHotel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewHotel";
            this.Load += new System.EventHandler(this.ViewHotel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelBindingNavigator)).EndInit();
            this.HotelBindingNavigator.ResumeLayout(false);
            this.HotelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchHotel;
        private System.Windows.Forms.DataGridView dgvHotels;
        private System.Windows.Forms.Button bntNewHotel;
        private System.Windows.Forms.Button btnSeeHotel;
        private System.Windows.Forms.BindingNavigator HotelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource HotelsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceConfidencialservicio1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceConfidencialservicio2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceConfidencialservicio3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceConfidencialservicio4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicie1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicie2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicie3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicie4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
    }
}