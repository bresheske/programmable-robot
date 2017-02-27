using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Actors
{
    public class BlueBall : BaseActor
    {
        public override void Render(Graphics g)
        {
            var point = ProjectPoint(new Objects.Vector()
            {
                X = 15,
                Y = 15
            });
            g.FillEllipse(Brushes.Blue, point.X, point.Y, 20, 20);
        }
    }
}
