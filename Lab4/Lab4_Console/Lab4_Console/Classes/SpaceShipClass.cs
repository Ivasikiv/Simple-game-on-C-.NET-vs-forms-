using Lab4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4_Console.Patterns;

namespace Lab4.Classes {

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
        public uint shipPower { get; set; }
        public uint shipProtection { get; set; }
        public uint shipCrewAmount { get; set; }

        private SpaceShip() {
            shipPower = 5;
            shipProtection = 5;
            shipCrewAmount = 4;
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
            shipProtection++;
        }

        public void UpgradeCrewAmount() {
            shipCrewAmount++;
        }

    }
}
