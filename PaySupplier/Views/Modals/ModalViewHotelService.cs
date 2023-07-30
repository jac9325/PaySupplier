using PaySupplier.Controllers;
using PaySupplier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PaySupplier.Views.Modals
{
    public partial class ModalViewHotelService : Form
    {
        public List<HotelServiceWithName> currentListHotelServiceWithName = new List<HotelServiceWithName>();
        public HotelServiceWithName currentHotelServiceWithName = new HotelServiceWithName();
        public List<Service> currentListService = new List<Service>();
        private List<City> currentListCity = new List<City>();
        private Hotel currentHotel =  new Hotel();
        public Service currentService;
        string regexPattern = @"^[0-9]*(?:\.[0-9]*)?$";
        public ModalViewHotelService()
        {
            InitializeComponent();
            int radio = 15;
            Rectangle r = new Rectangle(0, 0, btnSave.Width, btnSave.Height);
            btnSave.FlatAppearance.BorderSize = 0;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(r.X, r.Y, radio, radio, 180, 90);
            gp.AddArc(r.X + r.Width - radio, r.Y, radio, radio, 270, 90);
            gp.AddArc(r.X + r.Width - radio, r.Y + r.Height - radio, radio, radio, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - radio, radio, radio, 90, 90);
            btnSave.Region = new Region(gp);

        }

        private void ModalViewHotelService_Load(object sender, EventArgs e)
        {
            ChargeListCity();
        }
        public void changeFormTextBox()
        {

        }

        private void pxEliminar_Click(object sender, EventArgs e)
        {
            if (currentListHotelServiceWithName.Count <= 0)
            {
                return;
            }
            if (dgvHotelServices.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un elemento de la Tabla", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int idService = Convert.ToInt32(dgvHotelServices.CurrentRow.Cells[0].Value);
            HotelServiceWithName aux = new HotelServiceWithName();
            aux = currentListHotelServiceWithName.Find(x=>x.idService == idService);
            currentListHotelServiceWithName.Remove(aux);
            hotelServiceWithNameBindingSource.DataSource = null;
            hotelServiceWithNameBindingSource.DataSource = currentListHotelServiceWithName;

            dgvHotelServices.Refresh();
        }

        private void pxAgregar_Click(object sender, EventArgs e)
        {
            bool rpta = validateTextBoxService();
            if (rpta || currentService == null)
            {
                MessageBox.Show("Los campos deben llenarse o no hay un servicio seleccionado", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HotelServiceWithName auxHotelService = new HotelServiceWithName();
            auxHotelService.idService = currentService.idService;
            auxHotelService.nameService = currentService.nameService;
            auxHotelService.priceConfidencial = Convert.ToDecimal(txtPConfidencial.Text.Trim());
            auxHotelService.priceBooking = Convert.ToDecimal(txtPBooking.Text.Trim());
            auxHotelService.pricePublic = Convert.ToDecimal(txtPPublicado.Text.Trim());
            //-- add datos a la lista
            currentListHotelServiceWithName.Add(auxHotelService);
            ActualizarDatos();
            clearFilds();
        }
        public bool validateTextBoxService()
        {
            bool rpta = false;
            if (txtPBooking.Text == string.Empty || txtPConfidencial.Text == string.Empty || txtPPublicado.Text == string.Empty) 
            {
                
                rpta = true;
            }
            return rpta;
        }

        private void txtPConfidencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número, un punto o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no cumple con las condiciones anteriores, cancelar el evento KeyPress
                e.Handled = true;
            }

        }
        public void ActualizarDatos()
        {
            if (currentListHotelServiceWithName == null)
            {
                MessageBox.Show("La lista esta vacia", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hotelServiceWithNameBindingSource.DataSource = null;
            hotelServiceWithNameBindingSource.DataSource = currentListHotelServiceWithName;
            dgvHotelServices.Refresh();
        }
        public void Reload()
        {

        }
        public void ChargeListCity()
        {
            currentListCity = CCity.getCitys();
            if (currentListCity.Count<= 0)
            {
                MessageBox.Show("Error al cargar las ciudades", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //asignar al combobox los datos de la lista
            cbCities.Items.Clear();
            cbCities.DisplayMember = "name";
            cbCities.ValueMember = "idCity";
            cbCities.DataSource = currentListCity;
        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            currentListService =CService.getServicesLike(txtSearchService.Text.Trim().ToString());
            ServicesBindingSource.DataSource = null;
            ServicesBindingSource.DataSource = currentListService;
            dgvServices.Refresh();
        }

        private void txtPBooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número, un punto o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no cumple con las condiciones anteriores, cancelar el evento KeyPress
                e.Handled = true;
            }
        }

        private void txtPPublicado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número, un punto o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no cumple con las condiciones anteriores, cancelar el evento KeyPress
                e.Handled = true;
            }

        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentService = new Service();
            int id = Convert.ToInt32(dgvServices.CurrentRow.Cells[0].Value);
            currentService = currentListService.Find(x=>x.idService == id);
            lblServicio.Text = currentService.nameService.ToString();
        }

        private void txtPConfidencial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPBooking_KeyDown(object sender, KeyEventArgs e)
        {
            Validartxt(sender,e);
        }
        private void Validartxt(object sender, KeyEventArgs e)
        {
            // Obtener el carácter presionado por el usuario
            char pressedKey = (char)e.KeyCode;

            // Verificar si la tecla presionada es la tecla DEL o la tecla Suprimir
            if (e.KeyCode == Keys.Delete && txtPConfidencial.SelectionStart < txtPConfidencial.Text.Length)
            {
                // Si se presiona la tecla DEL y hay caracteres después del cursor, eliminar el carácter después del cursor
                string currentText = txtPConfidencial.Text;
                int selectionStart = txtPConfidencial.SelectionStart;
                currentText = currentText.Remove(selectionStart, 1);

                // Validar el texto usando la expresión regular
                if (!Regex.IsMatch(currentText, regexPattern))
                {
                    // Si el texto no coincide con el patrón, cancelar el evento KeyDown
                    e.Handled = true;
                }
            }
        }

        private void txtPConfidencial_KeyDown(object sender, KeyEventArgs e)
        {
            Validartxt(sender, e);
        }

        private void txtPPublicado_KeyDown(object sender, KeyEventArgs e)
        {
            Validartxt(sender, e);
        }
        public bool ValidateFieldsAll()
        {
            if (txtNameHotel.Text == string.Empty || txtPhoneMobil.Text == string.Empty || txtEmailHotel.Text == string.Empty)
            {
                
                return false;
            }
            if (currentListHotelServiceWithName.Count <= 0)
            {
                
                return false;
            }
            return true;
        }
        private void clearFilds()
        {
            txtPBooking.Clear();
            txtPConfidencial.Clear();
            txtPPublicado.Clear();  
        }
        private void clearFieldsHotel()
        {
            txtNameHotel.Clear();
            txtDirectionHotel.Clear();
            txtEmailHotel.Clear();
            txtPhone.Clear();
            txtPhoneMobil.Clear();
            txtDescription.Clear();
            currentListHotelServiceWithName.Clear();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool respuesta = false;
            //validar campos
            if( !ValidateFieldsAll())
            {
                MessageBox.Show("Hay campos necesarios que estan vacios", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //preparar Hotel
            currentHotel.nameHotel = txtNameHotel.Text;
            currentHotel.phoneNumber = txtPhone.Text;
            currentHotel.mobileNumber = txtPhoneMobil.Text;
            currentHotel.email = txtEmailHotel.Text;
            currentHotel.address = txtDirectionHotel.Text;
            currentHotel.statusHotel = 1;
            currentHotel.descriptionHotel = txtDescription.Text;
            currentHotel.idCity = (int)cbCities.SelectedValue;

            //prepar servcios del hotel
            List<HotelService> listaServicios = currentListHotelServiceWithName.Select(hsn => new HotelService
            {
                dateCreated = System.DateTime.Now,
                dateUpdate = System.DateTime.Now,
                idService = hsn.idService,
                nameService = hsn.nameService,
                priceConfidencial = hsn.priceConfidencial,
                pricePublic = hsn.pricePublic,
                priceBooking = hsn.priceBooking
            }).ToList();

            //guardar Todo
            respuesta = CHotel.createHotelWithServices(currentHotel, listaServicios);
            MessageBox.Show(respuesta.ToString());
            clearFieldsHotel();
        }
        
    }
}
