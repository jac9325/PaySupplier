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

namespace PaySupplier.Views.Modals
{
    public partial class ModalViewService : Form
    {
        Service currentService = new Service();
        bool isNuevo = true;
        List<TypeService> currentTypeService = new List<TypeService>();
        //modo de ingreso para crear un servicio
        public ModalViewService()
        {
            InitializeComponent();
        }

        //modo de ingreso para editar el servicio
        //modo de ingreso para crear un servicio
        public ModalViewService(Service service)
        {
            InitializeComponent();
            this.currentService = service;
            isNuevo=false;
        }
        public void Reload()
        {
            getTypeServices();
            setDataCombo();
            if (!isNuevo)
            {
                SetFildsServices();
            }
        }
        public void SetFildsServices()
        {
            txtName.Text = currentService.nameService.ToString();
            txtDescription.Text = currentService.description.ToString();
            cbTypeService.SelectedIndex = currentService.idTypeService;
        }
        public void getTypeServices()
        {
            currentTypeService = CTypeService.getTypeServices();
        }
        public void setDataCombo()
        {
            if (currentTypeService.Count > 0)
            {
                ComboDataSoruce.DataSource = currentTypeService;
            }
            else
            {
                return;
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool process = false; 
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Hay campos sin llenar");
                    return;
                }
                else
                {
                    currentService.nameService = txtName.Text.ToString();
                    currentService.description = txtDescription.Text.ToString();
                    currentService.statusService = 1;
                    currentService.idTypeService = Convert.ToInt32(cbTypeService.SelectedValue);

                }

                DialogResult rpta = MessageBox.Show("¿Estas seguro de guardar?", "Pay Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rpta == DialogResult.OK)
                {
                    process = CService.createService(currentService);
                }
                if (process)
                {
                    MessageBox.Show("Se guardó correctamente", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void ModalViewService_Load(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
