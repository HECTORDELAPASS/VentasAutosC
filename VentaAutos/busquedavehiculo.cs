using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class busquedavehiculo
    {
        private string query, nombre;
        public string modelo, agencias, año, carroceria, variante, colores, interior, transmicion, idcar, vincarro;
        private bool auto;
        private SqlCommand cmd;
        private DataTable dt;
        public int EliminarActualizar = 0;
        public int seleccion;

        private void pic3_Click(object sender, EventArgs e)
        {
            MsgBoxResult respuesta;
            if (EliminarActualizar == 0)
            {
                Interaction.MsgBox("Selecciona un vehiculo para eliminar");
                return;
            }
            respuesta = Interaction.MsgBox("Estas a punto de borrar El Vehiculo seleccionado" + Constants.vbCrLf + "Id:" + EliminarActualizar + Constants.vbCrLf + " Modelo:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idauto", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "SpBorrarAutos");

                    query = "select estatus from carro where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Vehiculo borrado correctamente");
                        actualizar();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar Vehiculo" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            seleccion = 1;
            My.MyProject.Forms.VehiculoAgregarActualizar.Show();
            My.MyProject.Forms.tip.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            if (EliminarActualizar != 0)
            {
                seleccion = 2;
                My.MyProject.Forms.VehiculoAgregarActualizar.Show();
                My.MyProject.Forms.tip.Show();
            }
            else
            {
                Interaction.MsgBox("Selecciona el vehiculo a actualizar");
            }

        }


        public busquedavehiculo()
        {

            // This call is required by the designer.
            auto = true;
            InitializeComponent();

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            query = "select nombre from agencia order by nombre asc";
            CboAgencia.DataSource = Connection.SelectQuery(query);
            CboAgencia.DisplayMember = "nombre";
            auto = false;

        }
        private void busquedavehiculo_Load(object sender, EventArgs e)
        {
            txt1.Text = "Busqueda Avanzada Codigo de vehiculo";

            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            lb1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;

            if (My.MyProject.Forms.MenuOpciones.cargarvehiculos)
            {
                pic1.Visible = true;
                pic2.Visible = true;
                pic3.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
                lb3.Visible = true;
                txt1.Text = "Informacion de Vehiculos";
            }

            DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240);
            rdvin.Checked = true;
            cboyear.DropDownStyle = ComboBoxStyle.DropDownList;
            CboAgencia.DropDownStyle = ComboBoxStyle.DropDownList;
            txtvin.Text = My.MyProject.Forms.Infor.vintxt.Text;

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (auto | cboyear.Text is null)
            {
                return;
            }
            actualizar();

        }
        private void actualizar()
        {
            if (!string.IsNullOrEmpty(txtbuscar.Text) & rdmodelo.Checked)
            {
                query = "select * from Vwcarros where [modelo] like '%" + txtbuscar.Text + "%' and [agencia] = '" + CboAgencia.Text + "' and [Año] = '" + cboyear.Text + "'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            if (!string.IsNullOrEmpty(txtvin.Text) & rdvin.Checked)
            {
                query = "select * from Vwcarros where [codigovehiculo] like '%" + txtvin.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
        }


        private void CboAgencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auto)
            {
                return;
            }
            auto = true;

            query = "select distinct [Año] from Vwcarros where agencia = '" + CboAgencia.Text + "'";
            cboyear.DataSource = Connection.SelectQuery(query);
            cboyear.DisplayMember = "Año";
            auto = false;
            actualizar();

        }
        private void cboyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auto)
            {
                return;
            }
            if (CboAgencia.Text is null)
            {
                return;
            }
            query = "select * from Vwcarros where [agencia] = '" + CboAgencia.Text + "' and [Año] = '" + cboyear.Text + "'";
            DataGridView1.DataSource = Connection.SelectQuery(query);

            actualizar();
        }

        private void txtvin_TextChanged(object sender, EventArgs e)
        {
            if (auto)
            {
                return;
            }
            actualizar();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (My.MyProject.Forms.MenuOpciones.cargarvehiculos)
            {
                return;
            }

            if (My.MyProject.Forms.Infor.nuevaventa)
            {
                try
                {
                    modelo = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    agencias = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    año = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    carroceria = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[6].Value);
                    variante = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    colores = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[8].Value);
                    interior = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[9].Value);
                    transmicion = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[7].Value);
                    vincarro = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    idcar = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    // ''''''''''''''''''''''''''''''
                    My.MyProject.Forms.Infor.modelotxt.Text = modelo;
                    My.MyProject.Forms.Infor.agentxt.Text = agencias;
                    My.MyProject.Forms.Infor.yeartxt.Text = año;
                    My.MyProject.Forms.Infor.txtcarroceria.Text = carroceria;
                    My.MyProject.Forms.Infor.Variatxt.Text = variante;
                    My.MyProject.Forms.Infor.colortxt.Text = colores;
                    My.MyProject.Forms.Infor.inttxt.Text = interior;
                    My.MyProject.Forms.Infor.trastxt.Text = transmicion;
                    My.MyProject.Forms.Infor.vintxt.Text = vincarro;
                    My.MyProject.Forms.Infor.idcarro = Conversions.ToInteger(idcar);
                    Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Si deseas seleccionar el Vehiculo, Double Click sobre la fila");
                }
            }

            else
            {
                try
                {
                    idcar = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    vincarro = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    My.MyProject.Forms.Infor.vintxt.Text = vincarro;
                    My.MyProject.Forms.Infor.idcarro = Conversions.ToInteger(idcar);
                    Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Si deseas seleccionar el Vehiculo, Double Click sobre la fila");
                }
            }

        }

        private void busquedavehiculo_Closed(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.cargarvehiculos = false;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EliminarActualizar = Conversions.ToInteger(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                nombre = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[4].Value);
            }
            catch (Exception ex)
            {

            }
        }

    }
}