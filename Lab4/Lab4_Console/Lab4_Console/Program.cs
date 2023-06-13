using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4_Console.Patterns;
using Lab4.Classes;

namespace Lab4_Console {
    internal class Program {
        static void Main(string[] args) {

            SpaceShip ship = SpaceShip.Instance;
            Console.WriteLine("Ship power: {0}", ship.shipPower);
            Console.WriteLine("Ship protection: {0}", ship.shipProtection);
            Console.WriteLine("Ship crew amount: {0}", ship.shipCrewAmount);
            
            Console.WriteLine();
            
            ship.UpgradePower();
            ship.UpgradeProtection();
            ship.UpgradeCrewAmount();

            Console.WriteLine("Ship power: {0}", ship.shipPower);
            Console.WriteLine("Ship protection: {0}", ship.shipProtection);
            Console.WriteLine("Ship crew amount: {0}", ship.shipCrewAmount);

            Console.WriteLine();

            SpaceShip ship2 = SpaceShip.Instance;
            Console.WriteLine("Ship power: {0}", ship2.shipPower);

            Console.WriteLine();

            PlanetShape colonialPlanet = new ColonialPlanet();
            PlanetShape militaryPlanet = new MilitaryPlanet();

            PlanetShape colonyPlanetClone = colonialPlanet.Clone();
            colonyPlanetClone.Name = "Catalina";
            colonyPlanetClone.WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", (uint)new Random().Next(1, 5) },
                { "shipProtection", (uint)new Random().Next(1, 5) },
                { "shipCrewAmount", (uint)new Random().Next(1, 5) }
            };
            colonyPlanetClone.Artefacts = (uint)new Random().Next(3, 5);

            Console.WriteLine(colonyPlanetClone.GetInfo());

            Console.WriteLine();

            PlanetShape colonyPlanetClone2 = colonialPlanet.Clone();
            colonyPlanetClone2.Name = "Catalina";
            colonyPlanetClone2.WeatherDebuffs = new Dictionary<string, uint> {
                { "shipPower", (uint)new Random().Next(1, 5) },
                { "shipProtection", (uint)new Random().Next(1, 5) },
                { "shipCrewAmount", (uint)new Random().Next(1, 5) }
            };
            colonyPlanetClone2.Artefacts = (uint)new Random().Next(3, 5);
            colonyPlanetClone2.PopulatePirates();

            Console.WriteLine(colonyPlanetClone2.GetInfo());

            Console.WriteLine();

            Console.ReadKey();




        }
    }
}

//// Singleton
//Console.WriteLine("----------------------------------------------------------------------------------------");
//Console.WriteLine("Singleton pattern example:");
//Console.WriteLine("");

//// Створюємо екземпляр класу Singleton
//Singleton singleton = Singleton.Instance;
//singleton.DoSomething();
//Singleton.Instance.DoSomething();

//Console.WriteLine("");
//Console.WriteLine("----------------------------------------------------------------------------------------");

////-----------------------------------------------------------------------------------------------

//Console.WriteLine("Abstract factory pattern example:");
//Console.WriteLine("");

//// Створюємо фабрику для створення кредитних карт MasterCard
//CreditCardFactory masterCardFactory = new MasterCardFactory(10000, 50);

//// Створюємо кредитну карту MasterCard за допомогою фабрики
//CreditCard masterCard = masterCardFactory.GetCreditCard();

//// Виводимо інформацію про кредитну карту
//Console.WriteLine("Credit card type: " + masterCard.CardType);
//Console.WriteLine("Credit limit: " + masterCard.CreditLimit);
//Console.WriteLine("Annual charge: " + masterCard.AnnualCharge);
//Console.WriteLine("");

//// Створюємо фабрику для створення кредитних карт Visa
//CreditCardFactory visaCardFactory = new VisaCardFactory(5000, 20);

//// Створюємо кредитну карту Visa за допомогою фабрики
//CreditCard visaCard = visaCardFactory.GetCreditCard();

//// Виводимо інформацію про кредитну карту
//Console.WriteLine("Credit card type: " + visaCard.CardType);
//Console.WriteLine("Credit limit: " + visaCard.CreditLimit);
//Console.WriteLine("Annual charge: " + visaCard.AnnualCharge);
//Console.WriteLine("");

//Console.WriteLine("----------------------------------------------------------------------------------------");
////-----------------------------------------------------------------------------------------------

//Console.WriteLine("Builder pattern example:");
//Console.WriteLine("");

//// Використання шаблону Builder для створення об'єкта користувача
//var userBuilder = new UserBuilder();
//var user = userBuilder.SetFirstName("Dmytro")
//                      .SetLastName("Ivasikiv")
//                      .SetEmail("ahahaha.tttttt@example.com")
//                      .SetPhoneNumber("123-456-7890")
//                      .Build();

//// Виводимо інформацію про користувача
//Console.WriteLine("First name: " + user.FirstName + ", Last name: " + user.LastName + ", Email: " + user.Email + ", Phone number: " + user.PhoneNumber);

//Console.WriteLine("");
//Console.WriteLine("----------------------------------------------------------------------------------------");
////-----------------------------------------------------------------------------------------------

//Console.WriteLine("Prototype pattern example:");
//Console.WriteLine("");

//// Створюємо прототип
//Rectangle rect = new Rectangle();
//rect.X = 10;
//rect.Y = 20;
//rect.Width = 30;
//rect.Height = 40;
//rect.Color = "red";

//// Клонування об'єкту rect
//Rectangle clonedRect = (Rectangle)rect.Clone();

//Console.WriteLine("Original Rectangle: ");
//Console.WriteLine($"X = {rect.X}, Y = {rect.Y}, Width = {rect.Width}, Height = {rect.Height}, Color = {rect.Color}");
//Console.WriteLine();

//Console.WriteLine("Cloned Rectangle: ");
//Console.WriteLine($"X = {clonedRect.X}, Y = {clonedRect.Y}, Width = {clonedRect.Width}, Height = {clonedRect.Height}, Color = {clonedRect.Color}");
//Console.WriteLine();

//// Змінюємо значення в клонованому об'єкті
//clonedRect.X = 50;
//clonedRect.Y = 60;
//clonedRect.Width = 70;
//clonedRect.Height = 80;
//clonedRect.Color = "blue";

//Console.WriteLine("Original Rectangle after cloning: ");
//Console.WriteLine($"X = {rect.X}, Y = {rect.Y}, Width = {rect.Width}, Height = {rect.Height}, Color = {rect.Color}");
//Console.WriteLine();

//Console.WriteLine("Cloned Rectangle after modification: ");
//Console.WriteLine($"X = {clonedRect.X}, Y = {clonedRect.Y}, Width = {clonedRect.Width}, Height = {clonedRect.Height}, Color = {clonedRect.Color}");
//Console.WriteLine();

//Console.WriteLine("----------------------------------------------------------------------------------------");
