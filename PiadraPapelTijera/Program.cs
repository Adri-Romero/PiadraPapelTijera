using System;

namespace PiadraPapelTijera
{
    class Program
    {
        private static string[] opcions = new string[] { "PEDRA", "PAPER", "TISORA" };

        private static string [,] resultats = new string[,] {{"Empat", "Perds", "Guanyes"},
                                                             {"Guanyes", "Empat", "Perds"},
                                                             {"Perds", "Guanyes", "Empat"}};

        static void Main(string[] args)
        {
        }
        
        private static string comprovaQuiGuanya (int opcioUsuari, int opcioOrdinador)
        {
            Console.WriteLine("         Usuari: " + opcioUsuari);
            Console.WriteLine("         Ordinador: " + opcioOrdinador);
            Console.WriteLine("         " + resultats[opcioUsuari, opcioOrdinador]);

            return resultats[opcioUsuari, opcioOrdinador];
        }
        private static int opcioUsuari()
        {
            string opcio;
            int number;

            Console.WriteLine("Selecciona una opció (1, 2 o 3): ");
            for (int i = 0; i< opcions.Length; i++)
            {
                Console.WriteLine(i + 1 + "->" + opcions[i]);
            }
            opcio = Console.ReadLine();
            bool success = int.TryParse(opcio, out number);

            if (success || (number >= 1 && number <= 3))
            {
                return number - 1;
            }
            else
            {
                return opcioUsuari();
            }
        }
    }
}
