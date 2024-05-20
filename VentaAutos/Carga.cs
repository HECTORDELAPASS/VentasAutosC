using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{
    public partial class Carga
    {
        private string query;

        public Carga()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            CircularProgressBar1.Value += 2;
            CircularProgressBar1.Text = (CircularProgressBar1.Text + 2d).ToString();

            if (Opacity < 1d)
            {
                Opacity += 0.1d;

            }
            if (CircularProgressBar1.Value == 100)
            {
                Timer1.Stop();
                Timer2.Start();
            }
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            string usuario = My.MyProject.Forms.InicioSeccion.idusuario;
            query = "select nombre,username from usuario where id = '" + usuario + "'";
            var dt = Connection.SelectQuery(query);
            dt = Connection.SelectQuery(query);
            CircularProgressBar1.OuterColor = Color.Black;
            CircularProgressBar1.ProgressColor = Color.BlanchedAlmond;

            if (My.MyProject.Forms.InicioSeccion.pantallabienvenida)
            {
                lb1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Bienvenido. ", dt.Rows[0][0]), " , "), dt.Rows[0][1]));
                CircularProgressBar1.OuterColor = Color.FromArgb(0, 64, 0);
                CircularProgressBar1.ProgressColor = Color.Green;
            }
            else if (My.MyProject.Forms.Form1.pantallamasinfo)
            {
                lb1.Text = "Cargando Informacion del vehiculo, Espera";
                CircularProgressBar1.OuterColor = Color.Maroon;
                CircularProgressBar1.ProgressColor = Color.Red;
            }
            else if (My.MyProject.Forms.Infor.pantallaupdate)
            {
                lb1.Text = "Agregando Permisos, Espera";
                CircularProgressBar1.OuterColor = Color.DarkGoldenrod;
                CircularProgressBar1.ProgressColor = Color.Yellow;
            }
            else if (My.MyProject.Forms.MenuOpciones.pantallaventas)
            {
                lb1.Text = "Cargando informacion de Ventas, Espera";
            }


            CircularProgressBar1.Value = 0;
            Opacity = 0d;
            Timer1.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1d;
            if (Opacity == 0d)
            {
                Timer2.Stop();

                if (My.MyProject.Forms.InicioSeccion.pantallabienvenida)
                {
                    My.MyProject.Forms.MenuOpciones.Show();
                }
                else if (My.MyProject.Forms.Form1.pantallamasinfo)
                {
                    My.MyProject.Forms.Infor.Show();
                }
                else if (My.MyProject.Forms.Infor.pantallaupdate)
                {
                    My.MyProject.Forms.tip.Show();
                }


                My.MyProject.Forms.InicioSeccion.pantallabienvenida = false;
                My.MyProject.Forms.Form1.pantallamasinfo = false;
                My.MyProject.Forms.Infor.pantallaupdate = false;
                Close();
            }
        }

    }
}