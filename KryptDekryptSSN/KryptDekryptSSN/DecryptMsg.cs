using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KryptDekryptSSN
{
    class DecryptMsg
    {

        public DecryptMsg()
        {



        }



        public String DeCrypt(List<BigInteger> CryptedText, BigInteger d, BigInteger n)
        {

            // Skapa en Encoder Objekt för att encoda texten.
            TextEncoderDecoder EncoderDecoder = new TextEncoderDecoder();

          
            
            // Use the public parameters to encrypt the data.
            List<BigInteger> DecipherdTextInts = RSADecrypt(CryptedText, d, n);

           
            // Display the encrypted bytes.
            string DeCryptedText = EncoderDecoder.Decode(DecipherdTextInts);

            
            

            return DeCryptedText;
        }




        public List<BigInteger> RSADecrypt(List<BigInteger> CipherBytes, BigInteger d, BigInteger n)
        {

            List<BigInteger> DecipherdTextInts = new List<BigInteger>(); 

            for (int i = 0; i < CipherBytes.Count; i++)
            {

                DecipherdTextInts.Add(BigInteger.ModPow(CipherBytes.ElementAt(i), d, n));

              //  Console.WriteLine("Value of DeCrypted: " + DecipherdTextInts.ElementAt(i));

            }

            return DecipherdTextInts;

        }
    }
}
