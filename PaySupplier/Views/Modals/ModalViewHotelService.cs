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
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PaySupplier.Views.Modals
{
    public partial class ModalViewHotelService : Form
    {
        private List<HotelServiceWithName> currentListHotelServiceWithName = new List<HotelServiceWithName>();
        private List<HotelService> currentListHotelService = new List<HotelService>();
        public HotelServiceWithName currentHotelServiceWithName = new HotelServiceWithName();
        public List<Service> currentListService = new List<Service>();
        private List<City> currentListCity = new List<City>();
        private Hotel currentHotel =  new Hotel();
        public Service currentService;
        string regexPattern = @"^[0-9]*(?:\.[0-9]*)?$";
        private bool EsNuevo = false;
        private int idHotel = 0;
        public ModalViewHotelService()
        {
            InitializeComponent();
            EsNuevo = true;
        }
        public ModalViewHotelService(int idHotel)
        {
            InitializeComponent();
            this.EsNuevo = false;
            this.idHotel = idHotel;
        }

        private void ModalViewHotelService_Load(object sender, EventArgs e)
        {
            ChargeListCity();
            if (!EsNuevo)
            {
                ChargeData();
            }
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
            setCountItems();
        }
        private void pxAgregar_Click(object sender, EventArgs e)
        {
            //comprobar dato repetido           

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
            //-- Comprobar datos repetidos
            bool response = false;
            response = currentListHotelServiceWithName.Any(h => h.idService == currentService.idService);
            if (response == true)
            {
                DialogResult res = MessageBox.Show("El elemento ya esta agregado se va a Editar", "Pay Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(res != DialogResult.OK)
                {
                    return;
                }
                currentHotelServiceWithName = currentListHotelServiceWithName.Find(x => x.idService == currentService.idService);
                currentHotelServiceWithName.priceConfidencial = Convert.ToDecimal(txtPConfidencial.Text.Trim());
                currentHotelServiceWithName.priceBooking = Convert.ToDecimal(txtPBooking.Text.Trim());
                currentHotelServiceWithName.pricePublic = Convert.ToDecimal(txtPPublicado.Text.Trim());
                ActualizarDatos();
                clearFilds();
                setCountItems();
                return;
            }
            currentListHotelServiceWithName.Add(auxHotelService);
            ActualizarDatos();
            clearFilds();
            setCountItems();
        }
        public void setCountItems()
        {
            int countItems = currentListHotelServiceWithName.Count;
            lblTotal.Text = countItems.ToString();
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
            hotelServiceWithNameBindingSource.DataSource = null;
            hotelServiceWithNameBindingSource.DataSource = currentListHotelServiceWithName;
            dgvHotelServices.Refresh();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                //Para editar datos 
            if (!EsNuevo)
            {
                //-- Aqui todo para actualizar los datos
                //primero se actualizan los datos del Hotel
                //preparar Hotel
                currentHotel.nameHotel = txtNameHotel.Text;
                currentHotel.phoneNumber = txtPhone.Text;
                currentHotel.mobileNumber = txtPhoneMobil.Text;
                currentHotel.email = txtEmailHotel.Text;
                currentHotel.address = txtDirectionHotel.Text;
                currentHotel.descriptionHotel = txtDescription.Text;
                currentHotel.idCity = (int)cbCities.SelectedValue;
                currentHotel.categoryHotel = cbCategoriesHotel.Text.ToString();
                //prepar servcios del hotel
                foreach (var auxHotelServiceWithName in currentListHotelServiceWithName) //lista de hoteles en dgv
                {
                    int idServiceAux = auxHotelServiceWithName.idService;
                    HotelService auxHService = new HotelService();
                    auxHService = currentListHotelService.Find(x=>x.idService == idServiceAux);
                    if (auxHService != null)
                    {
                        auxHService.dateUpdate = System.DateTime.Now;
                        auxHService.pricePublic = auxHotelServiceWithName.pricePublic;
                        auxHService.priceConfidencial = auxHotelServiceWithName.priceConfidencial;
                        auxHService.priceBooking = auxHotelServiceWithName.priceBooking;
                    }
                    else
                    {
                        auxHService.dateCreated = System.DateTime.Now;
                        auxHService.dateUpdate = System.DateTime.Now;
                        auxHService.idService = auxHotelServiceWithName.idService;
                        auxHService.nameService = auxHotelServiceWithName.nameService;
                        auxHService.priceConfidencial = auxHotelServiceWithName.priceConfidencial;
                        auxHService.pricePublic = auxHotelServiceWithName.pricePublic;
                        auxHService.priceBooking  = auxHotelServiceWithName.priceBooking;
                        auxHService.idHotelServices = 0;
                        auxHService.idHotels = currentHotel.idHotels;
                        currentListHotelService.Add(auxHService);
                    }
                }                
                DialogResult Dl = MessageBox.Show("¿Estás segur@ de Actualizar?", "Pay Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Dl == DialogResult.OK)
                {

                    bool resHotel = CHotel.updateAllHotelAndServices(currentHotel, currentListHotelService);
                    if (resHotel) // se guardó correctamente el Hotel
                    {
                        MessageBox.Show("Se guardó correctamente", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
                
                //--
                return;
            }
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
            currentHotel.categoryHotel = cbCategoriesHotel.Text.ToString();

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
            DialogResult saveAll = MessageBox.Show("¿Estás segur@ de guardar?", "Pay Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (saveAll == DialogResult.OK)
            {
                respuesta = CHotel.createHotelWithServices(currentHotel, listaServicios);
                if (respuesta)
                {
                    MessageBox.Show("Se guardó correctamente", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Guardar", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }        
            clearFieldsHotel();
            setCountItems();
        }

        #region Editar Hotel
        public void ChargeData()
        {
            GetHotel();
            GetAllHotelServices();
            SetDataFields();
            setCountItems();
        }
        public void GetHotel()
        {
            currentHotel = CHotel.getHotel(idHotel.ToString());
            if (currentHotel == null)
            {
                MessageBox.Show("Error al obtener el Hotel", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void GetAllHotelServices()
        {
            currentListHotelService = CHotelServices.getHotelServiceByIdHotel(idHotel);
            if (currentListHotelService == null)
            {
                MessageBox.Show("Error al obtener los servicios", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentListHotelServiceWithName = currentListHotelService
            .Select(hs => new HotelServiceWithName
            {
                idService = hs.idService,
                nameService = hs.nameService,
                priceConfidencial = hs.priceConfidencial,
                pricePublic = hs.pricePublic,
                priceBooking = hs.priceBooking
            })
            .ToList();
        }
        public void SetDataFields()
        {
            // para el hotel
            txtNameHotel.Text = currentHotel.nameHotel;
            txtDirectionHotel.Text = currentHotel.address;
            txtEmailHotel.Text = currentHotel.email;
            txtPhoneMobil.Text = currentHotel.mobileNumber;
            txtPhone.Text = currentHotel.phoneNumber;
            txtDescription.Text = currentHotel.descriptionHotel;
            cbCities.SelectedValue = currentHotel.idCity;
            cbCategoriesHotel.Text = currentHotel.categoryHotel;

            if (currentListHotelServiceWithName == null)
            {
                MessageBox.Show("La lista esta vacia", "Pay Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hotelServiceWithNameBindingSource.DataSource = null;
            hotelServiceWithNameBindingSource.DataSource = currentListHotelServiceWithName;
            dgvHotelServices.Refresh();
        }
        #endregion

        private void dgvHotelServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idServiceAux = Convert.ToInt32(dgvHotelServices.CurrentRow.Cells[0].Value);
                currentHotelServiceWithName = currentListHotelServiceWithName.Find(x=>x.idService == idServiceAux);
                txtPBooking.Text = currentHotelServiceWithName.priceBooking.ToString();
                txtPConfidencial.Text = currentHotelServiceWithName.priceConfidencial.ToString();
                txtPPublicado.Text = currentHotelServiceWithName.pricePublic.ToString();
                //dar como actual servicio
                currentService = new Service();
                currentService.idService = currentHotelServiceWithName.idService;
                currentService.nameService = currentHotelServiceWithName.nameService;
                lblServicio.Text = currentService.nameService;              
            }
        }
    }
}
