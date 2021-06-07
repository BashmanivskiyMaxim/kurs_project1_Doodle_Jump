using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump.Classes
{
    public class Player
    {
        public Physics physics;
        public Image sprite;
        

        public Player()
        {
            Form1 Q = new Form1();
            sprite = Properties.Resources.pepefrog;           
            physics = new Physics(new PointF(Q.Width/2, 350), new Size(60, 60));
        }

        

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(sprite, physics.transform.position.X, physics.transform.position.Y, physics.transform.size.Width, physics.transform.size.Height);
        }
        

        
    }
}
