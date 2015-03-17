using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5RainOfTabels
{
    class Program
    {

        private static int Counter = 0;

        private static StreamWriter file = new StreamWriter(@".\CalculatedValue.txt");

        private static Dictionary<string, string> newValues = new Dictionary<string, string>();
        private static Dictionary<string, string> CollidedValues = new Dictionary<string, string>();

        private static int ColidedValueExtraIde = 0;

        private static Random gen = new Random(); 

        static void Main(string[] args)
        {
            
            bool FoundCode = false;
            string oldValue;
            string Fournumbers;
            string LastFournumbers;
            string RandomFournumbers;
            string newValue;

            Console.WriteLine("Arbetar.....");
            oldValue = "ABCEEDF5017915685F379075F00A5CCD";

           
           
            
          
           Fournumbers =  ReductionFunctionFirstFour(oldValue);
           newValue = CalculateMd5sum(Fournumbers);

           FoundCode = CompareHSums(newValue, oldValue, Fournumbers);

           if (!FoundCode)
           {

               LastFournumbers = ReductionFunctionLastFour(oldValue);
               newValue = CalculateMd5sum(LastFournumbers);
               FoundCode = CompareHSums(newValue, oldValue, LastFournumbers);

           }

           if (!FoundCode)
           {

               RandomFournumbers = ReductionFunctionRandomFour(oldValue);
               newValue = CalculateMd5sum(RandomFournumbers);
               FoundCode = CompareHSums(newValue, oldValue, RandomFournumbers);


           }
          

           while(!FoundCode){

               Fournumbers = ReductionFunctionFirstFour(newValue);
               newValue = CalculateMd5sum(Fournumbers);
               FoundCode = CompareHSums(newValue, oldValue, Fournumbers);

               if (!FoundCode)
               {

                   LastFournumbers = ReductionFunctionLastFour(newValue);
                   newValue = CalculateMd5sum(LastFournumbers);
                   FoundCode = CompareHSums(newValue, oldValue, LastFournumbers);

               }

               if (!FoundCode)
               {

                   RandomFournumbers = ReductionFunctionRandomFour(newValue);
                   newValue = CalculateMd5sum(RandomFournumbers);
                   FoundCode = CompareHSums(newValue, oldValue, RandomFournumbers);


               }

           }
            

            Console.ReadLine(); 

        }



        public static string ReductionFunctionFirstFour(string hashvalue)
        {
            char[] DividedHashValue = hashvalue.ToCharArray();
            string ReducesdValue = ""; 

            for (int i = 0; i < DividedHashValue.Length; i++)
            {

                switch (DividedHashValue[i]) {

                    case '0':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '1':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '2':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '3':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '4':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '5':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '6':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '7':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '8':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '9':
                        ReducesdValue += DividedHashValue[i];
                        break;



                }


                  //Stoppa loppen när vi har 4 siffror. 
                 if (ReducesdValue.Length == 4)
                {

                    break;
                }

            }



            return ReducesdValue;




        }




        public static string ReductionFunctionLastFour(string hashvalue)
        {
            char[] DividedHashValue = hashvalue.ToCharArray();
            string ReducesdValue = "";
         

            for (int i = DividedHashValue.Length - 1; i > 0; i--)
            {

                switch (DividedHashValue[i])
                {

                    case '0':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '1':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '2':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '3':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '4':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '5':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '6':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '7':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '8':
                        ReducesdValue += DividedHashValue[i];
                        break;

                    case '9':
                        ReducesdValue += DividedHashValue[i];
                        break;



                }


                //Stoppa loppen när vi har 4 siffror. 
                if (ReducesdValue.Length == 4)
                {

                    break;
                }

            }



            return ReducesdValue;




        }



        public static string ReductionFunctionRandomFour(string hashvalue)
        {
            char[] DividedHashValue = hashvalue.ToCharArray();
            string ReducesdValue = "";
           

          
            while (ReducesdValue.Length != 4) { 

                char Randomchar = DividedHashValue[gen.Next(DividedHashValue.Length - 1)];

                switch (Randomchar)
                {

                    case '0':
                        ReducesdValue += Randomchar;
                        break;

                    case '1':
                        ReducesdValue += Randomchar;
                        break;

                    case '2':
                        ReducesdValue += Randomchar;
                        break;

                    case '3':
                        ReducesdValue += Randomchar;
                        break;

                    case '4':
                        ReducesdValue += Randomchar;
                        break;

                    case '5':
                        ReducesdValue += Randomchar;
                        break;

                    case '6':
                        ReducesdValue += Randomchar;
                        break;

                    case '7':
                        ReducesdValue += Randomchar;
                        break;

                    case '8':
                        ReducesdValue += Randomchar;
                        break;

                    case '9':
                        ReducesdValue += Randomchar;
                        break;



                }


               

            }



            return ReducesdValue;


        }


        public static string CalculateMd5sum(string ReducedValue)
        {
            MD5 md5 = MD5.Create();
            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

            //int ReducedValueInteger = int.Parse(ReducedValue);
            byte[] ReducedValueBytes = System.Text.Encoding.ASCII.GetBytes(ReducedValue);
            byte[] Computedhash = md5.ComputeHash(ReducedValueBytes);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Computedhash.Length; i++)
            {
                sb.Append(Computedhash[i].ToString("X2"));
            
            
            }
            return sb.ToString();
            }




        public static bool CompareHSums(string newValue, string oldValue, string Fournumbers)
        {
            
            bool FoundCode = false;
            

            if(!CollisionDetector(newValues,newValue)){

                newValues.Add(Fournumbers,newValue);
                Console.WriteLine(newValues.Count);
            }
            else
            {
                ColidedValueExtraIde++;
                CollidedValues.Add(Fournumbers + " | " + ColidedValueExtraIde, newValue); //Lägger krockvärdet i en lista med andra krockvärden, med en extra unik idé för att undvika krock igen i krocklistan.

            }


            if (newValues.Count != 0)
            {
                /*
                for (int i = 0; i < newValues.Count; i++)
                {

                    if (newValues.ElementAt(i).Value.Equals(oldValue))//Kolla ifall en ny hash värde motsvarar mot det gammla.
                    {
                        Console.WriteLine("MATCH!!");
                        Console.WriteLine("Code: " + newValues.ElementAt(i).Key + " | "  + "Mot. Hash: " +  newValues.ElementAt(i).Value);
                        file.WriteLine("MATCH!!");
                        file.AutoFlush = true;
                        file.WriteLine("Code: " + newValues.ElementAt(i).Key + " | " + "Mot. Hash: " + newValues.ElementAt(i).Value);
                        FoundCode = true;

                    }
                    else
                    {
                        Counter++;
                       // Console.WriteLine(Counter);
                        FoundCode = false; 
                    }

                }
                 */

                if (newValues.ContainsValue(oldValue))
                {
                    Console.WriteLine("MATCH!!");
                    file.WriteLine("MATCH!!");
                    file.AutoFlush = true;


                    string hashvalue;
                    newValues.TryGetValue(Fournumbers, out hashvalue);
                    file.WriteLine("Code: " + Fournumbers + " | " + "Mot. Hash: " + hashvalue);
                    Console.WriteLine("Code: " + Fournumbers + " | " + "Mot. Hash: " + hashvalue);
                    
                    
                    
                    FoundCode = true;
                }
                else
                {
                    Counter++;
                    // Console.WriteLine(Counter);
                    FoundCode = false;
                }


            }

            return FoundCode;
        }


        public static bool CollisionDetector(Dictionary<string,string> newValues, string newValue)
        {
            bool collision = false;

            if (newValues.ContainsValue(newValue))
            {
                collision = true;

            }
            else
            {
                collision = false; 
            }



            return collision;
        }

            
        }



    }

