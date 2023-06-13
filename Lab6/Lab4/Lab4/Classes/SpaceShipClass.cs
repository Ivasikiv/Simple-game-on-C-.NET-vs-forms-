using Lab6.Classes;

namespace Lab6.Classes {

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
        private Level _shipPower;
        private Level _shipProtection;
        private Level _shipCriticalHitProbability;

        private SpaceShip() {
            _shipPower = new Level(5);
            _shipProtection = new Level(200000);
            _shipCriticalHitProbability = new Level(4);
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

        public Level shipPower {
            get { return _shipPower; }
        }

        public Level shipProtection {
            get { return _shipProtection; }
        }

        public Level shipCriticalHitProbability {
            get { return _shipCriticalHitProbability; }
        }

        public void UpgradePower() {
            _shipPower.IncreaseLvl();
        }

        public void UpgradeProtection() {
            _shipProtection.IncreaseLvl();
            HP = (int)_shipProtection.lvl;
        }

        public void UpgradeCriticalHitProbability() {
            _shipCriticalHitProbability.IncreaseLvl();
        }

        public int Shoot() {
            Random rnd = new Random();
            int crit = rnd.Next(1, 100);
            if (crit <= _shipCriticalHitProbability.lvl) {
                return (int)_shipPower.lvl * 2;
            }
            return (int)_shipPower.lvl;
        }

        public bool TakeDamage(int damage) {
            HP -= damage;
            return !(HP <= 0);
        }
    }

}
