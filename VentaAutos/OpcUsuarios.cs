using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class OpcUsuarios
    {
        private SqlCommand cmd;
        private string query;
        private DataTable dt;
        private int idusuario;

        public OpcUsuarios()
        {
            InitializeComponent();
        }
        private void OpcUsuarios_Load(object sender, EventArgs e)
        {
            idusuario = Conversions.ToInteger(My.MyProject.Forms.InicioSeccion.idusuario);

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240);
            DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13.8f);

            txtusuario2.Text = My.MyProject.Forms.InicioSeccion.nombreusuario;
            txtusuario2.ReadOnly = true;
            txtnombre.ReadOnly = true;
            txtusername.ReadOnly = true;

            if (Conversions.ToDouble(My.MyProject.Forms.InicioSeccion.idusuario) == 1d)
            {
                txtnombre.Text = My.MyProject.Forms.InicioSeccion.nombreusuario;
                txtusername.Text = My.MyProject.Forms.InicioSeccion.username;
                DataGridView1.Visible = true;
                actualizar();
            }
            else
            {
                txtnombre.Text = My.MyProject.Forms.InicioSeccion.nombreusuario;
                txtusername.Text = My.MyProject.Forms.InicioSeccion.username;
                DataGridView1.Visible = false;
            }
        }
        private void actualizar()
        {
            query = "select id,nombre,username from usuario where id <> 1 and estatus =1";
            DataGridView1.DataSource = Connection.SelectQuery(query);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombreactualizar2.Text) | string.IsNullOrEmpty(txtcontractualizar2.Text) | string.IsNullOrEmpty(txtusernameactualizar2.Text))
            {

                Interaction.MsgBox("Faltan campor por rellenar");
                return;

            }

            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de modificar los datos del usuario" + Constants.vbCrLf + "Deseas Continuar ?" + Constants.vbCrLf, MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();

                    cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombreactualizar2.Text;
                    cmd.Parameters.Add("@usarname", SqlDbType.VarChar).Value = txtusernameactualizar2.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtcontractualizar2.Text;
                    cmd.Parameters.Add("@passwordUsuario", SqlDbType.VarChar).Value = My.MyProject.Forms.InicioSeccion.password;

                    Connection.ExecuteStoreProcedure(cmd, "SpActualizarUsuario");

                    Interaction.MsgBox("Usuario Actualizado Correctamente");
                }

                catch (Exception ex)
                {
                    Interaction.MsgBox("Error " + ex.Message);
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtusername.Text = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[2].Value);
                txtnombre.Text = Conversions.ToString(DataGridView1.Rows[e.RowIndex].Cells[1].Value);
                idusuario = Conversions.ToInteger(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception ex)
            {

            }
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar el usuario: " + txtusername.Text + Constants.vbCrLf + "Deseas Continuar ?" + Constants.vbCrLf, MsgBoxStyle.YesNo);
            if (idusuario == 1)
            {
                Interaction.MsgBox("ERROR NO PUEDES BORRAR EL USUARIO ADMINISTRADOR");
                return;
            }
            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();

                    cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario;

                    Connection.ExecuteStoreProcedure(cmd, "SpborrarUsuario");

                    Interaction.MsgBox("Usuario Eliminado");
                    actualizar();

                    txtusername.Clear();
                    txtnombre.Clear();

                    if (!(Conversions.ToDouble(My.MyProject.Forms.InicioSeccion.idusuario) == 1d))
                    {
                        int numForms = Application.OpenForms.Count - 1;
                        for (int i = numForms; i >= 0; i -= 1)
                        {
                            if (!(Application.OpenForms[i].Name == "InicioSeccion"))
                            {
                                Application.OpenForms[i].Close();
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    Interaction.MsgBox("Error " + ex.Message);
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}