using System;
using System.Collections.Generic;
using System.Text;

namespace bonus13_2
{
    class Wizard : MagicUsingCharacter
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
            Console.Write("Please enter Magical Energy ");
            var numMagicalEnergy = Console.ReadLine();
            var magicalEnergy = int.Parse(numMagicalEnergy);
            Console.Write("Please enter your Spell Number ");
            var numSpellNumber = Console.ReadLine();
            var spellNumber = int.Parse(numSpellNumber);
            Console.WriteLine($"Name = {name}, Strength = {strength}, Intelligence = {intelligence}, Magical Energy = {magicalEnergy}, Spell Number = {spellNumber} ");
            Console.WriteLine();
        }
    }
}
