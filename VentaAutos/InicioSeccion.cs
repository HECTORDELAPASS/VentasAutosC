using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class InicioSeccion
    {
        // Public autoriza As Integer = 0
        public bool pantallabienvenida;
        private string query;
        public string idusuario, nombreusuario, username, password;
        private SqlCommand cmd;
        private DataTable dt;

        public InicioSeccion()
        {
            InitializeComponent();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InicioSeccion_Load(object sender, EventArgs e)
        {
            picno.Visible = false;
            txtcontra.UseSystemPasswordChar = true;

            Connection.VisibleoNo(Panel2, false);
            Connection.VisibleoNo(Panel1, true);
        }

        private void txtNotengo_Click(object sender, EventArgs e)
        {
            Connection.VisibleoNo(Panel1, false);
            Connection.VisibleoNo(Panel2, true);
            txtNotengo.Visible = false;
        }

        private void txtcrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcreacontra.Text) | string.IsNullOrEmpty(txtcreanombre.Text) | string.IsNullOrEmpty(txtcreausername.Text))
            {
                Interaction.MsgBox("Faltan Campor por llenar");
                return;
            }

            query = "SELECT COUNT(username) FROM usuario WHERE username = '" + txtcreausername.Text + "'";
            dt = Connection.SelectQuery(query);

            if (Operators.ConditionalCompareObjectEqual(dt.AsEnumerable().ElementAtOrDefault(0)[0], "1", false))
            {
                Interaction.MsgBox("Usuario Ya existente");
                txtcreausername.Clear();
                return;
            }


            try
            {
                cmd = new SqlCommand();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtcreanombre.Text;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtcreausername.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtcreacontra.Text;

                Connection.ExecuteStoreProcedure(cmd, "SpagregarUsuario");

                Interaction.MsgBox("Usuario Creado");
                txtNotengo.Visible = true;
                Connection.VisibleoNo(Panel1, true);

                txtusuario.Text = txtcreausername.Text;
                txtcontra.Text = txtcreacontra.Text;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error: " + ex.Message);
            }

        }

        private void picsi_Click_1(object sender, EventArgs e)
        {
            picno.Visible = true;
            picsi.Visible = false;
            txtcontra.UseSystemPasswordChar = false;
        }

        private void picno_Click_1(object sender, EventArgs e)
        {
            picsi.Visible = true;
            picno.Visible = false;
            txtcontra.UseSystemPasswordChar = true;
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            query = "select convert(nvarchar(50),hashbytes('SHA1','" + txtcontra.Text + @"'),2) from usuario
                where username = '" + txtusuario.Text + "'";

            DataTable dt;
            try
            {
                dt = Connection.SelectQuery(query);
                var contrausuario = dt.Rows[0][0];

                query = "select id, nombre,password,username from usuario where username ='" + txtusuario.Text + "' and estatus = 1";
                dt = Connection.SelectQuery(query);
                var contrabase = dt.Rows[0][2];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(contrabase, contrausuario, false)))
                {
                    idusuario = Conversions.ToString(dt.Rows[0][0]);
                    nombreusuario = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[1]);
                    password = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[2]);
                    username = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[3]);
                    pantallabienvenida = true;
                    My.MyProject.Forms.Carga.Show();
                }

                else
                {
                    Interaction.MsgBox("Contra incorrecta");
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Usuario No existe");
            }
        }

    }
}