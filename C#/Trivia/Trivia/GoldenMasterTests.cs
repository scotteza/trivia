using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using System;
using System.IO;

namespace Trivia
{
    [TestFixture]
    public class GoldenMasterTests
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void Run_Golden_Master()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            for (var i = 0; i < 1000; i++)
            {
                var gameInstance = new GameInstance();
                gameInstance.RunGameSimulation(i);
            }
            var output = stringWriter.ToString();


            Approvals.Verify(output);
        }
    }
}
