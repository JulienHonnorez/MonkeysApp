using MonkeysApp.Enums;
using MonkeysApp.Interfaces;
using System;

namespace MonkeysApp.Models
{
    public class Spectator : ISpectator
    {
        public string name;                                 // Spectator's name

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Spectator's name</param>
        public Spectator(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Allow spectator to react to a specific trick type
        /// </summary>
        /// <param name="trickType">The trick type</param>
        public void ReactToTrick(TrickType trickType)
        {
            switch (trickType)
            {
                case TrickType.Acrobatics:
                    Console.WriteLine(name + " applaudit !");
                    break;
                case TrickType.Music:
                    Console.WriteLine(name + " siffle !");
                    break;
                default:
                    break;
            }
        }
    }
}
