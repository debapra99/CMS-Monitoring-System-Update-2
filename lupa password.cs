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

//Library Firebase untuk C# Language (dinamakan Firesharp)
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace WindowsFormsApp2
{
    public partial class lupa_password : Form
    {
        public lupa_password()
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
        private void MsgError(string msg)
        {
            labelgagal.Text = "  " + msg;
            labelgagal.Visible = true;
        }
        private void Lupa_password_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Please check your internet connection");
            }
        }
        #endregion

        //Program Sistem Lupa Password
        #region
        private void  Btnlanjut_Click(object sender, EventArgs e)
        {
          if(txtnama.Text != "NAMA LENGKAP")
            {
                if(txtemail.Text != "EMAIL")
                {
                    if(txttelepon.Text != "NOMOR TELEPON")
                    {
                        if(txtgantipass.Text != "PASSWORD BARU")
                        {
                            FirebaseResponse res = client.Get(@"Users/" + txtnama.Text);
                            MyLupaPassword Reuser = res.ResultAs<MyLupaPassword>();

                            MyLupaPassword CurUser = new MyLupaPassword()
                            {
                                NamaLengkap = txtnama.Text,
                                Email = txtemail.Text,
                                NoTelepon = txttelepon.Text
                            };
                            if (MyLupaPassword.IsEqual(Reuser, CurUser))
                            {
                                MyLupaPassword user = new MyLupaPassword()
                                {
                                    Password = txtgantipass.Text,
                                    Email = txtemail.Text,
                                    NamaLengkap = txtnama.Text,
                                    NoTelepon = txttelepon.Text
                                };
                                FirebaseResponse response = client.Update(@"Users/" + txtnama.Text, user);
                                MsgError("Password anda berhasil terganti");
                                labelgagal.ForeColor = Color.Chartreuse;
                            }
                            else
                            {
                                MsgError("Nama Lengkap, Email, atau Nomor Telepon tidak terdaftar");
                            }                            
                        }
                       else  MsgError("Nama Lengkap, Email, atau Nomor Telepon tidak terdaftar ");
                    }
                    else MsgError("Nama Lengkap, Email, atau Nomor Telepon tidak terdaftar ");
                }
                else MsgError("Nama Lengkap, Email, atau Nomor Telepon tidak terdaftar ");
            }
            else MsgError("Nama Lengkap, Email, atau Nomor Telepon tidak terdaftar ");
        }
        #endregion

        //Program Konfigurasi Button, Linklabel, TextBox, Picture dan sebagainya
        #region
        private void Btnbacklupapassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 MainForm = new Form1();
            MainForm.Show();
        }
        private void Txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "EMAIL")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.LightGray;
            }
        }
        private void Txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "EMAIL";
                txtemail.ForeColor = Color.LightGray;
            }
        }
        private void Txtnama_Enter(object sender, EventArgs e)
        {
            if (txtnama.Text == "NAMA LENGKAP")
            {
                txtnama.Text = "";
                txtnama.ForeColor = Color.LightGray;
            }
        }
        private void Txtnama_Leave(object sender, EventArgs e)
        {
            if (txtnama.Text == "")
            {
                txtnama.Text = "NAMA LENGKAP";
                txtnama.ForeColor = Color.LightGray;
            }
        }
        private void Txtgantipass_Enter_1(object sender, EventArgs e)
        {
            if(txtgantipass.Text== "PASSWORD BARU")
            {
                txtgantipass.Text = "";
                txtgantipass.ForeColor = Color.LightGray;
                txtgantipass.UseSystemPasswordChar = true;
            }
        }
        private void Txtgantipass_Leave_1(object sender, EventArgs e)
        {
            if (txtgantipass.Text == "")
            {
                txtgantipass.Text = "PASSWORD BARU";
                txtgantipass.ForeColor = Color.LightGray;
                txtgantipass.UseSystemPasswordChar = false;
            }
        }
        private void Txttelepon_Enter(object sender, EventArgs e)
        {
            if (txttelepon.Text == "NOMOR TELEPON")
            {
                txttelepon.Text = "";
                txttelepon.ForeColor = Color.LightGray;
            }
        }
        private void Txttelepon_Leave(object sender, EventArgs e)
        {
            if (txttelepon.Text == "")
            {
                txttelepon.Text = "NOMOR TELEPON";
                txttelepon.ForeColor = Color.LightGray;
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }
        private void Linkbelumdaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrasi mainForm = new Registrasi();
            mainForm.Show();
        }
        private void Linksudahdaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }      
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Txtgantipass_Enter(object sender, EventArgs e)
        {

        }
        private void Txtgantipass_Leave(object sender, EventArgs e)
        {

        }
        private void LineShape1_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}