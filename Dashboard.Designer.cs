namespace WindowsFormsApp2
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelslidemenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelsubmenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnktad2 = new System.Windows.Forms.Button();
            this.btnmonitor = new System.Windows.Forms.Button();
            this.btnktad1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelformulir = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.axMap2 = new AxMapWinGIS.AxMap();
            this.panelslidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelsubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelformulir.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelslidemenu
            // 
            this.panelslidemenu.BackColor = System.Drawing.Color.Black;
            this.panelslidemenu.Controls.Add(this.pictureBox1);
            this.panelslidemenu.Controls.Add(this.button1);
            this.panelslidemenu.Controls.Add(this.panelsubmenu);
            this.panelslidemenu.Controls.Add(this.btnlogout);
            this.panelslidemenu.Controls.Add(this.pictureBox2);
            this.panelslidemenu.Controls.Add(this.btnhome);
            this.panelslidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelslidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelslidemenu.Name = "panelslidemenu";
            this.panelslidemenu.Size = new System.Drawing.Size(235, 768);
            this.panelslidemenu.TabIndex = 1;
            this.panelslidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelslidemenu_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(0, 140);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(235, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Information";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelsubmenu
            // 
            this.panelsubmenu.BackColor = System.Drawing.Color.White;
            this.panelsubmenu.Controls.Add(this.panel5);
            this.panelsubmenu.Controls.Add(this.panel4);
            this.panelsubmenu.Controls.Add(this.panel2);
            this.panelsubmenu.Controls.Add(this.button2);
            this.panelsubmenu.Controls.Add(this.btnktad2);
            this.panelsubmenu.Controls.Add(this.btnmonitor);
            this.panelsubmenu.Controls.Add(this.btnktad1);
            this.panelsubmenu.Location = new System.Drawing.Point(0, 189);
            this.panelsubmenu.MaximumSize = new System.Drawing.Size(235, 200);
            this.panelsubmenu.MinimumSize = new System.Drawing.Size(235, 50);
            this.panelsubmenu.Name = "panelsubmenu";
            this.panelsubmenu.Size = new System.Drawing.Size(235, 200);
            this.panelsubmenu.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(225, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 50);
            this.panel5.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(225, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 50);
            this.panel4.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(225, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 50);
            this.panel2.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(0, 150);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(235, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "KT-AD 3";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnktad2
            // 
            this.btnktad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnktad2.FlatAppearance.BorderSize = 0;
            this.btnktad2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnktad2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnktad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnktad2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F);
            this.btnktad2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnktad2.Location = new System.Drawing.Point(0, 100);
            this.btnktad2.Name = "btnktad2";
            this.btnktad2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnktad2.Size = new System.Drawing.Size(235, 50);
            this.btnktad2.TabIndex = 3;
            this.btnktad2.Text = "KT-AD 2";
            this.btnktad2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnktad2.UseVisualStyleBackColor = false;
            this.btnktad2.Click += new System.EventHandler(this.Btnktad2_Click);
            // 
            // btnmonitor
            // 
            this.btnmonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnmonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmonitor.FlatAppearance.BorderSize = 0;
            this.btnmonitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmonitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmonitor.Font = new System.Drawing.Font("Century Schoolbook", 14.25F);
            this.btnmonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmonitor.Image = global::WindowsFormsApp2.Properties.Resources.pngfuel1;
            this.btnmonitor.Location = new System.Drawing.Point(0, 0);
            this.btnmonitor.Name = "btnmonitor";
            this.btnmonitor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnmonitor.Size = new System.Drawing.Size(235, 50);
            this.btnmonitor.TabIndex = 0;
            this.btnmonitor.Text = "Monitoring";
            this.btnmonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnmonitor.UseVisualStyleBackColor = false;
            this.btnmonitor.Click += new System.EventHandler(this.Btnmonitor_Click);
            // 
            // btnktad1
            // 
            this.btnktad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnktad1.FlatAppearance.BorderSize = 0;
            this.btnktad1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnktad1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnktad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnktad1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F);
            this.btnktad1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnktad1.Location = new System.Drawing.Point(0, 50);
            this.btnktad1.Name = "btnktad1";
            this.btnktad1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnktad1.Size = new System.Drawing.Size(235, 50);
            this.btnktad1.TabIndex = 1;
            this.btnktad1.Text = "KT-AD 1";
            this.btnktad1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnktad1.UseVisualStyleBackColor = false;
            this.btnktad1.Click += new System.EventHandler(this.Btnktad1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.btnlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlogout.Location = new System.Drawing.Point(0, 717);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(235, 50);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "       Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(50, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnhome.CausesValidation = false;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Schoolbook", 14.25F);
            this.btnhome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnhome.Location = new System.Drawing.Point(0, 90);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnhome.Size = new System.Drawing.Size(235, 50);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.Btnhome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelformulir);
            this.panel1.Controls.Add(this.panelslidemenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panelformulir
            // 
            this.panelformulir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelformulir.Controls.Add(this.axMap2);
            this.panelformulir.Controls.Add(this.axMap1);
            this.panelformulir.Controls.Add(this.panel3);
            this.panelformulir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformulir.Location = new System.Drawing.Point(235, 0);
            this.panelformulir.Name = "panelformulir";
            this.panelformulir.Size = new System.Drawing.Size(1131, 768);
            this.panelformulir.TabIndex = 2;
            this.panelformulir.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 31);
            this.panel3.TabIndex = 28;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1048, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1090, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // axMap1
            // 
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 29);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(1128, 736);
            this.axMap1.TabIndex = 29;
            // 
            // axMap2
            // 
            this.axMap2.Enabled = true;
            this.axMap2.Location = new System.Drawing.Point(111, 199);
            this.axMap2.Name = "axMap2";
            this.axMap2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap2.OcxState")));
            this.axMap2.Size = new System.Drawing.Size(8, 8);
            this.axMap2.TabIndex = 30;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.panelslidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelsubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelformulir.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelslidemenu;
        private System.Windows.Forms.Panel panelsubmenu;
        private System.Windows.Forms.Button btnktad2;
        private System.Windows.Forms.Button btnktad1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnmonitor;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelformulir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private AxMapWinGIS.AxMap axMap2;
        private AxMapWinGIS.AxMap axMap1;
    }
}