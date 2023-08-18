namespace PaySupplier.Views
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.pLeft = new System.Windows.Forms.Panel();
            this.btnHotelBookings = new System.Windows.Forms.Button();
            this.pSupLeft = new System.Windows.Forms.Panel();
            this.btnViewHotels = new System.Windows.Forms.Button();
            this.pSup = new System.Windows.Forms.Panel();
            this.pxImagenCerrar = new System.Windows.Forms.PictureBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnAgency = new System.Windows.Forms.Button();
            this.pLeft.SuspendLayout();
            this.pSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagenCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(190)))));
            this.pLeft.Controls.Add(this.btnAgency);
            this.pLeft.Controls.Add(this.btnHotelBookings);
            this.pLeft.Controls.Add(this.pSupLeft);
            this.pLeft.Controls.Add(this.btnViewHotels);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(271, 788);
            this.pLeft.TabIndex = 0;
            // 
            // btnHotelBookings
            // 
            this.btnHotelBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btnHotelBookings.FlatAppearance.BorderSize = 0;
            this.btnHotelBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelBookings.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnHotelBookings.ForeColor = System.Drawing.Color.White;
            this.btnHotelBookings.Location = new System.Drawing.Point(12, 382);
            this.btnHotelBookings.Name = "btnHotelBookings";
            this.btnHotelBookings.Size = new System.Drawing.Size(253, 60);
            this.btnHotelBookings.TabIndex = 2;
            this.btnHotelBookings.Text = "Reservas de Hotel";
            this.btnHotelBookings.UseVisualStyleBackColor = false;
            this.btnHotelBookings.Click += new System.EventHandler(this.btnHotelBookings_Click);
            // 
            // pSupLeft
            // 
            this.pSupLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSupLeft.Location = new System.Drawing.Point(0, 0);
            this.pSupLeft.Name = "pSupLeft";
            this.pSupLeft.Size = new System.Drawing.Size(271, 280);
            this.pSupLeft.TabIndex = 1;
            // 
            // btnViewHotels
            // 
            this.btnViewHotels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btnViewHotels.FlatAppearance.BorderSize = 0;
            this.btnViewHotels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHotels.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnViewHotels.ForeColor = System.Drawing.Color.White;
            this.btnViewHotels.Location = new System.Drawing.Point(12, 305);
            this.btnViewHotels.Name = "btnViewHotels";
            this.btnViewHotels.Size = new System.Drawing.Size(253, 60);
            this.btnViewHotels.TabIndex = 0;
            this.btnViewHotels.Text = "Hotels";
            this.btnViewHotels.UseVisualStyleBackColor = false;
            this.btnViewHotels.Click += new System.EventHandler(this.btnViewHotels_Click);
            // 
            // pSup
            // 
            this.pSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(190)))));
            this.pSup.Controls.Add(this.pxImagenCerrar);
            this.pSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSup.Location = new System.Drawing.Point(271, 0);
            this.pSup.Name = "pSup";
            this.pSup.Size = new System.Drawing.Size(945, 112);
            this.pSup.TabIndex = 1;
            // 
            // pxImagenCerrar
            // 
            this.pxImagenCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxImagenCerrar.Image = global::PaySupplier.Properties.Resources.ico_cerrar;
            this.pxImagenCerrar.Location = new System.Drawing.Point(885, 12);
            this.pxImagenCerrar.Name = "pxImagenCerrar";
            this.pxImagenCerrar.Size = new System.Drawing.Size(48, 44);
            this.pxImagenCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxImagenCerrar.TabIndex = 1;
            this.pxImagenCerrar.TabStop = false;
            this.pxImagenCerrar.Click += new System.EventHandler(this.pxImagenCerrar_Click);
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(271, 112);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(945, 676);
            this.pMain.TabIndex = 2;
            // 
            // btnAgency
            // 
            this.btnAgency.Location = new System.Drawing.Point(12, 467);
            this.btnAgency.Name = "btnAgency";
            this.btnAgency.Size = new System.Drawing.Size(253, 44);
            this.btnAgency.TabIndex = 3;
            this.btnAgency.Text = "button1";
            this.btnAgency.UseVisualStyleBackColor = true;
            this.btnAgency.Click += new System.EventHandler(this.btnAgency_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 788);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pSup);
            this.Controls.Add(this.pLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Text = "Pay Supplier 1.5.0.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.SizeChanged += new System.EventHandler(this.DashBoard_SizeChanged);
            this.pLeft.ResumeLayout(false);
            this.pSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxImagenCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pSup;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnViewHotels;
        private System.Windows.Forms.Panel pSupLeft;
        private System.Windows.Forms.PictureBox pxImagenCerrar;
        private System.Windows.Forms.Button btnHotelBookings;
        private System.Windows.Forms.Button btnAgency;
    }
}