using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok03_Class07.Domain.Models
{
    public static class ListHelper
    {

        public static void CountOfCars<T> (List<T> list1,List<T> list2,List<T>list3)
        {
            Console.WriteLine($"US : {list1.Count} models.\nEU : {list2.Count} models.\nJPN : {list3.Count} models." );

        }

        public static void PrintModels<T>( List<T> list)
        {

            Console.WriteLine($"Printing {list.Count} items :");
            foreach (T item in list)
            {
                Console.WriteLine($" Model : {item}");

            }
        }

        public static void PrintInfo<T>( List<T> list) where T : Car
        {
            foreach(T i in list)
            {
                Console.WriteLine($"Model :{i.Model} ,miles per galon : {i.MilesPerGalon}, horsepower :{i.HorsePower}");
            }

        }
    }
}
