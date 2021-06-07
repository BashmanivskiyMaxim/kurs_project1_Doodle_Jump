using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoodleJump.Classes
{
    
     public static class PlatformController
     {        
        public static List<Platform> platforms;
        public static List<Fragile_Platform> platforms1;
        public static List<Speed_Platform> platforms2;
        public static List<Opponent> enemy;
        public static int startPlatformPosY = 400; 
        public static int startEnemyPosY = 300;
        public static int score = 0;
        public static void AddPlatform(PointF position)
        {
            Platform platform = new Platform(position);    
            platforms.Add(platform);            
        }
        public static void GenerateRandomEnemy() 
        {            
            Form1 Q = new Form1();           
            Random f = new Random();
            int x = f.Next(0, Q.Size.Width - 40);            
            PointF position = new PointF(x, startEnemyPosY);            
            Opponent opon = new Opponent(position);         
            enemy.Add(opon);           
        }
        public static void GenerateStartSequence() 
        {
            Platform pl = new Platform();
            Form1 Q = new Form1();
            Random r = new Random();
            for(int i = 0; i < 15; i++)
            {
                int x = r.Next(0, Q.Size.Width- pl.sizeX); 
                int y = r.Next(30, 40); 
                int y_en = r.Next(80, 90);
                startPlatformPosY -= y; 
                startEnemyPosY -= y_en;
                PointF position = new PointF(x, startPlatformPosY); 
                Platform platform = new Platform(position);
                platforms.Add(platform);
            }
        }

        public static void GenerateRandomPlatform() 
        {
            Platform pl = new Platform();
            Form1 Q = new Form1();
            ClearPlatforms();
            Random f = new Random();
            int x = f.Next(0 , Q.Size.Width - pl.sizeX);
            
            int xB = f.Next(0, Q.Size.Width - pl.sizeX);
            int yB = f.Next(startPlatformPosY - 80, startPlatformPosY + 80);

            PointF position = new PointF(x, startPlatformPosY);
            
            PointF position2 = new PointF(xB, yB);
            PointF position3 = new PointF(f.Next(0 , Q.Size.Width- pl.sizeX), startPlatformPosY-50);

            Platform platform = new Platform(position);
           
            Fragile_Platform platform2 = new Fragile_Platform(position2);
            Speed_Platform platform3 = new Speed_Platform(position3);

            platforms.Add(platform);
           
            platforms1.Add(platform2);
            platforms2.Add(platform3);
        }
        public static void ClearPlatforms()
        {
            for(int i = 0; i < platforms.Count; i++) 
            {
                if (platforms[i].transform.position.Y >= 700) platforms.RemoveAt(i);
            }
            for (int i = 0; i < platforms1.Count; i++) 
            {
                if (platforms1[i].transform.position.Y >= 700) platforms1.RemoveAt(i);
            }
            for (int i = 0; i < platforms2.Count; i++) 
            {
                if (platforms2[i].transform.position.Y >= 700) platforms2.RemoveAt(i);
            }
            for (int i = 0; i < enemy.Count; i++) 
            {
                if (enemy[i].transform_op.position.Y >= 700) enemy.RemoveAt(i);
            }
        }
    }
}
