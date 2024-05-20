using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class busquedaedoventa : Form
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
            RdNombre = new RadioButton();
            Rdid = new RadioButton();
            txtbuscar = new TextBox();
            txtbuscar.TextChanged += new EventHandler(txtbuscar_TextChanged);
            ListId = new ListBox();
            ListId.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
            ListId.DoubleClick += new EventHandler(ListId_DoubleClick);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ListEdo = new ListBox();
            ListEdo.SelectedIndexChanged += new EventHandler(ListEdo_SelectedIndexChanged);
            ListEdo.DoubleClick += new EventHandler(ListEdo_DoubleClick);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(21, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(515, 41);
            Label1.TabIndex = 10;
            Label1.Text = "Busqueda Avanzada Estados de venta";
            // 
            // RdNombre
            // 
            RdNombre.AutoSize = true;
            RdNombre.Location = new Point(665, 78);
            RdNombre.Name = "RdNombre";
            RdNombre.Size = new Size(149, 45);
            RdNombre.TabIndex = 9;
            RdNombre.TabStop = true;
            RdNombre.Text = "Nombre";
            RdNombre.UseVisualStyleBackColor = true;
            // 
            // Rdid
            // 
            Rdid.AutoSize = true;
            Rdid.Location = new Point(599, 78);
            Rdid.Name = "Rdid";
            Rdid.Size = new Size(65, 45);
            Rdid.TabIndex = 8;
            Rdid.TabStop = true;
            Rdid.Text = "Id";
            Rdid.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(24, 75);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(569, 47);
            txtbuscar.TabIndex = 7;
            // 
            // ListId
            // 
            ListId.FormattingEnabled = true;
            ListId.ItemHeight = 41;
            ListId.Location = new Point(24, 139);
            ListId.Name = "ListId";
            ListId.Size = new Size(144, 537);
            ListId.TabIndex = 11;
            // 
            // ListEdo
            // 
            ListEdo.FormattingEnabled = true;
            ListEdo.ItemHeight = 41;
            ListEdo.Location = new Point(174, 139);
            ListEdo.Name = "ListEdo";
            ListEdo.Size = new Size(640, 537);
            ListEdo.TabIndex = 12;
            // 
            // busquedaedoventa
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 697);
            Controls.Add(ListEdo);
            Controls.Add(ListId);
            Controls.Add(Label1);
            Controls.Add(RdNombre);
            Controls.Add(Rdid);
            Controls.Add(txtbuscar);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "busquedaedoventa";
            Text = "busquedaedoventa";
            Load += new EventHandler(busquedaedoventa_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal RadioButton RdNombre;
        internal RadioButton Rdid;
        internal TextBox txtbuscar;
        internal ListBox ListId;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal ListBox ListEdo;
    }
}