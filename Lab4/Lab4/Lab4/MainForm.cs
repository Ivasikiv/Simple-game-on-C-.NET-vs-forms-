using Lab4.Classes;

namespace Lab4 {
    public partial class MainForm : Form {
        enum PlanetNames {
            Mars, HumuAnt, Catalina, Graylien, Stellaria, Celestrix,
            Elysium, Astra, Fornax, Lepus
        }

        public Dictionary<string, int> upgrades = new Dictionary<string, int> {
            {"Power", 0},
            {"Protection", 0},
            {"Crit", 0}
        };

        public Dictionary<string, int> prices = new Dictionary<string, int> {
            {"Power", 250},
            {"Protection", 250},
            {"Crit", 250}
        };

        public int[] priceForEachNextArtifact = new int[50];

        static SpaceShip spaceShip;
        PlanetShape colonialPlanet = new ColonialPlanet();
        PlanetShape militaryPlanet = new MilitaryPlanet();

        static public int coins = 1000;
        static public int artifacts = 0;

        public MainForm() {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBoxCoin.BackColor = Color.Transparent;
            pictureBoxArtifact.BackColor = Color.Transparent;

            labelCoins.BackColor = Color.Transparent;
            labelArtifacts.BackColor = Color.Transparent;


            // перевірка чи працює сінглтон
            spaceShip = SpaceShip.Instance;
            SpaceShip spaceShip2 = SpaceShip.Instance;

            if (spaceShip == spaceShip2) {
                //MessageBox.Show("Singleton працює!!!!", "Singleton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        internal SpaceShip GetSpaceShip() {
            return spaceShip;
        }

        static public void AddCoins(int coinsAmount) {
            coins += coinsAmount;
            //labelCoins.Text = coins.ToString();
        }

        static public void AddArtifacts(int artifactsAmount) {
            artifacts += artifactsAmount;
            //labelArtifacts.Text = this.artifacts.ToString();
        }

        static public bool RemoveCoins(int coinsAmount) {
            if (coins - coinsAmount >= 0) {
                coins -= coinsAmount;
                //labelCoins.Text = coins.ToString();
                return true;
            }
            return false;
        }

        static public bool RemoveArtifacts(int artifactsAmount) {
            if (artifacts - artifactsAmount >= 0) {
                artifacts -= artifactsAmount;
                //labelArtifacts.Text = artifacts.ToString();
                return true;
            }
            return false;
        }

        public void UpdateLabels() {
            labelCoins.Text = coins.ToString();
            labelArtifacts.Text = artifacts.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            PlanetShape colonyPlanetClone = colonialPlanet.Clone();
            colonyPlanetClone.Name = PlanetNames.Catalina.ToString();

            FormPlanets.planetName = colonyPlanetClone.Name;

            colonyPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", (uint)new Random().Next(1, 5) },
                { "shipProtection", (uint)new Random().Next(1, 5) },
                { "shipCriticalHitProbability", (uint)new Random().Next(1, 5) }
            };
            colonyPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = colonyPlanetClone.PopulatePirates();
            colonyPlanetClone.pirates = array.ToList();

            MessageBox.Show(colonyPlanetClone.GetInfo(), "Інформація про планету", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Application.OpenForms.OfType<FormPlanets>().Any()) {
                Application.OpenForms.OfType<FormPlanets>().First().Activate();
            } else {
                FormPlanets formPlanets = new FormPlanets(colonyPlanetClone);
                formPlanets.Show();
                formPlanets.FormClosed += (s, args) => {
                    UpdateLabels();
                };
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            PlanetShape militaryPlanetClone = militaryPlanet.Clone();
            militaryPlanetClone.Name = PlanetNames.Astra.ToString();

            FormPlanets.planetName = militaryPlanetClone.Name;

            militaryPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", (uint)new Random().Next(1, 5) },
                { "shipProtection", (uint)new Random().Next(1, 5) },
                { "shipCriticalHitProbability", (uint)new Random().Next(1, 5) }
            };
            militaryPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = militaryPlanetClone.PopulatePirates();
            militaryPlanetClone.pirates = array.ToList();

            MessageBox.Show(militaryPlanetClone.GetInfo(), "Інформація про планету", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Application.OpenForms.OfType<FormPlanets>().Any()) {
                Application.OpenForms.OfType<FormPlanets>().First().Activate();
            } else {
                FormPlanets formPlanets = new FormPlanets(militaryPlanetClone);
                formPlanets.Show();
                formPlanets.FormClosed += (s, args) => {
                    UpdateLabels();
                };
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            PlanetShape colonyPlanetClone = colonialPlanet.Clone();
            colonyPlanetClone.Name = PlanetNames.Celestrix.ToString();

            FormPlanets.planetName = colonyPlanetClone.Name;

            colonyPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", (uint)new Random().Next(1, 5) },
                { "shipProtection", (uint)new Random().Next(1, 5) },
                { "shipCriticalHitProbability", (uint)new Random().Next(1, 5) }
            };
            colonyPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = colonyPlanetClone.PopulatePirates();
            colonyPlanetClone.pirates = array.ToList();

            MessageBox.Show(colonyPlanetClone.GetInfo(), "Інформація про планету", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Application.OpenForms.OfType<FormPlanets>().Any()) {
                Application.OpenForms.OfType<FormPlanets>().First().Activate();
            } else {
                FormPlanets formPlanets = new FormPlanets(colonyPlanetClone);
                formPlanets.Show();
                formPlanets.FormClosed += (s, args) => {
                    UpdateLabels();
                };
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            PlanetShape colonyPlanetClone = colonialPlanet.Clone();
            colonyPlanetClone.Name = PlanetNames.HumuAnt.ToString();

            FormPlanets.planetName = colonyPlanetClone.Name;

            colonyPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", (uint)new Random().Next(1, 5) },
                { "shipProtection", (uint)new Random().Next(1, 5) },
                { "shipCriticalHitProbability", (uint)new Random().Next(1, 5) }
            };
            colonyPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = colonyPlanetClone.PopulatePirates();
            colonyPlanetClone.pirates = array.ToList();
            MessageBox.Show(colonyPlanetClone.GetInfo(), "Інформація про планету", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Application.OpenForms.OfType<FormPlanets>().Any()) {
                Application.OpenForms.OfType<FormPlanets>().First().Activate();
            } else {
                FormPlanets formPlanets = new FormPlanets(colonyPlanetClone);
                formPlanets.Show();
                formPlanets.FormClosed += (s, args) => {
                    UpdateLabels();
                };
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) {
            PlanetShape militaryPlanetClone = militaryPlanet.Clone();
            militaryPlanetClone.Name = PlanetNames.Elysium.ToString();

            FormPlanets.planetName = militaryPlanetClone.Name;

            militaryPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", (uint)new Random().Next(1, 5) },
                { "shipProtection", (uint)new Random().Next(1, 5) },
                { "shipCriticalHitProbability", (uint)new Random().Next(1, 5) }
            };
            militaryPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = militaryPlanetClone.PopulatePirates();
            militaryPlanetClone.pirates = array.ToList();

            MessageBox.Show(militaryPlanetClone.GetInfo(), "Інформація про планету", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Application.OpenForms.OfType<FormPlanets>().Any()) {
                Application.OpenForms.OfType<FormPlanets>().First().Activate();
            } else {
                FormPlanets formPlanets = new FormPlanets(militaryPlanetClone);
                formPlanets.Show();
                formPlanets.FormClosed += (s, args) => {
                    UpdateLabels();
                };
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            FormTrader formTrader = new FormTrader(this);
            formTrader.Show();
            formTrader.FormClosed += (s, args) => {
                UpdateLabels();
            };
        }
    }
}