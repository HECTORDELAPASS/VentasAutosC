using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VentaAutos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Carga : Form
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
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer2 = new Timer(components);
            Timer2.Tick += new EventHandler(Timer2_Tick);
            CircularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            lb1 = new Label();
            Label1 = new Label();
            PictureBox2 = new PictureBox();
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Timer1
            // 
            Timer1.Interval = 15;
            // 
            // Timer2
            // 
            Timer2.Interval = 30;
            // 
            // CircularProgressBar1
            // 
            CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            CircularProgressBar1.AnimationSpeed = 500;
            CircularProgressBar1.BackColor = Color.FromArgb(22, 22, 22);
            CircularProgressBar1.Font = new Font("Microsoft Sans Serif", 72.0f, FontStyle.Bold);
            CircularProgressBar1.ForeColor = Color.White;
            CircularProgressBar1.InnerColor = Color.FromArgb(22, 22, 22);
            CircularProgressBar1.InnerMargin = 2;
            CircularProgressBar1.InnerWidth = -1;
            CircularProgressBar1.Location = new Point(43, 187);
            CircularProgressBar1.MarqueeAnimationSpeed = 2000;
            CircularProgressBar1.Name = "CircularProgressBar1";
            CircularProgressBar1.OuterColor = Color.DarkGoldenrod;
            CircularProgressBar1.OuterMargin = -25;
            CircularProgressBar1.OuterWidth = 26;
            CircularProgressBar1.ProgressColor = Color.Yellow;
            CircularProgressBar1.ProgressWidth = 20;
            CircularProgressBar1.SecondaryFont = new Font("Microsoft Sans Serif", 36.0f);
            CircularProgressBar1.Size = new Size(234, 236);
            CircularProgressBar1.StartAngle = 270;
            CircularProgressBar1.Style = ProgressBarStyle.Marquee;
            CircularProgressBar1.SubscriptColor = Color.White;
            CircularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            CircularProgressBar1.SubscriptText = "%";
            CircularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            CircularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            CircularProgressBar1.SuperscriptText = "";
            CircularProgressBar1.TabIndex = 3;
            CircularProgressBar1.Text = "0";
            CircularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            CircularProgressBar1.Value = 68;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI Semibold", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.ForeColor = Color.White;
            lb1.Location = new Point(37, 83);
            lb1.Margin = new Padding(6, 0, 6, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(171, 41);
            lb1.TabIndex = 4;
            lb1.Text = "bienvenido";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 28.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(126, 7);
            Label1.Margin = new Padding(6, 0, 6, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(736, 62);
            Label1.TabIndex = 5;
            Label1.Text = "Automobile Sales Control System";
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.marca;
            PictureBox2.Location = new Point(713, -45);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(282, 308);
            PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBox2.TabIndex = 6;
            PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Presentación1;
            PictureBox1.Location = new Point(-6, 156);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(979, 310);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Carga
            // 
            AutoScaleDimensions = new SizeF(17.0f, 41.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(969, 463);
            Controls.Add(Label1);
            Controls.Add(lb1);
            Controls.Add(CircularProgressBar1);
            Controls.Add(PictureBox1);
            Controls.Add(PictureBox2);
            Font = new Font("Segoe UI", 18.0f);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 8, 6, 8);
            Name = "Carga";
            Text = "Carga";
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Carga_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal PictureBox PictureBox1;
        internal Timer Timer1;
        internal Timer Timer2;
        internal CircularProgressBar.CircularProgressBar CircularProgressBar1;
        internal Label lb1;
        internal Label Label1;
        internal PictureBox PictureBox2;
    }
}