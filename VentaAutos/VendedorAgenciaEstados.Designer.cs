using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class VendedorAgenciaEstados : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(VendedorAgenciaEstados));
            DataGridView1 = new DataGridView();
            DataGridView1.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellClick);
            DataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            Lb1 = new Label();
            txtbuscar = new TextBox();
            txtbuscar.TextChanged += new EventHandler(txtbuscar_TextChanged);
            lb2 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            PictureBox3 = new PictureBox();
            PictureBox3.Click += new EventHandler(PictureBox3_Click);
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(299, 111);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(1203, 687);
            DataGridView1.TabIndex = 0;
            // 
            // Lb1
            // 
            Lb1.AutoSize = true;
            Lb1.Font = new Font("Segoe UI Semibold", 28.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb1.ForeColor = Color.Maroon;
            Lb1.Location = new Point(12, 9);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(159, 62);
            Lb1.TabIndex = 1;
            Lb1.Text = "Label1";
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(617, 61);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(826, 47);
            txtbuscar.TabIndex = 2;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(292, 65);
            lb2.Name = "lb2";
            lb2.Size = new Size(112, 41);
            lb2.TabIndex = 3;
            lb2.Text = "Buscar ";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 13.0f);
            Label1.Location = new Point(58, 280);
            Label1.Name = "Label1";
            Label1.Size = new Size(177, 30);
            Label1.TabIndex = 5;
            Label1.Text = "Agregar Registro";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 13.0f);
            Label2.Location = new Point(58, 511);
            Label2.Name = "Label2";
            Label2.Size = new Size(191, 30);
            Label2.TabIndex = 7;
            Label2.Text = "Actualizar Registro";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 13.0f);
            Label3.Location = new Point(58, 748);
            Label3.Name = "Label3";
            Label3.Size = new Size(174, 30);
            Label3.TabIndex = 9;
            Label3.Text = "Eliminar Registro";
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(44, 579);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(193, 166);
            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox3.TabIndex = 8;
            PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(44, 342);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(193, 166);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 6;
            PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(44, 111);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(193, 166);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 4;
            PictureBox1.TabStop = false;
            // 
            // VendedorAgenciaEstados
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 810);
            Controls.Add(Label3);
            Controls.Add(PictureBox3);
            Controls.Add(Label2);
            Controls.Add(PictureBox2);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Controls.Add(lb2);
            Controls.Add(txtbuscar);
            Controls.Add(Lb1);
            Controls.Add(DataGridView1);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "VendedorAgenciaEstados";
            Text = "VendedorAgenciaEstados";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(VendedorAgenciaEstados_Load);
            Closed += new EventHandler(VendedorAgenciaEstados_Closed);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal Label Lb1;
        internal TextBox txtbuscar;
        internal Label lb2;
        internal PictureBox PictureBox1;
        internal Label Label1;
        internal Label Label2;
        internal PictureBox PictureBox2;
        internal Label Label3;
        internal PictureBox PictureBox3;
    }
}