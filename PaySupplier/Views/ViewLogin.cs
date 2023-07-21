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
    public partial class ViewLogin : Form
    {
        MUser currentUser = new MUser();
        public ViewLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == null || txtPassword.Text == null)  
                {
                    MessageBox.Show("Hay campos vacios", "Pay Supplier", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                currentUser = CUser.LoginUser(txtUser.Text.ToString().Trim(), txtPassword.Text.Trim().ToString());
                MessageBox.Show(currentUser.user, "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
