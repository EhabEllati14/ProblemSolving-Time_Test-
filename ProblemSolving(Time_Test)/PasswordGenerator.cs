using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Time_Test_
{
     class PasswordGenerator
    {
        
        Dictionary<char, char[]> maps = new Dictionary<char, char[]>() { 
            { 'A', "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray() } ,
             { 'a',  "abcdefghijklmnopqrstuvwxyz".ToCharArray() },
              { '#' ,"0123456789".ToCharArray() },
               { '*', "!@#$%^&*".ToCharArray() }
        };
      
        //case emoty string (pattern)
        //here because we have a huge number of the passwrod where we can generate so we used the limit 

        int limitNumberOfPasswords = 150;
        //here to trace how many opasswrod we have been print
        int printedCount = 0;
        public void GeneratePasswords(string pattern)
        {
            printedCount = 0; 
            Console.WriteLine($"\nGenerated passwords for pattern \"{pattern}\" (limit {limitNumberOfPasswords}):\n");

            GenerateRecursive(pattern, 0, "");
        }
        private void GenerateRecursive(string pattern, int index, string current)
        {
            if (printedCount >= limitNumberOfPasswords)
                return;

            if (index == pattern.Length)
            {
                Console.WriteLine(current);
                printedCount++;
                return;
            }

            foreach (char option in GetOptions(pattern[index]))
            {
                GenerateRecursive(pattern, index + 1, current + option);
            }
        }

        private char[] GetOptions(char symbol)
        {
            return maps.TryGetValue(symbol, out var chars)
                ? chars
                : new char[] { symbol };
        }
    }
}
