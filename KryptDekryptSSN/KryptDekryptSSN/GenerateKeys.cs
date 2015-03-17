using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace KryptDekryptSSN
{
    class GenerateKeys
    {

        private BigInteger p;
        private BigInteger q;
        private BigInteger PhiN;
        private BigInteger e = 2;
        public static BigInteger Phin;

        public BigInteger getPublicKeyE { get; set; }
        public BigInteger getPrivateKeyD { get; set; }

        public BigInteger getN { get; set; }


        public GenerateKeys(BigInteger p, BigInteger q)
        {
            this.p = p;
            this.q = q;

        }


        public void GeneratePublicPrivatePair()
        {
            BigInteger n = BigInteger.Multiply(q,p);  //Generara n 

            getN  = n;

            PhiN = BigInteger.Multiply((q - 1),(p - 1)); //Genererar Phi(N) 
            Phin = PhiN;


            //private key 
            BigInteger publicKey = GeneratePublicKey(PhiN, e);

            this.getPublicKeyE = publicKey;

          // Console.WriteLine("Public Key: " + publicKey); {Controll Utskrift Exl.}

            //public Key 
           BigInteger privateKey = GeneratePrivateKey(PhiN, publicKey);

           this.getPrivateKeyD = privateKey;

            //Console.WriteLine("Private Key: " + privateKey); {Controll Utskrift Exl.}

           


        }



        /*
        private int GetGCD(int PhiN, int e)  //hitta GCD
        {

            while (PhiN != 0 && e != 0)
            {

                if (PhiN > e)
                {
                    PhiN %= e;
                }
                else
                {
                    e %= PhiN;
                }

            }

            return Math.Max(PhiN, e);

        }
         */

        private bool Coprime(BigInteger PhiN, BigInteger e)  //Testa för relativt prima
        {
            return BigInteger.GreatestCommonDivisor(PhiN,e) == 1;
        }



        //Funktion för beräkning av {publik nyckel} 
        private BigInteger GeneratePublicKey(BigInteger PhiN, BigInteger e)
        {
            

            while (!Coprime(PhiN, e))
            {  //Kontrollerar om e är ett relativt prima för phi(qp)

                e++; //Öka e++.
            }



            return e;  //Ger tillbaka värdet av e.

        }


        //Function för beräkning av d {privat nyckel} 
        public BigInteger GeneratePrivateKey( BigInteger phiN, BigInteger e)
        {
            BigInteger d;
            
            for ( d = 0 ; d < phiN; d++)
            {


                BigInteger reminder = BigInteger.Remainder(BigInteger.Multiply(e,d),phiN);

               
                
                if (reminder == 1)
                {
                    break;

                }   
            }


            return d; //Ge tillbaka värdet av d. 


        }
    }

}
