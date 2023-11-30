using System;
namespace ovning_objektorientering
{
   
    abstract class Character
    {
        protected string name;
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        protected int hp;
        public int HP
        {
            get{return hp;}
            set{hp = value;}
        }

        public Character(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public abstract void Print();

        public abstract void TakeDamage();
    }

    class Paladin : Character
    {
        int HolyPower;
        public Paladin(int HolyPower, string name, int hp) : base("Paladin", 100)
        {
            this.HolyPower = HolyPower;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"HolyPower: {HolyPower}");
            Console.WriteLine($"HP: {hp}\n");
        }

        public override void TakeDamage()
        {
            hp -= 10;
        }
    }

    class Sorcerer : Character
    {
        int Mana;
        public Sorcerer(int Mana, string name, int hp) : base("Sorcerer", 100)
        {
            this.Mana = Mana;
        }
        public override void Print()
        {   
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Mana: {Mana}");
            Console.WriteLine($"HP: {hp}\n");
        }
        public override void TakeDamage()
        {
            hp -= 10;
        }
    }

    class Barbarian : Character
    {
        int RageLevel;
        public Barbarian(int RageLevel, string name, int hp) : base("Barbarian", 100)
        {
            this.RageLevel = RageLevel;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"RageLevel: {RageLevel}");
            Console.WriteLine($"HP: {hp}\n");
        }
        public override void TakeDamage()
        {
            hp -= 10;
        }
    }
}