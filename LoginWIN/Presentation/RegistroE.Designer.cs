namespace Presentation
{
    partial class RegistroE
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
            this.EMPLOYEEdgv = new System.Windows.Forms.DataGridView();
            this.Filtrocb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchingtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.Padd = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEdgv)).BeginInit();
            this.Padd.SuspendLayout();
            this.SuspendLayout();
            // 
            // EMPLOYEEdgv
            // 
            this.EMPLOYEEdgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EMPLOYEEdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EMPLOYEEdgv.Location = new System.Drawing.Point(12, 80);
            this.EMPLOYEEdgv.Name = "EMPLOYEEdgv";
            this.EMPLOYEEdgv.RowTemplate.Height = 25;
            this.EMPLOYEEdgv.Size = new System.Drawing.Size(615, 288);
            this.EMPLOYEEdgv.TabIndex = 0;
            // 
            // Filtrocb
            // 
            this.Filtrocb.FormattingEnabled = true;
            this.Filtrocb.Location = new System.Drawing.Point(26, 35);
            this.Filtrocb.Name = "Filtrocb";
            this.Filtrocb.Size = new System.Drawing.Size(239, 23);
            this.Filtrocb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            // 
            // searchingtxt
            // 
            this.searchingtxt.Location = new System.Drawing.Point(305, 35);
            this.searchingtxt.Name = "searchingtxt";
            this.searchingtxt.Size = new System.Drawing.Size(165, 23);
            this.searchingtxt.TabIndex = 3;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.LightGray;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Location = new System.Drawing.Point(493, 25);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(88, 40);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Buscar";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Padd
            // 
            this.Padd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(137)))));
            this.Padd.Controls.Add(this.label9);
            this.Padd.Controls.Add(this.label8);
            this.Padd.Controls.Add(this.label7);
            this.Padd.Controls.Add(this.label6);
            this.Padd.Controls.Add(this.label5);
            this.Padd.Controls.Add(this.label4);
            this.Padd.Controls.Add(this.label3);
            this.Padd.Controls.Add(this.label2);
            this.Padd.Controls.Add(this.btnAdd);
            this.Padd.Controls.Add(this.txtID);
            this.Padd.Controls.Add(this.cbposition);
            this.Padd.Controls.Add(this.txttel);
            this.Padd.Controls.Add(this.txtEmail);
            this.Padd.Controls.Add(this.txtlname);
            this.Padd.Controls.Add(this.txtname);
            this.Padd.Controls.Add(this.txtpass);
            this.Padd.Controls.Add(this.txtuser);
            this.Padd.Dock = System.Windows.Forms.DockStyle.Right;
            this.Padd.ForeColor = System.Drawing.Color.White;
            this.Padd.Location = new System.Drawing.Point(633, 0);
            this.Padd.Name = "Padd";
            this.Padd.Size = new System.Drawing.Size(270, 380);
            this.Padd.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "E-Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Posición";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(51, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(157, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(91, 19);
            this.txtID.TabIndex = 10;
            // 
            // cbposition
            // 
            this.cbposition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Location = new System.Drawing.Point(89, 209);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(159, 23);
            this.cbposition.TabIndex = 6;
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttel.Location = new System.Drawing.Point(108, 287);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(140, 19);
            this.txttel.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(89, 251);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 19);
            this.txtEmail.TabIndex = 8;
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtlname.Location = new System.Drawing.Point(108, 175);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(140, 19);
            this.txtlname.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtname.Location = new System.Drawing.Point(108, 137);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(140, 19);
            this.txtname.TabIndex = 6;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpass.Location = new System.Drawing.Point(121, 101);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(127, 19);
            this.txtpass.TabIndex = 5;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtuser.Location = new System.Drawing.Point(136, 63);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(112, 19);
            this.txtuser.TabIndex = 4;
            // 
            // RegistroE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(903, 380);
            this.Controls.Add(this.Padd);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchingtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filtrocb);
            this.Controls.Add(this.EMPLOYEEdgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroE";
            this.Load += new System.EventHandler(this.RegistroE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEdgv)).EndInit();
            this.Padd.ResumeLayout(false);
            this.Padd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView EMPLOYEEdgv;
        private ComboBox Filtrocb;
        private Label label1;
        private TextBox searchingtxt;
        private Button searchbtn;
        private Panel Padd;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAdd;
        private TextBox txtID;
        private ComboBox cbposition;
        private TextBox txttel;
        private TextBox txtEmail;
        private TextBox txtlname;
        private TextBox txtname;
        private TextBox txtpass;
        private TextBox txtuser;
    }
}