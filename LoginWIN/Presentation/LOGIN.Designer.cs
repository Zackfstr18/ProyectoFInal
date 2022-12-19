namespace Presentation
{
    partial class LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizebtn = new System.Windows.Forms.PictureBox();
            this.Closebtn = new System.Windows.Forms.PictureBox();
            this.USERTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PASSTXT = new System.Windows.Forms.TextBox();
            this.CARGOcb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbmsgError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.Minimizebtn);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 42);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimizebtn.Image = ((System.Drawing.Image)(resources.GetObject("Minimizebtn.Image")));
            this.Minimizebtn.Location = new System.Drawing.Point(450, 0);
            this.Minimizebtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(35, 36);
            this.Minimizebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizebtn.TabIndex = 10;
            this.Minimizebtn.TabStop = false;
            this.Minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.Location = new System.Drawing.Point(492, 0);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(35, 36);
            this.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Closebtn.TabIndex = 9;
            this.Closebtn.TabStop = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // USERTXT
            // 
            this.USERTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.USERTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USERTXT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.USERTXT.ForeColor = System.Drawing.Color.LightGray;
            this.USERTXT.Location = new System.Drawing.Point(40, 359);
            this.USERTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.USERTXT.Name = "USERTXT";
            this.USERTXT.Size = new System.Drawing.Size(462, 21);
            this.USERTXT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(36, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(36, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña :";
            // 
            // PASSTXT
            // 
            this.PASSTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.PASSTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PASSTXT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PASSTXT.ForeColor = System.Drawing.Color.LightGray;
            this.PASSTXT.Location = new System.Drawing.Point(40, 448);
            this.PASSTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PASSTXT.Name = "PASSTXT";
            this.PASSTXT.Size = new System.Drawing.Size(462, 21);
            this.PASSTXT.TabIndex = 3;
            this.PASSTXT.TextChanged += new System.EventHandler(this.PASSTXT_TextChanged);
            // 
            // CARGOcb
            // 
            this.CARGOcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CARGOcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CARGOcb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CARGOcb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CARGOcb.FormattingEnabled = true;
            this.CARGOcb.Items.AddRange(new object[] {
            "Administrador",
            "Caja",
            "Inventario"});
            this.CARGOcb.Location = new System.Drawing.Point(114, 255);
            this.CARGOcb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CARGOcb.Name = "CARGOcb";
            this.CARGOcb.Size = new System.Drawing.Size(298, 22);
            this.CARGOcb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de usuario :";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.ForeColor = System.Drawing.Color.LightGray;
            this.loginbtn.Location = new System.Drawing.Point(54, 524);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(425, 46);
            this.loginbtn.TabIndex = 7;
            this.loginbtn.Text = "ACCEDER";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(152, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "L O G I N";
            // 
            // lbmsgError
            // 
            this.lbmsgError.AutoSize = true;
            this.lbmsgError.ForeColor = System.Drawing.Color.Red;
            this.lbmsgError.Location = new System.Drawing.Point(40, 483);
            this.lbmsgError.Name = "lbmsgError";
            this.lbmsgError.Size = new System.Drawing.Size(10, 15);
            this.lbmsgError.TabIndex = 9;
            this.lbmsgError.Text = " ";
            this.lbmsgError.Visible = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 639);
            this.Controls.Add(this.lbmsgError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CARGOcb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PASSTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USERTXT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LOGIN";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LOGIN_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Closebtn;
        private System.Windows.Forms.TextBox USERTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PASSTXT;
        private System.Windows.Forms.ComboBox CARGOcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Minimizebtn;
        private Label lbmsgError;
    }
}