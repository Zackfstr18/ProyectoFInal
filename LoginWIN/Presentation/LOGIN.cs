using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace Presentation
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PASSTXT_TextChanged(object sender, EventArgs e)
        {
           PASSTXT.UseSystemPasswordChar = true;
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            CARGOcb.SelectedItem = "Administrador";

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (USERTXT.Text != "")
            {
                if (PASSTXT.Text != "")
                {
                    UserModel user = new UserModel();
                    var ValidLogin = user.LoginUser(USERTXT.Text, PASSTXT.Text,CARGOcb.Text);
                    if (ValidLogin == true && CARGOcb.SelectedItem == "Administrador")
                    {
                        ADMINWIN Principal = new ADMINWIN();
                        Principal.Show();
                        this.Hide();
                    }
                    else if (ValidLogin == true && CARGOcb.SelectedItem == "Caja")
                    {
                        Maintenance Mant = new Maintenance();
                        Mant.Show();
                        this.Hide();
                    }
                    else if (ValidLogin == true && CARGOcb.SelectedItem ==   "Inventario")
                    {
                        Maintenance Mant = new Maintenance();
                        Mant.Show();
                        this.Hide();
                    }
                    else { msgError("Cargo,Usuario o Contraseña Incorrectos. \n Ingrese los datos nuevamente");
                        PASSTXT.Clear();
                        USERTXT.Focus();
                    }

                }
                else msgError("Introduzca una contraseña.");

            }
            else msgError("Introduzca un nombre de usuario.");  
        }
        private void msgError(string Error)
        {
            lbmsgError.Text = "" + Error;
            lbmsgError.Visible = true;
        }
        
    }
}
