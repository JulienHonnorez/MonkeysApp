using MonkeysApp.Enums;

namespace MonkeysApp.Models
{
    public class Trick
    {
        public string name;                                 // Trick's name
        public TrickType type;                              // Trick's type

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> The trick's name</param>
        /// <param name="type"> The trick's type</param>
        public Trick(string name, TrickType type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
