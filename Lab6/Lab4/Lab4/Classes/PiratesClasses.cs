using Lab6.Classes;

namespace Lab6.Classes {

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


    /*
     Шаблон Composite дозволяє об'єднати об'єкти в деревоподібну структуру, де 
    кожен об'єкт може бути компонентом, або контейнером для інших компонентів. 
    У даному випадку, інтерфейс IEnemy виступає як компонент, а клас Pirate є 
    абстрактним класом, який реалізує цей інтерфейс і виступає як базовий клас 
    для конкретних класів FastPirate, ProtectedPirate і StrongPirate. Кожен 
    конкретний клас Pirate може мати свої власні характеристики, такі як Type, 
    HealthPoints, Damage і imagePath, а також реалізувати методи Attack() і TakeDamage().

    Таким чином, я можу створювати об'єкти типу FastPirate, ProtectedPirate і
    StrongPirate, які діють як окремі компоненти, а також компонувати їх разом,
    якщо потрібно, створюючи складніші структури ворогів.
     */


    // Компонент
    public interface IEnemy {
        int Attack();
        bool TakeDamage(int damage);
    }


    // Абстрактний клас продукту - Пірат
    public abstract class Pirate : IEnemy {
        public int TotalHealthPoints { get; set; }
        public string Type { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }
        public string imagePath { get; set; }
        public IState State { get; set; }

        public abstract int Attack();
        public abstract bool TakeDamage(int damage);
    }


    
    // Конкретний клас продукту - Швидкий Пірат
    class FastPirate : Pirate {
        public FastPirate() {
            Type = "Fast Pirate";
            HealthPoints = new Random().Next(5, 10);
            TotalHealthPoints = HealthPoints;
            Damage = new Random().Next(2, 10);
            imagePath = "..\\images\\yellow-alien.png";
            State = new NormalState();
        }

        public override int Attack() {
            return Damage;
        }
        
        public override bool TakeDamage(int damage) {
            HealthPoints -= damage;
            if (HealthPoints < TotalHealthPoints / 2) {
                State = new InjuredState();
                imagePath = "..\\images\\yellow-alien-injured.png";
            }
            return !(HealthPoints <= 0);
            
        }
    }

    // Конкретний клас продукту - Захищений Пірат

    class ProtectedPirate : Pirate {
        public ProtectedPirate() {
            Type = "Protected Pirate";
            HealthPoints = new Random().Next(15, 30);
            TotalHealthPoints = HealthPoints;
            Damage = new Random().Next(1, 10);
            imagePath = "..\\images\\red-alien.png";
            State = new NormalState();
        }

        public override int Attack() {
            return Damage;
        }

        public override bool TakeDamage(int damage) {
            HealthPoints -= damage;
            if (HealthPoints < TotalHealthPoints / 2) {
                State = new InjuredState();
                imagePath = "..\\images\\red-alien-injured.png";
            }
            return !(HealthPoints <= 0);
        }
    }

    // Конкретний клас продукту - Сильний Пірат
    class StrongPirate : Pirate {
        public StrongPirate() {
            Type = "Strong Pirate";
            HealthPoints = new Random().Next(15, 30);
            TotalHealthPoints = HealthPoints;
            Damage = new Random().Next(4, 10);
            imagePath = "..\\images\\gray-alien.png";
            State = new NormalState();
        }

        public override int Attack() {
            return Damage;
        }

        public override bool TakeDamage(int damage) {
            HealthPoints -= damage;
            if (HealthPoints < TotalHealthPoints / 2) {
                State = new InjuredState();
                imagePath = "..\\images\\gray-alien-injured.png";
            }
            return !(HealthPoints <= 0);
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
