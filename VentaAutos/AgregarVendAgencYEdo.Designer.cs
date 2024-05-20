using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarVendAgencYEdo : Form
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
            TxtNombre = new TextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label2 = new Label();
            txtid = new TextBox();
            Label3 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(21, 160);
            Label1.Name = "Label1";
            Label1.Size = new Size(135, 41);
            Label1.TabIndex = 0;
            Label1.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(165, 154);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(758, 47);
            TxtNombre.TabIndex = 1;
            // 
            // Button1
            // 
            Button1.Location = new Point(696, 212);
            Button1.Name = "Button1";
            Button1.Size = new Size(227, 56);
            Button1.TabIndex = 2;
            Button1.Text = "Aceptar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 24.0f, FontStyle.Bold);
            Label2.ForeColor = Color.Maroon;
            Label2.Location = new Point(21, 19);
            Label2.Name = "Label2";
            Label2.Size = new Size(141, 54);
            Label2.TabIndex = 3;
            Label2.Text = "Label2";
            // 
            // txtid
            // 
            txtid.Location = new Point(165, 101);
            txtid.Name = "txtid";
            txtid.Size = new Size(159, 47);
            txtid.TabIndex = 5;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(105, 107);
            Label3.Name = "Label3";
            Label3.Size = new Size(51, 41);
            Label3.TabIndex = 4;
            Label3.Text = "Id:";
            // 
            // AgregarVendAgencYEdo
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 282);
            Controls.Add(txtid);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Button1);
            Controls.Add(TxtNombre);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "AgregarVendAgencYEdo";
            Text = "AgregarVendAgencYEdo";
            Load += new EventHandler(AgregarVendAgencYEdo_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal TextBox TxtNombre;
        internal Button Button1;
        internal Label Label2;
        internal TextBox txtid;
        internal Label Label3;
    }
}