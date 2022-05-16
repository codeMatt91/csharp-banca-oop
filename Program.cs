using System;

namespace csharp_banca_oop // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente("Matteo", "Imbimbo", "MBMMNT92A09H501S", 1500);
            Banca bancaSella = new("Banca Sella");


            Console.WriteLine(cliente1.NomeCliente);
            Console.WriteLine(cliente1.CognomeCliente);
            Console.WriteLine(cliente1.CodiceFCliente);
            Console.WriteLine(cliente1.Stipendio);

            bancaSella.AggiungiCliente(cliente1);

            Console.WriteLine(" inserisci il codice fiscale del Cliente da modificare:");
            string codiceFiscale = Console.ReadLine();

            bancaSella.ModificareCliente(codiceFiscale);


            Console.WriteLine(cliente1.NomeCliente);
            Console.WriteLine(cliente1.CognomeCliente);
            Console.WriteLine(cliente1.CodiceFCliente);
            Console.WriteLine(cliente1.Stipendio);

            Prestito mioPrestito = new Prestito(cliente1, 5000.00, 500.00, new DateTime(12/01/2010), new DateTime(12 /10/2010));

            bancaSella.AggiungiPrestito(mioPrestito);

            // Per sapere se un prestito e associato ad un cliente
            Console.WriteLine(bancaSella.FiltraPrestitoPerCliente("MBMMNT92A09H501S", mioPrestito));


            
        }
    }
}
