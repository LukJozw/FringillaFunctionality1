using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FringillaFunctionality1
{
    public class Sample
    {
        public int SampleNo { get; set; }
        public string FileName { get; set; }
        public float AvgDistBckg { get; set; }
        public float AvgDistFilm { get; set; }
        public float ZeroShift { get; set; }
        public int NNumber { get; set; }
        public int Lambda { get; set; }
        public float Thickness { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
