using System;
using System.Collections.Generic;
using System.Text;

namespace bonus13_2
{
    public class GameCharacter
    {
       virtual public void Play()  //method
        {
            Console.Write("Please enter character name ");
            var name = Console.ReadLine();
            Console.Write("Please enter character strength ");
            var numstrength = Console.ReadLine();
            var strength = int.Parse(numstrength);
            Console.Write("Please enter character intelligence ");
            var numintelligence = Console.ReadLine();
            var intelligence = int.Parse(numintelligence);
            Console.WriteLine($"Name = {name}, Strength = {strength}, Intelligence = {intelligence}");
            Console.WriteLine();
            }
    }
}
