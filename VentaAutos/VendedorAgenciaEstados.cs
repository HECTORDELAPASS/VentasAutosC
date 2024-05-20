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

    public partial class VendedorAgenciaEstados
    {
        private string query, nombre;
        private DataTable dt;
        public int EliminarActualizar = 0;
        private SqlCommand cmd;
        public int eleccion, rows;

        public VendedorAgenciaEstados()
        {
            InitializeComponent();
        }
        private void VendedorAgenciaEstados_Load(object sender, EventArgs e)
        {
            DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240);

            if (My.MyProject.Forms.MenuOpciones.Boton == 1)
            {
                Lb1.Text = "Informacion Vendedores";
                lb2.Text = "Buscar Vendedor";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 2)
            {
                Lb1.Text = "Informacion Agencias";
                lb2.Text = "Buscar Agencia";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 3)
            {
                Lb1.Text = "Informacion Estados";
                lb2.Text = "Buscar Estado";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 4)
            {
                Lb1.Text = "Informacion Carrocerias";
                lb2.Text = "Buscar Carroceria";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 5)
            {
                Lb1.Text = "Informacion Modelos de Vehiculos";
                lb2.Text = "Buscar Modelo";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 6)
            {
                Lb1.Text = "Informacion de Variantes de Vehiculos";
                lb2.Text = "Buscar Variante";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 7)
            {
                Lb1.Text = "Informacion de Transmisiónes de Vehiculos";
                lb2.Text = "Buscar Transmisión";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 8)
            {
                Lb1.Text = "Informacion de Interiores de Vehiculos";
                lb2.Text = "Buscar Interior de Vehiculos";
                filtro();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 9)
            {
                Lb1.Text = "Informacion de Colores de Vehiculos";
                lb2.Text = "Buscar Colores de Vehiculos";
                filtro();
            }


        }
        private void formatotabla()
        {
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.Columns[0].FillWeight = 0.4f;
            DataGridView1.Columns[1].FillWeight = 2f;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        public void filtro()
        {
            if (My.MyProject.Forms.MenuOpciones.Boton == 1)
            {
                query = "select id, nombre from vendedor where estatus = 1 and nombre like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 2)
            {
                query = "select id, nombre from agencia where estatus = 1 and nombre like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 3)
            {
                query = "select id, nombreestado as [nombre de estado] from estado where estatus = 1 and nombreestado like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 4)
            {
                query = "select id, nombre from carroceria where estatus = 1 and nombre like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 5)
            {
                query = "select id, nombre from modelo where estatus = 1 and nombre like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 6)
            {
                query = "select id, nombre from variante where estatus = 1 and nombre like '%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 7)
            {
                query = "select id, nombre from trasmicion where estatus = 1 and nombre like'%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 8)
            {
                query = "select id, nombre from interior where estatus = 1 and nombre like'%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 9)
            {
                query = "select id, nombre from colores where estatus = 1 and nombre like'%" + txtbuscar.Text + "%'";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            formatotabla();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.MenuOpciones.Boton == 1)
            {
                agregarvendedor();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 2)
            {
                agregaragencia();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 3)
            {
                agregarestado();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 4)
            {
                AgregarCarroceria();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 5)
            {
                AgregarModelo();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 6)
            {
                AgregarVariante();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 7)
            {
                AgregarTransmisión();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 8)
            {
                AgregarInterior();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 9)
            {
                AgregarColor();
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.MenuOpciones.Boton == 1)
            {
                actualizarvendedor();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 2)
            {
                actualizaragencia();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 3)
            {
                actualizarestado();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 4)
            {
                ActualizarCarroceria();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 5)
            {
                ActualizarModelo();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 6)
            {
                ActualizarVariante();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 7)
            {
                ActualizarTransmisión();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 8)
            {
                ActualizarInterior();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 9)
            {
                ActualizarColor();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.MenuOpciones.Boton == 1)
            {
                Eliminarvendedor();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 2)
            {
                EliminarAgencia();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 3)
            {
                EliminarEstado();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 4)
            {
                EliminarCarroceria();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 5)
            {
                EliminarModelo();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 6)
            {
                EliminarVariante();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 7)
            {
                EliminarTransmisión();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 8)
            {
                EliminarInterior();
            }
            else if (My.MyProject.Forms.MenuOpciones.Boton == 9)
            {
                EliminarColor();
            }
        }
        private void agregarvendedor()
        {
            eleccion = 1;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void actualizarvendedor()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 1;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void Eliminarvendedor()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar al vendedor seleccionado" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "spborrarvendededor");

                    query = "select estatus from vendedor where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Vendedor borrado correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar vendedor" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void agregaragencia()
        {
            eleccion = 2;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void actualizaragencia()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 2;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarAgencia()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar la agencia seleccionada" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "spborraragencia");

                    query = "select estatus from agencia where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Agencia borrada correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar la Agencia" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void agregarestado()
        {
            eleccion = 3;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void actualizarestado()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 3;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarEstado()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar el estado seleccionado" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "spBorrarEstado");

                    query = "select estatus from estado where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Estado borrado correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar el Estado" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void AgregarCarroceria()
        {
            eleccion = 4;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void ActualizarCarroceria()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 4;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarCarroceria()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar la carroceria seleccionada" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idCarrociera", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "SpBorrarCarroceria");

                    query = "select estatus from carroceria where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Carroceria borrada correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar la carroceria" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        // '''''''''''''''''''''
        private void AgregarModelo()
        {
            eleccion = 5;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void ActualizarModelo()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 5;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarModelo()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar el modelo seleccionado" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "SpBorrarModelo");

                    query = "select estatus from modelo where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Modelo borrado correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar el Modelo" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        // ''''''''''''''''''
        private void AgregarVariante()
        {
            eleccion = 6;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void ActualizarVariante()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 6;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarVariante()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar La variante seleccionada" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "SpBorrarVariante");

                    query = "select estatus from variante where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Variante borrada correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar la Variante" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        // ''''''''''''''''''
        private void AgregarTransmisión()
        {
            eleccion = 7;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void ActualizarTransmisión()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 7;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarTransmisión()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar La Transmision seleccionada" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idTransmision", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "SpBorrarTransmision");

                    query = "select estatus from trasmicion where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Transmision borrada correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar la Transmision" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        // ''''''''''''''''''
        private void AgregarInterior()
        {
            eleccion = 8;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void ActualizarInterior()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 8;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarInterior()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar El Interior de vehiculo seleccionado" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idInterior", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "SpBorrarInterior");

                    query = "select estatus from interior where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Interior de vehiculo borrado correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar El Interior de vehiculo" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        // ''''''''''''''''''
        private void AgregarColor()
        {
            eleccion = 9;
            My.MyProject.Forms.AgregarVendAgencYEdo.Show();
        }
        private void ActualizarColor()
        {
            if (EliminarActualizar != 0)
            {
                eleccion = 9;
                My.MyProject.Forms.ActualizarVendAgencEdp.Show();
            }
        }
        private void EliminarColor()
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar El color de vehiculo seleccionado" + Constants.vbCrLf + "Id:" + EliminarActualizar + " Nombre:" + nombre + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "SpBorrarColores");

                    query = "select estatus from colores where id = '" + EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Color de vehiculo borrado correctamente");
                        filtro();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar El color de vehiculo" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EliminarActualizar = Conversions.ToInteger(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                nombre = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[1].Value);
            }
            catch (Exception ex)
            {

            }

        }


        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (My.MyProject.Forms.VehiculoAgregarActualizar.busquedadevehiculos)
            {
                try
                {
                    My.MyProject.Forms.VehiculoAgregarActualizar.busquedadevehiculos = false;
                    rows = Conversions.ToInteger(DataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    if (My.MyProject.Forms.MenuOpciones.Boton == 2)
                    {
                        query = "select nombre from agencia where id = " + rows;
                        dt = Connection.SelectQuery(query);

                        My.MyProject.Forms.VehiculoAgregarActualizar.idagencia = rows;
                        My.MyProject.Forms.VehiculoAgregarActualizar.txtagencia.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                    }

                    else if (My.MyProject.Forms.MenuOpciones.Boton == 4)
                    {
                        query = "select nombre from carroceria where id = " + rows;
                        dt = Connection.SelectQuery(query);

                        My.MyProject.Forms.VehiculoAgregarActualizar.idcarroceria = rows;
                        My.MyProject.Forms.VehiculoAgregarActualizar.txtcarroceria.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                    }

                    else if (My.MyProject.Forms.MenuOpciones.Boton == 5)
                    {
                        query = "select nombre from modelo where id = " + rows;
                        dt = Connection.SelectQuery(query);

                        My.MyProject.Forms.VehiculoAgregarActualizar.idmodelo = rows;
                        My.MyProject.Forms.VehiculoAgregarActualizar.txtModelo.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                    }

                    else if (My.MyProject.Forms.MenuOpciones.Boton == 6)
                    {
                        query = "select nombre from variante where id = " + rows;
                        dt = Connection.SelectQuery(query);

                        My.MyProject.Forms.VehiculoAgregarActualizar.idvariante = rows;
                        My.MyProject.Forms.VehiculoAgregarActualizar.txtvariante.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                    }

                    else if (My.MyProject.Forms.MenuOpciones.Boton == 7)
                    {
                        query = "select nombre from trasmicion where id = " + rows;
                        dt = Connection.SelectQuery(query);

                        My.MyProject.Forms.VehiculoAgregarActualizar.idtransmision = rows;
                        My.MyProject.Forms.VehiculoAgregarActualizar.txtTransmision.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                    }

                    else if (My.MyProject.Forms.MenuOpciones.Boton == 8)
                    {
                        query = "select nombre from interior where id = " + rows;
                        dt = Connection.SelectQuery(query);

                        My.MyProject.Forms.VehiculoAgregarActualizar.idinterior = rows;
                        My.MyProject.Forms.VehiculoAgregarActualizar.TxtInterior.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                    }

                    else if (My.MyProject.Forms.MenuOpciones.Boton == 9)
                    {
                        query = "select nombre from colores where id = " + rows;
                        dt = Connection.SelectQuery(query);

                        My.MyProject.Forms.VehiculoAgregarActualizar.idcolor = rows;
                        My.MyProject.Forms.VehiculoAgregarActualizar.TxtColor.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    }

                    Close();
                }

                catch (Exception ex)
                {
                    Interaction.MsgBox("Para Extraer informacion doble click sobre celdas validas");
                }
            }
        }

        private void VendedorAgenciaEstados_Closed(object sender, EventArgs e)
        {
            My.MyProject.Forms.VehiculoAgregarActualizar.busquedadevehiculos = false;
        }
    }
}