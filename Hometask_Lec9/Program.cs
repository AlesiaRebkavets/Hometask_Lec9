using Task1Lec9;
using Task2Lec9;

namespace Task3Lec9
{
    internal class Program
    {
        static void Main()
        {
            // ***** task 1 *****
            List<int> number = new List<int>(); // new list creation
            number = Task1.EnterListElement(); // entering list items
            int numSum = Task1.SumOfEvenNumbers(number); // finding sum of even numbers of the list

            Console.WriteLine("\nSumma chetnyh chisel ravna: " + numSum + "\n"); // output of sum of even numbers

            Task1.OutputOfListElements(number); // output of list elements

            List<string> people = new List<string>()
                { "Tom", "Bob", "Sam", "David", "James", "John", "Bill", "Kevin", "Walt" }; // new string list creation
            Task1.FiveLettersWordOutput(people); // output of words from from the list containing 5 symbols
            Task1.FindWordsOfACertainLength(
                people); // output of words from the list containing the entered number of symbols

            // ***** task 2 *****
                            // task 1
            LinkedList<int>
                numbers = new LinkedList<int>(new[]
                    { 2, 4, 3, 2, 8, 2, 5, 1, 2 }); // initialization of LinkedList for task 1
            int n1 = Task2.EnterElement(); // input of the first element
            int n2 = Task2.EnterElement(); // input of the second element
            Task2.AddElements(numbers, n1,
                n2); // adding element two after elements equal to the element one of LinkedList 'numbers'
            Task2.OutputOfListElements(numbers); // output of the result

                            // task 2
            LinkedList<int>
                list1 = new LinkedList<int>(new[]
                    { 1, 3, 4, 7, 12 }); // initialization of the first LinkedList for task 2
            LinkedList<int>
                list2 = new LinkedList<int>(new[] { 1, 5, 7, 9 }); // initialization of the second LinkedList for task 2
            LinkedList<int> list3 = new LinkedList<int>(); // initialization of empty LinkedList for task 2
            Task2.UniteTwoLists(list1, list2, list3); // uniting of two lists
            Task2.OutputOfListElements(list3); // output of the result

            // ***** task 3 *****
                                 // task 1
            Queue<int> numbers1 = new Queue<int>(); // initialization of queue
            numbers1 = Task3.AddElementsToQueue(); // adding elements to queue
            Console.WriteLine("Maksimalnoye chislo ocheredi: " +
                              Task3.GetMaxValue(numbers1)); // getting maximum number in queue
            numbers1.Dequeue(); // deleting the first element in queue
            numbers1.Dequeue(); // deleting the second (first after the previous deletion) element in queue
            Console.WriteLine("Maksimalnoye chislo ocheredi posle udaleniya: " +
                              Task3.GetMaxValue(numbers1)); // getting maximum number in queue
                                 // task 2
            Console.WriteLine(
                "\n***** task 2 *****\n"); // output of delimiter to make the result in console more readable
            Stack<char> letters = new Stack<char>(); // initialization of stack
            Task3.AddElementsToStac(letters); // adding elements to stack
            Console.WriteLine("Stack v obratnom poryadke: " +
                              Task3.OutputInReverseOrder(letters)); // output of stack on reverse order

            // ***** task 4 *****
                               // task 1
            Dictionary<string, int> person = new Dictionary<string, int>(); // initialization of dictionary
            person.Add("Alesia", 28); // adding value to dictionary
            person["Vasiliy"] = 29; // adding the second value to dictionary
            Console.WriteLine(person.ElementAt(0).Key + " " +
                              person.ElementAt(0).Value); // output of the first dictionary element
                               // task 2
            Console.WriteLine(
                "\n***** task 2 *****\n"); // output of delimiter to make the result in console more readable
            List<int> numbers2 = new List<int>() { 5, 7, 1, 8, 10, 9, 2, 3, 6, 4 }; // initialization of list elements
            List<string> names = new List<string>()
            {
                "Tom", "James", "Lily", "Severus", "Hermiona", "Ron", "Harry", "Nevil", "Dobbi", "Sirius"
            }; // initialization of list elements
            Dictionary<int, string> task2 = new Dictionary<int, string>(); // initialization of dictionary
            task2 = Task4.SortAndAddToDictionary(numbers2, names); // adding sorted list elements to dictionary
            Task4.OutputOfDictionaty(task2); // output of dictionary
                                // task 3
            Console.WriteLine(
                "\n***** task 3 *****"); // output of delimiter to make the result in console more readable

            Task4.City Katowice = new Task4.City(321000, 164.67); // initialization of objects of City type
            Task4.City Krakov = new Task4.City(779115, 327);
            Task4.City Wroclaw = new Task4.City(638659, 292.92);
            Task4.City Gdansk = new Task4.City(456967, 261.96);
            Task4.City Warsaw = new Task4.City(1860281, 517.2);

            Dictionary<string, Task4.City> task3 = new Dictionary<string, Task4.City>() // initialization of dictionary
            {
                ["Katowice"] = Katowice,
                ["Krakov"] = Krakov,
                ["Wroclaw"] = Wroclaw,
                ["Gdansk"] = Gdansk,
                ["Warsaw"] = Warsaw
            };

            Dictionary<string, Task4.City>
                ordered1 = task3.OrderBy(x => x.Value.area)
                    .ToDictionary(x => x.Key, x => x.Value); // sorting the dictionary by area
            Task4.OutputOfDictionatyWithObjects(ordered1,
                "Otsortirovannyi po ploschadi: "); // output of the sorted dictionary

            Dictionary<string, Task4.City> ordered2 = task3.OrderByDescending(x => x.Value.population)
                .ToDictionary(x => x.Key, x => x.Value); //sorting the dictionary by population in reverse order
            Task4.OutputOfDictionatyWithObjects(ordered2,
                "Otsortirovannyi po naseleniu v obratnom poryadke: "); // output of the sorted dictionary

            int populationOfAllCities = task3.Sum(x => x.Value.population); // total population of all cities
            Console.WriteLine("\nObschee naselenie vseh gorodov: " +
                              populationOfAllCities); // output of total population
        }
    }
}