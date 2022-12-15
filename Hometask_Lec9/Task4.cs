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
        public static Dictionary<int, string> SortAndAddToDictionary(List<int> numbers, List<string> names)
        {
            numbers.Sort(); // sort the list elements in ascending order
            names = names.OrderByDescending(x => x).ToList();  // adding 10 elements of the lists to dictionary
            
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)                                            
            {
                dictionary.Add(numbers[i], names[i]);
            }

            return dictionary;
        }

        public static void OutputOfDictionaty(Dictionary<int, string> dictionary) // output of dictionary with int key and value of string type
        {
            dictionary.AsParallel().ForAll(kv =>
            {
                Console.WriteLine($"key: {kv.Key};   value: {kv.Value}");   // output of dictionary 
            });
        }
        
        public static void OutputOfDictionatyWithObjects(Dictionary<string, City> dictionary,
                string outputText) // output of dictionary with string key and value of City type
        {
            Console.WriteLine("\n" + outputText); // output text related to the task to make the result more readable
            dictionary.AsParallel().ForAll(kv =>
            {
                Console.WriteLine($"key: {kv.Key};   population: {kv.Value.GetCityPopulation()}");   // output of dictionary 
            });
        }

        public class City
        {
            public int population; // initialization of fields of class City
            public double area;

            public City(int population, double area) // constructor of class City
            {
                this.population = population;
                this.area = area;
            }

            public int GetCityPopulation() // getting value of "population" parameter
            {
                return this.population;
            }

            public double GetCityArea() // getting value of "area" parameter
            {
                return this.area;
            }
        }
    }
}
