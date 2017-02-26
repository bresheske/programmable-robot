using ProgrammableRobot.Core.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Actors
{
    public class Wall : BaseActor
    {
        public override void Render(Graphics g)
        {
            var zero = new Vector()
            {
                X = 0,
                Y = 0
            };
            zero = ProjectPoint(zero);
            g.FillRectangle(Brushes.Black, zero.X, zero.Y, 50, 50);
        }
    }
}