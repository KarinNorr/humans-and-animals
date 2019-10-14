using System;
using System.Collections.Generic;

namespace humans_and_animals
{

    class Program
    {
        public static int nrOfMeatLeft = 10;
        public static int nrOfVeggiesLeft = 10;
        static void Main(string[] args)
        {
            List<Djur> anmials = new List<Djur>();

            Seal minSeal = new Seal();
            minSeal.sort = "Säl";
            minSeal.namn = "Buster";
            minSeal.hungrig = 0;
            anmials.Add(minSeal);

            Elefant minElefant = new Elefant();
            minElefant.sort = "Elefant";
            minElefant.namn = "Hanna";
            minElefant.hungrig = 0;
            anmials.Add(minElefant);

            Bear minBear = new Bear();
            minBear.sort = "Björn";
            minBear.namn = "Gustav";
            minBear.hungrig = 0;
            anmials.Add(minBear);

            Giraff minGiraff = new Giraff();
            minGiraff.sort = "Giraff";
            minGiraff.namn = "Pricken";
            minGiraff.hungrig = 0;
            anmials.Add(minGiraff);

            Seal secondSeal = new Seal();
            secondSeal.sort = "Säl";
            secondSeal.namn = "Doris";
            secondSeal.hungrig = 0;
            anmials.Add(secondSeal);

            // Day loop
            
            int day = 0;
            bool thereIsFoodLeft = true;

            Console.WriteLine("Det här är djurparken. Följande djur bor här:");

            foreach (Djur djur in anmials)
                {
                    djur.printAnimal();
                }
            
            Console.ReadKey();

            while (thereIsFoodLeft)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");
                

                foreach (Djur djur in anmials)
                {
                    djur.raiseHungerLevel();
                   
                    djur.animalNeedsToEat();

                    if (nrOfMeatLeft ==0 && nrOfVeggiesLeft ==0)
                    {
                        Console.WriteLine("Maten är slut! Ni skulle väl köpa in mat!? Vad har ni egentligen gjort?!");
                        thereIsFoodLeft = false;
                    }

                }

                // LÄGG TILL DIN NYA KOD HÄR

                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}


