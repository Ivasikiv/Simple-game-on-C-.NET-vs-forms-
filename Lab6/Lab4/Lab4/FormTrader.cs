using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6 {
    public partial class FormTrader : Form {

        private MainForm mainForm;

        private List<int> priceOfArtifacts = new List<int>();

        public FormTrader(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBoxCoin.BackColor = Color.Transparent;
            pictureBoxArtifact.BackColor = Color.Transparent;
            pictureBoxArtifactSell.BackColor = Color.FromArgb(8, 27, 59);

            pictureBox4.BackColor = Color.FromArgb(8, 27, 59);
            pictureBox5.BackColor = Color.FromArgb(8, 27, 59);
            pictureBox6.BackColor = Color.FromArgb(8, 27, 59);


            labelCoins.BackColor = Color.Transparent;
            labelArtifacts.BackColor = Color.Transparent;
            labelBack.BackColor = Color.Transparent;
            labelUpgradePower.BackColor = Color.FromArgb(8, 27, 59);
            labelUpgradeProtection.BackColor = Color.FromArgb(8, 27, 59);
            labelUpgradeCritHit.BackColor = Color.FromArgb(8, 27, 59);
            labelArtifactsValue.BackColor = Color.FromArgb(8, 27, 59);

        }

        private void labelBack_Click(object sender, EventArgs e) {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonUpgradePower_Click(object sender, EventArgs e) {
            //MessageBox.Show(mainForm.upgrades["Power"].ToString());
            if (mainForm.upgrades["Power"] >= 20) {
                MessageBox.Show("You have already upgraded power to the max level!");
                return;
            }

            int price = mainForm.prices["Power"];

            if (!MainForm.RemoveCoins(price)) {
                MessageBox.Show("Lack of money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                mainForm.GetSpaceShip().UpgradePower();
                mainForm.upgrades["Power"]++;
                labelUpgradePower.Text = "Power lvl: " + mainForm.GetSpaceShip().shipPower.lvl.ToString();
                labelCoins.Text = MainForm.coins.ToString();

                mainForm.prices["Power"] += 250;
                buttonUpgradePower.Text = "Upgrade: " + mainForm.prices["Power"].ToString() + " coins";
            }
        }

        private void buttonUpgradeProtection_Click(object sender, EventArgs e) {
            if (mainForm.upgrades["Protection"] >= 50) {
                MessageBox.Show("You have already upgraded protection to the max level!");
                return;
            }

            int price = mainForm.prices["Protection"];

            if (!MainForm.RemoveCoins(price)) {
                MessageBox.Show("Lack of money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                mainForm.GetSpaceShip().UpgradeProtection();
                mainForm.upgrades["Protection"]++;
                labelUpgradeProtection.Text = "Protection: " + mainForm.GetSpaceShip().shipProtection.lvl.ToString() + " ss";
                labelCoins.Text = MainForm.coins.ToString();

                mainForm.prices["Protection"] += 250;
                buttonUpgradeProtection.Text = "Upgrade: " + mainForm.prices["Protection"].ToString() + " coins";
            }
        }

        private void buttonUpgradeCritHit_Click(object sender, EventArgs e) {
            if (mainForm.upgrades["Crit"] >= 50) {
                MessageBox.Show("You have already upgraded critical hit probability to the max level!");
                return;
            }

            int price = mainForm.prices["Crit"];

            if (!MainForm.RemoveCoins(price)) {
                MessageBox.Show("Lack of money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                mainForm.GetSpaceShip().UpgradeCriticalHitProbability();
                mainForm.upgrades["Crit"] += 2;
                labelUpgradeCritHit.Text = "Critical hit: " + mainForm.GetSpaceShip().shipCriticalHitProbability.lvl.ToString() + "%";
                labelCoins.Text = MainForm.coins.ToString();

                mainForm.prices["Crit"] += 250;
                buttonUpgradeCritHit.Text = "Upgrade: " + mainForm.prices["Crit"].ToString() + " coins";
            }
        }

        private void FormTrader_Shown(object sender, EventArgs e) {
            labelCoins.Text = MainForm.coins.ToString();
            labelArtifacts.Text = MainForm.artifacts.ToString();
            labelUpgradePower.Text = "Power lvl: " + mainForm.GetSpaceShip().shipPower.lvl.ToString();
            labelUpgradeProtection.Text = "Protection: " + mainForm.GetSpaceShip().shipProtection.lvl.ToString() + " ss";
            labelUpgradeCritHit.Text = "Critical hit: " + mainForm.GetSpaceShip().shipCriticalHitProbability.lvl.ToString() + "%";

            buttonUpgradePower.Text = "Upgrade: " + mainForm.prices["Power"].ToString() + " coins";
            buttonUpgradeProtection.Text = "Upgrade: " + mainForm.prices["Protection"].ToString() + " coins";
            buttonUpgradeCritHit.Text = "Upgrade: " + mainForm.prices["Crit"].ToString() + " coins";

            mainForm.upgrades["Power"] = mainForm.GetSpaceShip().shipPower.lvl;
            mainForm.upgrades["Protection"] = mainForm.GetSpaceShip().shipProtection.lvl;
            mainForm.upgrades["Crit"] = mainForm.GetSpaceShip().shipCriticalHitProbability.lvl;
        }

        private void buttonSellArtifacts_Click(object sender, EventArgs e) {
            int amountOfArtifactsToSell = int.Parse(labelArtifactAmount.Text);
            
            string labelText = labelArtifactsValue.Text;
            int startIndex = labelText.IndexOf("Value: ") + "Value: ".Length;
            int endIndex = labelText.IndexOf(" coins");
            string numberString = labelText.Substring(startIndex, endIndex - startIndex);
            int value = int.Parse(numberString);

            MainForm.artifacts -= amountOfArtifactsToSell;
            MainForm.coins += value;

            labelCoins.Text = MainForm.coins.ToString();
            labelArtifacts.Text = MainForm.artifacts.ToString();

            labelArtifactsValue.Text = "Value: 0 coins";
            labelArtifactAmount.Text = "0";

            for (int i = 0; i < mainForm.priceForEachNextArtifact.Count(); i++) {
                mainForm.priceForEachNextArtifact[i] = 0;
            }

        }

        private void buttonAddArtifact_Click(object sender, EventArgs e) {
            int amountOfArtifactsToSell = int.Parse(labelArtifactAmount.Text);

            if (amountOfArtifactsToSell + 1 > MainForm.artifacts) {
                MessageBox.Show("You don't have that many artifacts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            amountOfArtifactsToSell++;
            labelArtifactAmount.Text = amountOfArtifactsToSell.ToString();

            string labelText = labelArtifactsValue.Text;
            int startIndex = labelText.IndexOf("Value: ") + "Value: ".Length;
            int endIndex = labelText.IndexOf(" coins");
            string numberString = labelText.Substring(startIndex, endIndex - startIndex);
            int value = int.Parse(numberString);

            int price = 0;
            // якщо ціна вже згенерована і є наявною в масиві priceForEachNextArtifact, то беремо її з масиву, якщо ні - 50 * (new Random().Next(1, 10));
            // інератором, за яким перевіряється ціна є amountOfArtifactsToSell
            if (mainForm.priceForEachNextArtifact[amountOfArtifactsToSell - 1] == 0) {
                price = 50 * (new Random().Next(1, 10));
                mainForm.priceForEachNextArtifact[amountOfArtifactsToSell - 1] = price;
            } else {
                price = mainForm.priceForEachNextArtifact[amountOfArtifactsToSell - 1];
            }


            priceOfArtifacts.Add(price);
            labelArtifactsValue.Text = "Value: " + (value + price).ToString() + " coins";
        }

        private void buttonRemoveArtifact_Click(object sender, EventArgs e) {
            int amountOfArtifactsToSell = int.Parse(labelArtifactAmount.Text);

            if (amountOfArtifactsToSell - 1 < 0) {
                MessageBox.Show("You can't sell less than 0 artifacts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            amountOfArtifactsToSell--;
            labelArtifactAmount.Text = amountOfArtifactsToSell.ToString();

            string labelText = labelArtifactsValue.Text;
            int startIndex = labelText.IndexOf("Value: ") + "Value: ".Length;
            int endIndex = labelText.IndexOf(" coins");
            string numberString = labelText.Substring(startIndex, endIndex - startIndex);
            int value = int.Parse(numberString);

            int price = priceOfArtifacts[priceOfArtifacts.Count - 1];
            priceOfArtifacts.RemoveAt(priceOfArtifacts.Count - 1);

            labelArtifactsValue.Text = "Value: " + (value - price).ToString() + " coins";

        }
    }
}
