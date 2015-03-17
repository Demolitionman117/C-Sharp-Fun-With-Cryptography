using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace KryptDekryptSSN
{
    class TextEncoderDecoder
    {

        //En Lista med tecken för Koda och Avkoda tecken.
        private List<char> CharTabel = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'å', 'ä', 'ö', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Å', 'Ä', 'Ö', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', '!', '"', '%', '&', '(', ')', '*', '+', ',', '-', '.', '/', ':', '=', '?' };

        public TextEncoderDecoder()
        {



        }

        //Text Encoder
        public List<BigInteger> Encode(string text)
        {
            char[] ParmaterTextArray = text.ToCharArray();
            List<BigInteger> CharNumbers = new List<BigInteger>(); 


            for (int i = 0; i < ParmaterTextArray.Length; i++)
            {
                //Kontrollera ifall tecknet finns med i kräktar tabellen
                if (CharTabel.Contains(ParmaterTextArray.ElementAt(i)))
                {

                    //Om så lägg till position nummret i en lista. 
                    CharNumbers.Add(CharTabel.IndexOf(ParmaterTextArray.ElementAt(i)));


                }

            }

            return CharNumbers;

        }

        //Text Decoder
        public string Decode(List<BigInteger> EncodedText)
        {
            string DecodedText = ""; 

            //Tar och hämtar element från karäktar tabellen baserat på den sparade positionen.
            for (int i = 0; i < EncodedText.Count; i++)
            {
                int charat = (int)EncodedText.ElementAt(i);
                DecodedText += CharTabel.ElementAt(charat);


            }


            return DecodedText; 
        }


    }
}
