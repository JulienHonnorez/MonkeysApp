using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeysApp.Enums;
using MonkeysApp.Models;
using System;

namespace MonkeyApp.Tests
{
    /// <summary>
    /// Spectator test class
    /// </summary>
    [TestClass]
    public class SpectatorTest
    {
        /// <summary>
        /// Allow to test spectator reaction when attends to acrobatic performance
        /// </summary>
        [TestMethod]
        public void ReactToTrick_WithApplause()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            TrickType trickType = TrickType.Acrobatics;
            string expected = spectator.name + " applaudit !\r\n";

            var currentConsoleOut = Console.Out;

            // Act and assert
            using (var consoleOutput = new ConsoleOutput())
            {
                spectator.ReactToTrick(trickType);

                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        /// <summary>
        /// Allow to test spectator reaction when attends to musical performance
        /// </summary>
        [TestMethod]
        public void ReactToTrick_WithWhistle()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            TrickType trickType = TrickType.Music;
            string expected = spectator.name + " siffle !\r\n";

            var currentConsoleOut = Console.Out;

            // Act and assert
            using (var consoleOutput = new ConsoleOutput())
            {
                spectator.ReactToTrick(trickType);

                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}
