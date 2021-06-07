using DoodleJump.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace DoodleJump
{
    public partial class Form1 : Form
    {       
        Player player;
        Timer timer1;       
        public Form1()
        {
            InitializeComponent();
            Heightrecords mass = new Heightrecords();          
            Array.Copy(mass.ReadKatalog(), task1 , 10);
            for (int i = 0; i < 10; i++) listBoxRecords.Items.Add(task1[i]);           
            BackgroundImage = Properties.Resources.sky;
            PlayGame.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;            
            Height = 850;
            Width = 500;
            KeyPreview = true;        
        }
        public int[] task1 = new int[10];
        public void Init()
        {
            Form1 Q = new Form1();
            PlatformController.platforms = new List<Platform>();
            PlatformController.platforms1 = new List<Fragile_Platform>();
            PlatformController.platforms2 = new List<Speed_Platform>();
            PlatformController.enemy = new List<Opponent>();
            PlatformController.AddPlatform(new PointF(Q.Width/2, 400));
            PlatformController.startPlatformPosY = 400; 
            PlatformController.startEnemyPosY = 300;            
            Heightrecords hscore = new Heightrecords(PlatformController.score);
            PlatformController.score = 0;                      
            PlatformController.GenerateStartSequence();
            player = new Player();
            flag = false;
        }

        private void OnKeyboardUp(object sender,KeyEventArgs e) 
        {
            player.physics.dx = 0;            
        }
        private void Back(object sender, KeyEventArgs e) 
        {
            if(e.KeyCode == Keys.Escape) Application.Restart();           
        }
        private void OnKeyboardPressed(object sender,KeyEventArgs e) 
        {            
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    player.physics.dx = 6; 
                    break;
                case "Left":
                    player.physics.dx = -6;
                    break;
                case "Down":
                    timer1.Stop();
                    break;
                case "Up":
                    timer1.Start();
                    break;
               
            }
        }      
        private void Update(object sender,EventArgs e)
        {            
            Score.Text = $"{PlatformController.score}";
           
            if (player.physics.transform.position.Y >= PlatformController.platforms[0].transform.position.Y + 200) 
            {
                BackgroundImage = Properties.Resources.sky;                                
                Init();               
            }
            player.physics.ApplyPhysics();
            player.physics.ExitLimit();
            FollowPlayer();
            Invalidate();
        }
        bool flag = false;
        public void FollowPlayer()
        {
            
            if(!flag && PlatformController.score >= 250)
            {
                BackgroundImage = Properties.Resources.kosmos;               
                flag = true;
            }                 
            int offset = 400 - (int)player.physics.transform.position.Y;
            player.physics.transform.position.Y += offset;

            for(int i = 0; i < PlatformController.platforms.Count; i++)
            {
                var platform = PlatformController.platforms[i];
                platform.transform.position.Y += offset;
            }
            for (int i = 0; i < PlatformController.platforms1.Count; i++)
            {
                var platform = PlatformController.platforms1[i];
                platform.transform.position.Y += offset;
            }
            for (int i = 0; i < PlatformController.platforms2.Count; i++)
            {
                var platform = PlatformController.platforms2[i];
                platform.transform.position.Y += offset;
            }
            for (int i = 0; i < PlatformController.enemy.Count; i++)
            {
                var opponent = PlatformController.enemy[i];
                opponent.transform_op.position.Y += offset;
            }
        }

        private void OnRepaint(object sender, PaintEventArgs e) 
        {
            

            Graphics g = e.Graphics;
            if (PlatformController.platforms.Count > 0)
            {
                for (int i = 0; i < PlatformController.platforms.Count; i++) PlatformController.platforms[i].DrawSprite(g);         
            }

            if (PlatformController.platforms2.Count > 0)
            {
                for (int i = 0; i < PlatformController.platforms2.Count; i++) PlatformController.platforms2[i].DrawSprite(g);
            }
            
            if (PlatformController.platforms1.Count > 0)
            {
                for (int i = 0; i < PlatformController.platforms1.Count; i++)
                {
                    PlatformController.platforms1[i].DrawSprite(g);
                    if(PlatformController.platforms1[i].isTouchedByPlayer == true)
                    {
                        PlatformController.platforms1[i].DrawSpritebreak(g);                       
                        PlatformController.platforms1.RemoveAt(i);                        
                    }
                }
                         
            }
            if (PlatformController.enemy.Count > 0)
            {
                for (int i = 0; i < PlatformController.enemy.Count; i++) PlatformController.enemy[i].DrawSprite(g);
            }
            player.DrawSprite(g);           
        }       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PlayGame_Click(object sender, EventArgs e)
        {
            Init();
            timer1 = new Timer();
            timer1.Interval = 15;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();
            KeyDown += new KeyEventHandler(OnKeyboardPressed);
            KeyUp += new KeyEventHandler(OnKeyboardUp);
            KeyDown += new KeyEventHandler(Back);
            BackgroundImage = Properties.Resources.sky;
            Height = 850;
            Width = 500;
            Paint += new PaintEventHandler(OnRepaint);
            PlayGame.Visible = false;
            label1.Visible = false;
            Resetrecords.Visible = false;
            Score.Visible = true;
            listBoxRecords.Visible = false;
            Rec.Visible = false;
            labelContr.Visible = false;
            Score.BackColor = Color.Transparent;            
        }

        private void Resetrecords_Click(object sender, EventArgs e)
        {
            Heightrecords k = new Heightrecords();
            k.AddnewPlayer();
            Application.Restart();
        }
    }
}
