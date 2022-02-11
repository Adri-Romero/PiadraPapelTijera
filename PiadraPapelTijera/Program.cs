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
            Random random = new Random();
            bool jugar = true;
            int nRondes = 0;
            int nGuanyades = 0;

            Console.WriteLine("Benvingut al Joc Pedra,Paper,Tisores");
            while (jugar)
            {
                int usuari = opcioUsuari();
                int ordinaror=random.Next(0,3);
                string resultat = comprovaQuiGuanya(usuari,ordinaror);
                nRondes++;
                if (resultat=="Guanyes")
                {
                    nGuanyades++;
                }

                Console.WriteLine($"Rondes jugades {nRondes} de les quals has guanyat {nGuanyades}");
                jugar=continuarJugant();
            }
            
        }
        
        private static string comprovaQuiGuanya (int opcioUsuari, int opcioOrdinador)
        {
            Console.WriteLine("         Usuari: " + opcions[opcioUsuari]);
            Console.WriteLine("         Ordinador: " + opcions[opcioOrdinador]);
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
        private static bool continuarJugant()
        {
            string resposta;

            Console.WriteLine("Vols continuar jugant (SI/NO)? ");
            resposta = Console.ReadLine();
            if (resposta.ToUpper() == "SI")
            {
                Console.WriteLine("------------------------------- ");
                return true;
            }
            else if (resposta.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                return continuarJugant();
            }
            




        }
    }
}
