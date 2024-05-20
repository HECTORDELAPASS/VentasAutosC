using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class busquedavendedor
    {
        private string query;
        public string idvendedor, nombrevendedor;

        public busquedavendedor()
        {
            InitializeComponent();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (Rdid.Checked)
            {
                query = "select id, nombre from vendedor where id like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (RdNombre.Checked)
            {
                query = "select id, nombre from vendedor where nombre like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

        }
        private void busquedavendedor_Load(object sender, EventArgs e)
        {
            RdNombre.Checked = true;
            txtbuscar.Text = My.MyProject.Forms.Infor.vendedortxt.Text;
        }



        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idvendedor = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                nombrevendedor = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Infor.vendedortxt.Text = nombrevendedor;
                My.MyProject.Forms.Infor.idvendedor = Conversions.ToInteger(idvendedor);
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Si deseas seleccionar el vendedor, Double Click sobre la fila");
            }
        }
    }
}