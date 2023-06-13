using Lab4.Classes;
using System.DirectoryServices;

namespace Lab4.Classes {

    /*
    ● Дозволяє клонувати об’єкти без прив’язки до їхніх конкретних класів: У 
    класі PlanetShape визначено абстрактний метод Clone, який дозволяє 
    клонувати об'єкти типу PlanetShape, включаючи його похідні класи, такі як 
    Planet, без прив'язки до конкретних класів.

    ● Менша кількість повторень коду ініціалізації об’єктів: Клас PlanetShape 
    містить поля, такі як Name, GoldReward, Artifacts, WeatherDebuffs, які не 
    потрібно дублювати у кожному класі-потомку, такому як Planet, оскільки вони 
    вже визначені в базовому класі PlanetShape. При клонуванні об'єктів також 
    використовується конструктор копіювання, який допомагає уникнути повторень коду.

    ● Прискорює створення об’єктів: Клонування об'єктів за допомогою методу 
    Clone може займати менше часу і ресурсів, ніж створення нового об'єкту з нуля,
    тому цей підхід може покращити продуктивність програми.

    ● Альтернатива створенню підкласів під час конструювання складних об’єктів: 
    За допомогою клонування можна створювати складні об'єкти, такі як планети, 
    з властивостями, такими як Name, GoldReward, Artifacts, WeatherDebuffs, без 
    необхідності створювати підкласи для кожного варіанту об'єкта. Таким чином, 
    програміст може легко створювати нові типи об'єктів, не розширюючи ієрархію класів.
    */


    public abstract class PlanetShape {
        public string Name { get; set; }
        public List<Pirate> pirates = new List<Pirate>();
        public uint GoldReward { get; set; }
        public Dictionary<string, uint> WeatherDebuffs { get; set; }
        public uint Artifacts { get; set; }

        public abstract PlanetShape Clone(); // Абстрактний метод клонування

        //функція що повертатиме рядок інформації про планету
        public virtual string GetInfo() {
            return "";
        }

        public virtual Pirate[] PopulatePirates() {
            return null;
        }
    }


    public class ColonialPlanet : PlanetShape {
        public List<Pirate> pirates = new List<Pirate>();
        public ColonialPlanet() {
            Name = "Colonial Planet";
            WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", 0 },
                { "shipProtection", 0 },
                { "shipCriticalHitProbability", 0 }
            };
            Artifacts = 0;

            PopulatePirates();
        }

        // Реалізація клонування Planet
        public override PlanetShape Clone() {
            return (PlanetShape)MemberwiseClone();
        }

        public override Pirate[] PopulatePirates() {
            pirates.Clear();

            int sizeFastPirate = new Random().Next(1, 5);
            int sizeProtectedPirate = new Random().Next(0, 2);

            GoldReward = (uint)(sizeFastPirate * 200 + sizeProtectedPirate * 300);

            PirateFactory fastPirateFactory = new FastPirateFactory();
            PirateFactory protectedPirateFactory = new ProtectedPirateFactory();


            // Створення швидких піратів
            for (int i = 0; i < sizeFastPirate; i++) {
                pirates.Add(fastPirateFactory.CreatePirate());
            }

            // Створення захищених піратів
            for (int i = 0; i < sizeProtectedPirate; i++) {
                pirates.Add(protectedPirateFactory.CreatePirate());
            }

            return pirates.ToArray();
        }

        public override string GetInfo() {
            uint[] piratesAmount = new uint[3];
            foreach (Pirate pirate in pirates) {
                if (pirate.Type == "Fast Pirate") {
                    piratesAmount[0]++;
                } else if (pirate.Type == "Protected Pirate") {
                    piratesAmount[1]++;
                } else {
                    piratesAmount[2]++;
                }
            }

            string info = $"Planet: {Name}\n" +
                          $"Gold reward: {GoldReward}\n" +
                          $"Special artifacts: {Artifacts}\n" +
                          $"Weather debuffs: ";
            foreach (var debuff in WeatherDebuffs) {
                info += $"{debuff.Key}: -{debuff.Value} ";
            }
            info += $"\nNumbers of Pirates: {pirates.Count()} ";
            info += $"\nFast Pirate: {piratesAmount[0]}\nProtected Pirate: {piratesAmount[1]}\n";
            return info;
        }
    }

    public class MilitaryPlanet : PlanetShape {
        public List<Pirate> pirates = new List<Pirate>();
        public MilitaryPlanet() {
            Name = "Military Planet";
            WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", 0 },
                { "shipProtection", 0 },
                { "shipCriticalHitProbability", 0 }
            };
            Artifacts = 0;

            PopulatePirates();
        }

        // Реалізація клонування Planet
        public override PlanetShape Clone() {
            return (PlanetShape)MemberwiseClone();
        }

        public override Pirate[] PopulatePirates() {
            pirates.Clear();
            
            int sizeFastPirate = new Random().Next(3, 7);
            int sizeProtectedPirate = new Random().Next(2, 4);
            int sizeStrongPirate = new Random().Next(2, 4);

            GoldReward = (uint)(sizeFastPirate * 150 + sizeProtectedPirate * 200 + sizeStrongPirate * 300);

            PirateFactory fastPirateFactory = new FastPirateFactory();
            PirateFactory protectedPirateFactory = new ProtectedPirateFactory();
            PirateFactory strongPirateFactory = new StrongPirateFactory();

            // Створення швидких піратів
            for (int i = 0; i < sizeFastPirate; i++) {
                pirates.Add(fastPirateFactory.CreatePirate());
            }

            // Створення захищених піратів
            for (int i = 0; i < sizeProtectedPirate; i++) {
                pirates.Add(protectedPirateFactory.CreatePirate());
            }

            // Створення сильних піратів
            for (int i = 0; i < sizeStrongPirate; i++) {
                pirates.Add(strongPirateFactory.CreatePirate());
            }

            return pirates.ToArray();
        }

        public override string GetInfo() {
            uint[] piratesAmount = new uint[3];
            foreach (Pirate pirate in pirates) {
                if (pirate.Type == "Fast Pirate") {
                    piratesAmount[0]++;
                } else if (pirate.Type == "Protected Pirate") {
                    piratesAmount[1]++;
                } else {
                    piratesAmount[2]++;
                }
            }

            string info = $"Planet: {Name}\n" +
                          $"Gold reward: {GoldReward}\n" +
                          $"Special artifacts: {Artifacts}\n" +
                          $"Weather debuffs: ";
            foreach (var debuff in WeatherDebuffs) {
                info += $"{debuff.Key}: -{debuff.Value} ";
            }
            info += $"\nNumbers of Pirates: {pirates.Count()} ";
            info += $"\nFast Pirate: {piratesAmount[0]}\nProtected Pirate: {piratesAmount[1]}\n" +
                    $"Strong Pirate: {piratesAmount[2]}\n";
            return info;
        }
    }
}
