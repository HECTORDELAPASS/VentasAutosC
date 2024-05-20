using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class Form1
    {
        public string rows;
        private string query;
        private bool auto, filtradoFecha;
        private int min, max, primero, segundo;
        public bool pantallamasinfo, NuevaVenta;

        public Form1()
        {

            // This call is required by the designer.
            auto = true;
            InitializeComponent();

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240);

            query = "select id, nombreestado from estado order by nombreestado";
            CboEdo.DataSource = Connection.SelectQuery(query);
            CboEdo.DisplayMember = "NombreEstado";
            CboEdo.ValueMember = "id";
            auto = false;

        }

        private void CboEdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auto)
            {
                return;
            }
            query = Conversions.ToString(Operators.ConcatenateObject("SELECT * FROM vwbuscaedo WHERE idestado = ", CboEdo.SelectedValue));

            CboAgen.DataSource = Connection.SelectQuery(query);
            CboAgen.DisplayMember = "nombre";
            CboAgen.ValueMember = "id";
            filtrar();
            actualizayear();

            filtradoFecha = false;

        }

        private void CboAgen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auto)
            {
                return;
            }
            if (CboEdo.Text is null)
            {
                return;
            }
            query = "select * from VWBusquedaCarro where [Nombre Agencia] = '" + CboAgen.Text + "' and [Estado De Venta] = '" + CboEdo.Text + "'";
            DataGridView1.DataSource = Connection.SelectQuery(query);
            llenadoyear();
            filtrar();

        }
        private void filtrar()
        {

            if (filtradoFecha & R1.Checked)
            {
                query = "select * from VWBusquedaCarro where [Nombre De carro] like '%" + txtbuscar.Text + "%' and [Estado De Venta]  = '" + CboEdo.Text + "' and [Año de carro] BETWEEN " + primero.ToString() + " And " + segundo.ToString() + " order by [Año de carro] asc";
                DataGridView1.DataSource = Connection.SelectQuery(query);
                // ''''''''''''''''''
                actualizayear();
            }

            else
            {
                if (string.IsNullOrEmpty(txtbuscar.Text))
                {
                    return;
                }
                query = "select * from VWBusquedaCarro where [Nombre De carro] like '%" + txtbuscar.Text + "%' and [Estado De Venta]  = '" + CboEdo.Text + "'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
                // ''''''''''''''''''
                actualizayear();
            }

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (auto | CboAgen.Text is null)
            {
                return;
            }
            filtrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            CboEdo.DropDownStyle = ComboBoxStyle.DropDownList;
            CboAgen.DropDownStyle = ComboBoxStyle.DropDownList;
            R1.Checked = true;
        }
        private void llenadoyear()
        {
            actualizayear();
            CboYear.Items.Clear();
            double vueltas = Math.Ceiling((max - min) / 5d);
            int temporal = min;

            for (double h = 1d, loopTo = vueltas; h <= loopTo; h++)
            {
                CboYear.Items.Add(temporal + " - " + (temporal + 5));
                temporal += 5;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Infor.Show();
        }

        private void d_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            NuevaVenta = true;
            My.MyProject.Forms.Infor.Show();
            My.MyProject.Forms.tip.Show();
        }

        private void actualizayear()
        {
            try
            {
                query = "select min([Año de carro]) as [AñoMinimo], max([Año de carro]) as [AñoMaximo] from VWBusquedaCarro where [Nombre De carro] like '%" + txtbuscar.Text + "%' and [Estado De Venta]  = '" + CboEdo.Text + "'";
                DataTable dt;
                dt = Connection.SelectQuery(query);

                if (dt.Rows.Count > 0)
                {
                    min = Conversions.ToInteger(dt.Rows[0][0].ToString());
                    max = Conversions.ToInteger(dt.Rows[0][1].ToString());
                }
            }
            catch (Exception ex)
            {
                // MsgBox("Error al ejecutar la consulta: " & ex.Message)
                min = 0;
                max = 0;
            }

        }

        private void CboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filtradoFecha = true;

                primero = Conversions.ToInteger(CboYear.SelectedItem.substring(0, 4));
                segundo = Conversions.ToInteger(CboYear.SelectedItem.substring(7, 4));

                filtrar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al localizar las fechas");
            }

        }


        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pantallamasinfo = true;
            try
            {
                rows = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[6].Value);
                My.MyProject.Forms.Carga.Show();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Si deseas conocer mas informacion de la venta, Double Click sobre el modelo del carro");
            }

        }
    }
}