using NUnit.Framework;
using ProgrammableRobot.Core.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Tests
{
    [TestFixture]
    public class CompilerTests
    {
        [Test]
        public void Test()
        {
            var compiler = new RobotCompiler();
            var input = new StringBuilder()
                .AppendLine("MoveForward();")
                .AppendLine("RotateLeft();")
                .AppendLine("RotateRight();")
                .AppendLine("Pickup();")
                .AppendLine("Drop();")
                .ToString();
            var result = compiler.Compile(input);
            Assert.IsTrue(result.Result);
            Assert.AreEqual(Core.Compiler.Action.MoveForward, result.Actions[0]);
            Assert.AreEqual(Core.Compiler.Action.RotateLeft, result.Actions[1]);
            Assert.AreEqual(Core.Compiler.Action.RotateRight, result.Actions[2]);
            Assert.AreEqual(Core.Compiler.Action.Pickup, result.Actions[3]);
            Assert.AreEqual(Core.Compiler.Action.Drop, result.Actions[4]);
        }
    }
}
