using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = Console.ReadLine();
            char[] plainTextArr = plainText.ToCharArray();
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd' };

            
            
            for (int i = 0; i < plainTextArr.Length; i++) //iterates through each letter of plainText
            {
                for (int k = 0; k < 27; k++)   //goes through alphabet finding the letter of each char in plaintext and changing it to the next 4th letter
                {
                      if (plainTextArr[i] == alphabet[k])
                      {
                        plainTextArr[i] = alphabet[k + 3];
                      }
                }
            }

            for (int i = 0; i < plainTextArr.Length; i++) //prints result
            {
                Console.Write(plainTextArr[i]);
            }

            Console.ReadLine();
        }
    }
}
