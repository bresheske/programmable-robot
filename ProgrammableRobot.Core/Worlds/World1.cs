using ProgrammableRobot.Core.Actors;
using System;
using System.Collections.Generic;
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
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 0 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 3 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 4 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 5 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 6 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 7 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 8 } },
                new Wall() { Position = new Objects.Vector() { X = 4, Y = 9 } },

                new Wall() { Position = new Objects.Vector() { X = 6, Y = 0 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 1 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 2 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 3 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 4 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 5 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 6 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 7 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 8 } },
                new Wall() { Position = new Objects.Vector() { X = 6, Y = 9 } },


                new Robot() { Position = new Objects.Vector() { X = 5, Y = 9 } },

                new BlueBall() { Position = new Objects.Vector() { X = 5, Y = 0 } },
            };

        }
    }
}
