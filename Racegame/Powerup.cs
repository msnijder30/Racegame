﻿using RaceGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racegame {

    public enum PowerupItem {Banana, Mushroom, Shell };

    class Powerup {

        private int X;
        private int Y;
        private Game game;
        private static Random rand;
        private int CurrentImage = 1;
        private static Dictionary<int, Image> ImageSequence = new Dictionary<int, Image>();
        private static Image Banana, Mushroom, Shell;
        private PictureBox pb;

        public Powerup(Game g, int X, int Y) {
            this.game = game;
            this.X = X;
            this.Y = Y;
            rand = new Random();
            pb = new PictureBox();
            pb.Width = 42;
            pb.Height = 42;
            pb.BackColor = Color.Transparent;
            pb.Location = new Point(X, Y);
            g.form.Controls.Add(pb);

            for(int i = 1; i <= 8; i++) {
                ImageSequence.Add(i, Image.FromFile(Path.Combine(Environment.CurrentDirectory, "powerup/Box" + i + ".png")));
            }
            
            Mushroom = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "powerup/MushroomIcon.png"));
            Banana = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "powerup/BananaIcon.png"));
            Shell = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "powerup/ShellIcon.png"));

            /*
                            Bitmap toReturn = new Bitmap(Width, Width);

                            Image img = Image.FromFile(Path.Combine(Environment.CurrentDirectory, getCharacterUrl(this.Character, getImageNumber(Angle))));
                g.DrawImage(img, new Rectangle(new Point(0, 0), new Size(Width, Height)));
                */
        }

        public void Rotate() {
            Thread t = new Thread(() => {
                while(true) {
                    Console.WriteLine(CurrentImage);
                    Bitmap image = new Bitmap(42, 42);
                    Graphics g = Graphics.FromImage(image);
                    g.DrawImage(ImageSequence[CurrentImage], new Rectangle(new Point(0, 0), new Size(42, 42)));
                    pb.Image = image;
                    g.Dispose();
                    if(CurrentImage < 8) {
                        CurrentImage++;
                    } else {
                        CurrentImage = 1;
                    }   
                    Thread.Sleep(100);
                }
            });
            t.IsBackground = true;
            t.Start();
               
        }

        public async void SpinItemBox(Player p) {
            Console.WriteLine("tete");
            PowerupItem current = PowerupItem.Banana;
            for(int i = 0; i < 30; i++) {
                switch(rand.Next(3)) {
                    case 0:
                        p.ItemFrame.Image = Banana;
                        current = PowerupItem.Banana;
                        break;

                    case 1:
                        p.ItemFrame.Image = Mushroom;
                        current = PowerupItem.Mushroom;
                        break;

                    case 2:
                        p.ItemFrame.Image = Shell;
                        current = PowerupItem.Shell;
                        break;
                }
                Console.WriteLine("WEWEW");
                await Wait();
            }

        }
        
        public void Collision(Player p) {
            game.CheckCollision(p, pb);
        }

        private async Task Wait() {
            await Task.Delay(500);
        }


    }
}