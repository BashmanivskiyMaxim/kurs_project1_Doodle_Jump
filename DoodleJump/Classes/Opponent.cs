using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoodleJump.Classes
{
    public class Opponent
    {
        
        Image sprite; 
        public Transform transform_op; 
        public int sizeX;  
        public int sizeY;
        public bool isTouchedByPlayer; 

        public Opponent(PointF pos) 
        {
            sprite = Properties.Resources.pixil_frame_0; 
            sizeX = 90; 
            sizeY = 90;
            transform_op = new Transform(pos, new Size(sizeX, sizeY)); 
            isTouchedByPlayer = false;
        }
        public void DrawSprite(Graphics g) 
        {
            g.DrawImage(sprite, transform_op.position.X, transform_op.position.Y, transform_op.size.Width, transform_op.size.Height);
        }

    }
}
