using static QUINTOESERCIZIO.FileWord;

namespace QUINTOESERCIZIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INTERFACCIA xxx = new FileTxt("Giuseppe");

            xxx.Stampa();
            xxx.ElencoPersone();

            Console.WriteLine();

            INTERFACCIA xxs = new FileWord("Enrico");

            xxs.Stampa();
            xxs.ElencoPersone();

            Console.WriteLine();

            IAnimale mioCane = new Cane("Pallina");

            IAnimale mioGatto = new Gatto("Billi");

            // Chiamata ai metodi definiti nell'interfaccia
            mioCane.Mangiare();
            mioCane.Dormire();

            Console.WriteLine();

            mioGatto.Mangiare();
            mioGatto.Dormire();
        }
    }
}
