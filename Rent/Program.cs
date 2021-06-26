using System;
using System.Collections.Generic;
using System.Linq;

namespace Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rentable> maziNamukai = new List<Rentable>();


            Rentable house0 = new Rentable(4, true, true, 1, "101", 60);
            Rentable house1 = new Rentable(4, true, true, 1, "102", 60);
            Rentable house2 = new Rentable(4, true, true, 1, "103", 60);
            Rentable house3 = new Rentable(4, true, true, 1, "104", 60);
            Rentable house4 = new Rentable(4, true, true, 1, "105", 60);
            Rentable house5 = new Rentable(4, true, true, 1, "106", 60);
            maziNamukai.Add(house0);
            maziNamukai.Add(house2);
            maziNamukai.Add(house3);
            maziNamukai.Add(house4);
            maziNamukai.Add(house5);


            Rentable room0 = new Rentable();
            Rentable room1 = new Rentable(1, true, false, 2, "21", 40);
            Rentable room2 = new Rentable(2, true, true, 1, "11", 35);
            Rentable room3 = new Rentable(3, false, false, 2, "22", 40);
            Rentable room4 = new Rentable(1, false, true, 2, "23", 40);
            Rentable room5 = new Rentable(2, true, true, 1, "12", 35);
            Rentable room6 = new Rentable(3, true, false, 1, "13", 35);
            Rentable room7 = new Rentable(1, false, true, 1, "14", 35);
            Rentable room8 = new Rentable(2, false, false, 2, "24", 40);
            Rentable room9 = new Rentable(3, false, true, 2, "25", 40);


            List<Rentable> hotel = new List<Rentable>();
            hotel.Add(room0);
            hotel.Add(room1);
            hotel.Add(room2);
            hotel.Add(room3);
            hotel.Add(room4);
            hotel.Add(room5);
            hotel.Add(room6);
            hotel.Add(room7);
            hotel.Add(room8);
            hotel.Add(room9);



            //foreach (var room in hotelAvailable)
            //{
            //    Console.WriteLine(room.ToString());
            //}


            /* Rentable
             * Available
             * beds
             * kitchen
             * shower
             * floor
             * name
             * price 
             * */
            while (true)
            {
                Console.WriteLine("ka norite daryti? x simbolizuoja skaičių");
                Console.WriteLine("1- pamatyti visus kambarius");
                Console.WriteLine("1l- pamatyti laisvus kambarius");
                Console.WriteLine("2 - pamatyti visus namelius");
                Console.WriteLine("2l - pamatyti laisvus namelius");
                Console.WriteLine("3-x - pamatyti visus kambarius x aukste");
                Console.WriteLine("3l-x - pamatyti laisvus kambarius x aukste");
                Console.WriteLine("rn- rezervuoti namelį");
                Console.WriteLine("rk- rezervuoti kambarį");
                Console.WriteLine("x- rezervuojamo objekto nr");

                string input = Console.ReadLine();
                int num = 0;
                if (input.Contains("3-"))
                {
                    num = int.Parse(input.Substring(2));
                    input = "3";
                }
                if (input.Contains("3l-"))
                {
                    num = int.Parse(input.Substring(3));
                    input = "3l";
                }

                switch (input)
                {
                    case "1":
                        ReceptionControl.printRooms(hotel);
                        break;
                    case "1l":
                        // code block
                        break;
                    case "2":
                        ReceptionControl.printRooms(maziNamukai);
                        break;
                    case "2l":
                        // code block
                        break;
                    case "3":
                        Console.WriteLine("3 + " + num);
                        break;
                    case "3l":
                        Console.WriteLine("3l + "+num);
                        break;
                    case "rn":
                        ReceptionControl.Reserve(maziNamukai);
                        break;
                    case "rk":
                        ReceptionControl.Reserve(hotel);
                        break;
                    case "x":
                        // code block
                        break;
                    default:
                        Console.WriteLine("iveskite teisingus duomenis");
                        break;
                }

            }
        }

      
    }
}
