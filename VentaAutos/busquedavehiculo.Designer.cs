using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class busquedavehiculo : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(busquedavehiculo));
            DataGridView1 = new DataGridView();
            DataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            DataGridView1.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellClick);
            txt1 = new Label();
            txtbuscar = new TextBox();
            txtbuscar.TextChanged += new EventHandler(txtbuscar_TextChanged);
            CboAgencia = new ComboBox();
            CboAgencia.SelectedIndexChanged += new EventHandler(CboAgencia_SelectedIndexChanged);
            cboyear = new ComboBox();
            cboyear.SelectedIndexChanged += new EventHandler(cboyear_SelectedIndexChanged);
            txtvin = new TextBox();
            txtvin.TextChanged += new EventHandler(txtvin_TextChanged);
            rdmodelo = new RadioButton();
            rdvin = new RadioButton();
            Agencia = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            lb3 = new Label();
            pic3 = new PictureBox();
            pic3.Click += new EventHandler(pic3_Click);
            lb2 = new Label();
            pic2 = new PictureBox();
            pic2.Click += new EventHandler(pic2_Click);
            lb1 = new Label();
            pic1 = new PictureBox();
            pic1.Click += new EventHandler(pic1_Click);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(20, 214);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(1236, 597);
            DataGridView1.TabIndex = 16;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Font = new Font("Segoe UI Semibold", 28.2f, FontStyle.Bold);
            txt1.ForeColor = Color.Maroon;
            txt1.Location = new Point(13, 14);
            txt1.Name = "txt1";
            txt1.Size = new Size(889, 62);
            txt1.TabIndex = 15;
            txt1.Text = "Busqueda Avanzada Codigo de vehiculo ";
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(662, 127);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(293, 47);
            txtbuscar.TabIndex = 12;
            // 
            // CboAgencia
            // 
            CboAgencia.FormattingEnabled = true;
            CboAgencia.Location = new Point(20, 125);
            CboAgencia.Name = "CboAgencia";
            CboAgencia.Size = new Size(372, 49);
            CboAgencia.TabIndex = 20;
            // 
            // cboyear
            // 
            cboyear.FormattingEnabled = true;
            cboyear.Location = new Point(409, 125);
            cboyear.Name = "cboyear";
            cboyear.Size = new Size(231, 49);
            cboyear.TabIndex = 22;
            // 
            // txtvin
            // 
            txtvin.Location = new Point(1110, 125);
            txtvin.Name = "txtvin";
            txtvin.Size = new Size(293, 47);
            txtvin.TabIndex = 23;
            // 
            // rdmodelo
            // 
            rdmodelo.AutoSize = true;
            rdmodelo.Location = new Point(961, 127);
            rdmodelo.Name = "rdmodelo";
            rdmodelo.Size = new Size(143, 45);
            rdmodelo.TabIndex = 24;
            rdmodelo.TabStop = true;
            rdmodelo.Text = "Modelo";
            rdmodelo.UseVisualStyleBackColor = true;
            // 
            // rdvin
            // 
            rdvin.AutoSize = true;
            rdvin.Location = new Point(1409, 126);
            rdvin.Name = "rdvin";
            rdvin.Size = new Size(82, 45);
            rdvin.TabIndex = 25;
            rdvin.TabStop = true;
            rdvin.Text = "Vin";
            rdvin.UseVisualStyleBackColor = true;
            // 
            // Agencia
            // 
            Agencia.AutoSize = true;
            Agencia.Font = new Font("Segoe UI", 14.0f);
            Agencia.Location = new Point(13, 89);
            Agencia.Name = "Agencia";
            Agencia.Size = new Size(99, 32);
            Agencia.TabIndex = 26;
            Agencia.Text = "Agencia";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 14.0f);
            Label2.Location = new Point(402, 89);
            Label2.Name = "Label2";
            Label2.Size = new Size(57, 32);
            Label2.TabIndex = 27;
            Label2.Text = "Año";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 14.0f);
            Label3.Location = new Point(655, 90);
            Label3.Name = "Label3";
            Label3.Size = new Size(97, 32);
            Label3.TabIndex = 28;
            Label3.Text = "Modelo";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 14.0f);
            Label4.Location = new Point(1103, 89);
            Label4.Name = "Label4";
            Label4.Size = new Size(189, 32);
            Label4.TabIndex = 29;
            Label4.Text = "Codigo Vehiculo";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 13.0f);
            lb3.Location = new Point(1312, 812);
            lb3.Name = "lb3";
            lb3.Size = new Size(174, 30);
            lb3.TabIndex = 35;
            lb3.Text = "Eliminar Registro";
            // 
            // pic3
            // 
            pic3.Image = (Image)resources.GetObject("pic3.Image");
            pic3.Location = new Point(1298, 643);
            pic3.Name = "pic3";
            pic3.Size = new Size(193, 166);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.TabIndex = 34;
            pic3.TabStop = false;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 13.0f);
            lb2.Location = new Point(1312, 575);
            lb2.Name = "lb2";
            lb2.Size = new Size(191, 30);
            lb2.TabIndex = 33;
            lb2.Text = "Actualizar Registro";
            // 
            // pic2
            // 
            pic2.Image = (Image)resources.GetObject("pic2.Image");
            pic2.Location = new Point(1298, 406);
            pic2.Name = "pic2";
            pic2.Size = new Size(193, 166);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 32;
            pic2.TabStop = false;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 13.0f);
            lb1.Location = new Point(1312, 344);
            lb1.Name = "lb1";
            lb1.Size = new Size(177, 30);
            lb1.TabIndex = 31;
            lb1.Text = "Agregar Registro";
            // 
            // pic1
            // 
            pic1.Image = (Image)resources.GetObject("pic1.Image");
            pic1.Location = new Point(1298, 175);
            pic1.Name = "pic1";
            pic1.Size = new Size(193, 166);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 30;
            pic1.TabStop = false;
            // 
            // busquedavehiculo
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(lb3);
            Controls.Add(pic3);
            Controls.Add(lb2);
            Controls.Add(pic2);
            Controls.Add(lb1);
            Controls.Add(pic1);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Agencia);
            Controls.Add(rdvin);
            Controls.Add(rdmodelo);
            Controls.Add(txtvin);
            Controls.Add(cboyear);
            Controls.Add(CboAgencia);
            Controls.Add(DataGridView1);
            Controls.Add(txt1);
            Controls.Add(txtbuscar);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "busquedavehiculo";
            Text = "busquedavehiculo";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            Load += new EventHandler(busquedavehiculo_Load);
            Closed += new EventHandler(busquedavehiculo_Closed);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal Label txt1;
        internal TextBox txtbuscar;
        internal ComboBox CboAgencia;
        internal ComboBox cboyear;
        internal TextBox txtvin;
        internal RadioButton rdmodelo;
        internal RadioButton rdvin;
        internal Label Agencia;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label lb3;
        internal PictureBox pic3;
        internal Label lb2;
        internal PictureBox pic2;
        internal Label lb1;
        internal PictureBox pic1;
    }
}