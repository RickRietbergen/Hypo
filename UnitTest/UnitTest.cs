using Hypo.Classes;
using Xunit;

namespace UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void UnitTest1()
        {
            var hypo = new Hypotheek();
            var person = new Hypo.Classes.Person();

            person.brutoJaarSalaris = 10000;

            Assert.Equal(10000, person.brutoJaarSalaris);
        }

        [Fact]
        public void UnitTest2()
        {
            var hypo = new Hypotheek();
            var person = hypo.person;

            EnumRente gekozenkeuze = EnumRente.DertigJaar;
            hypo.RentevastePeriode(gekozenkeuze);

            Assert.Equal(30, person.rentevastePeriode);
            Assert.Equal(5, person.rentePercentage);
        }
    }
}