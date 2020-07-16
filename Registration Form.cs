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
using FireSharp.Response;
using FireSharp.Interfaces;

namespace WindowsFormsApp2
{
    public partial class Registrasi : Form
    {
        public Registrasi()
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
            labelberhasil.Text = "  " + msg;
            labelberhasil.Visible = true;   
        }
        private void Form3_Load(object sender, EventArgs e)
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

        //Program sistem Registrasi
        #region
        private void Btnregis_Click(object sender, EventArgs e)
        {
            if (txtnama.Text != "NAMA LENGKAP")
            {
                if (txtemail.Text != "EMAIL")
                {
                    if (txttelepon.Text != "NO TELEPON")
                    {
                        if (txtpass.Text != "PASSWORD")
                        {
                            MyUser user = new MyUser()
                            {
                                NamaLengkap = txtnama.Text,
                                Email = txtemail.Text,
                                NoTelepon = txttelepon.Text,
                                Password = txtpass.Text
                            };
                            SetResponse set = client.Set(@"Users/" + txtnama.Text, user);                            
                            MsgError("Berhasil Mendaftar !");
                            labelberhasil.ForeColor = Color.Chartreuse;
                            
                        }
                        else MsgError("Lengkapi Forms Pendaftaran !");                        
                    }
                    else MsgError("Lengkapi Forms Pendaftaran !");                    
                }
                else MsgError("Lengkapi Forms Pendaftaran !");                
            }
            else MsgError("Lengkapi Forms Pendaftaran !");            
        }
        #endregion

        //Program Konfigurasi Button, Linklabel, TextBox, Picture dan sebagainya
        #region
        private void Btnback_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }     
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void Txtnomor_Enter(object sender, EventArgs e)
        {
            if ( txttelepon.Text == "NO TELEPON")
            {
                txttelepon.Text = "";
                txttelepon.ForeColor = Color.LightGray;
            }
        }
        private void Txtnomor_Leave(object sender, EventArgs e)
        {
            if (txttelepon.Text == "")
            {
                txttelepon.Text = "NO TELEPON";
                txttelepon.ForeColor = Color.LightGray;
            }
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
        private void Txtpasslagi_Enter(object sender, EventArgs e)
        {
            if(txtpasslagi.Text == "MASUKKAN KEMBALI PASSWORD")
            {
                txtpasslagi.Text = "";
                txtpasslagi.ForeColor = Color.LightGray;
                txtpasslagi.UseSystemPasswordChar = true;
            }
        }
        private void Txtpasslagi_Leave(object sender, EventArgs e)
        {
            if(txtpasslagi.Text == "")
            {
                txtpasslagi.Text = "";
                txtpasslagi.ForeColor = Color.LightGray;
                txtpasslagi.UseSystemPasswordChar = false;
            }
        }
       
        private void Txtlagipass_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LineShape1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Txtrepass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Logoback_Click(object sender, EventArgs e)
        {
           
        }
        #endregion
    }
}

        
    

