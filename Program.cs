using System;

namespace _08112020SpaceRustlers
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceships = 10;
            int aliens = 25;
            int cows = 100;

            if (aliens > spaceships)
            {
                Console.WriteLine("Vrroom, vroom! Let's going!");
            }
            else
            {
                Console.WriteLine("There aren't enough green guys to drive these ships!");
            }

            if (cows == spaceships)
            {
                Console.WriteLine("Wow, way to plan ahead! JUST enough room for all these walking hamburgers!");
            }
            else if (cows > spaceships)
            {
                Console.WriteLine("Dangit! I don't know how we're going to fit all these cows in here!");
            }
            else
            {
                Console.WriteLine("Too many ships! Not enough cows.");
            }

            if (aliens > cows)
            {
                Console.WriteLine("Hurrah, we've got the grub! Hamburger party on AlphaCentauri!");
            }
            else if (cows >= aliens)
            {
                Console.WriteLine("Oh no! The herd got restless and took over! Looks like_we're_hamburger now!!");
            }
        }
    }
}