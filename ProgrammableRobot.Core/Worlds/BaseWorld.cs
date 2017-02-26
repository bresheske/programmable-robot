using ProgrammableRobot.Core.Actors;
using ProgrammableRobot.Core.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableRobot.Core.Worlds
{
    public abstract class BaseWorld
    {
        public List<BaseActor> Actors { get; set; }
        
        public Bitmap Render()
        {
            var bitmap = new Bitmap(501, 501);
            var graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.White, 0, 0, 500, 500);
            
            // First the gridlines.
            for(int x = 0; x <= bitmap.Width; x += 50)
                graphics.DrawLine(Pens.Gray, x, 0, x, 500);
            for (int y = 0; y <= bitmap.Width; y += 50)
                graphics.DrawLine(Pens.Gray, 0, y, 500, y);

            // Now the actors.
            foreach (var a in Actors)
            {
                a.Render(graphics);
            }
            graphics.Dispose();
            return bitmap;
        }

    }
}
