using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace prov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Frågar användare hur många bilar hen vill skapa.
            Console.Write("Hur många bilar ska skapas?: ");
            int carsAmount = 0;
            // En while loop som kollar att användaren alltid stoppar in rätt grejer.
            while (!int.TryParse(Console.ReadLine(), out carsAmount))
            {
                Console.Clear();
                Console.WriteLine("Felaktigt input!");
                Console.Write("Hur många bilar ska skapas?: ");
            }

            List<Car> cars = new List<Car>();

            // For loop som lägger till all objekt i en lista
            for (int i = 0; i < carsAmount; i++)
            {
                cars.Add(new Car());
            }
            // En for each loop som kollar genom alla ebjekt il listan och checkar alla bilar!
            foreach (var car in cars)
            {
                Console.WriteLine(car.Examine());
            }

            Console.Write("Välj namn: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.Clear();
            Console.WriteLine("Välj kategori: ");
            Console.WriteLine("1 -> Superman");
            Console.WriteLine("2 -> Flash");
            Console.WriteLine("3 -> Hulk");
            int value = 0;
            // En while loop som kollar att användaren alltid stoppar in rätt grejer.
            while (!int.TryParse(Console.ReadLine(), out value) && value < 1 || value > 3)
            {
                Console.Clear();
                Console.WriteLine("Felaktigt input!");
                Console.WriteLine("Välj kategori: ");
                Console.WriteLine("1 -> Superman");
                Console.WriteLine("2 -> Flash");
                Console.WriteLine("3 -> Hulk");
            }

            List<string> Abilities = new List<string>();

            switch (value)
            {
                case 1:
                    Superhero superhero = new Superman(name, 25, "Krypton", Abilities, 100);
                    Console.WriteLine(superhero.GetName());
                    Console.WriteLine(superhero.GetAge());
                    Console.WriteLine(superhero.GetOrigin());
                    Console.WriteLine(superhero.GetPowerLevel(100));
                    break;
                case 2:
                    Superhero superhero2 = new Flash(name, 25, "Krypton", Abilities, 100);
                    Console.WriteLine(superhero2.GetName());
                    Console.WriteLine(superhero2.GetAge());
                    Console.WriteLine(superhero2.GetOrigin());
                    Console.WriteLine(superhero2.GetPowerLevel(100));
                    break;
                case 3:
                    Superhero superhero3 = new Hulk(name, 25, "Krypton", Abilities, 100);
                    Console.WriteLine(superhero3.GetName());
                    Console.WriteLine(superhero3.GetAge());
                    Console.WriteLine(superhero3.GetOrigin());
                    Console.WriteLine(superhero3.GetPowerLevel(100));
                    break;
            }
        }

        public static void CategoriseBy(string category, List<int> data) {
            switch (category)
            {
                case "power":
                    data.Reverse();
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Non existent category!");
                    break;
            }
        }
    }
}

class Superhero {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Origin { get; set; }

    public Superhero(string name, int age, string origin) {
        Name = name;
        Age = age;
        Origin = origin;
    }

    public string GetOrigin() {
        return Origin;
    }

    public int GetAge() {
        return Age;
    }

    public string GetName() {
        return Name;
    }

    public string GetPowerLevel(int power) {
        switch (power)
        {
            case > 90:
                return "God!";
            case > 70:
                return "Super!";
            case > 40:
                return "Mid powers!";
            case > 20:
                return "Not powerful!";
            default:
                return "Baby powers!";
        }
    }
}

class Superman : Superhero {
    List<string> Abilities = new List<string>();
    public int Power { get; set; }

    public Superman(string name, int age, string origin, List<string> abilities, int power) : base(name, age, origin) {
        foreach (var ability in abilities)
        {
            Abilities.Add(ability);
        }
        Power = power;
    }

    public List<string> GetSupermanAbilities() {
        return Abilities;
    }
}

class Flash : Superhero {    List<string> Abilities = new List<string>();
    public int Power { get; set; }

    public Flash(string name, int age, string origin, List<string> abilities, int power) : base(name, age, origin) {
        foreach (var ability in abilities)
        {
            Abilities.Add(ability);
        }
        Power = power;
    }

    public List<string> GetFlashAbilities() {
        return Abilities;
    }
}

class Hulk : Superhero {
    List<string> Abilities = new List<string>();
    public int Power { get; set; }

    public Hulk(string name, int age, string origin, List<string> abilities, int power) : base(name, age, origin) {
        foreach (var ability in abilities)
        {
            Abilities.Add(ability);
        }
        Power = power;
    }

    public List<string> GetHulkAbilities() {
        return Abilities;
    }
}

class Car
{
    public int Pasagers { get; set; } 
    public int ContrabandAmount { get; set; }
    public bool AlreadyChecked { get; set; }
    public Random Generator { get; set; }

    public Car() {
        Generator = new Random();
        Pasagers = Generator.Next(1, 5);
        ContrabandAmount = Generator.Next(0, 5);
    }

    public bool Examine() {
        AlreadyChecked = true;
        if (Pasagers <= 3 && ContrabandAmount == 0)
        {
            return false;
        } else if (ContrabandAmount == 1) {
            int FindChance = Generator.Next(1, 4);
            if (FindChance == 1) {
                return true;
            }  else {
                return false;
            }
        } else if (ContrabandAmount == 2) {
            int FindChance = Generator.Next(1, 4);
            if (FindChance >= 1 && FindChance < 3) {
                return true;
            }  else {
                return false;
            }
        } else if (ContrabandAmount == 3) {
            int FindChance = Generator.Next(1, 4);
            if (FindChance >= 1 && FindChance <= 3) {
                return true;
            }  else {
                return false;
            }
        } else if (ContrabandAmount == 4) {
            return true;
        }
        return true;
    }
}

class CleanCar : Car {
    public int AmountCleanCars { get; set; }
    public CleanCar() : base() {
        AmountCleanCars++;
    }

    public int GetCleanCarsAmount() {
        return AmountCleanCars;
    }
}

class ContrabandCar : Car {
    public int AmountContrabandCars { get; set; }
    public ContrabandCar() : base() {
        AmountContrabandCars++;
    }

    public int GetAmountContrabandCars() {
        return AmountContrabandCars;
    }
}