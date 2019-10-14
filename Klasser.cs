using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    //superklass för djur

    class Djur
    {
        public string sort;
        public string namn;
        public int hungrig = 0;

        public int foodleft = 0;

        //Metod för att skriva ut djuren som finns
        public virtual void printAnimal()
        {
            Console.WriteLine();
        }
        //Metod räknar upp hungernivån på djuret
        public void raiseHungerLevel()
        {
            hungrig++;
        }

        //Metod för varje djur som:
        //Ökar hungernivån
        //Kollar om djuret behöver äta eller inte
        //Konsumerar mat och återställer hungernivån

        public virtual void animalNeedsToEat()
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
            Console.WriteLine(sort + " | " + namn + " | " + mat);
        }
        public override void animalNeedsToEat()
        {
            if (hungrig == 10)
            {
                if (Program.nrOfVeggiesLeft >= 1)
                {
                    Console.WriteLine("Elefanten " + namn + " är hungrig och behöver äta");
                    Console.WriteLine("Tack! Nu äter elefanten " + namn + " och är snart mätt igen");
                    hungrig = 0;

                    Program.nrOfVeggiesLeft--;
                    Console.WriteLine("Det finns nu " + Program.nrOfVeggiesLeft + " blad kvar.");
                }
                else
                {
                    Console.WriteLine("Nu är bladen slut. Elefanten " + namn + " är hungrig men kan inte få nån mat!");
                }
            }
            else 
            {
                Console.WriteLine (sort + " " + namn + " behöver inte äta idag.");
            }
        }
    }

    class Giraff : Djur
    {
        protected string mat = "blad";
        public string Mat { get { return mat; } }
        public override void printAnimal()
        {
            Console.WriteLine(sort + " | " + namn + " | " + mat);
        }
        public override void animalNeedsToEat()
        {
            if (hungrig == 7)
            {
                if (Program.nrOfVeggiesLeft >= 1)
                {
                    Console.WriteLine("Giraffen " + namn + " är hungrig och behöver äta");
                    Console.WriteLine("Tack! Nu äter giraffen " + namn + " och är snart mätt igen");
                    hungrig = 0;

                    Program.nrOfVeggiesLeft--;
                    Console.WriteLine("Det finns nu " + Program.nrOfVeggiesLeft + " blad kvar.");
                }
                else
                {
                    Console.WriteLine("Nu är bladen slut. Giraffen" + namn + " är hungrig men kan inte få mat. Gör ett inköp!");
                }
            }
            else 
            {
                Console.WriteLine (sort + " " + namn + " behöver inte äta idag.");
            }
        }
    }
    class Seal : Djur
    {
        protected string mat = "kött";
        public string Mat { get { return mat; } }
        public override void printAnimal()
        {
            Console.WriteLine(sort + " | " + namn + " | " + mat);
        }
        public override void animalNeedsToEat()
        {
            if (hungrig == 13)
            {
                if (Program.nrOfMeatLeft >= 1)
                {
                    Console.WriteLine("Sälen " + namn + " är hungrig och behöver äta");
                    Console.WriteLine("Tack! Nu äter sälen " + namn + " och är snart mätt igen");
                    hungrig = 0;

                    Program.nrOfMeatLeft--;
                    Console.WriteLine("Det finns nu " + Program.nrOfMeatLeft + " köttbitar kvar.");
                }
                else
                {
                    Console.WriteLine("Nu är köttet slut! Sälen " + namn + " är hungrig. Det måste köpas in ny mat!");
                }
            }
            else 
            {
                Console.WriteLine (sort + " " + namn + " behöver inte äta idag.");
            }
        }
    }
    class Bear : Djur
    {
        protected string mat = "kött";
        public string Mat { get { return mat; } }
        public override void printAnimal()
        {
            Console.WriteLine(sort + " | " + namn + " | " + mat);
        }
        public override void animalNeedsToEat()
        {
            if (hungrig == 3)
            {
                if (Program.nrOfMeatLeft >= 1)
                {
                    Console.WriteLine("Björnen " + namn + " är hungrig och behöver äta");
                    Console.WriteLine("Tack! Nu äter björnen " + namn + " och är snart mätt igen");
                    hungrig = 0;
                    Program.nrOfMeatLeft--;
                    Console.WriteLine("Det finns nu " + Program.nrOfMeatLeft + " köttbitar kvar.");
                }
                else
                {
                    Console.WriteLine("Det finns inget kött kvar. Björnen " + namn + " är hungrig. Det måste köpas in nytt");
                }
            }
            else 
            {
                Console.WriteLine (sort + " " + namn + " behöver inte äta idag.");
            }
        }
    }
}