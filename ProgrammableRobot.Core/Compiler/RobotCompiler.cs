using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Compiler
{
    public class RobotCompiler
    {
        public CompileResult Compile(string input)
        {
            var output = new CompileResult();
            output.Actions = new List<Action>();

            var lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var l in lines)
            {
                var trimmed = l.Replace(" ", string.Empty);
                if (trimmed == "MoveForward();")
                    output.Actions.Add(Action.MoveForward);
                else if (trimmed == "RotateLeft();")
                    output.Actions.Add(Action.RotateLeft);
                else if (trimmed == "RotateRight();")
                    output.Actions.Add(Action.RotateRight);
                else if (trimmed == "Pickup();")
                    output.Actions.Add(Action.Pickup);
                else if (trimmed == "Drop();")
                    output.Actions.Add(Action.Drop);
                else
                {
                    if (string.IsNullOrWhiteSpace(output.Error))
                        output.Error = $"Unknown command '{l}'.";
                }
            }

            output.Result = string.IsNullOrWhiteSpace(output.Error);
            return output;
        }
    }
}
