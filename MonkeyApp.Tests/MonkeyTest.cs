using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeysApp.Models;
using System;

namespace MonkeyApp.Tests
{
    /// <summary>
    /// Monkey test class
    /// </summary>
    [TestClass]
    public class MonkeyTest
    {
        /// <summary>
        /// Allow to test the new trick addition to monkey's trick list
        /// </summary>
        [TestMethod]
        public void AddTrick_NewTrick()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            Monkey monkey = new Monkey("Monkey_Test", spectator);
            Trick trick = new Trick("Trick_Test", MonkeysApp.Enums.TrickType.Acrobatics);

            int expected = 1;

            // Act
            monkey.AddTrick(trick);

            // Assert
            Assert.AreEqual(expected, monkey.tricks.Count);
        }

        /// <summary>
        /// Allow to test the already known trick addition to monkey's trick list
        /// </summary>
        [TestMethod]
        public void AddTrick_AlreadyKnownTrick()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            Monkey monkey = new Monkey("Monkey_Test", spectator);
            Trick trick = new Trick("Trick_Test", MonkeysApp.Enums.TrickType.Acrobatics);
            monkey.AddTrick(trick);

            int expected = 1;

            // Act
            monkey.AddTrick(trick);

            // Assert
            Assert.AreEqual(expected, monkey.tricks.Count);
        }

        /// <summary>
        /// Allow to test the console output content when monkey executes a single trick
        /// </summary>
        [TestMethod]
        public void ExecuteAllTrick_SingleTrick()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            Monkey monkey = new Monkey("Monkey_Test", spectator);
            Trick trick = new Trick("Trick_Test", MonkeysApp.Enums.TrickType.Acrobatics);
            monkey.AddTrick(trick);

            var currentConsoleOut = Console.Out;
            string expected = "\n" + monkey.name + " exécute le tour '" + trick.name + "'\r\n" + spectator.name + " applaudit !\r\n";

            // Act and assert
            using (var consoleOutput = new ConsoleOutput())
            {
                monkey.ExecuteAllTricks();

                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        /// <summary>
        /// Allow to test the console output content when monkey executes amultiple tricks
        /// </summary>
        [TestMethod]
        public void ExecuteAllTrick_MultiTricks()
        {
            // Arrange
            Spectator spectator = new Spectator("Spectator_Test");
            Monkey monkey = new Monkey("Monkey_Test", spectator);
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
                monkey.ExecuteAllTricks();

                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}
