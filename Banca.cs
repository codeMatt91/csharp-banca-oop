using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Banca
    {
        private string NomeBanca { get; set; }
        private List<Cliente> listaClienti { get; set; }
        private List<Prestito> listaPrestiti { get; set; }


        public Banca(string sNomeBanca)
        {
            NomeBanca = sNomeBanca;
            listaClienti = new List<Cliente>();
            listaPrestiti = new List<Prestito>();
        }


        // Funzione per aggiungere un cliente alla lista
        public void AggiungiCliente(Cliente c)
        {

            // In questo modo evito di fare il costruttore nella classe Cliente 

            listaClienti.Add(c);
        }


        // Funzione per modificare un cliente 
        public void ModificareCliente(string CodiceFCliente)
        {
            Cliente mioCliente = listaClienti.Find(x => x.CodiceFCliente == CodiceFCliente);

            Console.WriteLine("Decidi cosa modificare:");
            Console.WriteLine("Se vuoi modificare il nome inserisci : 1");
            Console.WriteLine("Se vuoi modificare il cognome inserisci : 2");
            Console.WriteLine("Se vuoi modificare il codice fiscale inserisci : 3");
            Console.WriteLine("Se vuoi modificare lo stipendio inserisci : 4");

            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Inserisci il nuovo nome");
                    string newName = Console.ReadLine();
                    mioCliente.NomeCliente = newName;
                    break;
                case 2:
                    Console.WriteLine("Inserisci il nuovo cognome");
                    string newCognome = Console.ReadLine();
                    mioCliente.CognomeCliente = newCognome;
                    break;
                case 3:
                    Console.WriteLine("Inserisci il nuovo codice fiscale");
                    string newCodiceFiscale = Console.ReadLine();
                    if (newCodiceFiscale.Length == 11)
                        mioCliente.CognomeCliente = newCodiceFiscale;
                    break;
                case 4:
                    Console.WriteLine("Inserisci il nuovo stipendio");
                    int newStipendio = Convert.ToInt32(Console.ReadLine());
                    mioCliente.Stipendio = newStipendio;
                    break;
            }

        }


        //Funzione per eliminare un cliente dalla lista clienti
        public void RimuoviCliente(string CodiceFCliente)
        {
            Cliente mioCliente = listaClienti.Find(x => x.CodiceFCliente == CodiceFCliente);

            listaClienti.Remove(mioCliente);

        }

        public void CercaCliente(string CodiceFCliente)
        {
            Cliente mioCliente = listaClienti.Find(x => x.CodiceFCliente == CodiceFCliente);

            Console.WriteLine(mioCliente.NomeCliente);
            Console.WriteLine(mioCliente.CognomeCliente);
            Console.WriteLine(mioCliente.Stipendio);
            Console.WriteLine(mioCliente.CodiceFCliente);

        }

        public void AggiungiPrestito(Prestito p)
        {
            listaPrestiti.Add(p);
        }

        public bool FiltraPrestitoPerCliente(string CodiceFCliente, Prestito p)
        {
            if (p.Intestatario.CodiceFCliente.Equals(CodiceFCliente))
            {
                Console.WriteLine("Il prestito e associato al cliente inserito");
                return true;
            }
            else
            {
                Console.WriteLine("Il prestito non e associato al cliente inserito");
                return false;
            }
        }
    }


    public class Cliente
    {
        private string nomeCliente;
        public string NomeCliente
        {
            get => nomeCliente;
            set => nomeCliente = value;
        }
        private string cognomeCliente;
        public string CognomeCliente
        {
            get => cognomeCliente;
            set => cognomeCliente = value;
        }
        private string codiceFiscale;
        public string CodiceFCliente
        {
            get => codiceFiscale;
            set => codiceFiscale = value;
        }
        private int stipendio;
        public int Stipendio
        {
            get => stipendio;
            set => stipendio = value;
        }

        public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
        {
            this.NomeCliente = nome;
            this.CognomeCliente = cognome;
            this.CodiceFCliente = codiceFiscale;
            this.Stipendio = stipendio;
        }

    }


    public class Prestito
    {
        private Cliente intestatario;
        public Cliente Intestatario
        {
            get => intestatario;
            set => intestatario = value;
        }
        private double ammontarePrestito;
        public double AmmontarePrestito
        {
            get => ammontarePrestito;
            set => ammontarePrestito = value;
        }
        private double rataPrestito;
        public double RataPrestito
        {
            get => rataPrestito;
            set => rataPrestito = value;
        }
        private DateTime dataInizio;
        public DateTime DataInizio
        {
            get => dataInizio;
            set => dataInizio = value;
        }
        private DateTime dataFine;
        public DateTime DataFine
        {
            get => dataFine;
            set => dataFine = value;
        }


        public Prestito(Cliente intestatario, double totPrestito, double rata, DateTime dataInizio, DateTime dataFine)
        {
            this.Intestatario = intestatario;
            this.AmmontarePrestito = totPrestito;
            this.RataPrestito = rata;
            this.DataInizio = dataInizio;
            this.DataFine = dataInizio;
        }

    }

}
