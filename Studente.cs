using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Studente
    {

        public string Name;
        public string Cognome;
        public DateTime DateBirth;
        public ulong Matricola;

        public Studente(string name, string cognome, DateTime dateBirth, ulong matricola)
        {
            string Name = name;
            string Cognome = cognome;
            DateTime DateBirth = dateBirth;
            ulong Matricola = matricola;
        }

    }




    public class Universita
    {

        // COLLECTION: le proprieta dell'universita sono delle liste
        private List<string> listSedi;
        private List<Studente> listStudenti;


        // COSTRUTTORE
        public Universita()
        {

            this.listSedi = new List<string>();
            this.listStudenti = new List<Studente>();
        }


        public void AddSedi(string s)
        {
            // Metodo che aggiunge un elemento alla lista delle sedi
            this.listSedi.Add(s.ToLower());
        }

        public bool AddStudente(string nome, string cognome, string dataNascita, ulong matricola)
        {
            //this.listStudenti.Add(new Studenti(nome, cognome, dataNascita, matricola));

            // Controllo dei dati in ingresso
            bool bRetValue;
            DateTime dtDataNascitaStudente;
            bRetValue = DateTime.TryParse(dataNascita, out dtDataNascitaStudente);

            Convert.ToDateTime(dtDataNascitaStudente);

            if (bRetValue)
            {
                Studente mioStudente = new Studente(nome, cognome, dtDataNascitaStudente, matricola);
                this.listStudenti.Add(mioStudente);

                return true;
            }
            return false;
        }


        public void RimuoviSede(string sede)
        {
            listSedi.Remove(sede);
        }


        // Metodo per rimuovere lo studente
        public void RimuoviStudente(ulong matricola)
        {

            foreach (Studente s in this.listStudenti)
            {
                if (s.Matricola == matricola)
                {
                    listStudenti.Remove(s);
                    throw new Exception("Studente rimosso correttamente");
                }

                throw new Exception("Lo studente non è stato trovato");
            }
        }


        // Metodo per cercare la sede
        public bool CercaSede(string sede)
        {
            foreach (string s in listSedi)
            {
                string searchSede = s.ToLower();
                if (listSedi.Contains(searchSede))
                {
                    return true;
                }
            }
            return false;
        }


        /*public void CercaStudente(int anno, out List<Studente>MachingList)
        {

            
            MachingList = new List <Studente>();

            foreach (Studente s in listStudenti)
            {

                
                if (s.DateBirth.Year == anno)
                { 
                    MachingList.Add(s);
                }
            }
            

            MachingList = listStudenti.FindAll(s => s.DateBirth.Year == anno);
        }*/
    }
}

