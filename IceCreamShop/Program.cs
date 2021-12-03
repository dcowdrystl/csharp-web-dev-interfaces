using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;



            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            FlavorComparer comparer = new FlavorComparer();
            Console.WriteLine("------------Before comparing---------------");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }
            availableFlavors.Sort(comparer);
            Console.WriteLine("------------After comparing---------------");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            ConeComparer comparer2 = new ConeComparer();
            Console.WriteLine("------------Before comparing---------------");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            }
            availableCones.Sort(comparer2);
            Console.WriteLine("------------After comparing---------------");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            }
            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
