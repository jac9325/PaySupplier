﻿namespace PaySupplier.Views.Modals
{
    partial class ModalViewHotelService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameHotel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPhoneMobil = new System.Windows.Forms.TextBox();
            this.txtEmailHotel = new System.Windows.Forms.TextBox();
            this.txtDirectionHotel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvHotelServices = new System.Windows.Forms.DataGridView();
            this.txtPPublicado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPBooking = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPConfidencial = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.pxEliminar = new System.Windows.Forms.PictureBox();
            this.pxAgregar = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.idServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceConfidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePublicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelServiceWithNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelServices)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelServiceWithNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Edición";
            // 
            // txtNameHotel
            // 
            this.txtNameHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameHotel.Location = new System.Drawing.Point(10, 52);
            this.txtNameHotel.Multiline = true;
            this.txtNameHotel.Name = "txtNameHotel";
            this.txtNameHotel.Size = new System.Drawing.Size(324, 38);
            this.txtNameHotel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCities);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtPhoneMobil);
            this.groupBox1.Controls.Add(this.txtEmailHotel);
            this.groupBox1.Controls.Add(this.txtDirectionHotel);
            this.groupBox1.Controls.Add(this.txtNameHotel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 583);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descripción Observación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Celular*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo Electrónico*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Hotel *:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(10, 400);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(324, 101);
            this.txtDescription.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(10, 322);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(324, 38);
            this.txtPhone.TabIndex = 5;
            // 
            // txtPhoneMobil
            // 
            this.txtPhoneMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneMobil.Location = new System.Drawing.Point(10, 257);
            this.txtPhoneMobil.Multiline = true;
            this.txtPhoneMobil.Name = "txtPhoneMobil";
            this.txtPhoneMobil.Size = new System.Drawing.Size(324, 38);
            this.txtPhoneMobil.TabIndex = 4;
            // 
            // txtEmailHotel
            // 
            this.txtEmailHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailHotel.Location = new System.Drawing.Point(10, 188);
            this.txtEmailHotel.Multiline = true;
            this.txtEmailHotel.Name = "txtEmailHotel";
            this.txtEmailHotel.Size = new System.Drawing.Size(324, 38);
            this.txtEmailHotel.TabIndex = 3;
            // 
            // txtDirectionHotel
            // 
            this.txtDirectionHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectionHotel.Location = new System.Drawing.Point(10, 119);
            this.txtDirectionHotel.Multiline = true;
            this.txtDirectionHotel.Name = "txtDirectionHotel";
            this.txtDirectionHotel.Size = new System.Drawing.Size(324, 38);
            this.txtDirectionHotel.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.pxEliminar);
            this.groupBox2.Controls.Add(this.pxAgregar);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dgvHotelServices);
            this.groupBox2.Controls.Add(this.txtPPublicado);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPBooking);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPConfidencial);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(358, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 583);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotel Servicios";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 446);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dgvHotelServices
            // 
            this.dgvHotelServices.AllowUserToAddRows = false;
            this.dgvHotelServices.AllowUserToDeleteRows = false;
            this.dgvHotelServices.AutoGenerateColumns = false;
            this.dgvHotelServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHotelServices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHotelServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHotelServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceDataGridViewTextBoxColumn,
            this.nameServiceDataGridViewTextBoxColumn,
            this.priceConfidencialDataGridViewTextBoxColumn,
            this.pricePublicoDataGridViewTextBoxColumn,
            this.priceBookingDataGridViewTextBoxColumn});
            this.dgvHotelServices.DataSource = this.hotelServiceWithNameBindingSource;
            this.dgvHotelServices.Location = new System.Drawing.Point(18, 31);
            this.dgvHotelServices.Name = "dgvHotelServices";
            this.dgvHotelServices.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHotelServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHotelServices.RowHeadersVisible = false;
            this.dgvHotelServices.RowHeadersWidth = 51;
            this.dgvHotelServices.RowTemplate.Height = 24;
            this.dgvHotelServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHotelServices.Size = new System.Drawing.Size(476, 150);
            this.dgvHotelServices.TabIndex = 4;
            // 
            // txtPPublicado
            // 
            this.txtPPublicado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPublicado.Location = new System.Drawing.Point(18, 393);
            this.txtPPublicado.Multiline = true;
            this.txtPPublicado.Name = "txtPPublicado";
            this.txtPPublicado.Size = new System.Drawing.Size(275, 38);
            this.txtPPublicado.TabIndex = 9;
            this.txtPPublicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPPublicado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPPublicado_KeyDown);
            this.txtPPublicado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPPublicado_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Precio Publicado:";
            // 
            // txtPBooking
            // 
            this.txtPBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPBooking.Location = new System.Drawing.Point(18, 321);
            this.txtPBooking.Multiline = true;
            this.txtPBooking.Name = "txtPBooking";
            this.txtPBooking.Size = new System.Drawing.Size(275, 38);
            this.txtPBooking.TabIndex = 8;
            this.txtPBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPBooking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPBooking_KeyDown);
            this.txtPBooking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPBooking_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Precio Booking:";
            // 
            // txtPConfidencial
            // 
            this.txtPConfidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPConfidencial.Location = new System.Drawing.Point(18, 257);
            this.txtPConfidencial.Multiline = true;
            this.txtPConfidencial.Name = "txtPConfidencial";
            this.txtPConfidencial.Size = new System.Drawing.Size(275, 38);
            this.txtPConfidencial.TabIndex = 7;
            this.txtPConfidencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPConfidencial.TextChanged += new System.EventHandler(this.txtPConfidencial_TextChanged);
            this.txtPConfidencial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPConfidencial_KeyDown);
            this.txtPConfidencial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPConfidencial_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(424, 188);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 18);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = " 0 Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total de Items:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Precio Confidencial:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearchService);
            this.groupBox3.Controls.Add(this.dgvServices);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblServicio);
            this.groupBox3.Location = new System.Drawing.Point(933, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 583);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servicios";
            // 
            // txtSearchService
            // 
            this.txtSearchService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchService.Location = new System.Drawing.Point(6, 41);
            this.txtSearchService.Multiline = true;
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(240, 35);
            this.txtSearchService.TabIndex = 4;
            this.txtSearchService.TextChanged += new System.EventHandler(this.txtSearchService_TextChanged);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoGenerateColumns = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceDataGridViewTextBoxColumn1,
            this.nameServiceDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusServiceDataGridViewTextBoxColumn,
            this.idTypeServiceDataGridViewTextBoxColumn});
            this.dgvServices.DataSource = this.ServicesBindingSource;
            this.dgvServices.Location = new System.Drawing.Point(6, 82);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(240, 232);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Servicio Actual";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblServicio.Location = new System.Drawing.Point(6, 341);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(214, 29);
            this.lblServicio.TabIndex = 3;
            this.lblServicio.Text = "No Seleccionado";
            // 
            // pxEliminar
            // 
            this.pxEliminar.Image = global::PaySupplier.Properties.Resources.iconfinder_trash_4341321_120557;
            this.pxEliminar.Location = new System.Drawing.Point(500, 118);
            this.pxEliminar.Name = "pxEliminar";
            this.pxEliminar.Size = new System.Drawing.Size(63, 63);
            this.pxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxEliminar.TabIndex = 6;
            this.pxEliminar.TabStop = false;
            this.pxEliminar.Click += new System.EventHandler(this.pxEliminar_Click);
            // 
            // pxAgregar
            // 
            this.pxAgregar.Image = global::PaySupplier.Properties.Resources._189689;
            this.pxAgregar.Location = new System.Drawing.Point(500, 31);
            this.pxAgregar.Name = "pxAgregar";
            this.pxAgregar.Size = new System.Drawing.Size(63, 63);
            this.pxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxAgregar.TabIndex = 6;
            this.pxAgregar.TabStop = false;
            this.pxAgregar.Click += new System.EventHandler(this.pxAgregar_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(405, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 101);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // idServiceDataGridViewTextBoxColumn1
            // 
            this.idServiceDataGridViewTextBoxColumn1.DataPropertyName = "idService";
            this.idServiceDataGridViewTextBoxColumn1.HeaderText = "idService";
            this.idServiceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idServiceDataGridViewTextBoxColumn1.Name = "idServiceDataGridViewTextBoxColumn1";
            this.idServiceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idServiceDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameServiceDataGridViewTextBoxColumn1
            // 
            this.nameServiceDataGridViewTextBoxColumn1.DataPropertyName = "nameService";
            this.nameServiceDataGridViewTextBoxColumn1.HeaderText = "Nombre del Servicio";
            this.nameServiceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameServiceDataGridViewTextBoxColumn1.Name = "nameServiceDataGridViewTextBoxColumn1";
            this.nameServiceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
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
            // ServicesBindingSource
            // 
            this.ServicesBindingSource.DataSource = typeof(PaySupplier.Models.Service);
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
            this.nameServiceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.nameServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameServiceDataGridViewTextBoxColumn.Name = "nameServiceDataGridViewTextBoxColumn";
            this.nameServiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceConfidencialDataGridViewTextBoxColumn
            // 
            this.priceConfidencialDataGridViewTextBoxColumn.DataPropertyName = "priceConfidencial";
            this.priceConfidencialDataGridViewTextBoxColumn.HeaderText = "Confidencial";
            this.priceConfidencialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceConfidencialDataGridViewTextBoxColumn.Name = "priceConfidencialDataGridViewTextBoxColumn";
            this.priceConfidencialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricePublicoDataGridViewTextBoxColumn
            // 
            this.pricePublicoDataGridViewTextBoxColumn.DataPropertyName = "pricePublico";
            this.pricePublicoDataGridViewTextBoxColumn.HeaderText = "Publico";
            this.pricePublicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePublicoDataGridViewTextBoxColumn.Name = "pricePublicoDataGridViewTextBoxColumn";
            this.pricePublicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceBookingDataGridViewTextBoxColumn
            // 
            this.priceBookingDataGridViewTextBoxColumn.DataPropertyName = "priceBooking";
            this.priceBookingDataGridViewTextBoxColumn.HeaderText = "Booking";
            this.priceBookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceBookingDataGridViewTextBoxColumn.Name = "priceBookingDataGridViewTextBoxColumn";
            this.priceBookingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelServiceWithNameBindingSource
            // 
            this.hotelServiceWithNameBindingSource.DataSource = typeof(PaySupplier.Models.HotelServiceWithName);
            // 
            // cbCities
            // 
            this.cbCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Location = new System.Drawing.Point(10, 539);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(324, 28);
            this.cbCities.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cities:";
            // 
            // ModalViewHotelService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 683);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ModalViewHotelService";
            this.Load += new System.EventHandler(this.ModalViewHotelService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelServices)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelServiceWithNameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameHotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPhoneMobil;
        private System.Windows.Forms.TextBox txtEmailHotel;
        private System.Windows.Forms.TextBox txtDirectionHotel;
        private System.Windows.Forms.TextBox txtPConfidencial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvHotelServices;
        private System.Windows.Forms.TextBox txtPPublicado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPBooking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pxEliminar;
        private System.Windows.Forms.PictureBox pxAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource hotelServiceWithNameBindingSource;
        private System.Windows.Forms.TextBox txtSearchService;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.BindingSource ServicesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePublicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceConfidencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePublicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label label13;
    }
}