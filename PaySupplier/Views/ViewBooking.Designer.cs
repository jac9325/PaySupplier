namespace PaySupplier.Views
{
    partial class ViewBooking
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
            this.pLeftBooking = new System.Windows.Forms.Panel();
            this.pMainBooking = new System.Windows.Forms.Panel();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.pLeftBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeftBooking
            // 
            this.pLeftBooking.Controls.Add(this.btnNewBooking);
            this.pLeftBooking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftBooking.Location = new System.Drawing.Point(0, 0);
            this.pLeftBooking.Name = "pLeftBooking";
            this.pLeftBooking.Size = new System.Drawing.Size(233, 713);
            this.pLeftBooking.TabIndex = 0;
            // 
            // pMainBooking
            // 
            this.pMainBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainBooking.Location = new System.Drawing.Point(233, 0);
            this.pMainBooking.Name = "pMainBooking";
            this.pMainBooking.Size = new System.Drawing.Size(1034, 713);
            this.pMainBooking.TabIndex = 1;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.Crimson;
            this.btnNewBooking.FlatAppearance.BorderSize = 0;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnNewBooking.Location = new System.Drawing.Point(12, 75);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(215, 55);
            this.btnNewBooking.TabIndex = 0;
            this.btnNewBooking.Text = "Nuevo";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // ViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 713);
            this.Controls.Add(this.pMainBooking);
            this.Controls.Add(this.pLeftBooking);
            this.Name = "ViewBooking";
            this.Text = "ViewBooking";
            this.pLeftBooking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeftBooking;
        private System.Windows.Forms.Panel pMainBooking;
        private System.Windows.Forms.Button btnNewBooking;
    }
}