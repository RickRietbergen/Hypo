using Hypo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class IntegrationTest
    {
        [Fact]
        public void IntegrationTest1()
        {
            var hypo = new Hypotheek();
            var person = new Hypo.Classes.Person();
                
            person.brutoJaarSalaris = 10000;
            person.rentevastePeriode = 30;
            person.rentePercentage = 5;
            person.heeftPartner = false;
            person.partnerBrutoJaarSalaris = 0;
            person.totaalJaarSalaris = person.brutoJaarSalaris + person.partnerBrutoJaarSalaris;
            person.heeftStudieSchuld = false;
            person.postcode = 1111;
            person.magLenen = true;

            hypo.person = person;
            var result = hypo.BerekenHypotheek();

            var expected = new HypotheekResult
            {
                MaxHypotheek = 42500,
                RenteBedragPerMaand = 177.08,
                AflossingsBedrag = 118.06,
                TotaleMaandbedrag = 295.14,
                TotaalBedragNaDertigJaar = 106250.40,
            };

            Assert.Equivalent(expected, result);
        }
    }
}
