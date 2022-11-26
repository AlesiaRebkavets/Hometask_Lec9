using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Task1Lec9
{
    public class Task1
    {
        //static void Main()
        //{
        //    List<int> number = new List<int>();                                            // new list creation
        //    EnterListElement(number);                                                      // entering list items
        //    int numSum = SumOfEvenNumbers(number);                                         // finding sum of even numbers of the list

        //    Console.WriteLine("\nSumma chetnyh chisel ravna: " + numSum + "\n");           // output of sum of even numbers

        //    Console.WriteLine($"Vvedennyje chisla: {OutputOfListElements(number)}\n");                        // output of list elements
      
        //    List<string> people = new List<string>() { "Tom", "Bob", "Sam", "David", "James", "John", "Bill", "Kevin", "Walt" };  // new string list creation
        //    Console.WriteLine("\n\nWords containing five symbols: " + FiveLettersWordOutput(people));  // output of words from from the list containing 5 symbols
        //    FindWordsOfACertainLength(people);                                                         // output of words from the list containing the entered number of symbols
        //}

        public static int SumOfEvenNumbers(List<int> numbers)       // method calculates the sum of list even numbers
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)                            // if number is divided by two without a remainder, add it to the general sum
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        private static List<int> EnterListElement(List<int> numbers)
        {
            Console.WriteLine("Vvedite dlinu spiska");                              // ask user to enter a list length
            bool isNumeric = int.TryParse(Console.ReadLine(), out int n);           // user enters a number, parsing the entered value into numeric variable

            if ((!isNumeric) || (n == 0))                                           // if invalid number was entered error message is displayed  
            {
                Console.WriteLine("Invalid input data");
                EnterListElement(numbers);                                          // and recursion is used
            }
            else                                                                    // if correct data was entered
            {
                Console.WriteLine("Vvedite chisla");                                // ask user to enter numbers
                for (int i = 0; i < n; i++)
                {
                    isNumeric = int.TryParse(Console.ReadLine(), out int a);        // user enters a number, parsing the entered value into numeric variable
                    if (!isNumeric)
                    {                                                              // checking that a number was entered
                        Console.WriteLine("Invalid input data. Vvedite chislo eschio ras");   // display error message if invalid data was enered
                        i--;                                                                  // decrement i by one to enter the number again
                    }
                    else
                    {
                        numbers.Add(a);                                             // if valid number was enterd, add it to the list
                    }
                }
            }
            return numbers;
        }

        public static string OutputOfListElements(List<int> numbers)
        {
            string str = "";

            foreach (var num in numbers)                                                    // output of list elements
            {
                str += num + "  ";
            }
            return str;
        }

        public static string FiveLettersWordOutput(List<string> words)          // method returns string containing words from a list, containing 5 symbols
        {
            string str = "";

            foreach (string singleWord in words)                                     
            {
                if (singleWord.Length == 5) { str += singleWord + " "; }         // if the word consists of 5 symbols, add it to the string
            }
            return str;
        }

        public static void FindWordsOfACertainLength(List<string> words)
        {
            Console.WriteLine("\nVvedite dlinu slova");                              // ask user to enter a number
            bool isNumeric = int.TryParse(Console.ReadLine(), out int n);          // user enters a number, parsing the entered value into numeric variable

            if ((!isNumeric) || (n == 0))                                          // if invalid number was entered error message is displayed 
            {
                Console.WriteLine("Invalid input data");
                FindWordsOfACertainLength(words);                                  // and recursion is used
            }
            else 
            {
     
                bool ifPresent = words.Any(s => s.Length == n);                         // determing if words of the entered lenght exist in collection
                if (ifPresent)
                {
                    var result = words.Where(s => s.Length == n);                       // if they exist, we find them and save in 'result' variable

                    foreach (var name in result)                                        // and output 'result' variable
                        Console.Write(name + " ");
                    Console.WriteLine(" - imena soderzat " + n + " bukv(i)");
                }
                else                                                                    // if words of such length do not exist, display the error message
                {
                    Console.WriteLine("Takih slov net.");
                }
            }
        }

    }
}