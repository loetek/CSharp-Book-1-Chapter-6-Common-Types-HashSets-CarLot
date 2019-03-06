using System;
using System.Collections.Generic;

namespace CarLot_HashedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashSet<string> Showroom = new HashSet<string>();
            HashSet<string> UsedLot = new HashSet<string>();
            HashSet<string> JunkYard = new HashSet<string>();




            Showroom.Add("Tesla Model X");
            Showroom.Add("Tesla Model X");
            Showroom.Add("Tesla Model X");
            Showroom.Add("Tesla Model X");
            Showroom.Add("Tesla Model 3");
            Showroom.Add("Tesla Model S");
            Showroom.Add("Tesla Model Truck");

            UsedLot.Add("Subaru Outback");
            UsedLot.Add("Subaru Forester");
            UsedLot.Add("Subaru Baja");

           // Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory.
            //In the new set, add some different cars, but also add a few that are the same as in the Showroom set.

            JunkYard.Add("Tesla Model X");
            JunkYard.Add("Subaru Baja");
            JunkYard.Add("Nissan Rogue");
            JunkYard.Add("Ford Fiesta");
            JunkYard.Add("Dodge Ram");
            JunkYard.Add("Cadillac Coupe Devile");

            //!!This will combine the UsedLot into the Showroom.
            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Tesla Model Truck");


             //!!Makes a copy of Showroom.
            HashSet<string> Clone = new HashSet<string>(Showroom);

            //!!Checks for similarities and only keeps the similar items in Clone.
            Clone.IntersectWith(JunkYard);

            Showroom.UnionWith(Clone);



            // foreach (string model in clone)
            // {
            //     foreach (string junk in JunkYard)
            //     {
            //         if(clone.IntersectWith(junk)){


            //         }



            //     }

            // }


            //!!Original showroom before unions.
                Console.WriteLine("ShowRoom");
                Console.WriteLine("<><><><><><><>");

            foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }
                Console.WriteLine("---------------");


                Console.WriteLine("JunkYard");
                Console.WriteLine("<><><><><><><>");

            //!!Original Junkyard before unions.
            foreach (string junk in JunkYard)
            {
                Console.WriteLine(junk);
            }
                Console.WriteLine("------------");

                Console.WriteLine("Clone");
                Console.WriteLine("<><><><><><><>");


            foreach (string clones in Clone)
            {
                Console.WriteLine(clones);
            }
                Console.WriteLine("------------");

            Showroom.UnionWith(Clone);

            Showroom.UnionWith(JunkYard);

            Console.WriteLine("ShowRoom2");
            Console.WriteLine("<><><><><><><>");
               //!! showroom after unions and clones.
            foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }
                Console.WriteLine("---------------");



        }
    }
}
