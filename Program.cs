using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    //superklass för djur

    class Djur
    {
        public string sort;
        public string namn;
        public int hungrig;

        public virtual void printAnimal()
        {
            Console.WriteLine();
        }
    }

    //subklass för elefant 
    class Elefant : Djur
    {
        protected string mat = "blad";
        public string Mat { get { return mat; } }
        public override void printAnimal()
        {
            Console.WriteLine("Jag är en " + sort + " som heter " + namn + " och äter " + mat);
        }
    }

    class Giraff : Djur
    {
        //Du behöver skriva en metod för varje djur som gör följande:
        //* Ökar hungernivån
        //* Kollar om djuret behöver äta eller inte
        //* Konsumerar mat och återställer hungernivån
        protected string mat = "blad";
        public string Mat { get { return mat; } }
        public override void printAnimal()
        {
            Console.WriteLine("Jag är en " + sort + " som heter " + namn + " och äter " + mat);
        }
    }
    class Seal : Djur
    {
        protected string mat = "kött";
        public string Mat { get { return mat; } }
        public override void printAnimal()
        {
            Console.WriteLine("Jag är en " + sort + " som heter " + namn + " och äter " + mat);
        }
    }
    class Bear : Djur
    {
        protected string mat = "kött";
        public string Mat { get { return mat; } }
        public override void printAnimal()
        {
            Console.WriteLine("Jag är en " + sort + " som heter " + namn + " och äter " + mat);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Djur> anmials = new List<Djur>();

            Elefant minElefant = new Elefant();
            minElefant.sort = "Elefant";
            minElefant.namn = "Karin";
            Console.WriteLine(minElefant.Mat);
            anmials.Add(minElefant);

            Seal minSeal = new Seal();
            minSeal.sort = "Säl";
            minSeal.namn = "Penny";
            Console.WriteLine(minSeal.Mat);
            anmials.Add(minSeal);

            Elefant majsElefant = new Elefant();
            majsElefant.sort = "Blå Elefant";
            majsElefant.namn = "Bumbo";
            Console.WriteLine(majsElefant.Mat);
            anmials.Add(majsElefant);

            Bear minBear = new Bear();
            minBear.namn = "Bertil";
            minBear.sort = "Björn";
            Console.WriteLine(minBear.Mat);
            anmials.Add(minBear);

            Elefant tredjeElefanten = new Elefant();
            tredjeElefanten.namn = "Pluto";
            tredjeElefanten.sort = "Elefant";
            Console.WriteLine(tredjeElefanten.Mat);
            anmials.Add(tredjeElefanten);

            Seal secondSeal = new Seal();
            secondSeal.namn = "Gustav";
            secondSeal.sort = "Säl";
            Console.WriteLine(secondSeal.Mat);
            anmials.Add(secondSeal);

            foreach (Djur djur in anmials)
            {
                djur.printAnimal();
            }
            // Day loop
            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int day = 0;
            bool thereIsFoodLeft = true;
            while (thereIsFoodLeft)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

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

