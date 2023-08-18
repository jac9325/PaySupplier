using PaySupplier.Controllers;
using PaySupplier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaySupplier.Views
{
    public partial class DashBoard : Form
    {
        public MUser currentUser = new MUser();
        public DashBoard()
        {
            InitializeComponent();
        }
        public DashBoard(MUser user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
        #region Control de los Paneles
        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pMain.Controls.Count > 0)
                this.pMain.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pMain.Controls.Add(fh);
            this.pMain.Tag = fh;
            fh.Show();
        }
        #endregion

        private void btnViewHotels_Click(object sender, EventArgs e)
        {
            ViewHotel vwHotel = new ViewHotel();
            AbrirFormEnPanel(vwHotel);
        }

        private void pxImagenCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Esta seguro de salir?", "Pay Supplier 1.0.0.0", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog.ToString() == "OK")
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void DashBoard_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height + taskbarHeight);
            }
        }

        private void btnHotelBookings_Click(object sender, EventArgs e)
        {
            ViewBooking vwBooking = new ViewBooking();
            AbrirFormEnPanel(vwBooking);
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            List<HotelWithServices> hotels = new List<HotelWithServices>();
            hotels = CHotelServices.getHotelService();
        }
    }
}
