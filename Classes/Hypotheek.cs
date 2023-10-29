using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypo.Classes
{
    public class Hypotheek
    {
        public Hypo.Classes.Person person = new Hypo.Classes.Person();

        public void Maandinkomen(int geld = 1000)
        {
            if (geld == 1000)
            {
                Console.Write("Wat is uw brutojaarsalaris: ");
                double BrutoJaarInkomen = double.Parse(Console.ReadLine());

                person.brutoJaarSalaris = BrutoJaarInkomen;
            }
            else
            {
                person.brutoJaarSalaris = geld;
            }
        }

        public void RentevastePeriode(EnumRente gekozenRente = EnumRente.DefaultValue)
        {
            Console.WriteLine("Rentevaste periodes:");
            Console.WriteLine("1. 1 jaar  | 2%");
            Console.WriteLine("2. 5 jaar  | 3%");
            Console.WriteLine("3. 10 jaar | 3.5%");
            Console.WriteLine("4. 20 jaar | 4.5%");
            Console.WriteLine("5. 30 jaar | 5%");

            if (gekozenRente == EnumRente.DefaultValue)
            {
                Console.Write("selecteer welke rentevaste periode u wilt kiezen voor uw hypotheek lening: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        gekozenRente = EnumRente.EenJaar;
                        break;
                    case 2:
                        gekozenRente = EnumRente.VijfJaar;
                        break;
                    case 3:
                        gekozenRente = EnumRente.TienJaar;
                        break;
                    case 4:
                        gekozenRente = EnumRente.TwintigJaar;
                        break;
                    case 5:
                        gekozenRente = EnumRente.DertigJaar;
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        return;
                }
            }

            switch (gekozenRente)
            {
                case EnumRente.EenJaar:
                    person.rentevastePeriode = 1;
                    person.rentePercentage = 2;

                    Console.WriteLine("U heeft de rentevaste periode gekozen van: 1 jaar | 2%");
                    break;
                case EnumRente.VijfJaar:
                    person.rentevastePeriode = 5;
                    person.rentePercentage = 3;

                    Console.WriteLine("U heeft de rentevaste periode gekozen van: 5 jaar | 3%");
                    break;
                case EnumRente.TienJaar:
                    person.rentevastePeriode = 10;
                    person.rentePercentage = 3.5;

                    Console.WriteLine("U heeft de rentevaste periode gekozen van: 10 jaar | 3.5%");
                    break;
                case EnumRente.TwintigJaar:
                    person.rentevastePeriode = 20;
                    person.rentePercentage = 4.5;

                    Console.WriteLine("U heeft de rentevaste periode gekozen van: 20 jaar | 4.5%");
                    break;
                case EnumRente.DertigJaar:
                    person.rentevastePeriode = 30;
                    person.rentePercentage = 5;

                    Console.WriteLine($"U heeft de rentevaste periode gekozen van: {person.rentevastePeriode} | {person.rentePercentage}");
                    break;
            }
        }

        public void HeeftPartner(bool heefteenpartner = true)
        {
            if (heefteenpartner)
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
                    person.totaalJaarSalaris = person.brutoJaarSalaris + person.partnerBrutoJaarSalaris;
                }

                //set value
                person.heeftPartner = gebruikerHeeftPartner;
            }
            else
            {
                person.heeftPartner = false;
            }
        }

        public void HeeftStudieSchuld(bool heeftschulden = false)
        {
            if (!heeftschulden)
            {
                Console.Write("Heb je een studieschuld (Ja/Nee): ");
                string studieschuldInput = Console.ReadLine();
                //ja = true, nee = false
                bool heeftStudieschuld = studieschuldInput.Equals("Ja", StringComparison.OrdinalIgnoreCase);

                //set value
                person.heeftStudieSchuld = heeftStudieschuld;
            }
            else
            {
                person.heeftStudieSchuld = true;
            }
        }

        public void Postcode(int userPostcode = 1111)
        {
            if (userPostcode == 1111)
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
            else
            {
                person.postcode = userPostcode;
            }
        }

        public HypotheekResult BerekenHypotheek()
        {
            double maxHypotheek;

            if (person.heeftPartner)
            {
                maxHypotheek = person.totaalJaarSalaris * 4.25;
            }
            else
            {
                maxHypotheek = person.brutoJaarSalaris * 4.25;
            }

            if (person.heeftStudieSchuld == true)
            {
                //door een studieschuld mag de klant 25% minder lenen.
                maxHypotheek = maxHypotheek / 100 * 75;
            }

            if(person.magLenen == false)
            {
                //mag niets lenen i.v.m een aardbevingsgebied en dalende woningwaarde.
                maxHypotheek = 0;
            }

            //berekeningen
            double rentePerMaand = person.rentePercentage / 100 / 12;
            double renteBedragPerMaand = maxHypotheek * rentePerMaand;
            double AflossingsBedrag = maxHypotheek / 30 / 12;
            double totaleMaandbedrag = renteBedragPerMaand + AflossingsBedrag;
            double totaalBedragNaDertigJaar = Math.Round(totaleMaandbedrag, 2) * 12 * 30;

            var results = new HypotheekResult
            {
                MaxHypotheek = Math.Round(maxHypotheek, 2),
                RenteBedragPerMaand = Math.Round(renteBedragPerMaand, 2),
                AflossingsBedrag =  Math.Round(AflossingsBedrag, 2),
                TotaleMaandbedrag = Math.Round(totaleMaandbedrag, 2),
                TotaalBedragNaDertigJaar = Math.Round(totaalBedragNaDertigJaar, 2),
            };

            Console.WriteLine("====================");
            Console.WriteLine($"U komt maximaal een hypotheeklening nemen van: {maxHypotheek}");
            Console.WriteLine($"rentevaste periode: {person.rentevastePeriode} jaar || {person.rentePercentage}%");
            Console.WriteLine($"Rente bedrag: {renteBedragPerMaand:F2}");
            Console.WriteLine($"Aflossingbedrag: {AflossingsBedrag:F2}");
            Console.WriteLine($"Totale maandbedrag: {totaleMaandbedrag:F2}");
            Console.WriteLine($"Totaal betaald na 30 jaar : {totaalBedragNaDertigJaar:F2}");
            
            return results;
        }
    }
}
