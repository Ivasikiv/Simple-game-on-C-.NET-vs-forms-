﻿using Lab4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Lab4 {
    public partial class FormPlanets : Form {

        private List<(PictureBox pictureBox, int speed, int x, int y)> monsters = new List<(PictureBox pictureBox, int speed, int x, int y)>();
        private List<PictureBox> lasers = new List<PictureBox>();
        private DateTime lastTickTime; // зберігає час останнього таймера Tick

        List<System.Windows.Forms.Timer> laserTimers = new List<System.Windows.Forms.Timer>();


        private int playerSpeed = 10;
        private bool moveLeft, moveRight, moveUp, moveDown;


        public static string planetName;
        private PlanetShape currentPlanet;
        private List<Pirate> characters = new List<Pirate>();

        private Dictionary<string, int> positionsIterators = new Dictionary<string, int> {
            { "Fast Pirate", 0 },
            { "Protected Pirate", 0 },
            { "Strong Pirate", 0 }
        };


        Dictionary<string, string> planetImages = new Dictionary<string, string> {
        { "HumuAnt", "D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\HumuAntBackgraund.jpg"},
        { "Catalina", "D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\CatalinaBackgraund.jpg" },
        { "Celestrix", "D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\CelestrixBackgraund.jpg" },
        { "Elysium", "D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\ElysiumBackgraund.jpg" },
        { "Astra", "D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\AstraBackgraund.jpg" }
        };

        public FormPlanets(PlanetShape planet) {
            InitializeComponent();

            this.Focus();

            currentPlanet = planet;
            characters = currentPlanet.pirates;

            pictureBoxBack.BackColor = Color.Transparent;
            labelBack.BackColor = Color.Transparent;

        }

        private void buttonFight_Click(object sender, EventArgs e) {

        }

        private void FormPlanets_Shown(object sender, EventArgs e) {
            switch (planetName) {
                case "HumuAnt":
                    FormPlanets.ActiveForm.BackgroundImage = System.Drawing.Image.FromFile("D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\HumuAntBackground.jpg");
                    break;
                case "Catalina":
                    FormPlanets.ActiveForm.BackgroundImage = System.Drawing.Image.FromFile("D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\CatalinaBackground.jpg");
                    break;
                case "Celestrix":
                    FormPlanets.ActiveForm.BackgroundImage = System.Drawing.Image.FromFile("D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\CelestrixBackground.jpg");
                    break;
                case "Elysium":
                    FormPlanets.ActiveForm.BackgroundImage = System.Drawing.Image.FromFile("D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\ElysiumBackground.jpg");
                    break;
                case "Astra":
                    FormPlanets.ActiveForm.BackgroundImage = System.Drawing.Image.FromFile("D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\AstraBackground.jpg");
                    break;
                default:
                    break;
            }
            FormPlanets.ActiveForm.BackgroundImageLayout = ImageLayout.Stretch;

            List<Rectangle> existingRectangles = new List<Rectangle>();
            int x = 0, y = 0;

            for (int i = 0; i < currentPlanet.pirates.Count; i++) {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 100);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = System.Drawing.Image.FromFile(characters[i].imagePath);
                pictureBox.Tag = i;
                pictureBox.BackColor = Color.Transparent;

                // Випадкові координати для властивості Location
                Random random = new Random();
                bool intersecting = true;
                while (intersecting) {
                    x = random.Next(this.ClientSize.Width / 2, this.ClientSize.Width - pictureBox.Width);
                    y = random.Next(100, this.ClientSize.Height - pictureBox.Height);
                    Rectangle newRect = new Rectangle(x, y, pictureBox.Width, pictureBox.Height);
                    intersecting = existingRectangles.Any(rect => rect.IntersectsWith(newRect));
                }
                existingRectangles.Add(new Rectangle(x, y, pictureBox.Width, pictureBox.Height));
                pictureBox.Location = new Point(x, y);

                this.Controls.Add(pictureBox);

                int speed = random.Next(1, 5);
                switch (characters[i].Type) {
                    case "Fast Pirate":
                        speed = 10;
                        break;
                    case "Protected Pirate":
                        speed = 3;
                        break;
                    case "Strong Pirate":
                        speed = 6;
                        break;
                }

                var monster = new {
                    pictureBox = pictureBox,
                    speed = 5, // Швидкість руху монстра
                    x = pictureBox.Location.X, // Початкові координати монстра
                    y = pictureBox.Location.Y
                };
                monsters.Add((pictureBox, monster.speed, monster.x, monster.y));
            }

            PictureBox playerPicture = new PictureBox();
            playerPicture.Size = new Size(200, 200);
            playerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            playerPicture.Image = System.Drawing.Image.FromFile("D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\player.png");
            playerPicture.Tag = "player";
            playerPicture.BackColor = Color.Transparent;
            playerPicture.Location = new Point(100, 100);

            // Додайте PictureBox до контейнера Controls форми
            this.Controls.Add(playerPicture);

            // Зробіть PictureBox активним елементом форми
            playerPicture.Select();

            // Додайте обробники подій KeyDown та KeyUp для форми
            //this.KeyDown += new KeyEventHandler(FormPlanets_KeyDown);
            //this.KeyUp += new KeyEventHandler(FormPlanets_KeyUp);



            //foreach (var pictureBox in this.Controls.OfType<PictureBox>()) {
            //}

            // Налаштування таймера
            timer1.Interval = 100; // Кожні 50 мілісекунд будемо оновлювати координати монстрів
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e) {
            List<(PictureBox pictureBox, int speed, int x, int y)> monsterUpdates = new List<(PictureBox pictureBox, int speed, int x, int y)>();
            foreach (var monster in monsters) {
                if (monster == (null, 0, 0, 0)) continue;
                int index = monster.pictureBox.Tag as int? ?? -1; // Якщо перетворення не вдалося, індекс буде -1
                switch (currentPlanet.pirates[index].Type) {
                    case "Fast Pirate":
                        switch (positionsIterators[currentPlanet.pirates[index].Type]) {
                            case 0:
                                if (monster.x < this.ClientSize.Width / 2) {
                                    positionsIterators[currentPlanet.pirates[index].Type] = 1;
                                    monsterUpdates.Add((monster.pictureBox, monster.speed, monster.x, monster.y));
                                    continue;
                                }

                                monsterUpdates.Add((monster.pictureBox, 10, monster.x - 3, monster.y));
                                positionsIterators[currentPlanet.pirates[index].Type]++;
                                break;
                            case 1:
                                // якщо монстр вийде за верхню межу форми, то його потрібно зупинити
                                if (monster.y < 40) {
                                    positionsIterators[currentPlanet.pirates[index].Type] = 2;
                                    monsterUpdates.Add((monster.pictureBox, monster.speed, monster.x, monster.y));
                                    continue;
                                }
                                monsterUpdates.Add((monster.pictureBox, 10, monster.x, monster.y + 3));
                                positionsIterators[currentPlanet.pirates[index].Type]++;
                                break;
                            case 2:
                                // якщо монстр вийде за праву межу форми, то його потрібно зупинити
                                if (monster.x > this.ClientSize.Width - monster.pictureBox.Width) {
                                    positionsIterators[currentPlanet.pirates[index].Type] = 3;
                                    monsterUpdates.Add((monster.pictureBox, monster.speed, monster.x, monster.y));
                                    continue;
                                }
                                monsterUpdates.Add((monster.pictureBox, 10, monster.x + 3, monster.y));
                                positionsIterators[currentPlanet.pirates[index].Type]++;
                                break;
                            case 3:
                                // якщо монстр вийде за нижню межу форми, то його потрібно зупинити
                                if (monster.y - 40 > this.ClientSize.Height - monster.pictureBox.Height) {
                                    positionsIterators[currentPlanet.pirates[index].Type] = 0;
                                    monsterUpdates.Add((monster.pictureBox, monster.speed, monster.x, monster.y));
                                    continue;
                                }
                                if (monster.x < this.ClientSize.Width / 2) {
                                    positionsIterators[currentPlanet.pirates[index].Type] = 0;
                                    monsterUpdates.Add((monster.pictureBox, monster.speed, monster.x, monster.y));
                                    break;
                                }
                                monsterUpdates.Add((monster.pictureBox, 10, monster.x, monster.y - 3));
                                positionsIterators[currentPlanet.pirates[index].Type] = 0;
                                break;
                            default:
                                break;
                        }

                        //monsterUpdates.Add((monster.pictureBox, 10, monster.x - 10, monster.y));

                        break;
                    case "Protected Pirate":
                        /*
                         switch (positionsIterators[currentPlanet.pirates[index].Type]) {
                            case 0:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x - 3, monster.y));
                                break;
                            case 1:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x, monster.y));
                                break;
                            case 2:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x - 3, monster.y));
                                break;
                            case 3:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x, monster.y));
                                break;
                            case 4:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x + 3, monster.y));
                                break;
                            case 5:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x, monster.y));
                                break;
                            case 6:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x + 3, monster.y));
                                break;
                            case 7:
                                monsterUpdates.Add((monster.pictureBox, 3, monster.x, monster.y));
                                break;
                            default:
                                break;
                        }

                        if (positionsIterators[currentPlanet.pirates[index].Type] == 7) {
                            positionsIterators[currentPlanet.pirates[index].Type] = 0;
                        } else {
                            positionsIterators[currentPlanet.pirates[index].Type]++;
                        } */
                        monsterUpdates.Add((monster.pictureBox, 3, monster.x, monster.y));
                        break;
                    case "Strong Pirate":
                        /*
                         switch (positionsIterators[currentPlanet.pirates[index].Type]) {
                            case 0:
                                monsterUpdates.Add((monster.pictureBox, 6, monster.x, monster.y));
                                break;
                            case 1:
                                monsterUpdates.Add((monster.pictureBox, 6, monster.x, monster.y - 6));
                                break;
                            case 2:
                                monsterUpdates.Add((monster.pictureBox, 6, monster.x, monster.y));
                                break;
                            case 3:
                                monsterUpdates.Add((monster.pictureBox, 6, monster.x, monster.y));
                                break;
                            case 4:
                                monsterUpdates.Add((monster.pictureBox, 6, monster.x, monster.y + 6));
                                break;
                            case 5:
                                monsterUpdates.Add((monster.pictureBox, 6, monster.x, monster.y));
                                break;
                            default:
                                break;
                        }

                        if (positionsIterators[currentPlanet.pirates[index].Type] == 5) {
                            positionsIterators[currentPlanet.pirates[index].Type] = 0;
                        } else {
                            positionsIterators[currentPlanet.pirates[index].Type]++;
                        } */
                        monsterUpdates.Add((monster.pictureBox, 6, monster.x, monster.y));
                        break;
                    default:
                        break;
                }
            }

            // Заміна старих значень monster новими значеннями зі списку monsterUpdates
            for (int i = 0; i < monsters.Count; i++) {
                if (monsters[i] == (null, 0, 0, 0)) continue;
                monsters[i] = (monsterUpdates[i].pictureBox, monsters[i].speed, monsterUpdates[i].x, monsterUpdates[i].y);
            }

            // Переміщення монстрів
            foreach (var monster in monsters) {
                if (monster == (null, 0, 0, 0)) continue;
                monster.pictureBox.Location = new Point(monster.x, monster.y);
            }


            if (monsters.Count == 0) {
                Close();
                return;
            }

            // керування гравцем

            // find picturebox by tag "player"
            PictureBox pictureBox = this.Controls.OfType<PictureBox>()
                                      .Where(p => p.Tag.ToString() == "player")
                                      .FirstOrDefault();

            int x = pictureBox.Left;
            int y = pictureBox.Top;
            if (moveLeft) {
                x = Math.Clamp(pictureBox.Left - playerSpeed, 0, this.ClientSize.Width - pictureBox.Width);
            }
            if (moveRight) {
                x = Math.Clamp(pictureBox.Left + playerSpeed, 0, this.ClientSize.Width - pictureBox.Width);
            }
            if (moveUp) {
                y = Math.Clamp(pictureBox.Top - playerSpeed, 0, this.ClientSize.Height - pictureBox.Height);
            }
            if (moveDown) {
                y = Math.Clamp(pictureBox.Top + playerSpeed, 0, this.ClientSize.Height - pictureBox.Height);
            }
            pictureBox.Location = new Point(x, y);


        }

        /*
        private void FormPlanets_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Left:
                    moveLeft = true;
                    MessageBox.Show("OFJGPEWIG");
                    break;
                case Keys.Right:
                    moveRight = true;
                    break;
                case Keys.Up:
                    moveUp = true;
                    break;
                case Keys.Down:
                    moveDown = true;
                    break;
            }
        }

        private void FormPlanets_KeyUp(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Left:
                    moveLeft = false;
                    break;
                case Keys.Right:
                    moveRight = false;
                    break;
                case Keys.Up:
                    moveUp = false;
                    break;
                case Keys.Down:
                    moveDown = false;
                    break;
            }
        }
        */

        private void FormPlanets_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.A:
                    moveLeft = true;
                    break;
                case Keys.D:
                    moveRight = true;
                    break;
                case Keys.W:
                    moveUp = true;
                    break;
                case Keys.S:
                    moveDown = true;
                    break;
                case Keys.Space:
                    PictureBox player = this.Controls.OfType<PictureBox>()
                                      .Where(p => p.Tag.ToString() == "player")
                                      .FirstOrDefault();
                    int laserWidth = 50;
                    int laserHeight = 50;
                    int laserX = player.Right;
                    int laserY = player.Top + (player.Height / 2) - (laserHeight / 2);

                    PictureBox laser = new PictureBox();
                    laser.SizeMode = PictureBoxSizeMode.StretchImage;
                    laser.Image = System.Drawing.Image.FromFile("D:\\Jesus\\MAPZ Labs\\mapz\\Lab4\\Lab4\\Lab4\\images\\laser.png");
                    laser.BackColor = Color.Transparent;
                    laser.Tag = "laser";
                    laser.Size = new Size(laserWidth, laserHeight);
                    laser.Location = new Point(laserX, laserY);

                    this.Controls.Add(laser);
                    lasers.Add(laser);

                    System.Windows.Forms.Timer newLaserTimer = new System.Windows.Forms.Timer();
                    newLaserTimer.Tag = laser;
                    newLaserTimer.Interval = 10;
                    newLaserTimer.Tick += new EventHandler(laserTimer_Tick);
                    newLaserTimer.Start();
                    laserTimers.Add(newLaserTimer);

                    break;
            }
        }

        private void CheckLaserMonsterCollision() {
            for (int i = 0; i < lasers.Count(); i++) {
                PictureBox laser = lasers[i];
                if (laser != null) {
                    for (int j = 0; j < monsters.Count(); j++) {
                        PictureBox monster = monsters[j].pictureBox;
                        if (monster != null && laser.Bounds.IntersectsWith(monster.Bounds)) {
                            this.Controls.Remove(laser);
                            lasers[i] = null;
                            this.Controls.Remove(monster);
                            monsters.RemoveAt(j);
                            //monsters[j] = (null, 0, 0, 0);
                            break; // Вихід з циклу, оскільки індекси лазерів та монстрів змінюються при видаленні
                        }
                    }
                }
            }
        }


        private void laserTimer_Tick(object sender, EventArgs e) {
            // Рух кожного лазеру в масиві
            System.Windows.Forms.Timer laserTimer = (System.Windows.Forms.Timer)sender;

            PictureBox laser = (PictureBox)laserTimer.Tag;

            laser.Left += 10;

            if (laser.Right >= this.ClientSize.Width) {
                this.Controls.Remove(laser);
                laserTimer.Stop();
                laserTimer.Dispose();
            }

            CheckLaserMonsterCollision();

            //// Перевірка на колізію між лазером і монстром
            //foreach (PictureBox monster in monsters.) {
            //    if (monster != null && laser.Bounds.IntersectsWith(monster.Bounds)) {
            //        // Якщо вони перетинаються, лазер і монстр зникають
            //        this.Controls.Remove(laser);
            //        lasers.Remove(laser);
            //        this.Controls.Remove(monster);
            //        monsters.Remove(monster);
            //        break;  // Вихід з циклу, оскільки індекси монстрів змінюються при видаленні
            //    }
            //}
        }


        private void FormPlanets_KeyUp(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.A:
                    moveLeft = false;
                    break;
                case Keys.D:
                    moveRight = false;
                    break;
                case Keys.W:
                    moveUp = false;
                    break;
                case Keys.S:
                    moveDown = false;
                    break;
            }
        }

        private void FormPlanets_Load(object sender, EventArgs e) {
            //this.ActiveControl = this;
        }

        private void FormPlanets_FormClosing(object sender, FormClosingEventArgs e) {
            // зупинити всі таймери 
            foreach (System.Windows.Forms.Timer laserTimer in laserTimers) {
                laserTimer.Stop();
                laserTimer.Dispose();
            }
            timer1.Stop();
            timer1.Dispose();

            //delete all lasers
            foreach (PictureBox laser in lasers) {
                if (laser != null) {
                    this.Controls.Remove(laser);
                }
            }

            if (monsters.Count() > 0) {
                MessageBox.Show("You lose!");
                return;
            } else {
                MessageBox.Show("You win!");
            }

            MainForm.AddCoins((int)currentPlanet.GoldReward);
            MainForm.AddArtifacts((int)currentPlanet.Artifacts);
        }

        private void pictureBoxBack_Click(object sender, EventArgs e) {
            Close();
        }

        private void labelBack_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

//List<Rectangle> existingRectangles = new List<Rectangle>();

//for (int i = 0; i < currentPlanet.pirates.Count; i++) {
//    PictureBox pictureBox = new PictureBox();
//    pictureBox.Size = new Size(100, 100);
//    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
//    pictureBox.Image = System.Drawing.Image.FromFile(characters[i].imagePath);
//    pictureBox.Tag = i;
//    pictureBox.BackColor = Color.Transparent;

//    bool isUnique = false;

//    // Генерувати нові випадкові координати доти, доки не буде знайдено унікальне місце на формі
//    while (!isUnique) {
//        Random random = new Random();
//        int x = random.Next(this.ClientSize.Width / 2, this.ClientSize.Width - pictureBox.Width);
//        int y = random.Next(0, this.ClientSize.Height - pictureBox.Height);

//        // Прямокутник, який займає нове зображення
//        Rectangle newRectangle = new Rectangle(x, y, pictureBox.Width, pictureBox.Height);

//        // Перевір