using MonkeysApp.Interfaces;
using System;
using System.Collections.Generic;

namespace MonkeysApp.Models
{
    public class Monkey : IDressedAnimal
    {
        public string name;                                 // Monkey's name
        public List<Trick> tricks;                          // Monkey's list of tricks

        private readonly ISpectator spectator;              // The spectator who attends the performance

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The monkey's name</param>
        /// <param name="spectator">The spectator who attends the monkey's performance</param>
        public Monkey(string name, ISpectator spectator)
        {
            this.name = name;
            this.spectator = spectator;

            tricks = new List<Trick>();
        }

        /// <summary>
        /// Allow to add a trick to the monkey's trick list
        /// </summary>
        /// <param name="trick">The trick to add</param>
        /// <remarks>Cannot add a trick that's already in the list</remarks>
        public void AddTrick(Trick trick)
        {
            if (!tricks.Contains(trick))
            {
                tricks.Add(trick);
            }
        }

        /// <summary>
        /// Allow this monkey to execute all his tricks
        /// </summary>
        /// <remarks>After a trick, the monkey call a spectator's react</remarks>
        public void ExecuteAllTricks()
        {
            foreach (Trick trick in tricks)
            {
                Console.WriteLine("\n" + name + " exécute le tour '" + trick.name + "'");
                spectator.ReactToTrick(trick.type);
            }
        }
    }
}
