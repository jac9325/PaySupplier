using PaySupplier.Controllers;
using PaySupplier.Models;
using PaySupplier.Views.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PaySupplier.Views
{
    public partial class ViewHotel : Form
    {
        
        List<Hotel> currentListHotel = new List<Hotel>();
        List<HotelDGV> currentHotelDGV = new List<HotelDGV>();
        public ViewHotel()
        {
            InitializeComponent();
        }

        private void bntNewHotel_Click(object sender, EventArgs e)
        {
            ModalViewHotelService modalViewHotelService = new ModalViewHotelService();
            modalViewHotelService.ShowDialog();
            Reload();
        }

        private void ViewHotel_Load(object sender, EventArgs e)
        {
            Reload();
        }
        /* Metodos de Proceso */
        public void Reload()
        {
            GetHotelAllData();   
        }
        public void GetHotelAllData()
        {
            currentHotelDGV = CHotel.getHotelAllData();
            HotelsBindingSource.DataSource = null;
            HotelsBindingSource.DataSource = currentHotelDGV;
            dgvHotels.Refresh();
        }

        private void dgvHotels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvHotels_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int rowIndex = 0;
            if (e.RowIndex == rowIndex)
            {
                // Establece el alto deseado para la fila
                int desiredHeight = 30; // Cambia esto al alto que desees
                dgvHotels.Rows[e.RowIndex].Height = desiredHeight;
            }
        }

        private void txtSearchHotel_TextChanged(object sender, EventArgs e)
        {
            string textHotel = txtSearchHotel.Text.Trim().ToString();
            currentListHotel = CHotel.getHotelLike(textHotel);
            HotelsBindingSource.DataSource = null;
            HotelsBindingSource.DataSource = currentListHotel;
            dgvHotels.Refresh();
        }

        private void dgvHotels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //para editar un hotel
            if (e.ColumnIndex == dgvHotels.Columns[1].Index && e.RowIndex >= 0)
            {
                int idHotel = Convert.ToInt32(dgvHotels.CurrentRow.Cells[0].Value);
                ModalViewHotelService modalViewHotelService = new ModalViewHotelService(idHotel);
                modalViewHotelService.ShowDialog();
                
            }
        }
    }
}
