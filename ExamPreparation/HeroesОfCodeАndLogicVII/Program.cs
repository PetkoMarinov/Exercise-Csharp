using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesОfCodeАndLogicVII
{
    class Program
    {
        class Hero
        {
            public string Name { get; set; }
            public int HP { get; set; }
            public int Mana { get; set; }

            public Hero(string name, int hp, int mana)
            {
                this.Name = name;
                this.HP = hp;
                this.Mana = mana;
            }
        }

        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>(numberOfHeroes);

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroStats = Console.ReadLine().Split();
                string name = heroStats[0];
                int hp = int.Parse(heroStats[1]);
                int mana = int.Parse(heroStats[2]);

                Hero hero = new Hero(name, hp, mana);
                heroes.Add(hero);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandData = input.Split(" - ");
                string command = commandData[0];
                string heroName = commandData[1];
                var hero = heroes.Find(h => h.Name == heroName);

                switch (command)
                {
                    case "CastSpell":
                        int spellMana = int.Parse(commandData[2]);
                        string spellName = commandData[3];

                        if (hero.Mana >= spellMana)
                        {
                            hero.Mana -= spellMana;
                            Console.WriteLine($"{hero.Name} has successfully cast" +
                                $" {spellName} and now has {hero.Mana} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero.Name} does not have enough " +
                                $"MP to cast {spellName}!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(commandData[2]);
                        string attacker = commandData[3];

                        if (hero.HP > damage)
                        {
                            hero.HP -= damage;
                            Console.WriteLine($"{hero.Name} was hit for {damage} HP by" +
                                $" {attacker} and now has {hero.HP} HP left!");
                        }
                        else
                        {
                            heroes.Remove(hero);
                            Console.WriteLine($"{hero.Name} has been killed " +
                                $"by {attacker}!");
                        }
                        break;

                    case "Recharge":
                        int manaAdded = int.Parse(commandData[2]);
                        int recoveredMana = (hero.Mana + manaAdded) > 200
                            ? (200 - hero.Mana) : manaAdded;

                        if (hero.Mana <= 200)
                        {
                            Console.WriteLine($"{hero.Name} recharged for {recoveredMana} MP!");
                            hero.Mana += recoveredMana;
                        }
                        break;

                    case "Heal":
                        int hpAdded = int.Parse(commandData[2]);
                        int recoveredHP = (hero.HP + hpAdded) > 100
                            ? (100 - hero.HP) : hpAdded;

                        if (hero.HP <= 100)
                        {
                            Console.WriteLine($"{hero.Name} healed for {recoveredHP} HP!");
                            hero.HP += recoveredHP;
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var hero in heroes.OrderByDescending(x => x.HP).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{hero.Name}\n  HP: {hero.HP}\n  MP: {hero.Mana}");
            }
        }
    }
}
