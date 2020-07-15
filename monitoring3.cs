using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace WindowsFormsApp2
{
    public partial class Monitoring3 : Form
    {
        
        FirestoreDb database;
        public Monitoring3()
        {
            InitializeComponent();
            {
                //Konfigurasi Pengambilan data dari Database ke Monitoring untuk menampilkan data sensor Chiller dan Freezer
                #region
                string path = AppDomain.CurrentDomain.BaseDirectory + @"percobaanjson-firebase-adminsdk-7qk4t-80ed9d2f19.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                database = FirestoreDb.Create("percobaanjson");

                async void DocumentCostum()
                {
                    DocumentReference docref = database.Collection("DocumentCostum").Document("MyDoc");
                    DocumentSnapshot snap = await docref.GetSnapshotAsync();
                    if (snap.Exists)
                    {
                        if (snap.Exists)
                        {
                            FirestoreMonitoring_3 firestore = snap.ConvertTo<FirestoreMonitoring_3>();
                            txtchillermonitoring3.Text = firestore.Chiller.ToString() + "°C";
                            txtfreezermonitoring3.Text = firestore.Freezer + "°C";                         
                        }
                    }
                }
                DocumentCostum();
                #endregion
            }

            //Program pembuatan Grafik
            #region
            graphchart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(00.01,14),
                        new ObservablePoint(00.02,14.2),
                        new ObservablePoint(00.03,13.8),
                        new ObservablePoint(00.04,13.5),
                        new ObservablePoint(00.06,14.2),
                        new ObservablePoint(00.07,14.5),
                        new ObservablePoint(00.08,14.8),
                        new ObservablePoint(00.09,15),
                        new ObservablePoint(00.10,13),
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(00.01,3),
                        new ObservablePoint(00.02,2.5),
                        new ObservablePoint(00.03,2.8),
                        new ObservablePoint(00.04,2.3),
                        new ObservablePoint(00.06,2.5),
                        new ObservablePoint(00.07,3.2),
                        new ObservablePoint(00.08,2.8),
                        new ObservablePoint(00.09,3),
                        new ObservablePoint(00.10,3.1),
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(00.01,6),
                        new ObservablePoint(00.02,5),
                        new ObservablePoint(00.03,6.5),
                        new ObservablePoint(00.04,5.5),
                        new ObservablePoint(00.06,6),
                        new ObservablePoint(00.07,6.3),
                        new ObservablePoint(00.08,6.8),
                        new ObservablePoint(00.09,7),
                        new ObservablePoint(00.10,5.8),
                    },
                    PointGeometrySize = 15
                }
            };
            #endregion
        }
        private void Monitoring3_Load(object sender, EventArgs e)
        {
            cpbgenfuellevel.Value = 0;
            cpbgenfuellevel.Minimum = 0;
            cpbgenfuellevel.Maximum = 100;
        }
    }
}
