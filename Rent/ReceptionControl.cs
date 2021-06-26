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
            foreach (var rentable in rentables)
            {
                Console.WriteLine(rentable.ToString());
            }
        }
        public static void printRentablesAvailable(List<Rentable> rentables)
        {
            //List<Rentable> filtered = rentables.Where(r => r.Available == true).ToList();
            //printRentables(filtered);
            printRentables(rentables.Where(r => r.Available == true).ToList());
        }

        public static void Reserve(List<Rentable> rentables)
        {
            Console.WriteLine("pasirinkite kambari");
            string num = Console.ReadLine();
            foreach (var rentable in rentables)
            {

                //rasti pagal numeri ka rezervuoti ir pakeisti available
                Console.WriteLine(rentable.ToString());
            }
        }

        
    }
}
