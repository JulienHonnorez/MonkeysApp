using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeysApp.Models;
using System;

namespace MonkeyApp.Tests
{
    /// <summary>
    /// Tamer test class
    /// </summary>
    [TestClass]
    public class TamerTest
    {
        /// <summary>
        /// Allow to test the console output content when tamer calls single trick execution
        /// </summary>
        [TestMethod]
        public void CallTricks_SingleTrick()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            Monkey monkey = new Monkey("Monkey_Test", spectator);
            Tamer tamer = new Tamer("Tamer_Test", monkey); 
            Trick trick = new Trick("Trick_Test", MonkeysApp.Enums.TrickType.Acrobatics);
            monkey.AddTrick(trick);

            var currentConsoleOut = Console.Out;
            string expected = "\n" + monkey.name + " exécute le tour '" + trick.name + "'\r\n" + spectator.name + " applaudit !\r\n";

            // Act and assert
            using (var consoleOutput = new ConsoleOutput())
            {
                tamer.CallTricks();

                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        /// <summary>
        /// Allow to test the console output content when tamer calls multi tricks execution
        /// </summary>
        [TestMethod]
        public void CallTricks_MultiTricks()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            Monkey monkey = new Monkey("Monkey_Test", spectator);
            Tamer tamer = new Tamer("Tamer_Test", monkey);
            Trick trick1 = new Trick("Trick_Test_1", MonkeysApp.Enums.TrickType.Acrobatics);
            Trick trick2 = new Trick("Trick_Test_2", MonkeysApp.Enums.TrickType.Music);
            monkey.AddTrick(trick1);
            monkey.AddTrick(trick2);

            var currentConsoleOut = Console.Out;
            string expected = "\n" + monkey.name + " exécute le tour '" + trick1.name + "'\r\n" + spectator.name + " applaudit !\r\n" +
                "\n" + monkey.name + " exécute le tour '" + trick2.name + "'\r\n" + spectator.name + " siffle !\r\n";

            // Act and assert
            using (var consoleOutput = new ConsoleOutput())
            {
                tamer.CallTricks();

                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}
