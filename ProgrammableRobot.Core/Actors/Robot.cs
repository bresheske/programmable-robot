using ProgrammableRobot.Core.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Actors
{
    public class Robot : BaseActor
    {
        public Robot()
        {
            Direction = RobotDirection.Up;
        }

        public enum RobotDirection
        {
            Up,
            Down,
            Left,
            Right
        };

        public RobotDirection Direction { get; set; }

        public void MoveForward()
        {
            
        }

        public void RotateLeft()
        {
            var dirs = new List<RobotDirection>()
            {
                RobotDirection.Up,
                RobotDirection.Right,
                RobotDirection.Down,
                RobotDirection.Left
            };
            var curindex = dirs.IndexOf(Direction);
            var newindex = 0;
            if (curindex == 0)
                newindex = 3;
            else
                newindex = curindex - 1;
            Direction = dirs[newindex];
        }

        public void RotateRight()
        {
            var dirs = new List<RobotDirection>()
            {
                RobotDirection.Up,
                RobotDirection.Right,
                RobotDirection.Down,
                RobotDirection.Left
            };
            var curindex = dirs.IndexOf(Direction);
            var newindex = 0;
            if (curindex == 3)
                newindex = 0;
            else
                newindex = curindex + 1;
            Direction = dirs[newindex];
        }



        public override void Render(Graphics g)
        {
            var bitmap = new Bitmap(50, 50);
            var graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(Pens.Blue, 25, 10, 25, 40);
            graphics.DrawLine(Pens.Blue, 25, 10, 20, 15);
            graphics.DrawLine(Pens.Blue, 25, 10, 30, 15);

            bitmap.RotateFlip(
                Direction == RobotDirection.Up ? RotateFlipType.RotateNoneFlipNone
                : Direction == RobotDirection.Left ? RotateFlipType.Rotate270FlipNone
                : Direction == RobotDirection.Down ? RotateFlipType.Rotate180FlipNone
                : RotateFlipType.Rotate90FlipNone);

            var point = ProjectPoint(new Vector() { X = 0, Y = 0 });
            g.DrawImage(bitmap, new Point(point.X, point.Y));
            graphics.Dispose();
            bitmap.Dispose();
        }
    }
}
