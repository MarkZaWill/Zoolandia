using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia.Animals {

    class Panthera : Animal
    {
        public string Ears = "pointy";
        public bool Deadly = true;
        public bool wings = false;
    }

       
    }


    class Liger : Panthera
    {
        public int Cuteness = 10;
        public string Color = "light stripy";
        public string Location = "South Africa";
        public string Noise = "Derp";
        public override string Transportation()
        {
            return "creeps";
        }
    }
    class Lion : Panthera
    {
        public int Cuteness = 8;
        public string Color = "Mane";
        public string Location = "Africa";
        public string Noise = "Roar";
        public override string Transportation()
        {
            return "Sauntering";
        }
    }
    class SiberianTiger : Panthera
    {
        public int Cuteness = 14;
        public string Color = "Jack White... or white stripy";
        public string Location = "Siberia";
        public string Noise = "It's really cold!!!";
        public override string Transportation()
        {
            return "Slipping and Sliding";
        }
    }
    class Rana : Animal
    {
        public string Ears = "pointy";
        public bool Deadly = true;
        public bool wings = false;
    }
    class Bullfrog : Rana
    {
        public int Cuteness = 2;
        public string Color = "Dark Green";
        public string Location = "America";
        public string Noise = "CROAK";
        public override string Transportation()
        {
            return "hops";
        }
    }
    class GreenFrog : Rana
    {
        public int Cuteness = 14;
        public string Color = "Definitely Gree";
        public string Location = "The Grass";
        public string Noise = "Creak";
        public override string Transportation()
        {
            return "leaps";
        }
    }
    class PigFrog : Rana
    {
        public int Cuteness = 70;
        public string Color = "Pink";
        public string Location = "Pig Pen";
        public string Noise = "Oink?";
        public override string Transportation()
        {
            return "Prancing";
        }
    }
    class RiverFrog : Rana
    {
        public int Cuteness = 10;
        public string Color = "Blue";
        public string Location = "The River";
        public string Noise = "Gurgle";
        public override string Transportation()
        {
            return "Swim";
        }
    }
    class Canis : Animal
    {
        public string Ears = "pointy";
        public bool Deadly = true;
        public bool wings = false;
    }
    class Wolf : Canis
    {
        public int Cuteness = 10;
        public string Color = "Grey";
        public string Location = "America";
        public string Noise = "howl";
    }
    class Coyote : Canis
    {
        public int Cuteness = 14;
        public string Color = "Dirty Red";
        public string Location = "East USA";
        string Noise = "Laughter";
    }
    class blackJackal : Canis
    {
        public int Cuteness = 2;
        string Color = "Black";
        string Location = "Nambia";
        string Noise = "Kweeeee";
    }
    class Dogs : Canis
    {
        int Cuteness = 100;
        string Color = "Yellow";
        string Location = "Everywhere";
        string Noise = "Woof";
    }
    class Dynastes : Animal
    {
        string Ears = "none";
        public bool Deadly = false;
        public bool wings = true;
        public bool fur = false;

    }
    class HornBeetle : Dynastes
    {
        int Cuteness = 30;
        string Color = "black";
        string Location = "Arizona";
        string Noise = "tick tick tick";
        public override string Transportation()
        {
            return "crawl";
        }
    }
    class HerculesBeetle : Dynastes
    {
        int Cuteness = 12;
        string Color = "Yellow";
        string Location = "South America";
        string Noise = "Crunch";
        public override string Transportation()
        {
            return "tink tink tink";
        }
    }
    class Satanas : Dynastes
    {
        int Cuteness = 4;
        string Color = "Orange";
        string Location = "Bolivia";
        string Noise = "Quit taking my home, I'm endangered";
        public override string Transportation()
        {
            return "crying because they are endangered";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var Kate = new SiberianTiger() { Name = "kate"};
            Console.WriteLine("Hey, yo, from c#");
            Console.WriteLine(String.Format("{0} is a {1}", Kate.Name, Kate.GetType().ToString()));
            Console.ReadKey();
        }
    }


