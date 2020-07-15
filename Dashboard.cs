using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.CacheProviders;
using GMap.NET.Internals;
using GMap.NET.Projections;


namespace WindowsFormsApp2
{
    public partial class Dashboard : Form
    {
        private bool isCollaped;
        public Dashboard()
        {
            InitializeComponent();            
        }
        //Program Kongiruasi Halaman Dashboard seperti pengaturan panel, button dan sebagainya
        #region
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollaped)
            {
                btnmonitor.Image = Properties.Resources.uppngfuel1; 
                panelsubmenu.Height += 10;
                if (panelsubmenu.Size == panelsubmenu.MaximumSize)
                {
                    timer1.Stop();
                    isCollaped = false;
                }
            }
            else 
            {
                btnmonitor.Image = Properties.Resources.pngfuel1;
                panelsubmenu.Height -= 10;
                if (panelsubmenu.Size == panelsubmenu.MinimumSize)
                {
                    timer1.Stop();
                    isCollaped = true;
                }
            }
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelformulir.Controls.Add(childForm);
            panelformulir.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Btnmonitor_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }           
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }       
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panel1.Region = region;
            this.Invalidate();
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Monitoring3());

        }
        private void Btnktad1_Click(object sender, EventArgs e)
        {          
            OpenChildForm(new monitoring1());
        }
        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Btnhome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new home());
        }
        private void Btnktad2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Monitoring2());
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Information());
        }
        #endregion

        #region
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Label2_Click(object sender, EventArgs e)
        {
            
        }
        private void Map_Load(object sender, EventArgs e)
        {
           
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {

        }
        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void AxMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {

        }
        private void Panelslidemenu_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void PictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void LineShape1_Click(object sender, EventArgs e)
        {

        }

        private void GMapControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void Btnmap_Click(object sender, EventArgs e)
        {
          
        }
        #endregion
    }
}
