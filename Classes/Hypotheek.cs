using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypo.Classes
{
    public class Hypotheek
    {
        private int choice;
        Hypo.Classes.Person person = new Hypo.Classes.Person();

        public void Maandinkomen()
        {
            Console.Write("Wat is je maandinkomen: ");
            decimal BrutoJaarInkomen = decimal.Parse(Console.ReadLine());

            //set value
            person.brutoJaarSalaris = BrutoJaarInkomen;
        }

        public void RentevastePeriode()
        {
            while (true)
            {
                Console.WriteLine("Rentevaste periodes:");
                Console.WriteLine("1. 1 jaar  | 2%");
                Console.WriteLine("2. 5 jaar  | 3%");
                Console.WriteLine("3. 10 jaar | 3.5%");
                Console.WriteLine("4. 20 jaar | 4.5%");
                Console.WriteLine("5. 30 jaar | 5%");

                Console.Write("selecteer welke rentevaste periode u wilt kiezen voor uw hypotheek lening: ");

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 1 jaar | 2%");
                        break;
                    case 2:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 5 jaar | 3%");
                        break;
                    case 3:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 10 jaar | 3.5%");
                        break;
                    case 4:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 20 jaar | 4.5%");
                        break;
                    case 5:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 30 jaar | 5%");
                        break;
                }
            }
        }

        public void HeeftPartner()
        {
            Console.Write("Heeft u een partner (Ja/Nee): ");
            string partnerInput = Console.ReadLine();
            //ja = true, nee = false
            bool gebruikerHeeftPartner = partnerInput.Equals("Ja", StringComparison.OrdinalIgnoreCase);

            //set value
            person.heeftPartner = gebruikerHeeftPartner;
        }

        public void heeftStudieSchuld()
        {
            Console.Write("Heb je een studieschuld (Ja/Nee): ");
            string studieschuldInput = Console.ReadLine();
            //ja = true, nee = false
            bool heeftStudieschuld = studieschuldInput.Equals("Ja", StringComparison.OrdinalIgnoreCase);

            //set value
            person.heeftStudieSchuld = heeftStudieschuld;
        }
    }
}
