using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{
    public partial class Infor
    {
        private string query, s;
        private int temporal, permiso, cliks;
        private int Entro = 1;
        private string procedimiento;
        private SqlCommand cmd;
        private DataTable dt;
        public bool pantallaupdate, nuevaventa;
        public int idvendedor = 0;
        public int idcarro = 0;
        public int idedoventa = 0;

        public Infor()
        {
            InitializeComponent();
        }
        private void NuevoRegistro()
        {
            Label13.Text = "Registro de Nueva Venta";
            bloqueoinicio();

            BtnNuevaVenta.Visible = true;
            piclogo.Visible = false;
            PictureBox2.Visible = false;
            PictureBox1.Visible = false;
            lbagregar.Visible = true;
            picbuscar.Visible = true;
            nuevaventa = true;
            btnbuscaredo.Visible = true;
            btbuscarvendedor.Visible = true;
            btnbuscarcarro.Visible = true;


            query = "SELECT IDENT_CURRENT('venta')+1";
            dt = Connection.SelectQuery(query);
            idtxt.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

            bloqueo();
            fechventxt.Enabled = Enabled;
            mmrtxt.ReadOnly = false;
            Ventatxt.ReadOnly = false;
            conditxt.ReadOnly = false;
            kmtxt.ReadOnly = false;
        }
        private void limpiar()
        {
            modelotxt.Clear();
            agentxt.Clear();
            yeartxt.Clear();
            txtcarroceria.Clear();
            Variatxt.Clear();
            colortxt.Clear();
            inttxt.Clear();
            trastxt.Clear();
            fechventxt.Value = DateTime.Today;
            Ventatxt.Clear();
            mmrtxt.Clear();
            vendedortxt.Clear();
            Edtxt.Clear();
            vintxt.Clear();
            conditxt.Clear();
            kmtxt.Clear();

            idvendedor = 0;
            idcarro = 0;
            idedoventa = 0;

        }
        private void bloqueoinicio()
        {
            Label4.Visible = false;
            cboventa.Visible = false;
            pic1.Visible = false;
            lab1.Visible = false;
            btnbuscarcarro.Visible = false;
            btnbuscaredo.Visible = false;
            btbuscarvendedor.Visible = false;
            BtnNuevaVenta.Visible = false;
            lbagregar.Visible = false;
            picbuscar.Visible = false;
        }
        private void Infor_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Form1.NuevaVenta)
            {
                My.MyProject.Forms.Form1.NuevaVenta = false;
                NuevoRegistro();
            }
            else
            {
                nuevaventa = false;
                cliks = 0;
                cboventa.DropDownStyle = ComboBoxStyle.DropDownList;
                bloqueoinicio();
                s = My.MyProject.Forms.Form1.rows;
                query = @"select carro.codigovehiculo, count(carro.codigovehiculo)
				from venta
				inner join carro on venta.idcarro = carro.id
				where carro.codigovehiculo ='" + s + @"' and venta.estatus = 1
				group by carro.codigovehiculo";
                dt = Connection.SelectQuery(query);
                temporal = Conversions.ToInteger(dt.Rows[0][1]);
                try
                {
                    llenado();
                    bloqueo();
                    valorespordefecto();
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void bloqueo()
        {
            idtxt.ReadOnly = true;
            fechventxt.Enabled = false;
            mmrtxt.ReadOnly = true;
            Ventatxt.ReadOnly = true;
            vendedortxt.ReadOnly = true;
            modelotxt.ReadOnly = true;
            yeartxt.ReadOnly = true;
            conditxt.ReadOnly = true;
            kmtxt.ReadOnly = true;
            agentxt.ReadOnly = true;
            Variatxt.ReadOnly = true;
            txtcarroceria.ReadOnly = true;
            trastxt.ReadOnly = true;
            colortxt.ReadOnly = true;
            inttxt.ReadOnly = true;
            Edtxt.ReadOnly = true;
            vintxt.ReadOnly = true;
        }
        private void cboventa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Entro == 1)
            {
                llenado();
            }
        }
        public void valorespordefecto()
        {
            query = @"select idvendedor, idcarro, idestado from venta inner join carro on carro.id = venta.idcarro
				 where venta.id = '" + idtxt.Text + "'";
            dt = Connection.SelectQuery(query);


            idvendedor = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            idcarro = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[1]);
            idedoventa = Conversions.ToInteger(dt.AsEnumerable().ElementAtOrDefault(0)[2]);

        }

        private void llenado()
        {
            if (cboventa.SelectedItem is null)
            {
                query = "select * from VWInfoCarro WHERE [Codigovehiculo] = '" + s + " '";
            }
            else
            {
                query = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * From VWInfoCarro Where [id] = '", cboventa.SelectedItem), "'"));
            }
            dt = Connection.SelectQuery(query);
            int fila = dt.Rows.Count;
            int columna = dt.Columns.Count;

            var matriz = new object[fila, columna];
            for (int i = 0, loopTo = fila - 1; i <= loopTo; i++)
            {
                for (int j = 0, loopTo1 = columna - 1; j <= loopTo1; j++)
                    matriz[i, j] = dt.Rows[i][j];
            }
            if (temporal > 1 & cboventa.SelectedItem is null)
            {
                Interaction.MsgBox("Existe mas de una venta, para mas informacion " + Constants.vbCrLf + "ir a esquina superior derecha");
                Label4.Visible = true;
                cboventa.Visible = true;
                pic1.Visible = true;
                lab1.Visible = true;
                for (int h = 0, loopTo2 = temporal - 1; h <= loopTo2; h++)
                    cboventa.Items.Add(matriz[h, 0]).ToString();
            }
            idtxt.Text = Conversions.ToString(dt.Rows[0][0]);
            fechventxt.Text = Conversions.ToString(dt.Rows[0][1]);
            mmrtxt.Text = Conversions.ToString(dt.Rows[0][2]);
            Ventatxt.Text = Conversions.ToString(dt.Rows[0][3]);
            vendedortxt.Text = Conversions.ToString(dt.Rows[0][4]);
            modelotxt.Text = Conversions.ToString(dt.Rows[0][5]);
            yeartxt.Text = Conversions.ToString(dt.Rows[0][6]);
            conditxt.Text = Conversions.ToString(dt.Rows[0][7]);
            kmtxt.Text = Conversions.ToString(dt.Rows[0][8]);
            agentxt.Text = Conversions.ToString(dt.Rows[0][9]);
            Variatxt.Text = Conversions.ToString(dt.Rows[0][10]);
            txtcarroceria.Text = Conversions.ToString(dt.Rows[0][11]);
            trastxt.Text = Conversions.ToString(dt.Rows[0][12]);
            colortxt.Text = Conversions.ToString(dt.Rows[0][13]);
            inttxt.Text = Conversions.ToString(dt.Rows[0][14]);
            Edtxt.Text = Conversions.ToString(dt.Rows[0][15]);
            vintxt.Text = Conversions.ToString(dt.Rows[0][16]);
            string url = "https://logo.clearbit.com/" + agentxt.Text + ".com";

            if (LogoExists(url))
            {
                piclogo.Load(url);
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnbuscarcarro_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.busquedavehiculo.Show();
        }

        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Se agregará una nueva venta vinculada a tu cuenta." + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@fechaventa", SqlDbType.DateTime).Value = fechventxt.Text;
                    cmd.Parameters.Add("@mmr", SqlDbType.Int).Value = mmrtxt.Text;
                    cmd.Parameters.Add("@precioventa", SqlDbType.Int).Value = Ventatxt.Text;
                    cmd.Parameters.Add("@condicion", SqlDbType.Int).Value = conditxt.Text;
                    cmd.Parameters.Add("@kilometraje", SqlDbType.Int).Value = kmtxt.Text;
                    cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = idvendedor;
                    cmd.Parameters.Add("@idcarro", SqlDbType.Int).Value = idcarro;
                    cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = idedoventa;
                    cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    Connection.ExecuteStoreProcedure(cmd, "SpAgregarVenta");

                    query = "select max(id) from venta";
                    dt = Connection.SelectQuery(query);
                    var comprobacion = dt.AsEnumerable().ElementAtOrDefault(0)[0];

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(comprobacion, idtxt.Text, false)))
                    {
                        Interaction.MsgBox("Nueva Venta Registrada Correctamente");
                    }
                    else
                    {
                        Interaction.MsgBox("Error al agregar la venta");
                    }
                    limpiar();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al agregar la venta: " + ex.Message);
                }
            }

            query = "SELECT IDENT_CURRENT('venta')+1";
            dt = Connection.SelectQuery(query);
            idtxt.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
        }

        private void picbuscar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.busquedavehiculo.Show();
        }

        private void btbuscarvendedor_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.busquedavendedor.Show();
        }

        private void btnbuscaredo_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.busquedaedoventa.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            cliks += 1;
            btnbuscarcarro.Visible = true;
            btnbuscaredo.Visible = true;
            btbuscarvendedor.Visible = true;

            if (cliks == 1)
            {
                pantallaupdate = true;
                My.MyProject.Forms.Carga.Show();
                fechventxt.Enabled = true;
                mmrtxt.ReadOnly = false;
                Ventatxt.ReadOnly = false;
                conditxt.ReadOnly = false;
                kmtxt.ReadOnly = false;
                valorespordefecto();
                cboventa.Visible = false;
            }
            else if (cliks >= 2)
            {
                string horaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

                if (idvendedor != 0 & idcarro != 0 & idedoventa != 0)
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idventa", SqlDbType.Int).Value = idtxt.Text;
                    cmd.Parameters.Add("@fechaventa", SqlDbType.DateTime).Value = fechventxt.Text;
                    cmd.Parameters.Add("@mmr", SqlDbType.Int).Value = mmrtxt.Text;
                    cmd.Parameters.Add("@precioventa", SqlDbType.Int).Value = Ventatxt.Text;
                    cmd.Parameters.Add("@condicion", SqlDbType.Int).Value = conditxt.Text;
                    cmd.Parameters.Add("@kilometraje", SqlDbType.Int).Value = kmtxt.Text;
                    cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = idvendedor;
                    cmd.Parameters.Add("@idcarro", SqlDbType.Int).Value = idcarro;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = horaHoy;
                    cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = idedoventa;
                    Connection.ExecuteStoreProcedure(cmd, "spactualizarventa");
                    cliks = 0;

                    query = "select fechamodifica from venta where id = '" + idtxt.Text + "'";
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

                    btnbuscarcarro.Visible = false;
                    btnbuscaredo.Visible = false;
                    btbuscarvendedor.Visible = false;
                    bloqueo();
                }
                else
                {
                    Interaction.MsgBox("Inserta el vendedor desde la busqueda avanzada" + Constants.vbCrLf + "Inserta el Vin de carro desde la busqueda avanzada" + Constants.vbCrLf + "Inserta el Estado de venta desde la busqueda avanzada");
                }
                cboventa.Visible = true;
            }
        }
        public void eliminar()
        {
            Entro = 0;
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Vas a borrar la venta seleccionada " + Constants.vbCrLf + "¿Deseas continuar?", MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idventa", SqlDbType.Int).Value = idtxt.Text;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;

                    Connection.ExecuteStoreProcedure(cmd, "spborrarventa");

                    query = "select estatus from venta where id = '" + idtxt.Text + "'";
                    dt = Connection.SelectQuery(query);

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], 0, false)))
                    {
                        Interaction.MsgBox("Venta borrada. No podras acceder mas a esta venta");
                        cboventa.Items.Remove(cboventa.SelectedItem);
                        limpiar();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al borrar venta" + Constants.vbCrLf + "Intentar mas tarde");
                    }
                }
                catch (Exception ex)
                {
                }
            }
            Entro = 1;
        }
        private bool LogoExists(string url)
        {
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            request.Method = "HEAD";
            try
            {
                using (System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == System.Net.HttpStatusCode.OK;
                }
            }
            catch (System.Net.WebException ex)
            {
                return false;
            }
        }
    }
}