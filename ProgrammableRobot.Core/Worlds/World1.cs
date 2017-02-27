using ProgrammableRobot.Core.Actors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Worlds
{
    public class World1 : BaseWorld
    {
        public World1()
        {
            Actors = new List<Core.Actors.BaseActor>()
            {
                new Wall() { Position = new Objects.Vector() { X = 1, Y = 0 } },
                new Wall() { Position = new Objects.Vector() { X = 1, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 1, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 1, Y = 3 } },
                new Wall() { Position = new Objects.Vector() { X = 0, Y = 5 } },
                new Wall() { Position = new Objects.Vector() { X = 1, Y = 5 } },
                new Wall() { Position = new Objects.Vector() { X = 2, Y = 5 } },
                new Wall() { Position = new Objects.Vector() { X = 3, Y = 5 } },

                new Wall() { Position = new Objects.Vector() { X = 3, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 5, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 7, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 8, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 9, Y = 1 } },

                new Wall() { Position = new Objects.Vector() { X = 3, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 5, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 7, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 8, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 9, Y = 2 } },

                new Wall() { Position = new Objects.Vector() { X = 3, Y = 6 } },
                new Wall() { Position = new Objects.Vector() { X = 3, Y = 7 } },
                new Wall() { Position = new Objects.Vector() { X = 3, Y = 8 } },
                new Wall() { Position = new Objects.Vector() { X = 3, Y = 9 } },

                new Wall() { Position = new Objects.Vector() { X = 5, Y = 4 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 4 } },
                new Wall() { Position = new Objects.Vector() { X = 7, Y = 4 } },
                new Wall() { Position = new Objects.Vector() { X = 8, Y = 4 } },
                new Wall() { Position = new Objects.Vector() { X = 9, Y = 4 } },

                new Robot() { Position = new Objects.Vector() { X = 9, Y = 9 } },

                new BlueBall() { Position = new Objects.Vector() { X = 9, Y = 0 } },
            };
        }
    }
}
