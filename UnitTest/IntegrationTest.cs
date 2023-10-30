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
            person.postcode = 6836;
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

        [Fact]
        public void IntegrationTest2()
        {
            var hypo = new Hypotheek();
            var person = hypo.person;

            person.brutoJaarSalaris = 10000;
            person.rentevastePeriode = 30;
            person.rentePercentage = 5;
            person.heeftPartner = true;
            person.partnerBrutoJaarSalaris = 5000;
            person.totaalJaarSalaris = person.brutoJaarSalaris + person.partnerBrutoJaarSalaris;
            person.heeftStudieSchuld = true;
            person.postcode = 6836;
            person.magLenen = true;

            var result = hypo.BerekenHypotheek();

            var expected = new HypotheekResult
            {
                MaxHypotheek = 47812.50,
                RenteBedragPerMaand = 199.22,
                AflossingsBedrag = 132.81,
                TotaleMaandbedrag = 332.03,
                TotaalBedragNaDertigJaar = 119530.80,
            };

            Assert.Equivalent(expected, result);
        }

        [Fact]
        public void IntegrationTest3()
        {
            var hypo = new Hypotheek();
            var person = hypo.person;

            person.brutoJaarSalaris = 10000;
            person.rentevastePeriode = 30;
            person.rentePercentage = 5;
            person.heeftPartner = true;
            person.partnerBrutoJaarSalaris = 5000;
            person.totaalJaarSalaris = person.brutoJaarSalaris + person.partnerBrutoJaarSalaris;
            person.heeftStudieSchuld = true;
            person.postcode = 9679;

            var postcode = person.postcode;
            hypo.Postcode(postcode);
            var result = hypo.BerekenHypotheek();

            var expected = new HypotheekResult
            {
                MaxHypotheek = 0,
            };

            Assert.False(person.magLenen);
            Assert.Equivalent(expected, result);
        }
    }
}
