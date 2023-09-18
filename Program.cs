using System;
using System.Collections.Generic;
using System.Text;

namespace Hypo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of hypotheek.
            Hypo.Classes.Hypotheek hypotheek = new Hypo.Classes.Hypotheek();

            hypotheek.Maandinkomen();

            //hypotheek.RentevastePeriode();

            hypotheek.HeeftPartner();

            hypotheek.heeftStudieSchuld();

            Console.Write("Voer je postcode in: ");
            string postcode = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
