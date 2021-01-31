using MonkeysApp.Interfaces;
using System;
namespace MonkeysApp.Models
{
    public class Tamer
    {
        public string name;                                         // Tamer's name

        private readonly IDressedAnimal monkey;                     // Tamer's monkey

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The tamer's name</param>
        /// <param name="monkey">The tamer's monkey</param>
        public Tamer(string name, IDressedAnimal monkey)
        {
            this.name = name;
            this.monkey = monkey;
        }

        /// <summary>
        /// Allow tamer to call monkey's tricks execution
        /// </summary>
        public void CallTricks()
        {
            monkey.ExecuteAllTricks();
        }
    }
}
