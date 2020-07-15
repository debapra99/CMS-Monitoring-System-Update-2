using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//Library Firebase untuk C# Language (dinamakan Firesharp)
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Program Drag Page
        #region  
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        //Program konfigurasi awal Firesharp
        #region 
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "KAjSZyGu9BbJeHscNyCVzSKnloCF91kNRWMuHYaP",
            BasePath = "https://idpassword-8d768.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Tolong cek kembali koneksi internet anda");
            }
        }
        #endregion
       
        //Program sistem LOGIN
        #region
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (txtnama.Text != "NAMA LENGKAP")
            {
                if (txtpass.Text != "PASSWORD")
                {
                    MyUser user = new MyUser()
                    {
                        NamaLengkap = txtnama.Text,
                        Password = txtpass.Text
                    };
                    FirebaseResponse res = client.Get(@"Users/" + txtnama.Text);
                    MyUser Reuser = res.ResultAs<MyUser>();

                    if (MyUser.IsEqual(Reuser,user))
                    {
                        this.Hide();
                        Dashboard mainForm = new Dashboard();
                        mainForm.Show();
                    }
                    else
                    {
                        MsgError("Nama atau Password anda salah");
                    }                   
                }
            else MsgError("Tolong Masukkan Password anda");
            }
            else MsgError("Tolong Masukkan Nama anda");
        }
        private void MsgError(string msg)
        {
            lblmsgeror.Text = "  " + msg;
            lblmsgeror.Visible = true;
        }
        #endregion

        //Program Konfigurasi Button, Linklabel, TextBox, Picture dan sebagainya
        #region
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrasi mainForm = new Registrasi();
            mainForm.Show();
        }
        private void Linkbelumdaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrasi mainForm = new Registrasi();
            mainForm.Show();
        }

        private void Linklupapassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            lupa_password mainForm = new lupa_password();
            mainForm.Show();
        }
        private void Txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "PASSWORD")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }
        private void Txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "PASSWORD";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }                
      
        private void Txtnama_enter(object sender, EventArgs e)
        {
            if (txtnama.Text == "NAMA")
            {
                txtnama.Text = "";
                txtnama.ForeColor = Color.LightGray;
            }
        }
        private void Txtnama_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "NAMA";
                txtpass.ForeColor = Color.LightGray;
            }
        }
        private void Txtemail_Enter_1(object sender, EventArgs e)
        {
            if (txtnama.Text == "EMAIL")
            {
                txtnama.Text = "";
                txtpass.ForeColor = Color.LightGray;
            }
        }
        private void Txtemail_Leave_1(object sender, EventArgs e)
        {
            if (txtnama.Text == "")
            {
                txtnama.Text = "EMAIL";
                txtpass.ForeColor = Color.LightGray;
            }
        }
        
        private void Txtnama_Enter_1(object sender, EventArgs e)
        {
            if (txtnama.Text == "NAMA LENGKAP")
            {
                txtnama.Text = "";
                txtnama.ForeColor = Color.LightGray;
            }
        }

        private void Txtnama_Leave_1(object sender, EventArgs e)
        {
            if (txtnama.Text == "")
            {
                txtnama.Text = "NAMA LENGKAP";
                txtnama.ForeColor = Color.LightGray;
            }
        }
        
        private void Txtemail_Enter(object sender, EventArgs e)
        {

        }
        private void Txtemail_Leave(object sender, EventArgs e)
        {

        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }


}


