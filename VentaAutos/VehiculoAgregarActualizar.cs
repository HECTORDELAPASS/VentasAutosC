using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class VehiculoAgregarActualizar
    {
        private DataTable dt;
        private SqlCommand cmd;
        private string query;
        public bool busquedadevehiculos = false;
        public int idagencia, idmodelo, idvariante, idcarroceria, idtransmision, idcolor, idinterior;

        public VehiculoAgregarActualizar()
        {
            InitializeComponent();
        }
        private void VehiculoAgregarActualizar_Load(object sender, EventArgs e)
        {
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.CustomFormat = "yyyy";


            if (My.MyProject.Forms.busquedavehiculo.seleccion == 1)
            {
                Lb1.Text = "Agregar Nuevo Vehiculo";
            }
            else if (My.MyProject.Forms.busquedavehiculo.seleccion == 2)
            {
                Lb1.Text = "Actualizar Vehiculo";

                query = "select * from VwCarrosIds where id =" + My.MyProject.Forms.busquedavehiculo.EliminarActualizar;
                dt = Connection.SelectQuery(query);

                idmodelo = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                txtModelo.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[1]);
                idagencia = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[2]);
                txtagencia.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[3]);
                idvariante = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[4]);
                txtvariante.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[5]);
                idcarroceria = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[6]);
                txtcarroceria.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[7]);
                idtransmision = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[8]);
                txtTransmision.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[9]);
                idcolor = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[10]);
                TxtColor.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[11]);

                idinterior = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[12]);
                TxtInterior.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[13]);
                txtVin.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[14]);
                DateTimePicker1.Text = Conversions.ToString(Operators.ConcatenateObject(dt.AsEnumerable().ElementAtOrDefault(0)[15], "-01-01"));


            }

            txtModelo.ReadOnly = true;
            txtagencia.ReadOnly = true;
            txtvariante.ReadOnly = true;
            txtcarroceria.ReadOnly = true;
            txtTransmision.ReadOnly = true;
            TxtColor.ReadOnly = true;
            TxtInterior.ReadOnly = true;
        }

        private void btbuscarvendedor_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.Boton = 5;
            busquedadevehiculos = true;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.Boton = 2;
            busquedadevehiculos = true;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.Boton = 6;
            busquedadevehiculos = true;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.Boton = 4;
            busquedadevehiculos = true;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.Boton = 7;
            busquedadevehiculos = true;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.Boton = 9;
            busquedadevehiculos = true;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MenuOpciones.Boton = 8;
            busquedadevehiculos = true;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.busquedavehiculo.seleccion == 1)
            {
                agregarvehiculo();
            }
            else if (My.MyProject.Forms.busquedavehiculo.seleccion == 2)
            {
                actualizarvehiculo();
            }

        }
        private void agregarvehiculo()
        {
            if (string.IsNullOrEmpty(txtModelo.Text) | string.IsNullOrEmpty(txtagencia.Text) | string.IsNullOrEmpty(txtvariante.Text) | string.IsNullOrEmpty(txtcarroceria.Text) | string.IsNullOrEmpty(txtTransmision.Text) | string.IsNullOrEmpty(TxtColor.Text) | string.IsNullOrEmpty(TxtInterior.Text) | string.IsNullOrEmpty(txtVin.Text) | string.IsNullOrEmpty(DateTimePicker1.Text))
            {

                Interaction.MsgBox("Faltan campor por rellenar");
                return;

            }

            query = "SELECT IDENT_CURRENT('carro')+1";
            dt = Connection.SelectQuery(query);
            int siguienteid = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Se agregara un nuevo Vehiculo" + Constants.vbCrLf + "Deseas Continuar ?" + Constants.vbCrLf, MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@year", SqlDbType.DateTime).Value = DateTimePicker1.Text + "-01-01";
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtVin.Text;
                    cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = idagencia;

                    cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = idmodelo;
                    cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = idvariante;
                    cmd.Parameters.Add("@idcarroceria", SqlDbType.Int).Value = idcarroceria;

                    cmd.Parameters.Add("@idtransmicion", SqlDbType.Int).Value = idtransmision;
                    cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = idcolor;
                    cmd.Parameters.Add("@idinterior", SqlDbType.Int).Value = idinterior;

                    cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;

                    Connection.ExecuteStoreProcedure(cmd, "spAgregarAutos");

                    query = "select max(id) from carro";
                    dt = Connection.SelectQuery(query);
                    var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, siguienteid, false)))
                    {
                        Interaction.MsgBox("Nuevo Carro Registrado Correctamente");
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al agregar el registro");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error " + ex.Message);
                }
            }
        }
        private void actualizarvehiculo()
        {
            if (string.IsNullOrEmpty(txtModelo.Text) | string.IsNullOrEmpty(txtagencia.Text) | string.IsNullOrEmpty(txtvariante.Text) | string.IsNullOrEmpty(txtcarroceria.Text) | string.IsNullOrEmpty(txtTransmision.Text) | string.IsNullOrEmpty(TxtColor.Text) | string.IsNullOrEmpty(TxtInterior.Text) | string.IsNullOrEmpty(txtVin.Text) | string.IsNullOrEmpty(DateTimePicker1.Text))
            {

                Interaction.MsgBox("Faltan campor por rellenar");
                return;

            }

            string horaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Se agregara un Actualizara El Vehiculo" + Constants.vbCrLf + "Deseas Continuar ?" + Constants.vbCrLf, MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@year", SqlDbType.DateTime).Value = DateTimePicker1.Text + "-01-01";
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtVin.Text;
                    cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = idagencia;

                    cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = idmodelo;
                    cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = idvariante;
                    cmd.Parameters.Add("@idcarroceria", SqlDbType.Int).Value = idcarroceria;

                    cmd.Parameters.Add("@idtransmicion", SqlDbType.Int).Value = idtransmision;
                    cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = idcolor;
                    cmd.Parameters.Add("@idinterior", SqlDbType.Int).Value = idinterior;

                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = horaHoy;
                    cmd.Parameters.Add("@idauto", SqlDbType.Int).Value = My.MyProject.Forms.busquedavehiculo.EliminarActualizar;

                    Connection.ExecuteStoreProcedure(cmd, "SpActualizarAutos");

                    query = "select fechamodifica from carro where id ='" + My.MyProject.Forms.busquedavehiculo.EliminarActualizar + "'";
                    dt = Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error " + ex.Message);
                }
            }
        }

        private void txtVin_TextChanged(object sender, EventArgs e)
        {
            if (txtVin.Text.Length > 50)
            {

                if (txtVin.Text.Length > 50)
                {
                    // Truncar el texto a 50 caracteres
                    txtVin.Text = txtVin.Text.Substring(0, 50);

                    // Establecer el cursor al final del texto
                    txtVin.SelectionStart = 50;
                    txtVin.SelectionLength = 0;
                }

                txtVin.Text = txtVin.Text.Substring(0, 50);

            }
        }

    }
}