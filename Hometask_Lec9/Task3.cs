namespace Task3Lec9
{
    public class Task3
    {
        private static int EnteringANumber()
        {
            bool isNumeric =
                int.TryParse(Console.ReadLine(),
                    out int n); // user enters a number, parsing the entered value into numeric variable

            if ((!isNumeric)) // if invalid number was entered error message is displayed  
            {
                Console.WriteLine("Nevernye dannye. Vvedite chislo snova");
                n = EnteringANumber(); // and recursion is used
            }

            return n;
        }

        public static Queue<int> AddElementsToQueue()
        {
            Queue<int> numbers = new Queue<int>();
            Console.WriteLine("Vvedite kolichetvo elementov ocheredi"); // entering the number of elements in Queue
            int queueElementsNumber = EnteringANumber(); // using 'EnteringANumber()' method
            Console.WriteLine("Vvedite elementy ocheredi");
            for (int i = 1; i <= queueElementsNumber; i++) // entering numbers to Queue in cycle
            {
                numbers.Enqueue(EnteringANumber()); // using 'EnteringANumber()' method to add elements
            }

            return numbers;
        }

        public static int GetMaxValue(Queue<int> numbers)
        {
            int
                max = numbers
                    .Dequeue(); // the initial value of MAX variable shoud be the first number from queue; the number is deleted from the queue
            numbers.Enqueue(max); // and added to the end of the queue                
            for (int i = 0;
                 i < numbers.Count - 1;
                 i++) // deleting an element from Queue and adding it again to the same queue in cycle
            {
                int a = numbers.Dequeue(); // saving value of the deleted element
                numbers.Enqueue(a); // adding the deleted element to the queue again
                if (a > max)
                {
                    max = a;
                } // if the deleted number > max, we have a new max value
            }

            return max;
        }

        private static char EnteringCharValue()
        {
            bool isChar =
                char.TryParse(Console.ReadLine(),
                    out char n); // user enters a symbol, parsing the entered value into char variable

            if ((!isChar)) // if invalid data was entered error message is displayed  
            {
                Console.WriteLine("Nevernye dannye. Vvedite simvol snova");
                n = EnteringCharValue(); // and recursion is used
            }

            return n;
        }

        public static void AddElementsToStac(Stack<char> letters)
        {
            Console.WriteLine("Vvedite 3 bukvi");
            for (int i = 1; i <= 3; i++) // entering symbles to stack in cycle
            {
                letters.Push(EnteringCharValue()); // using 'EnteringCharValue()' method to add elements
            }
        }

        public static string OutputInReverseOrder(Stack<char> letters)
        {
            string s = "";
            for (int i = 0;
                 i < 3;
                 i++) // deleting the last one added element from stack and adding it's value to a string variable 's' in cycle
            {
                s += letters.Pop() + " ";
            }

            return s;
        }
    }
}