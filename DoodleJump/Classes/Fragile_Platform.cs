using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump.Classes
{
    public class Fragile_Platform
    {
        Image sprite; 
        Image sprite1 = Properties.Resources.platform_brown_break1;
        public Transform transform; 
        public int sizeX;   
        public int sizeY;
        public bool isTouchedByPlayer; 

        public Fragile_Platform(PointF pos) 
        {
            sprite = Properties.Resources.platform_brown; 
            sizeX = 60; 
            sizeY = 12;
            transform = new Transform(pos, new Size(sizeX, sizeY)); 
            isTouchedByPlayer = false;
        }

        public void DrawSprite(Graphics g) 
        {
            g.DrawImage(sprite, transform.position.X, transform.position.Y, transform.size.Width, transform.size.Height);
        }
        public void DrawSpritebreak(Graphics g) 
        {
            g.DrawImage(sprite1, transform.position.X, transform.position.Y, 72, 20);
        }
    }
}
