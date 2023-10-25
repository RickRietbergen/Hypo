using Hypo.Classes;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void BerekenHypotheek1()
        {
            var hypo = new Hypotheek();
            var person = new Hypo.Classes.Person();

            person.brutoJaarSalaris = 10000;

            Assert.Equal(10000, person.brutoJaarSalaris);
        }
    }
}