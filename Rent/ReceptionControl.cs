using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rent
{
    class ReceptionControl
    {

        public static void printRentables(List<Rentable> rentables)
        {
            Console.WriteLine("");
            foreach (var rentable in rentables)
            {
                Console.WriteLine(rentable.ToString());
            }
            Console.WriteLine("");
        }
        public static void printRentablesAvailable(List<Rentable> rentables)
        {
            //List<Rentable> filtered = rentables.Where(r => r.Available == true).ToList();
            //printRentables(filtered);
            printRentables( rentables.Where(r => r.Available == true).ToList() );
        }

        public static void Reserve(List<Rentable> rentables)
        {
            Console.WriteLine("pasirinkite kambari");
            string num = Console.ReadLine();
            rentables.Where(r => r.Available == true).Where(r => r.Number == num).First().Available = false;
            Console.WriteLine(num + "Rentable rezervuotas");
        }
        public static void printFloorRentables(List<Rentable> rentables,int num)
        {
            printRentables( rentables.Where(r => r.Floor == num).ToList());
        }
        public static void printFloorRentablesAvailable(List<Rentable> rentables, int num)
        {
            printRentablesAvailable(rentables.Where(r => r.Floor == num).ToList());

        }

    }
}
