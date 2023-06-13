using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Classes {

    public class PirateGroup : IEnemy {
        private List<IEnemy> enemies;
        private IEnemy currentTarget;
        public IEnemy CurrentTarget {
            get { return currentTarget; }
            set { currentTarget = value; }
        }

        int decreasedDamage = 0;
        public void SetDecreasedDamage(int damage) {
            decreasedDamage = damage;
        }

        public PirateGroup() {
            enemies = new List<IEnemy>();
        }

        public PirateGroup(List<Pirate> pirates) {
            enemies = pirates.ConvertAll(pirate => (IEnemy)pirate);
        }

        public void AddPirate(IEnemy pirate) {
            enemies.Add(pirate);
        }

        public void RemoveEnemy(IEnemy enemy) {
            enemies.Remove(enemy);
        }

        public int Attack() {
            int damage = 0;
            foreach (var enemy in enemies) {
                damage += enemy.Attack();
            }
            return damage;
        }

        public bool TakeDamage(int damage) {
            if (currentTarget != null) {
                bool isAlive = ((Pirate)currentTarget).TakeDamage(damage - decreasedDamage);
                //MessageBox.Show("Damage: " + (damage - decreasedDamage));
                //string output = "Total HP: " + ((Pirate)currentTarget).HealthPoints + "\n" + "Damage taken: " + damage + "\n";
                //MessageBox.Show(output);
                return isAlive;
            }
            return false;
        }

        public IEnemy GetEnemy(int index) {
            if (index >= 0 && index < enemies.Count) {
                return enemies[index];
            } else {
                return null;
            }
        }
    }

    // Фасадний клас
    public class BattleFacade {
        public List<(PictureBox pictureBox, int speed, int x, int y)> monsters = new List<(PictureBox pictureBox, int speed, int x, int y)>();
        public List<PictureBox> lasers = new List<PictureBox>();
        private SpaceShip spaceShip;
        public PirateGroup pirateGroup;
        public Dictionary<string, uint> WeatherDebuffs;

        public BattleFacade(List<Pirate> pirates, Dictionary<string, uint> WeatherDebuffs) {

            spaceShip = SpaceShip.Instance;
            pirateGroup = new PirateGroup(pirates);
            this.WeatherDebuffs = WeatherDebuffs;
        }

        public bool PlayerShoots() {
            IEnemy targetMonster = pirateGroup.CurrentTarget;
            int decreasedDamage = (int)WeatherDebuffs["Power"];
            pirateGroup.SetDecreasedDamage(decreasedDamage);

            if (targetMonster != null) {
                return pirateGroup.TakeDamage(spaceShip.Shoot());
            }
            return false;
        }

        public void MonsterAttacks() {
            int damage = pirateGroup.Attack();
            int increasedDamage = (int)WeatherDebuffs["Protection"];
            spaceShip.TakeDamage(damage + increasedDamage);
            //MessageBox.Show("Damage: " + damage + "\n" + "Increased damage: " + increasedDamage);
            //MessageBox.Show(damage.ToString());
        }

        public void SetTarget(IEnemy monster) {
            pirateGroup.CurrentTarget = monster;
        }

        public int getStarShipHP() {
            return spaceShip.HP;
        }

        public void UpdateStarShipHP() {
            spaceShip.HP = (int)spaceShip.shipProtection;
        }
    }
}
