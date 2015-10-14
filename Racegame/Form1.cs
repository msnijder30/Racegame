﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;
using RaceGame;

namespace Racegame
{
    public partial class Racegame : Form
    {

        public bool CheckpointPassed = false;
        Image Banana = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Banana.png"));
        Image Mushroom = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Mushroom.png"));
        Image Fuel = new Bitmap(Path.Combine(Environment.CurrentDirectory, "fuel.png"));
        public float angle = 0;
        public bool isLoaded = false;
        Graphics g;
        Player p1;
        Player p2;

        public Racegame()
        {
            InitializeComponent();
            GameTimer.Enabled = true;
            //        Player(Graphics g, System.Drawing.Color color, Keys up, Keys down, Keys right, Keys left, int x, int y, int width, int height) {
            g = this.CreateGraphics();
            p2 = new Player(g, null, Keys.Up, Keys.Down, Keys.Right, Keys.Left, Keys.RShiftKey, 600, 400, 64, 64);
            p1 = new Player(g, null, Keys.W, Keys.S, Keys.D, Keys.A, Keys.LShiftKey, 200, 500, 64, 64);

            //this.KeyDown += p1.ControlHandler;
            this.KeyDown += p2.ControlDownHandler;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(p2.ControlUpHandler);
            
            this.KeyDown += p1.ControlDownHandler;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(p1.ControlUpHandler);

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            FuelHandler();
            BorderHandler();
            p2.Move(this);
            p1.Move(this);
            CollisionHandler();
            ItemHandler();
            SpeedMeter();
            Checkpointhandler();
            RondeTeller();
            PlayerCollision();
        }

        public void Draw(Graphics g) {
            
            
            //FuelHandler();
            //Auto.Location = new Point(Auto.Location.X + speedX, Auto.Location.Y + speedY);
        }
        public void FuelHandler()
        {
            Fueling(p1, FuelBox, HealthBox);
            Fueling(p2, FuelBox2, HealthBox1);
        }

        public void Fueling(Player a, PictureBox b, PictureBox c)
        {
            a.Fuel -= Math.Abs(Convert.ToInt16(a.Speed));
            Size fuelboxsize = new Size(a.Fuel / 250 * 10, 10);
            b.Size = fuelboxsize;
            Size healthboxsize = new Size(a.Health * 4 , 10);
            c.Size = healthboxsize;

            if (a.Fuel <= 0)
            {
                a.Speed = 0;
            }
        }

        public void BorderHandler()
        {
            Borders(p1);
            Borders(p2);
        }

        public void Borders(Player a)
        {
            if (a.X >= ClientSize.Width - p1.Width && a.SpeedX >= 0)
            {
                a.Health -= Math.Abs(Convert.ToInt16(a.Speed));
                a.Speed = 0;
                a.X -= 10;
            }
            if (a.X <= 0)
            {
                a.Health -= Math.Abs(Convert.ToInt16(a.Speed));
                a.Speed = 0;
                a.X += 10;
            }
            if (a.Y >= ClientSize.Height - 2 * a.Height && a.SpeedY >= 0)
            {
                a.Health -= Math.Abs(Convert.ToInt16(a.Speed));
                a.Speed = 0;
                a.Y -= 10;
            }
            if (a.Y <= 0)
            {
                a.Health -= Math.Abs(Convert.ToInt16(a.Speed));
                a.Speed = 0;
                a.Y += 10;
            }

            if (a.Health <= 0)
            {
                a.Speed = 0;
            }
        }

        private void Racegame_Paint(object sender, PaintEventArgs e) {
            p1.DrawPlayer(e.Graphics);
            e.Graphics.ResetTransform();
            p2.DrawPlayer(e.Graphics);
            e.Graphics.ResetTransform();

            //e.Graphics.Dispose();
        }

        public void CollisionHandler()
        {
            CheckCollision(p1, Groen);
            CheckCollision(p2, Groen);
        }

        public void CheckCollision(Player a, PictureBox b)
        {
            ///Moet nog even naar gekeken worden want dit moet er wel zijn!
            if (a.X + a.MaxSize >= b.Location.X &&
                a.X <= b.Location.X + b.Size.Width &&
                a.Y + a.MaxSize >= b.Location.Y &&
                a.Y <= b.Location.Y + b.Size.Height)
            {
                a.Speed = 0;
                a.Speed = 0; 
            }
        }

        public void ItemHandler()
        {
            CheckItems(p1, ItemBox);
            CheckItems(p2, ItemBox);
        }

        public void CheckItems(Player a, PictureBox b)          
        {
            ///Moet nog even naar gekeken worden want dit moet er wel zijn!

            if (a.X + a.Width >= b.Location.X &&
                a.X <= b.Location.X + b.Size.Width &&
                a.Y + a.Height >= b.Location.Y &&
                a.Y <= b.Location.Y + b.Size.Height &&
                b.Visible == true)
            {
                b.Visible = false;
                GetItem();
                boost(a);   
                RespawnHandler();
            }
        }

