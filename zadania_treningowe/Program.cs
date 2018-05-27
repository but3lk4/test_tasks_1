using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania_treningowe
{
    class Program
    {

        // Jakub Haładus
        // nr albumu: 10541
        // inf2a



        static void Main(string[] args)
        {
            int[] a = new int[8] { 10, 12, 9, 0, 35, 28, 15, 7 };
            Console.WriteLine("Największy element tablicy to: " + getMaxValue(a));
            Console.WriteLine("Największy parzysty element tablicy to: " + getMaxValueUnderParityIndex(a));
            Console.WriteLine("Indeks z największą wartością znaduje się w: " + whereIsMaxValue(a));
            Console.WriteLine("Wartość max wynosi: " + getValue(a, true));
            Console.WriteLine("Wartość min wynosi: " + getValue(a, false));
            Console.WriteLine("Suma wartości elementów w tablicy wynosi: " + getSumOfValues(a));
            // Console.WriteLine("Rotacja cykliczna: " + rotateTable(a));
            //  Console.WriteLine("Elementy tablicy podzielne przez 3, w które wstawiane jest zero: "  insertZeros(a));
            string palindrom = "KAJAK";
            Console.WriteLine(Palindrome(palindrom));
            string noPalindrom = "CHLEB";
            Console.WriteLine(Palindrome(noPalindrom));
            string inToCapitalLetter = "zmienilies mnie na duze";
            Console.WriteLine(inToCapitalLetter);
            Console.WriteLine("zamien mnie na duze");
            Console.WriteLine(toUpper(inToCapitalLetter));
            string to_lower = "AbCdeFGhIjklMnOpRST";
            Console.WriteLine(to_lower);
            Console.WriteLine(toLower(to_lower));
            Console.WriteLine("2 ^ 5");
            Console.WriteLine(powerOfTwo(5));
            Console.WriteLine(makeMulti(true, false));





        }


        // zadanie 1.1

        static int getMaxValue(int[] table)
        {

            int max = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > max)
                    max = table[i];
            }
            return max;

        }

        // zadania 1.2

        static int getMaxValueUnderParityIndex(int[] table)
        {
            int parity = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                if (i % 2 == 1 && table[i] > parity)
                    parity = table[i];
            }
            return parity;
        }

        // zadanie 1.3

        static int whereIsMaxValue(int[] table)
        {
            int maxValue = table[0];
            int index = 0;

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > maxValue)
                {
                    maxValue = table[i];
                    index = i;
                }
            }

            return index;

        }

        // zadanie 1.4

        static int getValue(int[] table, bool min_or_max)
        {

            int minMax = table[0];

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > minMax && min_or_max == true)
                    minMax = table[i];
                if (table[i] < minMax && min_or_max == false)
                    minMax = table[i];
            }


            return minMax;
        }

        // zadanie 1.5

        static int getSumOfValues(int[] table)
        {
            int sum = table[0];

            for (int i = 0; i < table.Length; i++)
            {
                sum += table[i];
            }
            return sum;


        }


        // zadanie 1.6

        /*static int rotateTable(int[] table)
        {
          
            int [] newTable = new int[table.Length];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = newTable[i];
            }
            for (int i = 0; i < table.Length; i++)
            {
               if( i == table.Length - 1)
                
                    table[0] = newTable[i];
                    else
                    table[i + 1] = newTable[i];
                }
                return table;
            }
            */

        // zadanie 1.7


        // Zadanie 1.12
        static void insertZeros(int[] table)
        {
           
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i] % 3 == 0)
                        table[i] = 0;
                                
                }
            
            }


        // Zadanie 2.1
        static bool Palindrome(string text)
        {
            bool Palindrome = false;
            for (int i = 0; i < text.Length; i++)
            {
              
                if (text[i] == text[text.Length - 1 - i])
                    Palindrome = true;
                else
                    Palindrome = false;
            }
            return Palindrome;
        }

        // zadanie 2.4
        static string toUpper(string text)
        {
            
            string[] splitString = text.Split(' ');
            string newString = "";
            foreach (string word in splitString)
            {
               
                newString+= word.First().ToString().ToUpper() + String.Join("", word.Skip(1)) + (" ");
            }
            return newString;
        }
        // Zadanie 2.14
        static string toLower(string text)
        {
            
            string newText = text.ToLower();
            return newText;
        }
        // zadanie 3.1
        static long powerOfTwo(int exp)
        {
            int power = 1;
            if (exp == 0)
                return 1;
            for (int i = 0; i < exp; i++)
            {
                power *= 2;
            }
            return power;
        }

        

        // Zadanie 3.4
        static int makeMulti(bool val1, bool val2)
        {
            bool multi;
            multi = val1 & val2;
            return Convert.ToInt32(multi);
        }

    }


}






