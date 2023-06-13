using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Console.Patterns {

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

    
    public sealed class Singleton {
        private static Singleton instance = null;                       // статичне поле, що містить екземпляр класу
        private static readonly object padlock = new object();          // статичне поле, що містить об'єкт для синхронізації потоків

        Singleton() {                                                   // приватний конструктор
        }

        public static Singleton Instance {                              // статичний метод, що повертає екземпляр класу
            get {                                                       // метод доступу до екземпляру класу
                lock (padlock) {                                        // синхронізація потоків
                    if (instance == null) {                             // перевірка, чи створений екземпляр класу
                        instance = new Singleton();                     // створення екземпляру класу
                    }
                    return instance;                                    // повернення екземпляру класу
                }
            }
        }

        public void DoSomething() {                                     // метод класу, що виводить в консоль повідомлення
            Console.WriteLine("Singleton instance is doing something.");
        }
    }

}
