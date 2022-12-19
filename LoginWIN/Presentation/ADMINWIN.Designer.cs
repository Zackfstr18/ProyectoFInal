namespace Presentation
{
    partial class ADMINWIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINWIN));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbminimize = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pblogout = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHistorialAC = new System.Windows.Forms.Button();
            this.btnRCAJA = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnINVENTARIO = new System.Windows.Forms.Button();
            this.btnINICIO = new System.Windows.Forms.Button();
            this.Pcontenedor = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(99)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbminimize);
            this.panel2.Controls.Add(this.pbclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 33);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(387, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMINISTRACION";
            // 
            // pbminimize
            // 
            this.pbminimize.BackColor = System.Drawing.Color.Transparent;
            this.pbminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbminimize.Image = ((System.Drawing.Image)(resources.GetObject("pbminimize.Image")));
            this.pbminimize.Location = new System.Drawing.Point(842, 0);
            this.pbminimize.Name = "pbminimize";
            this.pbminimize.Size = new System.Drawing.Size(34, 33);
            this.pbminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbminimize.TabIndex = 1;
            this.pbminimize.TabStop = false;
            this.pbminimize.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbclose
            // 
            this.pbclose.BackColor = System.Drawing.Color.Transparent;
            this.pbclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(882, 0);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(34, 30);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose.TabIndex = 0;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.pblogout);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnHistorialAC);
            this.panel1.Controls.Add(this.btnRCAJA);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnINVENTARIO);
            this.panel1.Controls.Add(this.btnINICIO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 492);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pblogout
            // 
            this.pblogout.BackColor = System.Drawing.Color.Transparent;
            this.pblogout.Image = ((System.Drawing.Image)(resources.GetObject("pblogout.Image")));
            this.pblogout.Location = new System.Drawing.Point(3, 453);
            this.pblogout.Name = "pblogout";
            this.pblogout.Size = new System.Drawing.Size(37, 39);
            this.pblogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogout.TabIndex = 5;
            this.pblogout.TabStop = false;
            this.pblogout.Click += new System.EventHandler(this.pblogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnHistorialAC
            // 
            this.btnHistorialAC.FlatAppearance.BorderSize = 0;
            this.btnHistorialAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHistorialAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialAC.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialAC.ForeColor = System.Drawing.Color.White;
            this.btnHistorialAC.Location = new System.Drawing.Point(0, 310);
            this.btnHistorialAC.Name = "btnHistorialAC";
            this.btnHistorialAC.Size = new System.Drawing.Size(164, 23);
            this.btnHistorialAC.TabIndex = 4;
            this.btnHistorialAC.Text = "HISTORIAL ACCESO";
            this.btnHistorialAC.UseVisualStyleBackColor = true;
            this.btnHistorialAC.Click += new System.EventHandler(this.btnHistorialAC_Click);
            // 
            // btnRCAJA
            // 
            this.btnRCAJA.FlatAppearance.BorderSize = 0;
            this.btnRCAJA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRCAJA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCAJA.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRCAJA.ForeColor = System.Drawing.Color.White;
            this.btnRCAJA.Location = new System.Drawing.Point(0, 264);
            this.btnRCAJA.Name = "btnRCAJA";
            this.btnRCAJA.Size = new System.Drawing.Size(164, 23);
            this.btnRCAJA.TabIndex = 3;
            this.btnRCAJA.Text = "REPORTE CAJAS";
            this.btnRCAJA.UseVisualStyleBackColor = true;
            this.btnRCAJA.Click += new System.EventHandler(this.btnRCAJA_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(0, 172);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(164, 23);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registro Empleados";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnINVENTARIO
            // 
            this.btnINVENTARIO.FlatAppearance.BorderSize = 0;
            this.btnINVENTARIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnINVENTARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINVENTARIO.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnINVENTARIO.ForeColor = System.Drawing.Color.White;
            this.btnINVENTARIO.Location = new System.Drawing.Point(0, 219);
            this.btnINVENTARIO.Name = "btnINVENTARIO";
            this.btnINVENTARIO.Size = new System.Drawing.Size(164, 23);
            this.btnINVENTARIO.TabIndex = 1;
            this.btnINVENTARIO.Text = "INVENTARIO";
            this.btnINVENTARIO.UseVisualStyleBackColor = true;
            this.btnINVENTARIO.Click += new System.EventHandler(this.btnINVENTARIO_Click);
            // 
            // btnINICIO
            // 
            this.btnINICIO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINICIO.FlatAppearance.BorderSize = 0;
            this.btnINICIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnINICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINICIO.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnINICIO.ForeColor = System.Drawing.Color.White;
            this.btnINICIO.Location = new System.Drawing.Point(0, 122);
            this.btnINICIO.Name = "btnINICIO";
            this.btnINICIO.Size = new System.Drawing.Size(164, 23);
            this.btnINICIO.TabIndex = 0;
            this.btnINICIO.Text = "INICIO";
            this.btnINICIO.UseVisualStyleBackColor = true;
            this.btnINICIO.Click += new System.EventHandler(this.btnINICIO_Click);
            // 
            // Pcontenedor
            // 
            this.Pcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pcontenedor.Location = new System.Drawing.Point(167, 33);
            this.Pcontenedor.Name = "Pcontenedor";
            this.Pcontenedor.Size = new System.Drawing.Size(919, 459);
            this.Pcontenedor.TabIndex = 2;
            // 
            // ADMINWIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1086, 492);
            this.Controls.Add(this.Pcontenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADMINWIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ADMINWIN_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox pbclose;
        private Panel panel1;
        private Button btnRCAJA;
        private Button btnRegistro;
        private Button btnINVENTARIO;
        private Button btnINICIO;
        private Button btnHistorialAC;
        private Label label1;
        private PictureBox pbminimize;
        private PictureBox pictureBox2;
        private Panel Pcontenedor;
        private PictureBox pblogout;
    }
}