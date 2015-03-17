using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace KryptDekryptSSN
{
    class CryptMsg
    {

       

        public CryptMsg()
        {

        }


        public List<BigInteger> Crypt(string plaintext, BigInteger e, BigInteger n)
        {

            // Skapa en Encoder Objekt för att encoda texten.
            TextEncoderDecoder EncoderDecoder = new TextEncoderDecoder();


            List<BigInteger> EncodedPlainText = EncoderDecoder.Encode(plaintext);



                // Använd publika nyckeln för att kryptera texten
            List<BigInteger> cipherInts = RSAEncrypt(EncodedPlainText, e, n);
      

                return cipherInts;
            }




        public static List<BigInteger> RSAEncrypt(List<BigInteger> PlainMessage, BigInteger e, BigInteger n)
        {

            List<BigInteger> KrypteradText = new List<BigInteger>(); 

     //gå genom plan texten för extrahera siffrorna.
     for (int i = 0; i < PlainMessage.Count; i++)
     {
         

         //kontrollera storlek på karäktar block.
         if (PlainMessage.ElementAt(i) < n)
         {

             KrypteradText.Add((BigInteger.ModPow(PlainMessage.ElementAt(i), e, n)));

         }
         else
         {
             Console.WriteLine("N är för liten, gör om gör rätt.");


         }

     }


     return KrypteradText;


        }

    }
}



