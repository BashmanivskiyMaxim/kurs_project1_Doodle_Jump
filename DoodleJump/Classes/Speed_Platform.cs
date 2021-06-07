using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump.Classes
{
    public class Speed_Platform
    {

        Image sprite; 
       
        public Transform transform; 
        public int sizeX;   
        public int sizeY;
        public bool isTouchedByPlayer; 

        public Speed_Platform(PointF pos) 
        {
            sprite = Properties.Resources.platform_speed; 
            sizeX = 60;  
            sizeY = 12;
            transform = new Transform(pos, new Size(sizeX, sizeY)); 
            isTouchedByPlayer = false;
        }

        

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(sprite, transform.position.X, transform.position.Y, transform.size.Width, transform.size.Height);
        }
        
    }
}
