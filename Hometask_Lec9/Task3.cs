using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Lec9
{
    public class Task3
    {
        //static void Main()
        //{
        //    // task 1
        //    Queue<int> numbers = new Queue<int>();              // initialization of queue
        //    AddElementsToQueue(numbers);                        // adding elements to queue
        //    Console.WriteLine("Maksimalnoye chislo ocheredi: " + GetMaxValue(numbers));  // getting maximum number in queue
        //    numbers.Dequeue();      // deleting the first element in queue
        //    numbers.Dequeue();      // deleting the second (first after the previous deletion) element in queue
        //    Console.WriteLine("Maksimalnoye chislo ocheredi posle udaleniya: " + GetMaxValue(numbers));  // getting maximum number in queue
        //    // task 2
        //    Console.WriteLine("\n***** task 2 *****\n");        // output of delimiter to make the result in console more readable
        //    Stack<char> letters = new Stack<char>();            // initialization of stack
        //    AddElementsToStac(letters);                         // adding elements to stack
        //    Console.WriteLine("Stack v obratnom poryadke: " + OutputInReverseOrder(letters));  // output of stack on reverse order
        //}

        private static int EnteringANumber()
        {
            bool isNumeric = int.TryParse(Console.ReadLine(), out int n);           // user enters a number, parsing the entered value into numeric variable

            if ((!isNumeric))                                           // if invalid number was entered error message is displayed  
            {
                Console.WriteLine("Nevernye dannye. Vvedite chislo snova");
                n = EnteringANumber();                                          // and recursion is used
            }
            return n;
        }

        public static void AddElementsToQueue(Queue<int> numbers)
        {
            Console.WriteLine("Vvedite kolichetvo elementov ocheredi");    // entering the number of elements in Queue
            int queueElementsNumber = EnteringANumber();                       // using 'EnteringANumber()' method
            Console.WriteLine("Vvedite elementy ocheredi");
            for (int i = 1; i <= queueElementsNumber; i++)                 // entering numbers to Queue in cycle
            {
                numbers.Enqueue(EnteringANumber());                            // using 'EnteringANumber()' method to add elements
            }
        }

        public static int GetMaxValue(Queue<int> numbers)
        {
            int max = numbers.Dequeue();  // the initial value of MAX variable shoud be the first number from queue; the number is deleted from the queue
            numbers.Enqueue(max);  // and added to the end of the queue                
            for (int i = 0; i < numbers.Count - 1; i++)          // deleting an element from Queue and adding it again to the same queue in cycle
            {
                int a = numbers.Dequeue();                       // saving value of the deleted element
                numbers.Enqueue(a);                              // adding the deleted element to the queue again
                if (a > max) { max = a; }                        // if the deleted number > max, we have a new max value
            }
            return max;
        }

        private static char EnteringCharValue()
        {
            bool isChar = char.TryParse(Console.ReadLine(), out char n);           // user enters a symbol, parsing the entered value into char variable

            if ((!isChar))                                           // if invalid data was entered error message is displayed  
            {
                Console.WriteLine("Nevernye dannye. Vvedite simvol snova");
                n = EnteringCharValue();                                          // and recursion is used
            }
            return n;
        }

        public static void AddElementsToStac(Stack<char> letters)
        {
            Console.WriteLine("Vvedite 3 bukvi");
            for (int i = 1; i <= 3; i++)                               // entering symbles to stack in cycle
            {
                letters.Push(EnteringCharValue());                       // using 'EnteringCharValue()' method to add elements
            }
        }

        public static string OutputInReverseOrder(Stack<char> letters)
        {
            string s = "";
            for (int i = 0; i < 3; i++)               // deleting the last one added element from stack and adding it's value to a string variable 's' in cycle
            {
                s += letters.Pop() + " ";
            }
            return s;
        }
    }
}