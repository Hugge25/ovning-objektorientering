using System;

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
}

class Paladin : Character
{
    int HolyPower;
    public Paladin(int HolyPower) : base("Paladin", 100)
    {
        this.HolyPower = HolyPower;
    }
    public override void Print()
    {
        Console.WriteLine($"HolyPower: {HolyPower}");
        Console.WriteLine($"HP: {name}");
        Console.WriteLine($"Name {hp}");
    }
}

class Sorcerer : Character
{
    int Mana;
    public Sorcerer(int Mana) : base("Sorcerer", 100)
    {
        this.Mana = Mana;
    }
    public override void Print()
    {
        Console.WriteLine($"Mana: {Mana}");
        Console.WriteLine($"HP: {name}");
        Console.WriteLine($"Name {hp}");
    }
}

class Barbarian : Character
{
    int RageLevel;
    public Barbarian(int RageLevel) : base("Barbarian", 100)
    {
        this.RageLevel = RageLevel;
    }
    public override void Print()
    {
        Console.WriteLine($"RageLevel: {RageLevel}");
        Console.WriteLine($"HP: {name}");
        Console.WriteLine($"Name {hp}");
    }
}