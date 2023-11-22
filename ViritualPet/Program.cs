using System;
using System.Globalization;
using System.Threading.Channels;
using System.Xml.Linq;

namespace VirtualPetParProgrammering
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hvilket race vil du ha?");
            Console.WriteLine("1. Kattepus");
            Console.WriteLine("2. Hund");
            Console.WriteLine("3. Banan");
            string raceInput = Console.ReadLine();

            string race = "";
            if (raceInput == "1")
                race = "Kattpus";
            else if (raceInput == "2")
                race = "Hund";
            else if (raceInput == "3")
                race = "Banan";
            else
                Console.WriteLine("Not a valid input, try again");
            //Console.WriteLine(race);

            Console.WriteLine($"Hva skal {race}en hete?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hvor gammel er {name}?");
            int age = Convert.ToInt32(Console.ReadLine());

            Pet myPet = new Pet(name, age, race);
            Console.Clear();
            Console.WriteLine($"Du har valgt kjæledyret: ");
            Console.WriteLine($"Navn:  {myPet.name}");
            Console.WriteLine($"Rase:  {myPet.race}");
            Console.WriteLine($"Alder: {myPet.age}");
            Console.WriteLine("\n ** \n");
            Console.WriteLine("Velg et tall fra 1 - 3");
            Console.WriteLine("1. Mat");
            Console.WriteLine("2. Snuggle");
            Console.WriteLine("3. sjekk om må på ramma");
            string ToDoInput = Console.ReadLine();
            if (ToDoInput == "1")
            {
                myPet.Feed();
            }
            else if (ToDoInput == "2")
            {
                myPet.Snuggle();
            }
            else if (ToDoInput == "3")
            {
                myPet.isInNeedOfPooping();
            }
            else Console.WriteLine("Not valid input!");

            //string race = myPet.CheckForRace(raceInput);

            //myPet.Confirmation();

        }
    }

    public class Pet
    {
        public string name;
        public int age;
        public string race;
        public Pet(string Name, int Age, string Race)
        {
            name = Name;
            age = Age;
            race = Race;
        }
        public void Feed()
        {
            Console.WriteLine($"Du gir mat til {name}");
        }
        public void Snuggle()
        {
            Console.WriteLine($"Du snuggler opp med {name}");
        }
        public void isInNeedOfPooping()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 1)
                Console.WriteLine($"{name} må gå på do");
            else
                Console.WriteLine($"{name} må IKKE på do");
        }
        public void Confirmation()
        {
            Console.WriteLine($"Du skrev: {race}");
        }
    }
}