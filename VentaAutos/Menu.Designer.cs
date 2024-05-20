using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MenuOpciones : Form
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
            components = new System.ComponentModel.Container();
            Label5 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            Button8 = new Button();
            Button8.Click += new EventHandler(Button8_Click);
            Button9 = new Button();
            Button9.Click += new EventHandler(Button9_Click);
            Button10 = new Button();
            Button10.Click += new EventHandler(Button10_Click);
            Button12 = new Button();
            Button12.Click += new EventHandler(Button12_Click);
            GroupBox1 = new GroupBox();
            txthoraactual = new Label();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            txtsaludo = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            Label1 = new Label();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 25.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.Maroon;
            Label5.Location = new Point(31, 26);
            Label5.Name = "Label5";
            Label5.Size = new Size(1043, 59);
            Label5.TabIndex = 4;
            Label5.Text = "Sistema de Gestion de Ventas de Vehiculos en (USA)";
            // 
            // Button1
            // 
            Button1.Location = new Point(41, 219);
            Button1.Name = "Button1";
            Button1.Size = new Size(1444, 86);
            Button1.TabIndex = 5;
            Button1.Text = "Ventas de Vehiculos";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Location = new Point(1008, 335);
            Button4.Name = "Button4";
            Button4.Size = new Size(477, 86);
            Button4.TabIndex = 8;
            Button4.Text = "Estados";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(42, 335);
            Button2.Name = "Button2";
            Button2.Size = new Size(477, 86);
            Button2.TabIndex = 9;
            Button2.Text = "Vendedores";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(48, 51);
            Button3.Name = "Button3";
            Button3.Size = new Size(339, 138);
            Button3.TabIndex = 10;
            Button3.Text = "Vehiculos";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.Location = new Point(407, 131);
            Button5.Name = "Button5";
            Button5.Size = new Size(288, 58);
            Button5.TabIndex = 13;
            Button5.Text = "Modelos";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.Location = new Point(407, 51);
            Button6.Name = "Button6";
            Button6.Size = new Size(288, 58);
            Button6.TabIndex = 12;
            Button6.Text = "Carroceria";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.Location = new Point(1088, 51);
            Button7.Name = "Button7";
            Button7.Size = new Size(385, 58);
            Button7.TabIndex = 11;
            Button7.Text = "Interior del Vehiculo";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Button8
            // 
            Button8.Location = new Point(715, 51);
            Button8.Name = "Button8";
            Button8.Size = new Size(348, 58);
            Button8.TabIndex = 16;
            Button8.Text = "Variantes";
            Button8.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            Button9.Location = new Point(1088, 131);
            Button9.Name = "Button9";
            Button9.Size = new Size(385, 58);
            Button9.TabIndex = 15;
            Button9.Text = "Colores Exteriores";
            Button9.UseVisualStyleBackColor = true;
            // 
            // Button10
            // 
            Button10.Location = new Point(525, 335);
            Button10.Name = "Button10";
            Button10.Size = new Size(477, 86);
            Button10.TabIndex = 14;
            Button10.Text = "Agencias";
            Button10.UseVisualStyleBackColor = true;
            // 
            // Button12
            // 
            Button12.Location = new Point(715, 131);
            Button12.Name = "Button12";
            Button12.Size = new Size(348, 58);
            Button12.TabIndex = 17;
            Button12.Text = "Transmisión";
            Button12.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Button12);
            GroupBox1.Controls.Add(Button8);
            GroupBox1.Controls.Add(Button3);
            GroupBox1.Controls.Add(Button9);
            GroupBox1.Controls.Add(Button7);
            GroupBox1.Controls.Add(Button6);
            GroupBox1.Controls.Add(Button5);
            GroupBox1.Location = new Point(12, 441);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(1500, 213);
            GroupBox1.TabIndex = 18;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Vehiculos y Complementos";
            // 
            // txthoraactual
            // 
            txthoraactual.AutoSize = true;
            txthoraactual.Font = new Font("Segoe UI Semibold", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txthoraactual.Location = new Point(1324, 24);
            txthoraactual.Name = "txthoraactual";
            txthoraactual.Size = new Size(0, 41);
            txthoraactual.TabIndex = 19;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            // 
            // txtsaludo
            // 
            txtsaludo.AutoSize = true;
            txtsaludo.Font = new Font("Segoe UI", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsaludo.Location = new Point(35, 101);
            txtsaludo.Name = "txtsaludo";
            txtsaludo.Size = new Size(219, 41);
            txtsaludo.TabIndex = 20;
            txtsaludo.Text = "Hola de nuevo ";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.privacidad__1_;
            PictureBox1.Location = new Point(1331, 119);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(116, 94);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 21;
            PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(1268, 82);
            Label1.Name = "Label1";
            Label1.Size = new Size(244, 38);
            Label1.TabIndex = 22;
            Label1.Text = "Opciones de perfil";
            // 
            // MenuOpciones
            // 
            AutoScaleDimensions = new SizeF(15.0f, 37.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Controls.Add(txtsaludo);
            Controls.Add(txthoraactual);
            Controls.Add(Button10);
            Controls.Add(Button2);
            Controls.Add(Button4);
            Controls.Add(Button1);
            Controls.Add(Label5);
            Controls.Add(GroupBox1);
            Font = new Font("Segoe UI", 16.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MenuOpciones";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(MenuOpciones_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label5;
        internal Button Button1;
        internal Button Button4;
        internal Button Button2;
        internal Button Button3;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
        internal Button Button8;
        internal Button Button9;
        internal Button Button10;
        internal Button Button12;
        internal GroupBox GroupBox1;
        internal Label txthoraactual;
        internal Timer Timer1;
        internal Label txtsaludo;
        internal PictureBox PictureBox1;
        internal Label Label1;
    }
}