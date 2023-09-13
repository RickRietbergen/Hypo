using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypo.Classes
{
    public class Person
    {
        public int brutoJaarSalaris { get; set; }
        public int rentevastePeriode { get; set; }
        public bool heeftPartner { get; set; }
        public int partnerBrutoJaarSalaris { get; set; } = 0;
        public bool heeftStudieSchuld { get; set; }
        public int postcode { get; set; }

        public double maximaleHypotheekLening { get; set; }
        public double renteBetaaldElkeMaand { get; set; }
        public double aflossingElkeMaand { get; set; }
        public double totaalAfgelost { get; set; }
    }
}
