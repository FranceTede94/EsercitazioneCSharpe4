using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUINTOESERCIZIO
{
    internal interface INTERFACCIA
    {
        // Il metodo 'Stampa' viene dichiarato nell'interfaccia.
        // Tutte le classi che implementano questa interfaccia devono avere questo metodo.

        // Questo è un metodo che stampa qualcosa, ma non ha un corpo, solo la dichiarazione.
        void Stampa();

        void ElencoPersone();
    }

    class FileTxt : INTERFACCIA
    {
        private string Nome;

        public FileTxt(string nome)
        {
            Nome = nome;
        }

        public string Nome1 { get => Nome; set => Nome = value; }

        public void Stampa()
        {
            Console.WriteLine(Nome);
        }

        public void ElencoPersone()
        {
            Console.WriteLine("Qui trovi i nomi delle persone");
        }

    }

    class FileWord : INTERFACCIA
    {
        private string Nome;

        public FileWord(string nome)
        {
            Nome = nome;
        }

        public string Nome1 { get => Nome; set => Nome = value; }

        public void Stampa()
        {
            Console.WriteLine(Nome);
        }

        public void ElencoPersone()
        {
            Console.WriteLine("Con questo metodo estrai tutti i nomi delle persone inserite");
        }


        public interface IAnimale
        {
            void Mangiare();
            void Dormire();
        }

        public class Cane : IAnimale
        {
            private string Nome;

            public Cane(string nome)
            {
                Nome = nome;
            }
            public void Mangiare()
            {
                Console.WriteLine("Il cane mangia le crocchette e il suo nome è " + Nome);
            }

            public void Dormire()
            {
                Console.WriteLine("Il cane dorme nel suo letto.");
            }
        }


        public class Gatto : IAnimale
        {
            private string Nome;

            public Gatto(string nome)
            {
                Nome = nome;
            }

            public string Nome1 { get => Nome; set => Nome = value; }

            public void Mangiare()
            {
                Console.WriteLine("Il gatto mangia le crocchette e il pesce e il suo nome è " + Nome);
            }

            public void Dormire()
            {
                Console.WriteLine("Il gatto dorme nella sua cuccetta.");
            }
        }
    }

}
