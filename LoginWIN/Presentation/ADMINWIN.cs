using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Presentation
{
    public partial class ADMINWIN : Form
    {
        public ADMINWIN()
        {
            InitializeComponent();
        }

      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button3_Click(object sender, EventArgs e)
        {
            Abrirformhija(new RegistroE());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnINICIO_Click(object sender, EventArgs e)
        {
            Abrirformhija(new INICIO());
        }

        private void Abrirformhija(object formhijo)
        {
            if (this.Pcontenedor.Controls.Count>0)
                this.Pcontenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pcontenedor.Controls.Add(fh);
            this.Pcontenedor.Tag = fh;
            fh.Show();

            
        }

        private void ADMINWIN_Load(object sender, EventArgs e)
        {
            btnINICIO_Click(null, e);
        }

        private void pblogout_Click(object sender, EventArgs e)
        {
            LOGIN log = new LOGIN();
            log.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Abrirformhija(new INICIO());
        }

        private void btnINVENTARIO_Click(object sender, EventArgs e)
        {
            Abrirformhija(new MaintenanceXTRA());
        }

        private void btnRCAJA_Click(object sender, EventArgs e)
        {
            Abrirformhija(new MaintenanceXTRA());
        }

        private void btnHistorialAC_Click(object sender, EventArgs e)
        {
            Abrirformhija(new MaintenanceXTRA());
        }
    }
}