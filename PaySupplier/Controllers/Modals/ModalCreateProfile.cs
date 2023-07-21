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

namespace PaySupplier.Controllers.Modals
{
    public partial class ModalCreateProfile : Form
    {
        public ModalCreateProfile()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MProfile profile = new MProfile();
            profile.name = txtName.Text.ToString();
            profile.description = txtDescription.Text.ToString();
            profile.status = 1;
            profile.dateCreated = DateTime.Now;

            CProfile cprofile = new CProfile();
            bool rpta = cprofile.CreateProfile(profile);
            MessageBox.Show("respuesta: " + rpta.ToString());
        }
    }
}
