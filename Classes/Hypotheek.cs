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
            Console.Write("Wat is uw brutojaarsalaris: ");
            double BrutoJaarInkomen = double.Parse(Console.ReadLine());

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
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 1 jaar | 2%");

                        //set value's and continue to next function
                        person.rentevastePeriode = 1;
                        person.rentePercentage = 2;
                        HeeftPartner();
                        break;
                    case 2:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 5 jaar | 3%");

                        //set value's and continue to next function
                        person.rentevastePeriode = 5;
                        person.rentePercentage = 3;
                        HeeftPartner();
                        break;
                    case 3:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 10 jaar | 3.5%");

                        //set value's and continue to next function
                        person.rentevastePeriode = 10;
                        person.rentePercentage = 3.5;
                        HeeftPartner();
                        break;
                    case 4:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 20 jaar | 4.5%");

                        //set value's and continue to next function
                        person.rentevastePeriode = 20;
                        person.rentePercentage = 4.5;
                        HeeftPartner();
                        break;
                    case 5:
                        Console.WriteLine("U heeft de rentevaste periode gekozen van: 30 jaar | 5%");

                        //set value's and continue to next function
                        person.rentevastePeriode = 30;
                        person.rentePercentage = 5;
                        HeeftPartner();
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

            if (gebruikerHeeftPartner == true)
            {
                Console.Write("Wat is het brutojaarsalaris van uw partner: ");
                double BrutoJaarInkomenPartner = double.Parse(Console.ReadLine());

                //set value
                person.partnerBrutoJaarSalaris = BrutoJaarInkomenPartner;
            }

            //set value
            person.heeftPartner = gebruikerHeeftPartner;
        }

        public void HeeftStudieSchuld()
        {
            Console.Write("Heb je een studieschuld (Ja/Nee): ");
            string studieschuldInput = Console.ReadLine();
            //ja = true, nee = false
            bool heeftStudieschuld = studieschuldInput.Equals("Ja", StringComparison.OrdinalIgnoreCase);

            //set value
            person.heeftStudieSchuld = heeftStudieschuld;
        }

        public void Postcode()
        {
            Console.Write("Voer je postcode in: ");
            int postcode = int.Parse(Console.ReadLine());

            if (postcode == 9679 || postcode == 9681 || postcode == 9682) 
            {
                person.magLenen = false;
                Console.WriteLine("U mag helaas geen hypotheek lening nemen i.v.m aardbevingsgebied en/of dalende woningwaarde.");
            }
            else
            {
                person.magLenen = true;
                Console.WriteLine("U mag een lening bij ons nemen, u bevindt zich niet in een aardbevingsgebied en/of dalende woningwaarde.");
            }

            //set value
            person.postcode = postcode;
        }
    }
}
