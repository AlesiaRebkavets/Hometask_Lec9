using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3Lec9
{
    public class Task4
    {
        static void Main()
        {
            // task 1
            Dictionary<string, int> person = new Dictionary<string, int>();  // initialization of dictionary
            person.Add("Alesia", 28);   // adding value to dictionary
            person["Vasiliy"] = 29;     // adding the second value to dictionary
            Console.WriteLine(person.ElementAt(0).Key + " " + person.ElementAt(0).Value);  // output of the first dictionary element
            // task 2
            Console.WriteLine("\n***** task 2 *****\n");                    // output of delimiter to make the result in console more readable
            List<int> numbers = new List<int>() { 5,7,1,8,10,9,2,3,6,4 };   // initialization of list elements
            List<string> names = new List<string>() {"Tom", "James", "Lily", "Severus", "Hermiona", "Ron", "Harry", "Nevil", "Dobbi", "Sirius"};  // initialization of list elements
            Dictionary<int, string> task2 = new Dictionary<int, string>();  // initialization of dictionary
            task2 = SortAndAddToDictionary(numbers, names);   // adding sorted list elements to dictionary
            OutputOfDictionaty(task2);     // output of dictionary
            // task 3
            Console.WriteLine("\n***** task 3 *****");                      // output of delimiter to make the result in console more readable

            City Katowice = new(321000, 164.67);           // initialization of objects of City type
            City Krakov = new City(779115, 327);
            City Wroclaw = new City(638659, 292.92);
            City Gdansk = new City(456967, 261.96);
            City Warsaw = new City(1860281, 517.2);

            Dictionary<string, City> task3 = new Dictionary<string, City>()   // initialization of dictionary
            {
                ["Katowice"] = Katowice,
                ["Krakov"] = Krakov,
                ["Wroclaw"] = Wroclaw,
                ["Gdansk"] = Gdansk,
                ["Warsaw"] = Warsaw
            };

            Dictionary<string, City> ordered1 = task3.OrderBy(x => x.Value.area).ToDictionary(x => x.Key, x => x.Value); // sorting the dictionary by area
            OutputOfDictionatyWithObjects(ordered1, "Otsortirovannyi po ploschadi: ");               // output of the sorted dictionary

            Dictionary<string, City> ordered2 = task3.OrderByDescending(x => x.Value.population).ToDictionary(x => x.Key, x => x.Value);  //sorting the dictionary by population in reverse order
            OutputOfDictionatyWithObjects(ordered2, "Otsortirovannyi po naseleniu v obratnom poryadke: ");  // output of the sorted dictionary

            int populationOfAllCities = task3.Sum(x => x.Value.population);       // total population of all cities
            Console.WriteLine("\nObschee naselenie vseh gorodov: " + populationOfAllCities);  // output of total population
        }   
         
        private static Dictionary<int, string> SortAndAddToDictionary(List<int> numbers, List<string> names)
        {
            numbers.Sort();      // sort the list elements in ascending order
            names.Sort();        // sort the list elements in ascending order
            names.Reverse();     // reverse the list elements
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)                        // adding 10 elements of the lists to dictionary
            {
                dictionary.Add(numbers[i], names[i]);
            }
            return dictionary;
        }
        private static void OutputOfDictionaty(Dictionary<int, string> dictionary)  // output of dictionary with int key and value of string type
        {
            foreach (var d in dictionary)        // for all key-values in dictionary
            {
                Console.WriteLine($"key: {d.Key}  value: {d.Value}");   // output key and value of the dictionary 
            }
        }

        private static void OutputOfDictionatyWithObjects(Dictionary<string, City> dictionary, string outputText)  // output of dictionary with string key and value of City type
        {
            Console.WriteLine("\n" + outputText);         // output text related to the task to make the result more readable
            foreach (var d in dictionary)                 // for all key-values in dictionary
            {
                Console.WriteLine($"key: {d.Key};   population: {d.Value.GetCityPopulation()};   area: {d.Value.GetCityArea()}");  // output key of the dictionary 
            }                                                // and value (fields of an object of City type) using 'GetCityPopulation()' and 'GetCityArea()' methods
        }
    }

    public class City
    {
        public int population;         // initialization of fields of class City
        public double area;

        public City(int population, double area)   // constructor of class City
        {
            this.population = population;
            this.area = area;
        }

        public int GetCityPopulation()     // getting value of "population" parameter
        {
            return this.population;
        }

        public double GetCityArea()       // getting value of "area" parameter
        {
            return this.area;
        }
    }
}
