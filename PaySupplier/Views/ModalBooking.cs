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
    public partial class ModalBooking : Form
    {
        public ModalBooking()
        {
            InitializeComponent();
        }

        private void ModalBooking_Load(object sender, EventArgs e)
        {
            this.cbBookingStatus.Text = "PENDIENTE";
        }
    }
}
