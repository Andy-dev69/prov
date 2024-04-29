using System;
using System.Collections.Generic;
using System.Dynamic;

namespace prov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Abilities = new List<string>();
            Abilities.Add("Test");
            Superman test = new Superman("Superman", 25, "Krypton", Abilities, 100);
            Flash test2 = new Flash("Superman", 30, "Krypton", Abilities, 80);
            // Console.WriteLine($"Origin: {test.GetOrigin()}");
            List<int> blabla = new List<int>();

            blabla.Add(test.GetAge());
            blabla.Add(test2.GetAge());
            CategoriseBy("power", blabla);
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