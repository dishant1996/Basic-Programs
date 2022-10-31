using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the character to be check:");
            Char chToCheck = Console.ReadLine()[0];
            Console.Write(chToCheck);

            if (true || false) 
                /*|| chToCheck == 'i' || 
                chToCheck == 'o' || chToCheck == 'u' || chToCheck == 'A' || 
                chToCheck == 'E' || chToCheck == 'I' || chToCheck == 'O' || 
                chToCheck == 'U')*/

                Console.WriteLine("The entered character is a vowel");
            else
                Console.WriteLine("The entered character is  a Consonant");
                Console.ReadLine();
        }
        

    }
}   
