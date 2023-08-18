namespace PaySupplier.Views
{
    partial class ModalBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalBooking));
            this.gbBookings = new System.Windows.Forms.GroupBox();
            this.gbService = new System.Windows.Forms.GroupBox();
            this.dtpDateBooking = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbBookingStatus = new System.Windows.Forms.ComboBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrepayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbBookings.SuspendLayout();
            this.gbService.SuspendLayout();
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBookings
            // 
            this.gbBookings.Controls.Add(this.txtPrepayment);
            this.gbBookings.Controls.Add(this.label2);
            this.gbBookings.Controls.Add(this.label5);
            this.gbBookings.Controls.Add(this.label4);
            this.gbBookings.Controls.Add(this.label3);
            this.gbBookings.Controls.Add(this.label1);
            this.gbBookings.Controls.Add(this.txtObservations);
            this.gbBookings.Controls.Add(this.cbBookingStatus);
            this.gbBookings.Controls.Add(this.txtAmount);
            this.gbBookings.Controls.Add(this.dtpDateBooking);
            this.gbBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookings.Location = new System.Drawing.Point(731, 63);
            this.gbBookings.Name = "gbBookings";
            this.gbBookings.Size = new System.Drawing.Size(387, 561);
            this.gbBookings.TabIndex = 0;
            this.gbBookings.TabStop = false;
            this.gbBookings.Text = "Reserva";
            // 
            // gbService
            // 
            this.gbService.Controls.Add(this.comboBox1);
            this.gbService.Controls.Add(this.dgvServices);
            this.gbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbService.Location = new System.Drawing.Point(12, 63);
            this.gbService.Name = "gbService";
            this.gbService.Size = new System.Drawing.Size(713, 365);
            this.gbService.TabIndex = 1;
            this.gbService.TabStop = false;
            this.gbService.Text = "Servicios";
            // 
            // dtpDateBooking
            // 
            this.dtpDateBooking.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBooking.Location = new System.Drawing.Point(23, 287);
            this.dtpDateBooking.Name = "dtpDateBooking";
            this.dtpDateBooking.Size = new System.Drawing.Size(338, 24);
            this.dtpDateBooking.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(150, 34);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(211, 43);
            this.txtAmount.TabIndex = 1;
            // 
            // cbBookingStatus
            // 
            this.cbBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookingStatus.FormattingEnabled = true;
            this.cbBookingStatus.Items.AddRange(new object[] {
            "PAGADO",
            "PENDIENTE"});
            this.cbBookingStatus.Location = new System.Drawing.Point(23, 208);
            this.cbBookingStatus.Name = "cbBookingStatus";
            this.cbBookingStatus.Size = new System.Drawing.Size(196, 28);
            this.cbBookingStatus.TabIndex = 2;
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(23, 406);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(343, 149);
            this.txtObservations.TabIndex = 4;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.textBox1);
            this.gbClient.Controls.Add(this.txtNroDocumento);
            this.gbClient.Controls.Add(this.txtNameClient);
            this.gbClient.Controls.Add(this.btnNewClient);
            this.gbClient.Controls.Add(this.label9);
            this.gbClient.Controls.Add(this.label8);
            this.gbClient.Controls.Add(this.label7);
            this.gbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClient.Location = new System.Drawing.Point(12, 434);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(713, 190);
            this.gbClient.TabIndex = 2;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pago Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto Total:";
            // 
            // txtPrepayment
            // 
            this.txtPrepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrepayment.Location = new System.Drawing.Point(150, 100);
            this.txtPrepayment.Multiline = true;
            this.txtPrepayment.Name = "txtPrepayment";
            this.txtPrepayment.Size = new System.Drawing.Size(211, 43);
            this.txtPrepayment.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado de Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reservas";
            // 
            // dgvServices
            // 
            this.dgvServices.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(7, 150);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(386, 209);
            this.dgvServices.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.Brown;
            this.btnNewClient.FlatAppearance.BorderSize = 0;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClient.ForeColor = System.Drawing.Color.White;
            this.btnNewClient.Location = new System.Drawing.Point(7, 36);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(131, 37);
            this.btnNewClient.TabIndex = 0;
            this.btnNewClient.Text = "Nuevo Clente";
            this.btnNewClient.UseVisualStyleBackColor = false;
            // 
            // txtNameClient
            // 
            this.txtNameClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameClient.Location = new System.Drawing.Point(7, 98);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(334, 27);
            this.txtNameClient.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nro Documento:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocumento.Location = new System.Drawing.Point(154, 157);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(187, 27);
            this.txtNroDocumento.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tipo Documento:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 27);
            this.textBox1.TabIndex = 7;
            // 
            // ModalBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1130, 636);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbBookings);
            this.Controls.Add(this.gbService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModalBooking";
            this.Load += new System.EventHandler(this.ModalBooking_Load);
            this.gbBookings.ResumeLayout(false);
            this.gbBookings.PerformLayout();
            this.gbService.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBookings;
        private System.Windows.Forms.GroupBox gbService;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDateBooking;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.ComboBox cbBookingStatus;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrepayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}