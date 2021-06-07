using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace DoodleJump.Classes
{
    public class Physics
    {
        public SoundPlayer simpleSound3 = new SoundPlayer(@"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Sounds\blue.wav");
        public SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Sounds\green.wav");
        public SoundPlayer simpleSound2 = new SoundPlayer(@"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Sounds\brown.wav");   
        public Transform transform; 
        float gravity;
        float a; 

        public float dx; 
        
        public Physics(PointF position, Size size)
        {
            transform = new Transform(position, size);
            gravity = 0;
            a = 0.4f; 
            dx = 0;
        }

        public void ApplyPhysics()
        {
            CalculatePhysics();
        }

        public void CalculatePhysics()
        {
            if (dx != 0)
            {
                transform.position.X += dx;
            }
            if(transform.position.Y < 700)
            {
                transform.position.Y += gravity;
                gravity += a;

                Collide();
            }
        }

        public void Collide()
        {
            for (int i = 0; i < PlatformController.platforms.Count; i++)
            {
                var platform = PlatformController.platforms[i];
                if (transform.position.X + transform.size.Width / 2 >= platform.transform.position.X && transform.position.X + transform.size.Width / 2 <= platform.transform.position.X + platform.transform.size.Width) 
                {
                    if (transform.position.Y + transform.size.Height >= platform.transform.position.Y && transform.position.Y + transform.size.Height <= platform.transform.position.Y + platform.transform.size.Height) 
                    {
                        if (gravity > 0) 
                        {
                            AddForce();
                           
                            simpleSound1.Play();
                            if (!platform.isTouchedByPlayer)
                            {
                                PlatformController.score += 20;
                                PlatformController.GenerateRandomPlatform();
                                platform.isTouchedByPlayer = true;
                            }
                        }
                    }
                }
            }
                for (int i = 0; i < PlatformController.platforms1.Count; i++)
                {
                    var platform_fragile = PlatformController.platforms1[i];
                    if (transform.position.X + transform.size.Width / 2 >= platform_fragile.transform.position.X && transform.position.X + transform.size.Width / 2 <= platform_fragile.transform.position.X + platform_fragile.transform.size.Width) 
                    {
                        if (transform.position.Y + transform.size.Height >= platform_fragile.transform.position.Y && transform.position.Y + transform.size.Height <= platform_fragile.transform.position.Y + platform_fragile.transform.size.Height) 
                        {
                            if (gravity > 0) 
                            {
                            simpleSound2.Play();
                            AddForce();
                                if (!platform_fragile.isTouchedByPlayer)
                                {
                                    
                                    PlatformController.score += 10;
                                    PlatformController.GenerateRandomPlatform();
                                    platform_fragile.isTouchedByPlayer = true;
                                    
                                    
                                }
                            }
                        }
                    }
                }
            for (int i = 0; i < PlatformController.platforms2.Count; i++)
            {
                var platform_speed = PlatformController.platforms2[i];
                if (transform.position.X + transform.size.Width / 2 >= platform_speed.transform.position.X && transform.position.X + transform.size.Width / 2 <= platform_speed.transform.position.X + platform_speed.transform.size.Width) 
                {
                    if (transform.position.Y + transform.size.Height >= platform_speed.transform.position.Y && transform.position.Y + transform.size.Height <= platform_speed.transform.position.Y + platform_speed.transform.size.Height) 
                    {
                        if (gravity > 0)
                        {
                            AddForce_speed_up();
                            simpleSound3.Play();
                            if (!platform_speed.isTouchedByPlayer) 
                            {
                                PlatformController.score += 30;
                                PlatformController.GenerateRandomPlatform();
                                platform_speed.isTouchedByPlayer = true;
                                PlatformController.GenerateRandomEnemy();
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < PlatformController.enemy.Count; i++)
            {
                var enemy = PlatformController.enemy[i];
                if (transform.position.X + transform.size.Width/2 >= enemy.transform_op.position.X && transform.position.X + transform.size.Width / 2 <= enemy.transform_op.position.X + enemy.transform_op.size.Width) 
                {
                    if (transform.position.Y + transform.size.Height >= enemy.transform_op.position.Y && transform.position.Y + transform.size.Height <= enemy.transform_op.position.Y + enemy.transform_op.size.Height) 
                    {                                                   
                                AddForce_touch_op();                                                                                                                                       
                    }
                }
            }
        }
        public void ExitLimit()
        {
            Form1 Q = new Form1();
            if (transform.position.X > Q.Width-30)
            {
                transform.position.X = 0;
            }
            if (transform.position.X < 0)
            {
                transform.position.X = Q.Width-30;
            }
        }
        public void AddForce()
        {
            gravity = -10;
        }
        
        public void AddForce_speed_up()
        {
            gravity = -18;
        }
        public void AddForce_touch_op()
        {
            gravity = 10;
        }
    }
}
