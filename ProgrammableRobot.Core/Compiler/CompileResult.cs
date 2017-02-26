using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Compiler
{
    public class CompileResult
    {
        public List<Action> Actions { get; set; }
        public bool Result { get; set; }
        public string Error { get; set; }
    }
}
