using ProgrammableRobot.Core.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Actors
{
    public abstract class BaseActor
    {
        public Vector Position { get; set; }

        public abstract void Render(Graphics g);

        public Vector ProjectPoint(Vector pos)
        {
            var vect = new Vector()
            {
                X = (Position.X * 50) + pos.X,
                Y = (Position.Y * 50) + pos.Y
            };
            return vect;
        }
    }
}
