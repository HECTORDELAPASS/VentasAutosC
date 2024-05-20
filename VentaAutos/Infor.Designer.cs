using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Infor : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Venta = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            Transmisióntxt = new Label();
            Carroceriatxt = new Label();
            Variante = new Label();
            Label16 = new Label();
            Label17 = new Label();
            idtxt = new TextBox();
            mmrtxt = new TextBox();
            Ventatxt = new TextBox();
            conditxt = new TextBox();
            yeartxt = new TextBox();
            modelotxt = new TextBox();
            vendedortxt = new TextBox();
            vintxt = new TextBox();
            Edtxt = new TextBox();
            inttxt = new TextBox();
            colortxt = new TextBox();
            trastxt = new TextBox();
            txtcarroceria = new TextBox();
            Variatxt = new TextBox();
            agentxt = new TextBox();
            kmtxt = new TextBox();
            cboventa = new ComboBox();
            cboventa.SelectedIndexChanged += new EventHandler(cboventa_SelectedIndexChanged);
            Label4 = new Label();
            Label13 = new Label();
            lab1 = new Label();
            fechventxt = new DateTimePicker();
            lbagregar = new Label();
            picbuscar = new PictureBox();
            picbuscar.Click += new EventHandler(picbuscar_Click);
            BtnNuevaVenta = new PictureBox();
            BtnNuevaVenta.Click += new EventHandler(BtnNuevaVenta_Click);
            btnbuscarcarro = new PictureBox();
            btnbuscarcarro.Click += new EventHandler(btnbuscarcarro_Click);
            btnbuscaredo = new PictureBox();
            btnbuscaredo.Click += new EventHandler(btnbuscaredo_Click);
            btbuscarvendedor = new PictureBox();
            btbuscarvendedor.Click += new EventHandler(btbuscarvendedor_Click);
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            piclogo = new PictureBox();
            pic1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnNuevaVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnbuscarcarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnbuscaredo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btbuscarvendedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(1209, 344);
            Label1.Name = "Label1";
            Label1.Size = new Size(127, 41);
            Label1.TabIndex = 0;
            Label1.Text = "Id Venta";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(650, 223);
            Label2.Name = "Label2";
            Label2.Size = new Size(178, 41);
            Label2.TabIndex = 1;
            Label2.Text = "Fecha Venta";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(650, 341);
            Label3.Name = "Label3";
            Label3.Size = new Size(213, 41);
            Label3.TabIndex = 3;
            Label3.Text = "MMR (dolares)";
            // 
            // Venta
            // 
            Venta.AutoSize = true;
            Venta.Location = new Point(650, 286);
            Venta.Name = "Venta";
            Venta.Size = new Size(216, 41);
            Venta.TabIndex = 2;
            Venta.Text = "Venta (dolares)";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(1209, 223);
            Label5.Name = "Label5";
            Label5.Size = new Size(153, 41);
            Label5.TabIndex = 7;
            Label5.Text = "Condicion";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(43, 344);
            Label6.Name = "Label6";
            Label6.Size = new Size(72, 41);
            Label6.TabIndex = 6;
            Label6.Text = "Año";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(43, 223);
            Label7.Name = "Label7";
            Label7.Size = new Size(122, 41);
            Label7.TabIndex = 5;
            Label7.Text = "Modelo";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(650, 402);
            Label8.Name = "Label8";
            Label8.Size = new Size(148, 41);
            Label8.TabIndex = 4;
            Label8.Text = "Vendedor";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(650, 534);
            Label9.Name = "Label9";
            Label9.Size = new Size(351, 41);
            Label9.TabIndex = 15;
            Label9.Text = "Codigo De Vehiculo (Vin)";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(650, 464);
            Label10.Name = "Label10";
            Label10.Size = new Size(235, 41);
            Label10.TabIndex = 14;
            Label10.Text = "Estado De Venta";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(43, 596);
            Label11.Name = "Label11";
            Label11.Size = new Size(114, 41);
            Label11.TabIndex = 13;
            Label11.Text = "Interior";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(43, 537);
            Label12.Name = "Label12";
            Label12.Size = new Size(206, 41);
            Label12.TabIndex = 12;
            Label12.Text = "Color Exterior ";
            // 
            // Transmisióntxt
            // 
            Transmisióntxt.AutoSize = true;
            Transmisióntxt.Location = new Point(43, 657);
            Transmisióntxt.Name = "Transmisióntxt";
            Transmisióntxt.Size = new Size(174, 41);
            Transmisióntxt.TabIndex = 11;
            Transmisióntxt.Text = "Transmisión";
            // 
            // Carroceriatxt
            // 
            Carroceriatxt.AutoSize = true;
            Carroceriatxt.Location = new Point(43, 402);
            Carroceriatxt.Name = "Carroceriatxt";
            Carroceriatxt.Size = new Size(152, 41);
            Carroceriatxt.TabIndex = 10;
            Carroceriatxt.Text = "Carroceria";
            // 
            // Variante
            // 
            Variante.AutoSize = true;
            Variante.Location = new Point(43, 467);
            Variante.Name = "Variante";
            Variante.Size = new Size(125, 41);
            Variante.TabIndex = 9;
            Variante.Text = "Variante";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(43, 286);
            Label16.Name = "Label16";
            Label16.Size = new Size(124, 41);
            Label16.TabIndex = 8;
            Label16.Text = "Agencia";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(1209, 283);
            Label17.Name = "Label17";
            Label17.Size = new Size(167, 41);
            Label17.TabIndex = 16;
            Label17.Text = "Kilometraje";
            // 
            // idtxt
            // 
            idtxt.Location = new Point(1342, 338);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(174, 47);
            idtxt.TabIndex = 17;
            // 
            // mmrtxt
            // 
            mmrtxt.Location = new Point(869, 338);
            mmrtxt.Name = "mmrtxt";
            mmrtxt.Size = new Size(250, 47);
            mmrtxt.TabIndex = 20;
            // 
            // Ventatxt
            // 
            Ventatxt.Location = new Point(875, 280);
            Ventatxt.Name = "Ventatxt";
            Ventatxt.Size = new Size(247, 47);
            Ventatxt.TabIndex = 19;
            // 
            // conditxt
            // 
            conditxt.Location = new Point(1363, 217);
            conditxt.Name = "conditxt";
            conditxt.Size = new Size(117, 47);
            conditxt.TabIndex = 24;
            // 
            // yeartxt
            // 
            yeartxt.Location = new Point(121, 338);
            yeartxt.Name = "yeartxt";
            yeartxt.Size = new Size(154, 47);
            yeartxt.TabIndex = 23;
            // 
            // modelotxt
            // 
            modelotxt.Location = new Point(171, 217);
            modelotxt.Name = "modelotxt";
            modelotxt.Size = new Size(373, 47);
            modelotxt.TabIndex = 22;
            // 
            // vendedortxt
            // 
            vendedortxt.Location = new Point(804, 396);
            vendedortxt.Name = "vendedortxt";
            vendedortxt.Size = new Size(373, 47);
            vendedortxt.TabIndex = 21;
            // 
            // vintxt
            // 
            vintxt.Location = new Point(1007, 531);
            vintxt.Name = "vintxt";
            vintxt.Size = new Size(257, 47);
            vintxt.TabIndex = 32;
            // 
            // Edtxt
            // 
            Edtxt.Location = new Point(891, 461);
            Edtxt.Name = "Edtxt";
            Edtxt.Size = new Size(373, 47);
            Edtxt.TabIndex = 31;
            // 
            // inttxt
            // 
            inttxt.Location = new Point(163, 590);
            inttxt.Name = "inttxt";
            inttxt.Size = new Size(373, 47);
            inttxt.TabIndex = 30;
            // 
            // colortxt
            // 
            colortxt.Location = new Point(255, 531);
            colortxt.Name = "colortxt";
            colortxt.Size = new Size(373, 47);
            colortxt.TabIndex = 29;
            // 
            // trastxt
            // 
            trastxt.Location = new Point(223, 651);
            trastxt.Name = "trastxt";
            trastxt.Size = new Size(373, 47);
            trastxt.TabIndex = 28;
            // 
            // txtcarroceria
            // 
            txtcarroceria.Location = new Point(201, 396);
            txtcarroceria.Name = "txtcarroceria";
            txtcarroceria.Size = new Size(373, 47);
            txtcarroceria.TabIndex = 27;
            // 
            // Variatxt
            // 
            Variatxt.Location = new Point(174, 461);
            Variatxt.Name = "Variatxt";
            Variatxt.Size = new Size(373, 47);
            Variatxt.TabIndex = 26;
            // 
            // agentxt
            // 
            agentxt.Location = new Point(173, 280);
            agentxt.Name = "agentxt";
            agentxt.Size = new Size(373, 47);
            agentxt.TabIndex = 25;
            // 
            // kmtxt
            // 
            kmtxt.Location = new Point(1382, 277);
            kmtxt.Name = "kmtxt";
            kmtxt.Size = new Size(134, 47);
            kmtxt.TabIndex = 33;
            // 
            // cboventa
            // 
            cboventa.FormattingEnabled = true;
            cboventa.Location = new Point(1188, 38);
            cboventa.Name = "cboventa";
            cboventa.Size = new Size(174, 49);
            cboventa.TabIndex = 37;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(1368, 41);
            Label4.Name = "Label4";
            Label4.Size = new Size(127, 41);
            Label4.TabIndex = 36;
            Label4.Text = "Id Venta";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI Semibold", 30.2f, FontStyle.Bold);
            Label13.Location = new Point(38, 9);
            Label13.Name = "Label13";
            Label13.Size = new Size(531, 68);
            Label13.TabIndex = 38;
            Label13.Text = "Mas detalles de venta";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab1.ForeColor = Color.FromArgb(0, 192, 0);
            lab1.Location = new Point(981, 7);
            lab1.Name = "lab1";
            lab1.Size = new Size(355, 28);
            lab1.TabIndex = 40;
            lab1.Text = "Consultar mas ventas del mismo auto";
            // 
            // fechventxt
            // 
            fechventxt.Format = DateTimePickerFormat.Short;
            fechventxt.Location = new Point(834, 217);
            fechventxt.Name = "fechventxt";
            fechventxt.Size = new Size(314, 47);
            fechventxt.TabIndex = 45;
            // 
            // lbagregar
            // 
            lbagregar.AutoSize = true;
            lbagregar.Font = new Font("Segoe UI Semilight", 12.0f);
            lbagregar.Location = new Point(1370, 581);
            lbagregar.Name = "lbagregar";
            lbagregar.Size = new Size(134, 28);
            lbagregar.TabIndex = 50;
            lbagregar.Text = "Agregar Venta";
            // 
            // picbuscar
            // 
            picbuscar.Image = My.Resources.Resources.detallando;
            picbuscar.Location = new Point(391, 83);
            picbuscar.Name = "picbuscar";
            picbuscar.Size = new Size(153, 128);
            picbuscar.SizeMode = PictureBoxSizeMode.Zoom;
            picbuscar.TabIndex = 51;
            picbuscar.TabStop = false;
            // 
            // BtnNuevaVenta
            // 
            BtnNuevaVenta.Image = My.Resources.Resources.agregar_carrito;
            BtnNuevaVenta.Location = new Point(1363, 450);
            BtnNuevaVenta.Name = "BtnNuevaVenta";
            BtnNuevaVenta.Size = new Size(153, 128);
            BtnNuevaVenta.SizeMode = PictureBoxSizeMode.Zoom;
            BtnNuevaVenta.TabIndex = 49;
            BtnNuevaVenta.TabStop = false;
            // 
            // btnbuscarcarro
            // 
            btnbuscarcarro.Image = My.Resources.Resources.hacer_clic;
            btnbuscarcarro.Location = new Point(1270, 531);
            btnbuscarcarro.Name = "btnbuscarcarro";
            btnbuscarcarro.Size = new Size(50, 47);
            btnbuscarcarro.SizeMode = PictureBoxSizeMode.Zoom;
            btnbuscarcarro.TabIndex = 48;
            btnbuscarcarro.TabStop = false;
            // 
            // btnbuscaredo
            // 
            btnbuscaredo.Image = My.Resources.Resources.hacer_clic;
            btnbuscaredo.Location = new Point(1270, 461);
            btnbuscaredo.Name = "btnbuscaredo";
            btnbuscaredo.Size = new Size(50, 47);
            btnbuscaredo.SizeMode = PictureBoxSizeMode.Zoom;
            btnbuscaredo.TabIndex = 47;
            btnbuscaredo.TabStop = false;
            // 
            // btbuscarvendedor
            // 
            btbuscarvendedor.Image = My.Resources.Resources.hacer_clic;
            btbuscarvendedor.Location = new Point(1183, 396);
            btbuscarvendedor.Name = "btbuscarvendedor";
            btbuscarvendedor.Size = new Size(50, 47);
            btbuscarvendedor.SizeMode = PictureBoxSizeMode.Zoom;
            btbuscarvendedor.TabIndex = 46;
            btbuscarvendedor.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.recargar;
            PictureBox2.Location = new Point(1248, 128);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(103, 70);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 44;
            PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.borrar;
            PictureBox1.Location = new Point(1377, 128);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(103, 70);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 43;
            PictureBox1.TabStop = false;
            // 
            // piclogo
            // 
            piclogo.Location = new Point(50, 80);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(295, 131);
            piclogo.TabIndex = 42;
            piclogo.TabStop = false;
            // 
            // pic1
            // 
            pic1.Image = My.Resources.Resources.flecha_correcta__1_;
            pic1.Location = new Point(1020, 38);
            pic1.Name = "pic1";
            pic1.Size = new Size(162, 49);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 39;
            pic1.TabStop = false;
            // 
            // Infor
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1770, 732);
            Controls.Add(picbuscar);
            Controls.Add(lbagregar);
            Controls.Add(BtnNuevaVenta);
            Controls.Add(btnbuscarcarro);
            Controls.Add(btnbuscaredo);
            Controls.Add(btbuscarvendedor);
            Controls.Add(fechventxt);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            Controls.Add(piclogo);
            Controls.Add(lab1);
            Controls.Add(pic1);
            Controls.Add(Label13);
            Controls.Add(cboventa);
            Controls.Add(Label4);
            Controls.Add(kmtxt);
            Controls.Add(vintxt);
            Controls.Add(Edtxt);
            Controls.Add(inttxt);
            Controls.Add(colortxt);
            Controls.Add(trastxt);
            Controls.Add(txtcarroceria);
            Controls.Add(Variatxt);
            Controls.Add(agentxt);
            Controls.Add(conditxt);
            Controls.Add(yeartxt);
            Controls.Add(modelotxt);
            Controls.Add(vendedortxt);
            Controls.Add(mmrtxt);
            Controls.Add(Ventatxt);
            Controls.Add(idtxt);
            Controls.Add(Label17);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(Label11);
            Controls.Add(Label12);
            Controls.Add(Transmisióntxt);
            Controls.Add(Carroceriatxt);
            Controls.Add(Variante);
            Controls.Add(Label16);
            Controls.Add(Label5);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(Label8);
            Controls.Add(Label3);
            Controls.Add(Venta);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 8, 6, 8);
            Name = "Infor";
            Text = "Infor";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picbuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnNuevaVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnbuscarcarro).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnbuscaredo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btbuscarvendedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            Load += new EventHandler(Infor_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Venta;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal Label Label11;
        internal Label Label12;
        internal Label Transmisióntxt;
        internal Label Carroceriatxt;
        internal Label Variante;
        internal Label Label16;
        internal Label Label17;
        internal TextBox idtxt;
        internal TextBox mmrtxt;
        internal TextBox Ventatxt;
        internal TextBox conditxt;
        internal TextBox yeartxt;
        internal TextBox modelotxt;
        internal TextBox vendedortxt;
        internal TextBox vintxt;
        internal TextBox Edtxt;
        internal TextBox inttxt;
        internal TextBox colortxt;
        internal TextBox trastxt;
        internal TextBox txtcarroceria;
        internal TextBox Variatxt;
        internal TextBox agentxt;
        internal TextBox kmtxt;
        internal ComboBox cboventa;
        internal Label Label4;
        internal Label Label13;
        internal PictureBox pic1;
        internal Label lab1;
        internal PictureBox piclogo;
        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
        internal DateTimePicker fechventxt;
        internal PictureBox btbuscarvendedor;
        internal PictureBox btnbuscaredo;
        internal PictureBox btnbuscarcarro;
        internal PictureBox BtnNuevaVenta;
        internal Label lbagregar;
        internal PictureBox picbuscar;
    }
}