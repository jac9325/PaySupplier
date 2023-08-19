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
        private void AjustarPanelSegunCelda()
        {
            /*int columnIndex = 9; // Cambia esto al índice de columna deseado
            Rectangle headerRect = dgvHotels.GetColumnDisplayRectangle(columnIndex, true);
            Point headerLocation = headerRect.Location;
            pRedInitial.Location = headerLocation;
            pRedInitial.Size = new Size(headerRect.Width, headerRect.Height);
            //--ahora para el tamaño
            int[] selectedColumns = { 9, 10, 11 }; // Cambia esto a los índices de las columnas deseadas

            int totalWidth = 0;
            foreach (int columnInd in selectedColumns)
            {
                if (columnIndex >= 0 && columnInd < dgvHotels.Columns.Count)
                {
                    totalWidth += dgvHotels.Columns[columnInd].Width;
                }
            }
            if (totalWidth > 0)
            {
                pRedInitial.Size = new Size(totalWidth, pRedInitial.Height);
            }
            //-- para la habitacion doble
            int columnIndex2 = 14; // Cambia esto al índice de columna deseado
            Rectangle headerRect2 = dgvHotels.GetColumnDisplayRectangle(columnIndex2, true);
            Point headerLocation2 = headerRect2.Location;
            pHDoble.Location = headerLocation2;
            pHDoble.Size = new Size(headerRect2.Width, headerRect2.Height);
            //--ahora para el tamaño
            int[] selectedColumns2 = { 14, 15, 16 }; // Cambia esto a los índices de las columnas deseadas

            int totalWidth2 = 0;
            foreach (int columnInd2 in selectedColumns2)
            {
                if (columnIndex2 >= 0 && columnInd2 < dgvHotels.Columns.Count)
                {
                    totalWidth2 += dgvHotels.Columns[columnInd2].Width;
                }
            }
            if (totalWidth2 > 0)
            {
                pHDoble.Size = new Size(totalWidth2, pHDoble.Height);
            }

            //-- para la habitacion triple
            int columnIndex3 = 19; // Cambia esto al índice de columna deseado
            Rectangle headerRect3 = dgvHotels.GetColumnDisplayRectangle(columnIndex3, true);
            Point headerLocation3 = headerRect3.Location;
            pHTriple.Location = headerLocation3;
            pHTriple.Size = new Size(headerRect3.Width, headerRect3.Height);
            //--ahora para el tamaño
            int[] selectedColumns3 = { 19, 20, 21 }; // Cambia esto a los índices de las columnas deseadas

            int totalWidth3 = 0;
            foreach (int columnInd3 in selectedColumns3)
            {
                if (columnIndex3 >= 0 && columnInd3 < dgvHotels.Columns.Count)
                {
                    totalWidth3 += dgvHotels.Columns[columnInd3].Width;
                }
            }
            if (totalWidth3 > 0)
            {
                pHTriple.Size = new Size(totalWidth3, pHTriple.Height);
            }*/
        }

        private void dgvHotels_SizeChanged(object sender, EventArgs e)
        {
            AjustarPanelSegunCelda();
        }
    }
}
