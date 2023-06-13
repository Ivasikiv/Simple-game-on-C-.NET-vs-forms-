using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Console.Patterns {

    /*
    ● Гарантує поєднання створюваних продуктів: Абстрактна фабрика та її конкретні 
    фабрики гарантують створення сумісних об'єктів-продуктів, наприклад, якщо клієнт 
    використовує MasterCardFactory, то результатом буде об'єкт MasterCard.
    
    ● Звільняє клієнтський код від прив'язки до конкретних класів продукту: 
    Клієнтський код використовує тільки абстрактні класи та інтерфейси 
    (CreditCardFactory та CreditCard), тому не має прив'язки до конкретних класів продукту.
    
    ● Виділяє код виробництва продуктів в одне місце, спрощуючи підтримку коду: 
    Весь код створення об'єктів знаходиться в конкретних фабриках, що спрощує його підтримку.
    
    
    ● Спрощує додавання нових продуктів до програми: Для додавання нових продуктів 
    до програми необхідно створити новий абстрактний клас та конкретну реалізацію 
    класу продукту, і додати нову конкретну фабрику, яка буде повертати новий продукт.
    
    ● Реалізує принцип відкритості/закритості: Додавання нових продуктів не впливає 
    на існуючий код або клієнтів, тому код дотримує принцип відкритості/закритості.
    */


    // Абстрактний клас кредитної карти
    abstract class CreditCard {     
        public abstract string CardType { get; }   
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }

    // Клас MasterCard
    class MasterCard : CreditCard {
        public override string CardType {
            get { return "MasterCard"; }
        }

        private int _creditLimit;
        public override int CreditLimit {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        private int _annualCharge;
        public override int AnnualCharge {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }

    // Клас VisaCard
    class VisaCard : CreditCard {
        public override string CardType {
            get { return "Visa Card"; }
        }

        private int _creditLimit;
        public override int CreditLimit {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        private int _annualCharge;
        public override int AnnualCharge {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }

    // Абстрактна фабрика для створення кредитних карт
    abstract class CreditCardFactory {
        public abstract CreditCard GetCreditCard();                     // Абстрактний метод для створення кредитної карти
    }

    // Фабрика для створення кредитних карт MasterCard
    class MasterCardFactory : CreditCardFactory {
        private int _creditLimit;
        private int _annualCharge;

        public MasterCardFactory(int creditLimit, int annualCharge) {   // Конструктор для ініціалізації полів
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard() {                    // Перевизначений метод для створення кредитної карти
            return new MasterCard() {
                CreditLimit = _creditLimit,
                AnnualCharge = _annualCharge
            };
        }
    }

    // Фабрика для створення кредитних карт Visa
    class VisaCardFactory : CreditCardFactory {
        private int _creditLimit;
        private int _annualCharge;

        public VisaCardFactory(int creditLimit, int annualCharge) {     // Конструктор для ініціалізації полів
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard() {                    // Перевизначений метод для створення кредитної карти
            return new VisaCard() {
                CreditLimit = _creditLimit,
                AnnualCharge = _annualCharge
            };
        }
    }
}
