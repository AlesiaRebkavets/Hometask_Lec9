namespace Task1Lec9
{
    public class Task1
    {
        public static int SumOfEvenNumbers(List<int> numbers) // method calculates the sum of list even numbers
        {
            var result = from n in numbers
                where (n % 2 == 0)
                select n;
            int sum = result.Sum();
            return sum;
        }

        public static List<int> EnterListElement()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Vvedite dlinu spiska i chisla"); // ask user to enter a list length and numbers
            try
            {
                
                int n = Convert.ToInt16(Console.ReadLine());    // user enters a list length, parsing the entered value into numeric variable  
                  
                for (int i = 0; i < n; i++)
                {
                    int a = Convert.ToInt16(Console.ReadLine());       // user enters numbers
                    numbers.Add(a);   // adding the numbers to the list
                }
            }
            catch
            {
                Console.WriteLine("Invalid input data. Number should be entered!");
            } 
            return numbers;
        }

        public static void OutputOfListElements(List<int> numbers)
        {
            Console.WriteLine($"Vvedennyje chisla: ");
            var result = from n in numbers
                select n;
            
            Console.WriteLine(string.Join(", ", result.ToArray()));
        }

        public static void
            FiveLettersWordOutput(
                List<string> words) // method returns string containing words from a list, containing 5 symbols
        {
            Console.WriteLine("\nWords containing five symbols: ");

            var result = from str in words
                where str.Length == 5
                select str;
            
            Console.WriteLine(string.Join(",", result.ToArray()));
        }
        public static void FindWordsOfACertainLength(List<string> words)
        {
            Console.WriteLine("\nVvedite dlinu slova"); // ask user to enter a number
            // bool isNumeric = int.TryParse(Console.ReadLine(), out int n); // user enters a number, parsing the entered value into numeric variable

            int n = 0;
            try
            {
                n = Convert.ToInt16(Console.ReadLine()); 
            }
            catch
            {
                Console.WriteLine("Invalid input data. Number should be entered!");
            }
            var result = from str in words
                where str.Length == n
                select str;
            if (!result.Any())
            {
                Console.WriteLine("Takih slov net.");
            }
            else
            {
                foreach (var name in result) // and output 'result' variable
                    Console.Write(name + " ");
                Console.WriteLine(" - imena soderzat " + n + " bukv(i)");
            }
        }
    }
}