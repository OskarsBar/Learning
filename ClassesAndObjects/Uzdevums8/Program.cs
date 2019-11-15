using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums8
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dogMax = new Dog("Max", "male");
            Dog dogRocky = new Dog("Rocky", "male"); 
            Dog dogSparky = new Dog("Sparky", "male"); 
            Dog dogBuster = new Dog("Buster", "male"); 
            Dog dogSam = new Dog("Sam", "male"); 
            Dog dogLady = new Dog("Lady", "female"); 
            Dog dogMolly = new Dog("Molly", "female"); 
            Dog dogCoco = new Dog("Coco", "female");

            dogMax.Mother = dogLady;
            dogMax.Father = dogRocky;

            dogCoco.Mother = dogMolly;
            dogCoco.Father = dogBuster;

            dogRocky.Mother = dogMolly;
            dogRocky.Father = dogSam;

            dogBuster.Mother = dogLady;
            dogBuster.Father = dogSparky;

            Console.WriteLine(dogCoco.FathersName());
            Console.WriteLine(dogCoco.HasSameMotherAs(dogRocky));
            Console.Read();
    
        }
    }
}
