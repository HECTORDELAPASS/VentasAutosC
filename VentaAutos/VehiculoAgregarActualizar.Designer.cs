using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class VehiculoAgregarActualizar : Form
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
            Lb1 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            txtModelo = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            txtvariante = new TextBox();
            txtagencia = new TextBox();
            Label4 = new Label();
            Label5 = new Label();
            TxtColor = new TextBox();
            txtTransmision = new TextBox();
            Label6 = new Label();
            Label7 = new Label();
            txtcarroceria = new TextBox();
            Label8 = new Label();
            TxtInterior = new TextBox();
            Label9 = new Label();
            btbuscarvendedor = new PictureBox();
            btbuscarvendedor.Click += new EventHandler(btbuscarvendedor_Click);
            pic1 = new PictureBox();
            pic1.Click += new EventHandler(PictureBox1_Click);
            pic2 = new PictureBox();
            pic2.Click += new EventHandler(PictureBox2_Click);
            pic3 = new PictureBox();
            pic3.Click += new EventHandler(PictureBox3_Click);
            pic4 = new PictureBox();
            pic4.Click += new EventHandler(PictureBox4_Click);
            pic5 = new PictureBox();
            pic5.Click += new EventHandler(PictureBox5_Click);
            pic6 = new PictureBox();
            pic6.Click += new EventHandler(PictureBox6_Click);
            txtVin = new TextBox();
            txtVin.TextChanged += new EventHandler(txtVin_TextChanged);
            Label3 = new Label();
            DateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)btbuscarvendedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic6).BeginInit();
            SuspendLayout();
            // 
            // Lb1
            // 
            Lb1.AutoSize = true;
            Lb1.Font = new Font("Segoe UI Semibold", 24.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb1.ForeColor = Color.Maroon;
            Lb1.Location = new Point(12, 9);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(472, 54);
            Lb1.TabIndex = 11;
            Lb1.Text = "Actualizacion de nombre";
            // 
            // Button1
            // 
            Button1.Location = new Point(449, 720);
            Button1.Name = "Button1";
            Button1.Size = new Size(227, 56);
            Button1.TabIndex = 16;
            Button1.Text = "Aceptar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(164, 92);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(510, 47);
            txtModelo.TabIndex = 15;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(37, 167);
            Label2.Name = "Label2";
            Label2.Size = new Size(124, 41);
            Label2.TabIndex = 13;
            Label2.Text = "Agencia";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(36, 688);
            Label1.Name = "Label1";
            Label1.Size = new Size(72, 41);
            Label1.TabIndex = 12;
            Label1.Text = "Año";
            // 
            // txtvariante
            // 
            txtvariante.Location = new Point(167, 230);
            txtvariante.Name = "txtvariante";
            txtvariante.Size = new Size(509, 47);
            txtvariante.TabIndex = 20;
            // 
            // txtagencia
            // 
            txtagencia.Location = new Point(167, 161);
            txtagencia.Name = "txtagencia";
            txtagencia.Size = new Size(512, 47);
            txtagencia.TabIndex = 19;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(36, 236);
            Label4.Name = "Label4";
            Label4.Size = new Size(125, 41);
            Label4.TabIndex = 18;
            Label4.Text = "Variante";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(36, 98);
            Label5.Name = "Label5";
            Label5.Size = new Size(122, 41);
            Label5.TabIndex = 17;
            Label5.Text = "Modelo";
            // 
            // TxtColor
            // 
            TxtColor.Location = new Point(253, 441);
            TxtColor.Name = "TxtColor";
            TxtColor.Size = new Size(423, 47);
            TxtColor.TabIndex = 26;
            // 
            // txtTransmision
            // 
            txtTransmision.Location = new Point(216, 370);
            txtTransmision.Name = "txtTransmision";
            txtTransmision.Size = new Size(460, 47);
            txtTransmision.TabIndex = 25;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(36, 447);
            Label6.Name = "Label6";
            Label6.Size = new Size(211, 41);
            Label6.TabIndex = 24;
            Label6.Text = "Color Vehiculo";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(36, 376);
            Label7.Name = "Label7";
            Label7.Size = new Size(174, 41);
            Label7.TabIndex = 23;
            Label7.Text = "Transmision";
            // 
            // txtcarroceria
            // 
            txtcarroceria.Location = new Point(194, 293);
            txtcarroceria.Name = "txtcarroceria";
            txtcarroceria.Size = new Size(482, 47);
            txtcarroceria.TabIndex = 22;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(36, 299);
            Label8.Name = "Label8";
            Label8.Size = new Size(152, 41);
            Label8.TabIndex = 21;
            Label8.Text = "Carroceria";
            // 
            // TxtInterior
            // 
            TxtInterior.Location = new Point(281, 508);
            TxtInterior.Name = "TxtInterior";
            TxtInterior.Size = new Size(395, 47);
            TxtInterior.TabIndex = 28;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(36, 514);
            Label9.Name = "Label9";
            Label9.Size = new Size(235, 41);
            Label9.TabIndex = 27;
            Label9.Text = "Interior Vehiculo";
            Label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // btbuscarvendedor
            // 
            btbuscarvendedor.Image = My.Resources.Resources.hacer_clic;
            btbuscarvendedor.Location = new Point(692, 92);
            btbuscarvendedor.Name = "btbuscarvendedor";
            btbuscarvendedor.Size = new Size(50, 47);
            btbuscarvendedor.SizeMode = PictureBoxSizeMode.Zoom;
            btbuscarvendedor.TabIndex = 47;
            btbuscarvendedor.TabStop = false;
            // 
            // pic1
            // 
            pic1.Image = My.Resources.Resources.hacer_clic;
            pic1.Location = new Point(692, 161);
            pic1.Name = "pic1";
            pic1.Size = new Size(50, 47);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 48;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.Image = My.Resources.Resources.hacer_clic;
            pic2.Location = new Point(692, 230);
            pic2.Name = "pic2";
            pic2.Size = new Size(50, 47);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 49;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.Image = My.Resources.Resources.hacer_clic;
            pic3.Location = new Point(692, 293);
            pic3.Name = "pic3";
            pic3.Size = new Size(50, 47);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.TabIndex = 50;
            pic3.TabStop = false;
            // 
            // pic4
            // 
            pic4.Image = My.Resources.Resources.hacer_clic;
            pic4.Location = new Point(692, 370);
            pic4.Name = "pic4";
            pic4.Size = new Size(50, 47);
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            pic4.TabIndex = 51;
            pic4.TabStop = false;
            // 
            // pic5
            // 
            pic5.Image = My.Resources.Resources.hacer_clic;
            pic5.Location = new Point(692, 441);
            pic5.Name = "pic5";
            pic5.Size = new Size(50, 47);
            pic5.SizeMode = PictureBoxSizeMode.Zoom;
            pic5.TabIndex = 52;
            pic5.TabStop = false;
            // 
            // pic6
            // 
            pic6.Image = My.Resources.Resources.hacer_clic;
            pic6.Location = new Point(692, 508);
            pic6.Name = "pic6";
            pic6.Size = new Size(50, 47);
            pic6.SizeMode = PictureBoxSizeMode.Zoom;
            pic6.TabIndex = 53;
            pic6.TabStop = false;
            // 
            // txtVin
            // 
            txtVin.Location = new Point(348, 620);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(394, 47);
            txtVin.TabIndex = 55;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(36, 626);
            Label3.Name = "Label3";
            Label3.Size = new Size(306, 41);
            Label3.TabIndex = 54;
            Label3.Text = "Codigo Vehiculo (Vin)";
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Format = DateTimePickerFormat.Short;
            DateTimePicker1.Location = new Point(114, 682);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(200, 47);
            DateTimePicker1.TabIndex = 56;
            // 
            // VehiculoAgregarActualizar
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 788);
            Controls.Add(DateTimePicker1);
            Controls.Add(txtVin);
            Controls.Add(Label3);
            Controls.Add(pic6);
            Controls.Add(pic5);
            Controls.Add(pic4);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Controls.Add(btbuscarvendedor);
            Controls.Add(TxtInterior);
            Controls.Add(Label9);
            Controls.Add(TxtColor);
            Controls.Add(txtTransmision);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(txtcarroceria);
            Controls.Add(Label8);
            Controls.Add(txtvariante);
            Controls.Add(txtagencia);
            Controls.Add(Label4);
            Controls.Add(Label5);
            Controls.Add(Button1);
            Controls.Add(txtModelo);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Lb1);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "VehiculoAgregarActualizar";
            Text = "VehiculoAgregarActualizar";
            ((System.ComponentModel.ISupportInitialize)btbuscarvendedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic6).EndInit();
            Load += new EventHandler(VehiculoAgregarActualizar_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Lb1;
        internal Button Button1;
        internal TextBox txtModelo;
        internal Label Label2;
        internal Label Label1;
        internal TextBox txtvariante;
        internal TextBox txtagencia;
        internal Label Label4;
        internal Label Label5;
        internal TextBox TxtColor;
        internal TextBox txtTransmision;
        internal Label Label6;
        internal Label Label7;
        internal TextBox txtcarroceria;
        internal Label Label8;
        internal TextBox TxtInterior;
        internal Label Label9;
        internal PictureBox btbuscarvendedor;
        internal PictureBox pic1;
        internal PictureBox pic2;
        internal PictureBox pic3;
        internal PictureBox pic4;
        internal PictureBox pic5;
        internal PictureBox pic6;
        internal TextBox txtVin;
        internal Label Label3;
        internal DateTimePicker DateTimePicker1;
    }
}