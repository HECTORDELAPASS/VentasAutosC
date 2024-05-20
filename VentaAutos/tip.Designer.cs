using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class tip : Form
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
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            Label2 = new Label();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 24.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(36, 32);
            Label1.Name = "Label1";
            Label1.Size = new Size(548, 54);
            Label1.TabIndex = 0;
            Label1.Text = "Para una busqueda avanzada";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.hacer_clic;
            PictureBox1.Location = new Point(81, 143);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(406, 324);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 24.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(36, 86);
            Label2.Name = "Label2";
            Label2.Size = new Size(358, 54);
            Label2.TabIndex = 2;
            Label2.Text = "Click en este icono";
            // 
            // Timer1
            // 
            Timer1.Interval = 10;
            // 
            // tip
            // 
            AutoScaleDimensions = new SizeF(15.0f, 37.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(585, 479);
            Controls.Add(Label2);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 16.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "tip";
            Text = "tip";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(tip_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Label Label2;
        internal Timer Timer1;
    }
}