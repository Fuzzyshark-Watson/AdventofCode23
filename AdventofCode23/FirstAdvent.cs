using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode23
{
    internal class FirstAdvent
    {
        public static void ProcessTextDocument(string filePath)
        {
            // Read all lines from the text document
            string[] lines = File.ReadAllLines(filePath);
            int total = 0;

            // Process each line in the dataset
            foreach (string line in lines)
            {
                // Extract all numbers from the line into an array
                int[] numbers = ExtractNumbers(line);

                // Concatenate the first and last digits of each number and add them together
                int result = CalculateResult(numbers);

                
                total += result;

                // Display the results
                Console.WriteLine($"Line: {line} | Result: {result} | Total: {total}");
            }
        }

        private static int[] ExtractNumbers(string text)
        {
            // Use LINQ to extract all numbers from the text
            var numbers = text.Where(char.IsDigit).Select(c => int.Parse(c.ToString())).ToArray();
            return numbers;
        }

        private static int CalculateResult(int[] numbers)
        {
            // Concatenate the first and last digits of each number and add them together
            int result = 0;

            // Concatenate the first and last digits
            string firstDigit = numbers[0].ToString();
            string lastDigit = numbers[numbers.Length - 1].ToString();

            string finalNumber = firstDigit + lastDigit;
            // Add the concatenated value to the result
            result = int.Parse($"{finalNumber}");

            return result;
        }
        public static void ProcessTextDocumentPartTwo(string filePath)
        {
            // Read all lines from the text document
            string[] lines = File.ReadAllLines(filePath);
            int total = 0;

            // Process each line in the dataset
            foreach (string line in lines)
            {
                // Extract all numbers from the line into an array
                int[] numbers = ExtractNumbersPartTwo(line);

                // Concatenate the first and last digits of each number and add them together
                int result = CalculateResultPartTwo(numbers);


                total += result;

                // Display the results
                Console.WriteLine($"Line: {line} | Result: {result} | Total: {total}");
            }
        }

        private static int[] ExtractNumbersPartTwo(string text)
        {
            // Use LINQ to extract all numbers from the text
            List<string> numbers = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    numbers.Add(text[i].ToString());
                }
                else if (i + 2 < text.Length && text[i].ToString() == "o" && text[i + 1].ToString() == "n" && text[i + 2].ToString() == "e")
                {
                    numbers.Add("1");
                    i += 1;
                }
                else if (i + 2 < text.Length && text[i].ToString() == "t" && text[i + 1].ToString() == "w" && text[i + 2].ToString() == "o")
                {
                    numbers.Add("2");
                    i += 1;
                }
                else if (i + 4 < text.Length && text[i].ToString() == "t" && text[i + 1].ToString() == "h" && text[i + 2].ToString() == "r" && text[i + 3].ToString() == "e" && text[i + 4].ToString() == "e")
                {
                    numbers.Add("3");
                    i += 3;
                }
                else if (i + 3 < text.Length && text[i].ToString() == "f" && text[i + 1].ToString() == "o" && text[i + 2].ToString() == "u" && text[i + 3].ToString() == "r")
                {
                    numbers.Add("4");
                    i += 2;
                }
                else if (i + 3 < text.Length && text[i].ToString() == "f" && text[i + 1].ToString() == "i" && text[i + 2].ToString() == "v" && text[i + 3].ToString() == "e")
                {
                    numbers.Add("5");
                    i += 2;
                }
                else if (i + 2 < text.Length && text[i].ToString() == "s" && text[i + 1].ToString() == "i" && text[i + 2].ToString() == "x")
                {
                    numbers.Add("6");
                    i += 1;
                }
                else if (i + 4 < text.Length && text[i].ToString() == "s" && text[i + 1].ToString() == "e" && text[i + 2].ToString() == "v" && text[i + 3].ToString() == "e" && text[i + 4].ToString() == "n")
                {
                    numbers.Add("7");
                    i += 3;
                }
                else if (i + 4 < text.Length && text[i].ToString() == "e" && text[i + 1].ToString() == "i" && text[i + 2].ToString() == "g" && text[i + 3].ToString() == "h" && text[i + 4].ToString() == "t")
                {
                    numbers.Add("8");
                    i += 3;
                }
                else if (i + 3 < text.Length && text[i].ToString() == "n" && text[i + 1].ToString() == "i" && text[i + 2].ToString() == "n" && text[i + 3].ToString() == "e")
                {
                    numbers.Add("9");
                    i += 2;
                }
            }

            int[] intNumbers = numbers.Select(int.Parse).ToArray();
            return intNumbers;
        }


        private static int CalculateResultPartTwo(int[] numbers)
        {
            // Concatenate the first and last digits of each number and add them together
            int result = 0;
            string finalNumber ="";
            // Concatenate the first and last digits
            string firstDigit = numbers[0].ToString();
            string lastDigit = numbers[numbers.Length - 1].ToString();

            finalNumber = firstDigit + lastDigit;

            // Add the concatenated value to the result
            result = int.Parse($"{finalNumber}");

            return result;
        }
    }
}
