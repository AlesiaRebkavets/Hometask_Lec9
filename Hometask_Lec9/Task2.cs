using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Task2Lec9
{
    public class Task2
    {
        static void Main()
        {
            // task 1
            LinkedList<int> numbers = new LinkedList<int>(new[] { 2,4,3,2,8,2,5,1,2});  // initialization of LinkedList for task 1
            int n1 = EnterElement();                    // input of the first element
            int n2 = EnterElement();                    // input of the second element
            AddElements(numbers, n1, n2);               // adding element two after elements equal to the element one of LinkedList 'numbers'
            OutputOfListElements(numbers);              // output of the result

            // task 2
            LinkedList<int> list1 = new LinkedList<int>(new[] { 1,3,4,7,12 });          // initialization of the first LinkedList for task 2
            LinkedList<int> list2 = new LinkedList<int>(new[] { 1,5,7,9 });             // initialization of the second LinkedList for task 2
            LinkedList<int> list3 = new LinkedList<int>();                              // initialization of empty LinkedList for task 2
            UniteTwoLists(list1, list2, list3);                                // uniting of two lists
            OutputOfListElements(list3);                                       // output of the result

        }

        public static int EnterElement()
        {
            Console.WriteLine("Enter a number");
            bool isNumeric = int.TryParse(Console.ReadLine(), out int n);           // user enters a number, parsing the entered value into numeric variable

            if ((!isNumeric))                                           // if invalid number was entered error message is displayed  
            {
                Console.WriteLine("Invalid input data. Enter number again.");
                EnterElement();                                          // and recursion is used
            }
            return n;
        }

        public static void AddElements(LinkedList<int> numbers, int n1, int n2)
        {
            var currentNode = numbers.First;                  // making first element of list 'numbers' current node
            while (currentNode != null)                             // while list 'numbers' is not empty
            {
                if (currentNode.Value == n1)                        // if value of the selected list element is the same as the first entered number
                {
                    numbers.AddAfter(currentNode, n2);              // add the second entered number after the selected list element
                    currentNode = currentNode.Next;                 // and make the next element of list 'numbers' current node
                }
                currentNode = currentNode.Next;               // make the next element of list 'numbers' current node
            }
        }

        public static void OutputOfListElements(LinkedList<int> numbers)
        {
            var currentNode = numbers.First;                       // making first element of list 'numbers' current node
            while (currentNode != null)                            // while list 'numbers' is not empty
            {
                Console.Write(currentNode.Value + " ");                     // output the value of the current node
                currentNode = currentNode.Next;                             // make the next element of list 'numbers' current node
            }
            Console.WriteLine("\n");                                        // added two empty rows to the output to make the result in console more readable
        }

        public static void UniteTwoLists(LinkedList<int> list1, LinkedList<int> list2, LinkedList<int>list3)
        {
            var currentNodeL1 = list1.First;            // making first element of list1 current node
            var currentNodeL2 = list2.First;            // making first element of list2 current node
            while (currentNodeL1 != null)                                   // while list1 is not empty
            {
                while (currentNodeL2 != null)
                {                                                           // compare each element of list2 with the current element of list 1
                    if (currentNodeL1.Value == currentNodeL2.Value)         
                    {
                        list3.AddLast(currentNodeL2.Value);                 // and if their values are equal we add the number to list3
                    }
                    currentNodeL2 = currentNodeL2.Next;              // making next element of list2 current node
                }
                currentNodeL1 = currentNodeL1.Next;       // making next element of list1 current node
                currentNodeL2 = list2.First;              // making first element of list2 current node again
            }
        }
    }
}
