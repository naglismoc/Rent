using System;
using System.Collections.Generic;
using System.Text;

namespace Rent
{
    class ReceptionControl
    {

        public static void printRooms(List<Rentable> rentables)
        {
            foreach (var rentable in rentables)
            {
                Console.WriteLine(rentable.ToString());
            }
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
