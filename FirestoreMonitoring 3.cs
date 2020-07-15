using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace WindowsFormsApp2
{
    [FirestoreData]
    class FirestoreMonitoring_3
    {
        [FirestoreProperty]
        public int WaterLevel { get; set; }
        [FirestoreProperty]
        public int FuelLevel { get; set; }
        [FirestoreProperty]
        public int Chiller { get; set; }
        [FirestoreProperty]
        public string Freezer { get; set; }
        [FirestoreProperty]
        public string Odometer { get; set; }
        [FirestoreProperty]
        public int HdA { get; set; }
        [FirestoreProperty]
        public int HdB { get; set; }
        [FirestoreProperty]
        public int HdC { get; set; }
        [FirestoreProperty]
        public int HdD { get; set; }
        [FirestoreProperty]
        public int GasPreasure { get; set; }
        [FirestoreProperty]
        public int GenFuelLevel { get; set; }
        [FirestoreProperty]
        public int GenTemp { get; set; }
    }
}
