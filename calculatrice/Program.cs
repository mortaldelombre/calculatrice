using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenue dans la calculatrice de thomas");

            //Console.WriteLine("entrer une opération");

            //déclaration des variables
            //
            Console.WriteLine();

            Console.WriteLine("entrer un chiffre puis valider");
            int chiffre1 = Convert.ToInt32(Console.ReadLine());

            //char opération;



            //Console.WriteLine(chiffre1);
            Console.WriteLine("entrer une opération");

            char opération = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("entrer un chiffre puis valider");

            int chiffre2 = Convert.ToInt32(Console.ReadLine());

            int resultat;


            switch ((opération))
            {
                case Convert.ToChar("+"):
                    Console.WriteLine(chiffre1 + chiffre2);
                    break;
                    /*case 2:
                       Console.WriteLine("Tuesday");
                        break;
                    case 3:
                       Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");*/
            }
            Console.WriteLine("resultat:");
            Console.WriteLine(resultat);
        }
}