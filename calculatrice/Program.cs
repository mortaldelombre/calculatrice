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

            /* Thomas Peltier
             * Etml préap srage 1
             * Programme : calculatrice
             * 04/09/2023
             */

          /*int = stocke des nombres entiers
            double = stocke des nombres à virgule
            char = stocke un caractère
            string = stocke des chaines de textes
            bool = stocke des valeurs vrai ou faux */


            Console.WriteLine("bienvenue dans la calculatrice");  //écrit du début

            //déclaration des variables

            Console.WriteLine();   // espace entre l'écrit du début et l'explication

            Console.WriteLine("entrer un chiffre puis valider");     //explication 
            int ch1 = Convert.ToInt32(Console.ReadLine());      //convertion en int

            //lecture des nombre de l'utilisateur et explication
            Console.WriteLine("entrer une opération");       //explication

            string opération = Console.ReadLine();        //déclaration de la variable opération

            Console.WriteLine("entrer un chiffre puis valider");      //explication

            int ch2 = Convert.ToInt32(Console.ReadLine());      //convertion en int


            //calcule des opérations
            switch (opération)
            {
                case ("+"):
                    Console.WriteLine(add(ch1, ch2));   //déclaration de l'addition
                    Console.ReadLine();
                    break;

                case ("-"):
                    Console.WriteLine(sub(ch1, ch2));   //déclaration de la sustraction
                    Console.ReadLine();
                    break;

                case ("*"):
                    Console.WriteLine(tim(ch1, ch2));   //déclaration de la multiplication
                    Console.ReadLine();
                    break;

                case ("/"):
                    Console.WriteLine( div(ch1, ch2));   //déclaration de la division
                    Console.ReadLine();
                    break;

                    
            }


        }
        
        private static int add(int ch1, int ch2) //method addition
        {
            int result = ch1 + ch2;

            return result;
        }
        private static int sub(int ch1, int ch2) // method soustraction
        {
            int result = ch1 - ch2;

            return result;
        }

        private static int tim(int ch1, int ch2) // method multiplication
        {
            int result = ch1 * ch2;

            return result;
        }

        private static int div(int ch1, int ch2) // method division
        {
            int result = ch1 / ch2;

            return result;
        }

        
    }
}