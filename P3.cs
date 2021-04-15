using System;
using System.IO;

namespace P3UI
{
    class Program
    {
        /// <summary>
        /// Method to parse through the files in the int and enter them in array.
        /// </summary>
        static int[] ParseNumberFile(string filename)
    {
        string fileContent = File.ReadAllText(filename);

        string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int[] integers = new int[integerStrings.Length];

        for (int n = 0; n < integerStrings.Length; n++)
            integers[n] = int.Parse(integerStrings[n]);

        return integers;
    }
        static void Main(string[] args)
        {
            //C:\Users\adeeb\Documents\intFile.txt -> test file
            Console.WriteLine("Enter file path:");
            string filePath = Console.ReadLine();
            //Console.WriteLine(filePath); -> test to confirm file was entered properly
            
            int[] numbers = ParseNumberFile(filePath);
            
            //Loop to iterate through array and store values
            for(int i=0;i<numbers.Length;i++)
            {

            //store array value at i
            int val=numbers[i];

            //variable for prime factor math
            int b;

            //variable to keep track of product
            int c=1;

            //for loop to calculate all prime factors
            for (b = 2; val > 1; b++)
            {
                if (val % b == 0)
            {
                int x = 0;
                while (val % b == 0)
                {
                    val /= b;
                    x++;
                }
                //for loop to keep track of multiplication
                for(int j=0;j<x;j++){
                    c = b*c;
                    Console.Write("{0}, ",b);
                }//for loop to get the number
            }//if
            }//for
 
            Console.Write("\n"); //go to next line
            }//for array
            Console.WriteLine("This is the list of numbers in the file: ");
            Console.WriteLine(string.Join(",\n", numbers));
        }
    }
}
