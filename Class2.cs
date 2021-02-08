using System;
using System.Collections.Generic;
using System.Text;

namespace bonus13_2
{
    class Warrior : GameCharacter
    {
       override public void Play()
       {
            Console.Write("Please enter character name ");
            var name = Console.ReadLine();
            Console.Write("Please enter character strength ");
            var numstrength = Console.ReadLine();
            var strength = int.Parse(numstrength);
            Console.Write("Please enter character intelligence ");
            var numintelligence = Console.ReadLine();
            var intelligence = int.Parse(numintelligence);
            Console.Write("Please enter weapon type ");
            var weaponType = Console.ReadLine();
            Console.WriteLine($"Name = {name}, Strength = {strength}, Intelligence = {intelligence} Weapon Type = {weaponType}");
            Console.WriteLine();
        }
    }
    
}
        