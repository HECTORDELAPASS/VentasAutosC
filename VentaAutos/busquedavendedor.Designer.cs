using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class busquedavendedor : Form
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
            txtbuscar = new TextBox();
            txtbuscar.TextChanged += new EventHandler(TextBox1_TextChanged);
            Rdid = new RadioButton();
            RdNombre = new RadioButton();
            Label1 = new Label();
            DataGridView1 = new DataGridView();
            DataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(15, 62);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(569, 47);
            txtbuscar.TabIndex = 2;
            // 
            // Rdid
            // 
            Rdid.AutoSize = true;
            Rdid.Location = new Point(590, 65);
            Rdid.Name = "Rdid";
            Rdid.Size = new Size(65, 45);
            Rdid.TabIndex = 3;
            Rdid.TabStop = true;
            Rdid.Text = "Id";
            Rdid.UseVisualStyleBackColor = true;
            // 
            // RdNombre
            // 
            RdNombre.AutoSize = true;
            RdNombre.Location = new Point(656, 65);
            RdNombre.Name = "RdNombre";
            RdNombre.Size = new Size(149, 45);
            RdNombre.TabIndex = 4;
            RdNombre.TabStop = true;
            RdNombre.Text = "Nombre";
            RdNombre.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(450, 41);
            Label1.TabIndex = 5;
            Label1.Text = "Busqueda Avanzada Vendedores";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(15, 139);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(787, 522);
            DataGridView1.TabIndex = 6;
            // 
            // busquedavendedor
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 685);
            Controls.Add(DataGridView1);
            Controls.Add(Label1);
            Controls.Add(RdNombre);
            Controls.Add(Rdid);
            Controls.Add(txtbuscar);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "busquedavendedor";
            Text = "busquedavendedor";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(busquedavendedor_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal TextBox txtbuscar;
        internal RadioButton Rdid;
        internal RadioButton RdNombre;
        internal Label Label1;
        internal DataGridView DataGridView1;
    }
}