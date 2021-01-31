using MonkeysApp.Enums;
using MonkeysApp.Models;
using System;

namespace MonkeysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objects Initialization
            Spectator spectator = new Spectator("Spectateur");

            Monkey monkey1 = new Monkey("Singe_1", spectator);
            Monkey monkey2 = new Monkey("Singe_2", spectator);
            Trick trick1 = new Trick("Marcher sur les mains", TrickType.Acrobatics);
            Trick trick2 = new Trick("Fredonner une chanson", TrickType.Music);

            monkey1.AddTrick(trick1);
            monkey1.AddTrick(trick2);
            monkey2.AddTrick(trick1);
            monkey2.AddTrick(trick2);

            Tamer tamer1 = new Tamer("Tamer_1", monkey1);
            Tamer tamer2 = new Tamer("Tamer_2", monkey2);

            // Start Process

            tamer1.CallTricks();
            tamer2.CallTricks();

            // End Process

            Console.ReadLine();
        }
    }
}
