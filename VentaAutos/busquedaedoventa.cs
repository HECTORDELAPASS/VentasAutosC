using System;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{
    public partial class busquedaedoventa
    {
        private string query;
        public string NomEdo, IdEdo;

        public busquedaedoventa()
        {
            InitializeComponent();
        }
        private void busquedaedoventa_Load(object sender, EventArgs e)
        {
            RdNombre.Checked = true;
            txtbuscar.Text = My.MyProject.Forms.Infor.Edtxt.Text;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            ListId.Items.Clear();
            ListEdo.Items.Clear();

            if (Rdid.Checked)
            {
                query = "select id, nombreestado from estado where id like '%" + txtbuscar.Text + "%'";
            }

            else if (RdNombre.Checked)
            {
                query = "select id, nombreestado from estado where nombreestado  like '%" + txtbuscar.Text + "%'";
            }
            var dt = Connection.SelectQuery(query);

            for (int h = 0, loopTo = dt.Rows.Count - 1; h <= loopTo; h++)
            {
                ListId.Items.Add(dt.AsEnumerable().ElementAtOrDefault(h)[0]);
                ListEdo.Items.Add(dt.AsEnumerable().ElementAtOrDefault(h)[1]);
            }

        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListEdo.SelectedIndex = ListId.SelectedIndex;
        }

        private void ListEdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListId.SelectedIndex = ListEdo.SelectedIndex;
        }

        private void ListId_DoubleClick(object sender, EventArgs e)
        {
            NomEdo = ListEdo.SelectedItem.ToString();
            IdEdo = ListId.SelectedItem.ToString();
            try
            {
                My.MyProject.Forms.Infor.Edtxt.Text = NomEdo;
                My.MyProject.Forms.Infor.idedoventa = Conversions.ToInteger(IdEdo);
                Close();
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Si deseas seleccionar el estado de venta, Double Click sobre la fila");
            }
        }

        private void ListEdo_DoubleClick(object sender, EventArgs e)
        {
            NomEdo = ListEdo.SelectedItem.ToString();
            IdEdo = ListId.SelectedItem.ToString();
            try
            {
                My.MyProject.Forms.Infor.Edtxt.Text = NomEdo;
                My.MyProject.Forms.Infor.idedoventa = Conversions.ToInteger(IdEdo);
                Close();
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Si deseas seleccionar el estado de venta, Double Click sobre la fila");
            }
        }
    }
}