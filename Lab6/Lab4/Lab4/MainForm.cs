using Lab6.Classes;

namespace Lab6 {
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

        static public int coins = 1000000;
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


            // �������� �� ������ �������
            spaceShip = SpaceShip.Instance;
            SpaceShip spaceShip2 = SpaceShip.Instance;

            if (spaceShip == spaceShip2) {
                //MessageBox.Show("Singleton ������!!!!", "Singleton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // ��������� ��'���� ���������
            PowerObserver powerObserver = new PowerObserver();
            ProtectionObserver protectionObserver = new ProtectionObserver();
            CritObserver critObserver = new CritObserver();

            // ϳ������ �� ��������� ����
            spaceShip.shipPower.Attach(powerObserver);
            spaceShip.shipProtection.Attach(protectionObserver);
            spaceShip.shipCriticalHitProbability.Attach(critObserver);
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

            colonyPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = colonyPlanetClone.PopulatePirates();
            colonyPlanetClone.pirates = array.ToList();

            // ����������� ������� � ��������� �������
            PlanetShape weatherPlanet = new WeatherDecorator(colonyPlanetClone);
            //weatherPlanet.Name = colonyPlanetClone.Name;
            weatherPlanet.WeatherDebuffs = new Dictionary<string, uint> {
                { "Power", (uint)new Random().Next(0, 2) },
                { "Protection", (uint)new Random().Next(0, 3) }
            };

            colonyPlanetClone.WeatherDebuffs = weatherPlanet.WeatherDebuffs;

            MessageBox.Show(weatherPlanet.GetInfo(), "���������� ��� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

            militaryPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = militaryPlanetClone.PopulatePirates();
            militaryPlanetClone.pirates = array.ToList();

            /*essageBox.Show(militaryPlanetClone.GetInfo(), "���������� ��� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);*/


            // ����������� ������� � ��������� �������
            PlanetShape weatherPlanet = new WeatherDecorator(militaryPlanet);
            //weatherPlanet.Name = militaryPlanet.Name;
            weatherPlanet.WeatherDebuffs = new Dictionary<string, uint> {
                { "Power", (uint)new Random().Next(0, 5) },
                { "Protection", (uint)new Random().Next(0, 5) }
            };

            militaryPlanetClone.WeatherDebuffs = weatherPlanet.WeatherDebuffs;

            MessageBox.Show(weatherPlanet.GetInfo(), "���������� ��� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            colonyPlanetClone.Name = PlanetNames.Elysium.ToString();

            FormPlanets.planetName = colonyPlanetClone.Name;

            //colonyPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
            //    { "Power", (uint)new Random().Next(0, 5) },
            //    { "Protection", (uint)new Random().Next(1, 5) }
            //};

            colonyPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = colonyPlanetClone.PopulatePirates();
            colonyPlanetClone.pirates = array.ToList();

            MessageBox.Show(colonyPlanetClone.GetInfo(), "���������� ��� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            //colonyPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
            //    { "Power", (uint)new Random().Next(0, 5) },
            //    { "Protection", (uint)new Random().Next(1, 5) }
            //};
            colonyPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = colonyPlanetClone.PopulatePirates();
            colonyPlanetClone.pirates = array.ToList();
            MessageBox.Show(colonyPlanetClone.GetInfo(), "���������� ��� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            militaryPlanetClone.Name = PlanetNames.Celestrix.ToString();

            FormPlanets.planetName = militaryPlanetClone.Name;

            militaryPlanetClone.Artifacts = (uint)new Random().Next(3, 5);
            Pirate[] array = militaryPlanetClone.PopulatePirates();
            militaryPlanetClone.pirates = array.ToList();

            /*essageBox.Show(militaryPlanetClone.GetInfo(), "���������� ��� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);*/


            // ����������� ������� � ��������� �������
            PlanetShape weatherPlanet = new WeatherDecorator(militaryPlanet);
            //weatherPlanet.Name = militaryPlanet.Name;
            weatherPlanet.WeatherDebuffs = new Dictionary<string, uint> {
                { "Power", (uint)new Random().Next(0, 5) },
                { "Protection", (uint)new Random().Next(0, 5) }
            };

            militaryPlanetClone.WeatherDebuffs = weatherPlanet.WeatherDebuffs;

            MessageBox.Show(weatherPlanet.GetInfo(), "���������� ��� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void MainForm_Load(object sender, EventArgs e) {
            //
        }
    }
}