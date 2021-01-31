using MonkeysApp.Enums;

namespace MonkeysApp.Interfaces
{
    /// <summary>
    /// Interface that all spectator who want to attends an animal's performance must implement
    /// </summary>
    public interface ISpectator
    {
        /// <summary>
        /// Allow spectator to react to a specific trick type
        /// </summary>
        /// <param name="trickType">The trick's type</param>
        void ReactToTrick(TrickType trickType);
    }
}
