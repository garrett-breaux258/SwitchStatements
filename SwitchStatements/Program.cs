using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "English":
                    Console.WriteLine("That's awesome, but English was my least favorite!");
                    break;

                case "Math":
                    Console.WriteLine("I love math, I coul do equations in my sleep.");
                    break;

                case "Science":
                    Console.WriteLine("Woohoo, was bill nye your absolute favorite?");
                    break;

                case "History":
                    Console.WriteLine("I don't know why it's called history, should be called sleepstory.");
                    break;

                case "Athletics":
                    Console.WriteLine("Nice, got sweat?");
                    break;

                default:
                    Console.WriteLine("I have never heard of that subject!");
                    break;
            }
        }
    }
}
