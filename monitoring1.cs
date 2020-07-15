using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.Internals;
using GMap.NET.MapProviders;
using GMap.NET.ObjectModel;
using GMap.NET.Projections;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Reflection;
using System.Xml;
using System.IO;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace WindowsFormsApp2
{
    public partial class monitoring1 : Form
    {
        public monitoring1()
        {
            InitializeComponent();
        }

        //Firebase Setup
        #region
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "zbq47ODDnunqHeO9qBJXfjzUK0BPqDJDyoYeb931",
            BasePath = "https://dummydata-65971.firebaseio.com/"

        };

        IFirebaseClient client;

        public object Data { get; private set; }

        private void Monitoring_Load(object sender, EventArgs e)
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
    }
}
#endregion //gak tau ini

