using System;
using System.Collections.Generic;

namespace humans_and_animals
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Djur> anmials = new List<Djur>();

            Elefant minElefant = new Elefant();
            minElefant.sort = "Elefant";
            minElefant.namn = "Karin";
            minElefant.hungrig = 0;
            anmials.Add(minElefant);

            Seal minSeal = new Seal();
            minSeal.sort = "Säl";
            minSeal.namn = "Penny";
            minSeal.hungrig = 0;
            anmials.Add(minSeal);

            Bear minBear = new Bear();
            minBear.sort = "Björn";
            minBear.namn = "Gustav";
            minBear.hungrig = 0;
            anmials.Add(minBear);

            Elefant majsElefant = new Elefant();
            majsElefant.sort = "Blå Elefant";
            majsElefant.namn = "Bumbo";
            majsElefant.hungrig = 0;
            anmials.Add(majsElefant);

            Bear minAndraBear = new Bear();
            minAndraBear.namn = "Bertil";
            minAndraBear.sort = "Björn";
            minAndraBear.hungrig = 0;
            anmials.Add(minAndraBear);

            Elefant tredjeElefanten = new Elefant();
            tredjeElefanten.namn = "Pluto";
            tredjeElefanten.sort = "Elefant";
            tredjeElefanten.hungrig = 0;
            anmials.Add(tredjeElefanten);
            tredjeElefanten.animalNeedsToEat();

            // Day loop
            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int day = 0;
            bool thereIsFoodLeft = true;

            Console.WriteLine("Det här är djurparken. Följande djur bor här:");

            foreach (Djur djur in anmials)
                {
                    djur.printAnimal();
                }

            while (thereIsFoodLeft)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                foreach (Djur djur in anmials)
                {
                    djur.raiseHungerLevel();
                   
                    djur.animalNeedsToEat();
                }
                

                // LÄGG TILL DIN NYA KOD HÄR

                // Wait for the next day
                Console.ReadKey();

                //Kollar om maten har tagit slut:
                // if (nrOfMeatLeft = 0)
                // {
                //     Console.WriteLine("Det är dag " + day + "och maten har nu tagit slut. SLUT");
                //     thereIsFoodLeft = false;
                //     Console.WriteLine("Programmet kommer nu att avsltas.");
                // }
            }
        }
    }
}


