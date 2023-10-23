using Hypo.Classes;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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
            hypo.BerekenHypotheek();
        }
    }
}