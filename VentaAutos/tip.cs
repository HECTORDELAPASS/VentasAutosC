using System;

namespace VentaAutos
{
    public partial class tip
    {
        public int Tiempototal = 180;
        public int tiemporestante;

        public tip()
        {
            tiemporestante = Tiempototal;
            InitializeComponent();
        }
        private void tip_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tiemporestante -= 1;
            // Label2.Text = tiemporestante.ToString()

            if (tiemporestante == 0)
            {
                Timer1.Stop();
                Close();
            }
        }
    }
}