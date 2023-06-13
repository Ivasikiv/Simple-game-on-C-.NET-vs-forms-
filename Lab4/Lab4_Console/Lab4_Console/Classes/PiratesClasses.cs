using Lab4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4_Console.Patterns;

namespace Lab4.Classes {

    /*
    ● Гарантує поєднання створюваних продуктів: Конкретні фабрики 
    (FastPirateFactory, ProtectedPirateFactory, StrongPirateFactory) гарантують
    створення сумісних об'єктів-продуктів (FastPirate, ProtectedPirate, 
    StrongPirate), тобто вони створюють продукти однієї сімейства - піратів.

    ● Звільняє клієнтський код від прив'язки до конкретних класів продукту: 
    Клієнтський код використовує тільки абстрактні класи та інтерфейси 
    (PirateFactory та Pirate), тому не має прив'язки до конкретних класів 
    продукту, таких як FastPirate, ProtectedPirate, StrongPirate.

    ● Виділяє код виробництва продуктів в одне місце, спрощуючи підтримку коду: 
    Код створення об'єктів знаходиться в конкретних фабриках (FastPirateFactory,
    ProtectedPirateFactory, StrongPirateFactory), що спрощує його підтримку, 
    оскільки всі операції з створення об'єктів зосереджені в одному місці.

    ● Спрощує додавання нових продуктів до програми: Для додавання нових продуктів
    до програми необхідно створити новий абстрактний клас (Pirate) та конкретну 
    реалізацію класу продукту (наприклад, NinjaPirate), і додати нову конкретну 
    фабрику (NinjaPirateFactory), яка буде повертати новий продукт. Це не вплине 
    на існуючий код або клієнтів, тому код дотримує принцип відкритості/закритості.
    */

    // Абстрактний клас продукту - Пірат
    public abstract class Pirate {
        public string Type { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }

        public abstract void Attack();
    }


    
    // Конкретний клас продукту - Швидкий Пірат
    class FastPirate : Pirate {
        public FastPirate() {
            Type = "Fast Pirate";
            HealthPoints = new Random().Next(1, 10);
            Damage = new Random().Next(1, 10);
        }

        public override void Attack() {
            Console.WriteLine("Швидкий Пірат атакує!");
        }
    }

    // Конкретний клас продукту - Захищений Пірат

    class ProtectedPirate : Pirate {
        public ProtectedPirate() {
            Type = "Protected Pirate";
            HealthPoints = new Random().Next(1, 10);
            Damage = new Random().Next(1, 10);
        }
        public override void Attack() {
            Console.WriteLine("Захищений Пірат атакує!");
        }
    }

    // Конкретний клас продукту - Сильний Пірат
    class StrongPirate : Pirate {
        public StrongPirate() {
            Type = "Strong Pirate";
            HealthPoints = new Random().Next(1, 10);
            Damage = new Random().Next(1, 10);
        }

        public override void Attack() {
            Console.WriteLine("Сильний Пірат атакує!");
        }
    }


    
    // Абстрактна фабрика - Фабрика Піратів
    abstract class PirateFactory {
        public abstract Pirate CreatePirate();
    }


    
    // Конкретна фабрика - Фабрика Швидких Піратів
    class FastPirateFactory : PirateFactory {
        public override Pirate CreatePirate() {
            return new FastPirate();
        }
    }

    // Конкретна фабрика - Фабрика Захищених Піратів
    class ProtectedPirateFactory : PirateFactory {
        public override Pirate CreatePirate() {
            return new ProtectedPirate();
        }
    } 

    // Конкретна фабрика - Фабрика Сильних Піратів
    class StrongPirateFactory : PirateFactory {
        public override Pirate CreatePirate() {
            return new StrongPirate();
        }
    }


            //// Використання фабрики Швидких Піратів
            //PirateFactory fastPirateFactory = new FastPirateFactory();
            //Pirate fastPirate = fastPirateFactory.CreatePirate();
            //Console.WriteLine($"ХП: {fastPirate.HealthPoints}, Урон: {fastPirate.Damage}");
            //fastPirate.Attack();
   

}
