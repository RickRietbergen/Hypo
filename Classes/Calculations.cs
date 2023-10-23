using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypo.Classes
{
    public class HypotheekResult
    {
        public double MaxHypotheek { get; set; }
        public double RenteBedragPerMaand { get; set; }
        public double AflossingsBedrag { get; set; }
        public double TotaleMaandbedrag { get; set; }
        public double TotaalBedragNaDertigJaar { get; set; }
    }
}
