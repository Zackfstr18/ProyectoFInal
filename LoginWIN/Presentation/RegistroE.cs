using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Presentation
{
    public partial class RegistroE : Form
    {
        public RegistroE()
        {
            InitializeComponent();
        }

        private void RegistroE_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDat dat = new UserDat();
            dat.RegistE(Convert.ToInt32(txtID.Text), txtuser.Text,txtpass.Text,txtname.Text,txtlname.Text,cbposition.Text,txtEmail.Text,txttel.Text);
        }

       private void listpos()
        {
            UserDat dat = new UserDat();

            dat.conexion();
            var command = new SqlCommand();
            command.CommandText = "Select Posicion from [SERVECHAPP].[dbo].[login]";
            SqlDataAdapter adp= new SqlDataAdapter(command);
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            cbposition.DataSource = tabla;
            cbposition.DisplayMember = "Posicion";
            cbposition.ValueMember = "UserID";
            dat.conexclose();

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            listpos();
        }
    }
}
