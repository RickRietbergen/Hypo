using System;
using System.Collections.Generic;
using System.Text;

namespace Hypo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is je maandinkomen: ");
            decimal maandloon = decimal.Parse(Console.ReadLine());

            Console.Write("Heb je een partner (Ja/Nee): ");
            string partnerInput = Console.ReadLine();
            bool heeftPartner = partnerInput.Equals("Ja", StringComparison.OrdinalIgnoreCase);

            Console.Write("Heb je een studieschuld (Ja/Nee): ");
            string studieschuldInput = Console.ReadLine();
            bool heeftStudieschuld = studieschuldInput.Equals("Ja", StringComparison.OrdinalIgnoreCase);

            Console.Write("Voer de rentevaste periode in (1, 5, 10, 20, of 30 jaar): ");
            int rentevastePeriode = int.Parse(Console.ReadLine());

            Console.Write("Voer je postcode in: ");
            string postcode = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
