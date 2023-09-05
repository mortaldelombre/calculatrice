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

            //déclaration des variables
            //
            Console.WriteLine();

            Console.WriteLine("entrer un chiffre puis valider");
            int chiffre1 = Convert.ToInt32(Console.ReadLine());

            //
            Console.WriteLine("entrer une opération");

            string opération = Console.ReadLine();

            Console.WriteLine("entrer un chiffre puis valider");

            int chiffre2 = Convert.ToInt32(Console.ReadLine());



            switch (opération)
            {
                case ("+"):
                    Console.WriteLine(chiffre1 + chiffre2);
                    Console.ReadLine();
                    break;

                case ("-"):
                    Console.WriteLine(chiffre1 - chiffre2);
                    Console.ReadLine();
                    break;

                case ("*"):
                    Console.WriteLine(chiffre1 * chiffre2);
                    Console.ReadLine();
                    break;

                case ("/"):
                    Console.WriteLine(chiffre1 / chiffre2);
                    Console.ReadLine();
                    break;

            }

            Console.WriteLine("resultat:");


        }
    }
}