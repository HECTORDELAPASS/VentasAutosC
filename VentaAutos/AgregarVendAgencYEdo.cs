using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class AgregarVendAgencYEdo
    {
        private SqlCommand cmd;
        private string query;
        private DataTable dt;

        public AgregarVendAgencYEdo()
        {
            InitializeComponent();
        }
        private void AgregarVendAgencYEdo_Load(object sender, EventArgs e)
        {

            txtid.ReadOnly = true;

            if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 1)
            {
                Label2.Text = "Agregar Nuevo Vendedor";
                query = "SELECT IDENT_CURRENT('vendedor')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 2)
            {
                Label2.Text = "Agregar Nueva Agencia";
                query = "SELECT IDENT_CURRENT('agencia')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 3)
            {
                Label2.Text = "Agregar Nuevo Estado";
                query = "SELECT IDENT_CURRENT('estado')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 4)
            {
                Label2.Text = "Agregar Nueva Carroceria";
                query = "SELECT IDENT_CURRENT('carroceria')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 5)
            {
                Label2.Text = "Agregar Nuevo Modelo de auto";
                query = "SELECT IDENT_CURRENT('modelo')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 6)
            {
                Label2.Text = "Agregar Nueva variante";
                query = "SELECT IDENT_CURRENT('variante')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 7)
            {
                Label2.Text = "Agregar Nueva Transmisión";
                query = "SELECT IDENT_CURRENT('trasmicion')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 8)
            {
                Label2.Text = "Agregar Nuevo Interior de auto";
                query = "SELECT IDENT_CURRENT('interior')+1";
            }

            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 9)
            {
                Label2.Text = "Agregar Nuevo Color";
                query = "SELECT IDENT_CURRENT('colores')+1";
            }
            dt = Connection.SelectQuery(query);
            txtid.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
        }
        private void vendedoresagregar()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "SpAgregarVendedor");

                query = "select max(id) from vendedor";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nuevo Vendedor Registrado Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar el registro");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al el registro:" + ex.Message);

            }
        }
        private void AgenciaAgregar()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spagregaragencia");

                query = "select max(id) from agencia";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nueva Agencia Registrada Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar Nueva Agencia");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al agregar la Agencia: " + ex.Message);

            }
        }
        private void agregaredo()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spagregarEstado");

                query = "select max(id) from estado";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nuevo Estado Registrado Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar Estado");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al agregar el Estado: " + ex.Message);

            }
        }
        private void agregarcarrroceria()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spAgregarCarroceria");

                query = "select max(id) from carroceria";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nueva Carroceria Registrada Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar el registro");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al el registro:" + ex.Message);

            }
        }
        private void agregarmodelo()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spAgregarModelo");

                query = "select max(id) from modelo";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nuevo modelo Registrado Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar el registro");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al el registro:" + ex.Message);

            }
        }
        private void agregarvariante()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spAgregarVariantes");

                query = "select max(id) from variante";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nueva Variante Registrada Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar el registro");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al el registro:" + ex.Message);

            }
        }
        private void agregarTransmisión()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spAgregarTransmision");

                query = "select max(id) from trasmicion";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nueva Transmision Registrada Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar el registro");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al el registro:" + ex.Message);

            }
        }
        private void agregarinterior()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spAgregarInterior");

                query = "select max(id) from interior";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nuevo Interior Registrado Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar el registro");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al el registro:" + ex.Message);

            }
        }
        private void agregarcolores()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                Connection.ExecuteStoreProcedure(cmd, "spAgregarColores");

                query = "select max(id) from colores";
                dt = Connection.SelectQuery(query);
                var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, txtid.Text, false)))
                {
                    Interaction.MsgBox("Nuevo Color Registrado Correctamente");
                    My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                    Close();
                }
                else
                {
                    Interaction.MsgBox("Error al agregar el registro");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al el registro:" + ex.Message);

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 1)
            {
                vendedoresagregar();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 2)
            {
                AgenciaAgregar();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 3)
            {
                agregaredo();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 4)
            {
                agregarcarrroceria();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 5)
            {
                agregarmodelo();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 6)
            {
                agregarvariante();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 7)
            {
                agregarTransmisión();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 8)
            {
                agregarinterior();
            }
            else if (My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 9)
            {
                agregarcolores();
            }
        }
    }
}