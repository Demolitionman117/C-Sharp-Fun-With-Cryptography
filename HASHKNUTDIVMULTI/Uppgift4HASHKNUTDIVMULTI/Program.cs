using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4HASHKNUTDIVMULTI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("X = 482, n = 16 , A = Pi  \n");

            Console.WriteLine("Divisions-Metoden");
            Console.WriteLine("Resultat: " + DivisionMetod(482, 16));

            Console.WriteLine("\nKnuths Metod");
            Console.WriteLine("Resultat: " + KnutMetod(482,16));

            Console.WriteLine("\nMultiplikations-Metoden");
            Console.WriteLine("Resultat: " + MultiMetdo(482, 16));

            Console.ReadLine(); 

        }



        public static BigInteger DivisionMetod(BigInteger x, BigInteger n)
        {


            BigInteger HashValue = BigInteger.Remainder(x, (n + 1)); 

            return HashValue;

        }



        public static BigInteger KnutMetod(BigInteger x, BigInteger n)
        {

            BigInteger HashValue = BigInteger.Remainder(BigInteger.Multiply(x, (x + 3)), (n + 1));


            return HashValue;

        }

        public static double MultiMetdo(double x, double n)
        {
            double A = Math.PI;  //Sätter A till P 

            double KeyMultiA = x * A;  //Multiplicerar x med PI (482 * PI) 

            double fractionalpart = KeyMultiA - Math.Truncate(KeyMultiA); // Tar det talet man fick av  x * p och tar bort hel tals delen från den

            double NMultiFraction = n * fractionalpart;  //Tar n som är 2^4 = 16  * fraktionerna man fick utav föregående uträkning.

            double result = Math.Floor(NMultiFraction);  // Retunerar heltals delen av uträkningen. 


            return result; 



        }

        }
    }

