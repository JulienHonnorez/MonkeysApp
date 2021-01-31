using System;
using System.IO;

namespace MonkeyApp.Tests
{
    /// <summary>
    /// Class that allow to test console content.
    /// </summary>
    public class ConsoleOutput : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        /// <summary>
        /// Constructor
        /// </summary>
        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        /// <summary>
        /// Allow to get the output content
        /// </summary>
        /// <returns></returns>
        public string GetOuput()
        {
            return stringWriter.ToString();
        }

        /// <summary>
        /// Allow to restablish the original output and dispose StringWritter object
        /// </summary>
        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}
