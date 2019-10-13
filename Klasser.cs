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

        public virtual void printAnimal()
        {
            Console.WriteLine();
        }

        public void raiseHungerLevel() 
        {
            hungrig ++;
        }
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
                Console.WriteLine("Elefanten " + namn + " är hungrig och behöver äta");
                Console.WriteLine("Tack! Nu äter elefanten " + namn + " och är snart mätt igen");
                hungrig = 0;
            }
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
            Console.WriteLine(sort + " | " + namn + " | " + mat);
        }
        public override void animalNeedsToEat()
        {
            if (hungrig == 7)
            {
                Console.WriteLine("Giraffen " + namn + " är hungrig och behöver äta");
                Console.WriteLine("Tack! Nu äter giraffen " + namn + " och är snart mätt igen");
                hungrig = 0;
            }
        }
    }
    class Seal : Djur
    {
        protected string mat = "kött";
        public string Mat { get { return mat; } }
        public override void animalNeedsToEat()
        {
            if (hungrig == 13)
            {
                Console.WriteLine("Sälen " + namn + " är hungrig och behöver äta");
                Console.WriteLine("Tack! Nu äter sälen " + namn + " och är snart mätt igen");
                hungrig = 0;
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
                Console.WriteLine("Björnen " + namn + " är hungrig och behöver äta");
                Console.WriteLine("Tack! Nu äter björnen " + namn + " och är snart mätt igen");
                hungrig = 0;
            }
        }
    }
}