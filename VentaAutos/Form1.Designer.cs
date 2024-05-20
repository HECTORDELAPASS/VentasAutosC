using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
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
            DataGridView1 = new DataGridView();
            DataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            CboEdo = new ComboBox();
            CboEdo.SelectedIndexChanged += new EventHandler(CboEdo_SelectedIndexChanged);
            CboAgen = new ComboBox();
            CboAgen.SelectedIndexChanged += new EventHandler(CboAgen_SelectedIndexChanged);
            txtbuscar = new TextBox();
            txtbuscar.TextChanged += new EventHandler(TextBox1_TextChanged);
            CboYear = new ComboBox();
            CboYear.SelectedIndexChanged += new EventHandler(CboYear_SelectedIndexChanged);
            d = new Label();
            d.Click += new EventHandler(d_Click);
            R1 = new RadioButton();
            R2 = new RadioButton();
            Label2 = new Label();
            GroupBox1 = new GroupBox();
            Label1 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click_1);
            Label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(22, 173);
            DataGridView1.Margin = new Padding(6, 7, 6, 7);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(1493, 624);
            DataGridView1.TabIndex = 0;
            // 
            // CboEdo
            // 
            CboEdo.FormattingEnabled = true;
            CboEdo.Location = new Point(22, 104);
            CboEdo.Margin = new Padding(6, 7, 6, 7);
            CboEdo.Name = "CboEdo";
            CboEdo.Size = new Size(294, 45);
            CboEdo.TabIndex = 1;
            // 
            // CboAgen
            // 
            CboAgen.FormattingEnabled = true;
            CboAgen.Location = new Point(349, 104);
            CboAgen.Margin = new Padding(6, 7, 6, 7);
            CboAgen.Name = "CboAgen";
            CboAgen.Size = new Size(294, 45);
            CboAgen.TabIndex = 2;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Segoe UI Semilight", 16.2f);
            txtbuscar.Location = new Point(18, 35);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(332, 43);
            txtbuscar.TabIndex = 3;
            // 
            // CboYear
            // 
            CboYear.FormattingEnabled = true;
            CboYear.Location = new Point(677, 104);
            CboYear.Margin = new Padding(6, 7, 6, 7);
            CboYear.Name = "CboYear";
            CboYear.Size = new Size(187, 45);
            CboYear.TabIndex = 4;
            // 
            // d
            // 
            d.AutoSize = true;
            d.Font = new Font("Segoe UI Semilight", 12.0f);
            d.Location = new Point(672, 79);
            d.Name = "d";
            d.Size = new Size(164, 28);
            d.TabIndex = 6;
            d.Text = "Fecha Por Estados";
            // 
            // R1
            // 
            R1.AutoSize = true;
            R1.Font = new Font("Segoe UI Semilight", 12.0f);
            R1.Location = new Point(365, 44);
            R1.Name = "R1";
            R1.Size = new Size(47, 32);
            R1.TabIndex = 8;
            R1.TabStop = true;
            R1.Text = "Si";
            R1.UseVisualStyleBackColor = true;
            // 
            // R2
            // 
            R2.AutoSize = true;
            R2.Font = new Font("Segoe UI Semilight", 12.0f);
            R2.Location = new Point(420, 44);
            R2.Name = "R2";
            R2.Size = new Size(59, 32);
            R2.TabIndex = 9;
            R2.TabStop = true;
            R2.Text = "No";
            R2.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semilight", 12.0f);
            Label2.Location = new Point(351, 18);
            Label2.Name = "Label2";
            Label2.Size = new Size(124, 28);
            Label2.TabIndex = 10;
            Label2.Text = "Filtrar Fecha?";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(R2);
            GroupBox1.Controls.Add(R1);
            GroupBox1.Controls.Add(txtbuscar);
            GroupBox1.Font = new Font("Segoe UI Semilight", 12.0f);
            GroupBox1.Location = new Point(864, 71);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(507, 92);
            GroupBox1.TabIndex = 11;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Busqueda Por Estado";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semilight", 12.0f);
            Label1.Location = new Point(17, 79);
            Label1.Name = "Label1";
            Label1.Size = new Size(76, 28);
            Label1.TabIndex = 12;
            Label1.Text = "Estados";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semilight", 12.0f);
            Label3.Location = new Point(344, 79);
            Label3.Name = "Label3";
            Label3.Size = new Size(88, 28);
            Label3.TabIndex = 13;
            Label3.Text = "Agencias";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Semibold", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(17, 5);
            Label4.Name = "Label4";
            Label4.Size = new Size(1004, 41);
            Label4.TabIndex = 14;
            Label4.Text = "Ventas de Vehiculos, segmentadas por el Estado de venta y sus Agencias";
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.agregar_carrito;
            PictureBox2.Location = new Point(1412, 79);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(103, 84);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 45;
            PictureBox2.TabStop = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semilight", 12.0f);
            Label5.Location = new Point(1381, 48);
            Label5.Name = "Label5";
            Label5.Size = new Size(134, 28);
            Label5.TabIndex = 46;
            Label5.Text = "Agregar Venta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15.0f, 37.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(Label5);
            Controls.Add(PictureBox2);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Controls.Add(GroupBox1);
            Controls.Add(d);
            Controls.Add(CboYear);
            Controls.Add(CboAgen);
            Controls.Add(CboEdo);
            Controls.Add(DataGridView1);
            Font = new Font("Segoe UI Semilight", 16.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal ComboBox CboEdo;
        internal ComboBox CboAgen;
        internal TextBox txtbuscar;
        internal ComboBox CboYear;
        internal Label d;
        internal RadioButton R1;
        internal RadioButton R2;
        internal Label Label2;
        internal GroupBox GroupBox1;
        internal Label Label1;
        internal Label Label3;
        internal Label Label4;
        internal PictureBox PictureBox2;
        internal Label Label5;
    }
}