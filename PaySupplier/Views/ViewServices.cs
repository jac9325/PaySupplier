using PaySupplier.Controllers;
using PaySupplier.Models;
using PaySupplier.Views.Modals;
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
    public partial class ViewServices : Form
    {
        public Service currentService = new Service();
        List<Service> currentServices = new List<Service>();
        public ViewServices()
        {
            InitializeComponent();
        }

        private void ViewServices_Load(object sender, EventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            getServices();
        }
        public void getServices()
        {
            try
            {               
                currentServices = CService.getServices();
                ServicesDataSource.DataSource = null;
                ServicesDataSource.DataSource = currentServices;
                dgvServicios.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvServicios_DoubleClick(object sender, EventArgs e)
        {
            int idService = Convert.ToInt32(dgvServicios.CurrentRow.Cells[0].Value);
            currentService = currentServices.Find(x=>x.idService == idService);
            ModalViewService modalViewService = new ModalViewService(currentService);
            modalViewService.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ModalViewService currentModalService = new ModalViewService();
                currentModalService.ShowDialog();
                Reload();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
