using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3CUSHEW
{
    class Program

    {

        private static StreamWriter CUSUMfile = new StreamWriter(@".\CUSUM.txt");
       
        private static StreamWriter SHEWARTSfile = new StreamWriter(@".\SHEWARTS.txt");
    
        static void Main(string[] args)
        {

           


            
            //SHEWARTS Algoritm 
            SHEWARTSfile.WriteLine("#-#-#-#-#-#-#-#-#-#-#-#-#-# SHEWARTS METOD #-#-#-#-#-#-#-#-#-#-#-#-#-#" + "\n");
            SHEWARTSfile.WriteLine("          ");
            for (int z = 0; z < DiskData.AllDisks().Count; z++)
            {
                SHEWARTS(DiskData.AllDisks().ElementAt(z),DiskData.AllDisksTitels().ElementAt(z)); //Matar in Diskcluster listor och dess titlar. 

            }

            SHEWARTSfile.WriteLine("#####################+-Slutet på SHEWARTS METOD-+######################" + "\n");
            SHEWARTSfile.WriteLine("          ");
            
            

            //CUSUM Algoritm
            CUSUMfile.WriteLine("#-#-#-#-#-#-#-#-#-#-#-#-#-# CUSUM METOD #-#-#-#-#-#-#-#-#-#-#-#-#-#");
            CUSUMfile.WriteLine("           ");
            for (int j = 0; j < DiskData.AllDisks().Count; j++)
            {

                CUSUM(DiskData.AllDisks().ElementAt(j), DiskData.AllDisksTitels().ElementAt(j));

            }

            CUSUMfile.WriteLine("#####################+-Slutet på CUSUM METOD-+######################");
            CUSUMfile.WriteLine("           ");

           
            Console.WriteLine("Seriöst filerna är sparade nu... Helt ärligt, skojar inte.");
            Console.ReadLine();

            
        }


        public static void SHEWARTS(List<double> _DiskData, string _CaseName)
        {
            List<int> CryptedCluster = new List<int>();
            List<double> CrypteClusterUValue = new List<double>();


            double C = 25;  //Konstant för shewarts algoritm. 

            //Kontroll för Casfile Size. 
            for (int i = 0; i < _DiskData.Count; i++ )
            {

                if (_DiskData.ElementAt(i) < C)
                {

                    CryptedCluster.Add(_DiskData.IndexOf(_DiskData.ElementAt(i)));
                    CrypteClusterUValue.Add(_DiskData.ElementAt(i));
                    
                }


            }


            SHEWARTSfile.WriteLine("---------------Krypterade Kluster " + _CaseName + "---------------");
            SHEWARTSfile.WriteLine("          ");

            //Skriver ut Krypteradekluster för disk1 
            for (int k = 0; k < CryptedCluster.Count ; k++)
            {
               
                SHEWARTSfile.WriteLine("Kluster nummer: " + CryptedCluster.ElementAt(k) + "| U-värde: " + CrypteClusterUValue.ElementAt(k));
                SHEWARTSfile.WriteLine("          ");
                SHEWARTSfile.AutoFlush = true;
                break; //Stannar så får första misstänkta krypterade kluster har hittats. 

            }

            


        }

        public static void CUSUM(List<double> _DiskData, string _CaseName)
        {
            double C = 8.93;

            List<int> CryptedCluster = new List<int>(); //För att lagra cluster index. 
            int t = 0; //För Att indexera  
            List<double> AValues = new List<double>();  //för att lagra beräknade At värden
        
            


            for (int i = 0; i < _DiskData.Count; i++ )
            {
                int one = 1;
                


                if (t == 0)
                {

                    
                    AValues.Add((50 * Math.Log(1.25)) - (0.25 * _DiskData.ElementAt(i)));  //för första värdet, där t = 0;
                    CryptedCluster.Add(_DiskData.IndexOf(_DiskData.ElementAt(i))); //Lagra cluster nummret. 
                }
                else
                {
                    //för t => 1 
                    AValues.Add((Math.Max(0, AValues.ElementAt(t - one))) + (50 * Math.Log(1.25)) - (0.25 * _DiskData.ElementAt(i)));
                    CryptedCluster.Add(_DiskData.IndexOf(_DiskData.ElementAt(i))); //Lagra cluster nummret. 
                }


                t++;
               
               
               

            }







            //Kollar om  de beräknade at värden uppfyller villkoret at > c, om så är fallet då lagras värden
            CUSUMfile.WriteLine("---------------Krypterade Kluster " + _CaseName + "---------------");
            CUSUMfile.WriteLine("           ");
                for (int i = 0; i < AValues.Count; i++)
                {

                    if (AValues.ElementAt(i) > C)
                    {

                        CUSUMfile.WriteLine("Kluster nummer: " + CryptedCluster.ElementAt(i) + "| At-värde: " + AValues.ElementAt(i));
                        CUSUMfile.WriteLine("           ");
                        CUSUMfile.AutoFlush = true;
                        break; //Stannar så får första misstänkta krypterade kluster har hittats. 
                    }
                    


                }


            
        
                

                    
          
            
        }


     
            
          
          
        
    }
}
