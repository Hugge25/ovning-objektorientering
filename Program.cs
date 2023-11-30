using System;
using ovning_objektorientering;

class Program
{
    static void Main(string[] args)
    {
        Paladin paladin = new Paladin(20, "Paladin", 100);
        Sorcerer sorcerer = new Sorcerer(20, "Sorcerer", 100);
        Barbarian barbarian = new Barbarian(20, "Barbarian", 100);

        List<Character> characters = new List<Character>();

        characters.Add(paladin);
        characters.Add(barbarian);
        characters.Add(sorcerer);

        
        bool game = true;
        string input;

        while(game == true)
        {
            input = Console.ReadLine();
            
            if(input == "bar")
            {
                barbarian.TakeDamage();
            }

            if(input == "pal")
            {
                paladin.TakeDamage();
            }

            if(input == "sor")
            {
                sorcerer.TakeDamage();
            }

            if(input == "pri")
            {
                foreach(Character character in characters)
                {
                    character.Print();
                }
            }

            if(input == "done")
            {
                game = false;
            }
        }
        
    }
}