        public async void GetItem()
        {
            Random rand = new Random();
            int number = rand.Next(4);
            ItemFrame.Visible = true;
            for (int i = 0; i < 30; i++)
            {
                if(number == 0)
                {
                    ItemFrame.Image = Banana;
                }
                if(number == 1)
                {
                    ItemFrame.Image = Mushroom;
                }
                if(number == 2)
                {
                    ItemFrame.Image = Fuel;
                }
                number = rand.Next(3);
                await WaitMethod3();
            }
            

        }

        public void RespawnHandler()
        {
            if(ItemBox.Visible == false)
            {
                RespawnItems(ItemBox);
            }
        }
        
        public async void RespawnItems(PictureBox b)
        {
                await WaitMethod();
                b.Visible = true;
        }

        public async void boost(Player a)
        {
            if (a == p1)
            {
                Fueladder.Enabled = true;
            }
            else
            {
                Fueladder2.Enabled = true;
            }
            a.Speed = 20;
            a.MaxSpeed *= 2;
            await WaitMethod2();
            a.Speed = 14;
            a.MaxSpeed /= 2;
            if(a == p1)
            {
                Fueladder.Enabled = false;
            }
            else
            {
                Fueladder2.Enabled = false;
            }
        }

        async System.Threading.Tasks.Task WaitMethod()
        {
            await System.Threading.Tasks.Task.Delay(10000);
        }
        async System.Threading.Tasks.Task WaitMethod2()
        {
            await System.Threading.Tasks.Task.Delay(2000);
        }
        async System.Threading.Tasks.Task WaitMethod3()
        {
            await System.Threading.Tasks.Task.Delay(50);
        }

        public void SpeedMeter()
        {
            Speed(p1, Speed1);
            Speed(p2, Speed2);
        }

        public void Speed(Player a, Label b)
        {
            double speed = Math.Sqrt(Math.Pow(a.SpeedX, 2) + Math.Pow(a.SpeedY, 2));

            b.Text = "Speed: " + Math.Round(speed, 0);
        }

        public bool Checkpoints(Player a, PictureBox b)
        {
            ///Moet nog even naar gekeken worden want dit moet er wel zijn!

            if (a.X + a.Width >= b.Location.X &&
                a.X <= b.Location.X + b.Size.Width &&
                a.Y + a.Height >= b.Location.Y &&
                a.Y <= b.Location.Y + b.Size.Height &&
                a.CheckpointPassed == false)
            {
                a.CheckpointPassed = true;
            }
            return a.CheckpointPassed;

        }

        public void Checkpointhandler()
        {
            p1.CheckpointPassed = Checkpoints(p1, Checkpoint);
            p2.CheckpointPassed = Checkpoints(p2, Checkpoint);
        }

        public void RondeTeller()
        {
            p1.CheckpointPassed = Rondes(p1, Ronde1);
            p2.CheckpointPassed = Rondes(p2, Ronde2);
        }

        public bool Rondes(Player a, Label b)
        {
            {
                ///Moet nog even naar gekeken worden want dit moet er wel zijn!

                if (a.X + a.Width >= Finish.Location.X &&
                a.X <= Finish.Location.X + Finish.Size.Width &&
                a.Y + a.Height >= Finish.Location.Y &&
                a.Y <= Finish.Location.Y + Finish.Size.Height &&
                a.CheckpointPassed == true)
                {
                    a.laps = a.laps + 1;
                    a.CheckpointPassed = false;
                }

                b.Text = "Lap: " + a.laps;

                if (a.laps >= 4)
                {
                    a.Speed = 0;
                    b.Text = "Race complete.";
                }
                return a.CheckpointPassed;

            }

        }

        private void Fueladder_Tick(object sender, EventArgs e)
        {
            p1.Fuel += Convert.ToInt16(p1.Speed);
        }
        private void Fueladder2_Tick(object sender, EventArgs e)
        {
            p2.Fuel += Convert.ToInt16(p2.Speed);
        }


        public void PlayerCollision()
        {
            if (p1.X + p1.MaxSize -18 >= p2.X + 18 &&
       p1.X + 18 <= p2.X + p2.Width -18 &&
       p1.Y + p1.MaxSize - 18>= p2.Y + 18 &&
       p1.Y + 18 <= p2.Y + p2.Height - 18)
            {
                p1.Health -= Convert.ToInt16(p1.Speed + p2.Speed);
                p2.Health -= Convert.ToInt16(p1.Speed + p2.Speed);
                p1.Speed = 0;
                p2.Speed = 0;
            }


        }

        }
    
    }


