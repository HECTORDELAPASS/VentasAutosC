using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InicioSeccion : Form
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
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            Label2 = new Label();
            picsi = new PictureBox();
            picsi.Click += new EventHandler(picsi_Click_1);
            Label3 = new Label();
            picno = new PictureBox();
            picno.Click += new EventHandler(picno_Click_1);
            txtusuario = new TextBox();
            txtcontra = new TextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click_1);
            txtNotengo = new Label();
            txtNotengo.Click += new EventHandler(txtNotengo_Click);
            Panel1 = new Panel();
            Panel2 = new Panel();
            txtcreanombre = new TextBox();
            txtcrear = new Button();
            txtcrear.Click += new EventHandler(txtcrear_Click);
            Label5 = new Label();
            Label4 = new Label();
            txtcreausername = new TextBox();
            Label6 = new Label();
            txtcreacontra = new TextBox();
            Label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picsi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picno).BeginInit();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(339, 41);
            Label1.TabIndex = 0;
            Label1.Text = "Control de credenciales";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.salida_de_emergencia;
            PictureBox1.Location = new Point(720, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(78, 61);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 6;
            PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(11, 24);
            Label2.Name = "Label2";
            Label2.Size = new Size(275, 41);
            Label2.TabIndex = 9;
            Label2.Text = "Nombre de usuario";
            // 
            // picsi
            // 
            picsi.Image = My.Resources.Resources.ver;
            picsi.Location = new Point(732, 98);
            picsi.Name = "picsi";
            picsi.Size = new Size(34, 41);
            picsi.SizeMode = PictureBoxSizeMode.Zoom;
            picsi.TabIndex = 15;
            picsi.TabStop = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(11, 104);
            Label3.Name = "Label3";
            Label3.Size = new Size(168, 41);
            Label3.TabIndex = 10;
            Label3.Text = "Contraseña";
            // 
            // picno
            // 
            picno.Image = My.Resources.Resources.ojo__1_;
            picno.Location = new Point(732, 98);
            picno.Name = "picno";
            picno.Size = new Size(34, 41);
            picno.SizeMode = PictureBoxSizeMode.Zoom;
            picno.TabIndex = 14;
            picno.TabStop = false;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(292, 18);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(474, 47);
            txtusuario.TabIndex = 11;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(185, 98);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(528, 47);
            txtcontra.TabIndex = 12;
            // 
            // Button1
            // 
            Button1.Location = new Point(590, 160);
            Button1.Name = "Button1";
            Button1.Size = new Size(176, 48);
            Button1.TabIndex = 13;
            Button1.Text = "Continuar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // txtNotengo
            // 
            txtNotengo.AutoSize = true;
            txtNotengo.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotengo.ForeColor = Color.Red;
            txtNotengo.Location = new Point(634, 309);
            txtNotengo.Name = "txtNotengo";
            txtNotengo.Size = new Size(162, 28);
            txtNotengo.TabIndex = 17;
            txtNotengo.Text = "No tengo Cuenta";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(txtusuario);
            Panel1.Controls.Add(picno);
            Panel1.Controls.Add(picsi);
            Panel1.Controls.Add(txtcontra);
            Panel1.Controls.Add(Button1);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(12, 77);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(786, 220);
            Panel1.TabIndex = 19;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(Label7);
            Panel2.Controls.Add(txtcreacontra);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(txtcreausername);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(txtcreanombre);
            Panel2.Controls.Add(txtcrear);
            Panel2.Controls.Add(Label5);
            Panel2.Location = new Point(10, 74);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(786, 220);
            Panel2.TabIndex = 20;
            // 
            // txtcreanombre
            // 
            txtcreanombre.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcreanombre.Location = new Point(228, 52);
            txtcreanombre.Name = "txtcreanombre";
            txtcreanombre.Size = new Size(474, 38);
            txtcreanombre.TabIndex = 11;
            // 
            // txtcrear
            // 
            txtcrear.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcrear.Location = new Point(600, 165);
            txtcrear.Name = "txtcrear";
            txtcrear.Size = new Size(183, 38);
            txtcrear.TabIndex = 13;
            txtcrear.Text = "Crear Usuario";
            txtcrear.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(11, 59);
            Label5.Name = "Label5";
            Label5.Size = new Size(211, 31);
            Label5.TabIndex = 9;
            Label5.Text = "Nombre de usuario";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(11, 118);
            Label4.Name = "Label4";
            Label4.Size = new Size(186, 31);
            Label4.TabIndex = 14;
            Label4.Text = "Nombre Publico ";
            // 
            // txtcreausername
            // 
            txtcreausername.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcreausername.Location = new Point(203, 111);
            txtcreausername.Name = "txtcreausername";
            txtcreausername.Size = new Size(499, 38);
            txtcreausername.TabIndex = 15;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(11, 173);
            Label6.Name = "Label6";
            Label6.Size = new Size(129, 31);
            Label6.TabIndex = 16;
            Label6.Text = "Contraseña";
            // 
            // txtcreacontra
            // 
            txtcreacontra.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcreacontra.Location = new Point(146, 166);
            txtcreacontra.Name = "txtcreacontra";
            txtcreacontra.Size = new Size(448, 38);
            txtcreacontra.TabIndex = 17;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.FromArgb(192, 0, 0);
            Label7.Location = new Point(11, 6);
            Label7.Name = "Label7";
            Label7.Size = new Size(156, 31);
            Label7.TabIndex = 18;
            Label7.Text = "Crear Usuario";
            // 
            // InicioSeccion
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 355);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(txtNotengo);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "InicioSeccion";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picsi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picno).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Load += new EventHandler(InicioSeccion_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Label Label2;
        internal PictureBox picsi;
        internal Label Label3;
        internal PictureBox picno;
        internal TextBox txtusuario;
        internal TextBox txtcontra;
        internal Button Button1;
        internal Label txtNotengo;
        internal Panel Panel1;
        internal Panel Panel2;
        internal TextBox txtcreanombre;
        internal Button txtcrear;
        internal Label Label5;
        internal Label Label7;
        internal TextBox txtcreacontra;
        internal Label Label6;
        internal TextBox txtcreausername;
        internal Label Label4;
    }
}