using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class OpcUsuarios : Form
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
            TabPage2 = new TabPage();
            panelactualizar = new Panel();
            Label8 = new Label();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            txtcontractualizar2 = new TextBox();
            txtnombreactualizar2 = new TextBox();
            Label6 = new Label();
            txtusernameactualizar2 = new TextBox();
            Label7 = new Label();
            panelbuscar = new Panel();
            Label4 = new Label();
            txtusuario2 = new TextBox();
            TabControl1 = new TabControl();
            TabPage3 = new TabPage();
            TabPage3.Click += new EventHandler(TabPage3_Click);
            DataGridView1 = new DataGridView();
            DataGridView1.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellClick);
            txtnombre = new TextBox();
            Label2 = new Label();
            txtusername = new TextBox();
            Label3 = new Label();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            TabPage2.SuspendLayout();
            panelactualizar.SuspendLayout();
            panelbuscar.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(339, 41);
            Label1.TabIndex = 10;
            Label1.Text = "Control de credenciales";
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(panelactualizar);
            TabPage2.Controls.Add(panelbuscar);
            TabPage2.Location = new Point(4, 50);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(856, 347);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Actualizar mi Informacion";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // panelactualizar
            // 
            panelactualizar.Controls.Add(Label8);
            panelactualizar.Controls.Add(Button2);
            panelactualizar.Controls.Add(txtcontractualizar2);
            panelactualizar.Controls.Add(txtnombreactualizar2);
            panelactualizar.Controls.Add(Label6);
            panelactualizar.Controls.Add(txtusernameactualizar2);
            panelactualizar.Controls.Add(Label7);
            panelactualizar.Location = new Point(7, 139);
            panelactualizar.Name = "panelactualizar";
            panelactualizar.Size = new Size(843, 205);
            panelactualizar.TabIndex = 23;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(27, 142);
            Label8.Name = "Label8";
            Label8.Size = new Size(129, 31);
            Label8.TabIndex = 21;
            Label8.Text = "Contraseña";
            // 
            // Button2
            // 
            Button2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.Location = new Point(683, 147);
            Button2.Name = "Button2";
            Button2.Size = new Size(158, 48);
            Button2.TabIndex = 20;
            Button2.Text = "Actualizar";
            Button2.UseVisualStyleBackColor = true;
            // 
            // txtcontractualizar2
            // 
            txtcontractualizar2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontractualizar2.Location = new Point(162, 134);
            txtcontractualizar2.Name = "txtcontractualizar2";
            txtcontractualizar2.Size = new Size(490, 38);
            txtcontractualizar2.TabIndex = 22;
            // 
            // txtnombreactualizar2
            // 
            txtnombreactualizar2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombreactualizar2.Location = new Point(238, 36);
            txtnombreactualizar2.Name = "txtnombreactualizar2";
            txtnombreactualizar2.Size = new Size(473, 38);
            txtnombreactualizar2.TabIndex = 18;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(21, 44);
            Label6.Name = "Label6";
            Label6.Size = new Size(211, 31);
            Label6.TabIndex = 16;
            Label6.Text = "Nombre de usuario";
            // 
            // txtusernameactualizar2
            // 
            txtusernameactualizar2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusernameactualizar2.Location = new Point(207, 87);
            txtusernameactualizar2.Name = "txtusernameactualizar2";
            txtusernameactualizar2.Size = new Size(505, 38);
            txtusernameactualizar2.TabIndex = 19;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(21, 94);
            Label7.Name = "Label7";
            Label7.Size = new Size(180, 31);
            Label7.TabIndex = 17;
            Label7.Text = "Nombre Publico";
            // 
            // panelbuscar
            // 
            panelbuscar.Controls.Add(Label4);
            panelbuscar.Controls.Add(txtusuario2);
            panelbuscar.Location = new Point(7, 7);
            panelbuscar.Name = "panelbuscar";
            panelbuscar.Size = new Size(840, 127);
            panelbuscar.TabIndex = 24;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(21, 16);
            Label4.Name = "Label4";
            Label4.Size = new Size(211, 31);
            Label4.TabIndex = 9;
            Label4.Text = "Nombre de usuario";
            // 
            // txtusuario2
            // 
            txtusuario2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusuario2.Location = new Point(238, 9);
            txtusuario2.Name = "txtusuario2";
            txtusuario2.Size = new Size(473, 38);
            txtusuario2.TabIndex = 11;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Location = new Point(20, 79);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(864, 401);
            TabControl1.TabIndex = 12;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(DataGridView1);
            TabPage3.Controls.Add(txtnombre);
            TabPage3.Controls.Add(Label2);
            TabPage3.Controls.Add(txtusername);
            TabPage3.Controls.Add(Label3);
            TabPage3.Controls.Add(Button3);
            TabPage3.Location = new Point(4, 50);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(856, 347);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Borrar Perfil";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(26, 160);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(562, 181);
            DataGridView1.TabIndex = 24;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(235, 52);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(473, 38);
            txtnombre.TabIndex = 22;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(20, 60);
            Label2.Name = "Label2";
            Label2.Size = new Size(211, 31);
            Label2.TabIndex = 20;
            Label2.Text = "Nombre de usuario";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(205, 103);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(505, 38);
            txtusername.TabIndex = 23;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(20, 110);
            Label3.Name = "Label3";
            Label3.Size = new Size(180, 31);
            Label3.TabIndex = 21;
            Label3.Text = "Nombre Publico";
            // 
            // Button3
            // 
            Button3.Location = new Point(602, 274);
            Button3.Name = "Button3";
            Button3.Size = new Size(238, 48);
            Button3.TabIndex = 13;
            Button3.Text = "borrar";
            Button3.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.salida_de_emergencia;
            PictureBox1.Location = new Point(721, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(78, 61);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 11;
            PictureBox1.TabStop = false;
            // 
            // OpcUsuarios
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 485);
            Controls.Add(TabControl1);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 18.0f);
            Margin = new Padding(7, 8, 7, 8);
            Name = "OpcUsuarios";
            Text = "OpcUsuarios";
            TabPage2.ResumeLayout(false);
            panelactualizar.ResumeLayout(false);
            panelactualizar.PerformLayout();
            panelbuscar.ResumeLayout(false);
            panelbuscar.PerformLayout();
            TabControl1.ResumeLayout(false);
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(OpcUsuarios_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal Label Label1;
        internal TabPage TabPage2;
        internal Panel panelactualizar;
        internal Label Label8;
        internal Button Button2;
        internal TextBox txtcontractualizar2;
        internal TextBox txtnombreactualizar2;
        internal Label Label6;
        internal TextBox txtusernameactualizar2;
        internal Label Label7;
        internal Panel panelbuscar;
        internal Label Label4;
        internal TextBox txtusuario2;
        internal TabControl TabControl1;
        internal TabPage TabPage3;
        internal Button Button3;
        internal TextBox txtnombre;
        internal Label Label2;
        internal TextBox txtusername;
        internal Label Label3;
        internal DataGridView DataGridView1;
    }
}