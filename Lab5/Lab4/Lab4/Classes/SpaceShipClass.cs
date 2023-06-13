using Lab5.Classes;

namespace Lab5.Classes {

    /*
    ● Гарантує наявність єдиного екземпляра класу:
    Singleton має приватний конструктор, що запобігає створенню нових екземплярів
    класу ззовні. Всі екземпляри мають доступ до одного й того ж об'єкту через 
    статичне поле instance.
    
    ● Надає глобальну точку доступу до нього:
    Singleton має статичний метод Instance, який повертає єдиний екземпляр класу, 
    із яким можна працювати з будь-якого місця в коді.
    
    ● Реалізує відкладену ініціалізацію об’єкта-одинака:
    У цьому прикладі, якщо екземпляр класу ще не створений, метод Instance створює 
    його. Це називається відкладеною ініціалізацією.
    */

    internal sealed class SpaceShip {
        public int HP = 50;
        public uint shipPower { get; set; }
        public uint shipProtection { get; set; }
        public uint shipCriticalHitProbability { get; set; }

        private SpaceShip() {
            shipPower = 5;
            shipProtection = 20;
            shipCriticalHitProbability = 4;
        }

        //singleton
        private static SpaceShip _instance;

        public static SpaceShip Instance {
            get {
                if (_instance == null) {
                    _instance = new SpaceShip();
                }
                return _instance;
            }
        }

        public void UpgradePower() {
            shipPower++;
        }

        public void UpgradeProtection() {
            shipProtection += 15;
            HP = (int)shipProtection;
        }

        public void UpgradeCriticalHitProbability() {
            shipCriticalHitProbability += 2;
        }

        public int Shoot() {
            Random rnd = new Random();
            int crit = rnd.Next(1, 100);
            if (crit <= shipCriticalHitProbability) {
                return (int)shipPower * 2;
            }
            return (int)shipPower;
        }

        public bool TakeDamage(int damage) {
            HP -= damage;
            return !(HP <= 0);
        }
    }
}
