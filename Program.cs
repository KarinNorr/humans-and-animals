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
        public string mat;
        public override void printAnimal()
        {
            Console.WriteLine("Jag är en " + sort + " som heter " + namn + " och äter " + mat);
        }
    }

    class Giraff : Djur
    {
        public string mat;
        public override void printAnimal()
        {
            Console.WriteLine("Jag är en " + sort + " som heter " + namn + " och äter " + mat);
        }
    }
    class Seal : Djur
    {
        public string mat;
        public override void printAnimal()
        {
            Console.WriteLine("Jag är en " + sort + " som heter " + namn + " och äter " + mat);
        }
    }
    class Bear : Djur
    {
        public string mat;
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

        }
    }
}

