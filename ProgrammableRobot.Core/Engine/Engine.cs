using ProgrammableRobot.Core.Compiler;
using ProgrammableRobot.Core.Worlds;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Engine
{
    public class Engine
    {
        private readonly BaseWorld world;
        private readonly string input;
        private readonly RobotCompiler compiler;
        private List<Compiler.Action> instructions;

        public Engine(BaseWorld world, string input)
        {
            this.world = world;
            this.input = input;
        }

        public string CompileInput()
        {
            var res = compiler.Compile(input);
            instructions = res.Actions;
            return res.Error;
        }

        public Bitmap Render()
        {

        }

        /// <summary>
        /// Executes the next action and returns true if there is another action to execute.
        /// </summary>
        /// <returns></returns>
        public bool ExecuteNextAction()
        {

        }
    }
}