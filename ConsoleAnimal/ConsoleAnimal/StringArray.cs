using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class StringArray
    {
        static void Main(string[] args)
        {
            String[] MyArray;
            MyArray = new string[5] { "Zebra", "Ant", "Owl", "Lion", "Dog" };

            Console.WriteLine("---For Loop---");

            for(int i=0; i<5; i++)
                Console.WriteLine(" " + MyArray[i]);


            Console.WriteLine("-----Foreach Loop-----");

            foreach(string x in MyArray)
            {
                Console.WriteLine(" " +x);
            }


            Console.WriteLine("------Do While Loop----");


            int k = 0;
            do
            {
                Console.WriteLine(" " + MyArray[k]);
                k++;
            } while (k < 5);

            Console.WriteLine("----While Loop----");

            int p = 0;
            while (p < 5)
            {
                Console.WriteLine(" " + MyArray[p]);
                p++;
            }

            Console.WriteLine("\nAfter being Sorted:");
            Array.Sort(MyArray);

            foreach (string a in MyArray)
            {
                Console.WriteLine(a);
                
            }

            Console.WriteLine("-----array of animal----");
            String[] animals;
            animals = new string[] { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            foreach(string s in animals)
            {
                Console.WriteLine(" " + s);
            }

            Console.WriteLine("\nAfter being Sorted:");
            Array.Sort(animals);

            foreach (string b in animals)
            {
                Console.WriteLine(b);

            }

            Console.WriteLine("-----array of places----");
            String[] places;
            places = new string[] { "Africa", "New Zealand", "Jamaica", "India" };
            foreach (string q in places)
            {
                Console.WriteLine(" " + q);
            }

            Console.WriteLine("\nAfter being Sorted:");
            Array.Sort(places);

            foreach (string c in places)
            {
                Console.WriteLine(c);

            }

        }
    }
}
