using System;

namespace VentaAutos
{

    public partial class MenuOpciones
    {
        public bool pantallaventas;
        public int Boton;
        public bool cargarvehiculos;

        public MenuOpciones()
        {
            InitializeComponent();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Boton = 3;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Boton = 2;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void MenuOpciones_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            txtsaludo.Text = "Hola de nuevo, " + My.MyProject.Forms.InicioSeccion.nombreusuario;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pantallaventas = true;
            My.MyProject.Forms.Form1.Show();
            My.MyProject.Forms.Carga.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Boton = 1;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Boton = 4;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Boton = 5;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Boton = 6;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Boton = 7;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Boton = 8;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Boton = 9;
            My.MyProject.Forms.VendedorAgenciaEstados.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            cargarvehiculos = true;
            My.MyProject.Forms.busquedavehiculo.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txthoraactual.Text = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.OpcUsuarios.Show();
        }
    }
}