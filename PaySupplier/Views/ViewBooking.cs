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
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            ModalBooking modalBooking = new ModalBooking();
            modalBooking.ShowDialog();
        }
    }
}
