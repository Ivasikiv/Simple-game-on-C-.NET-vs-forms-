using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Console.Patterns {

    /*
    ● Дозволяє створювати продукти покроково - шаблон Builder дає можливість 
    створювати об'єкти крок за кроком, додаючи потрібні властивості за потреби 
    за допомогою методів SetFirstName, SetLastName, SetEmail, SetPhoneNumber. 
    При цьому, користувач може вибирати які властивості задає і в якому порядку.
    
    ● Дозволяє використовувати один і той самий код для створення різноманітних
    продуктів - у даному випадку шаблон Builder використовується для створення 
    об'єктів класу User, причому користувач може вказати тільки ті властивості, 
    які йому потрібні, і в будь-якому порядку.
    
    ● Ізолює складний код конструювання продукту від його головної бізнес-логіки 
    - клас UserBuilder ізолює код конструювання об'єкта User від його головної 
    бізнес-логіки, що дозволяє спростити процес створення об'єктів і уникнути 
    дублювання коду в майбутньому. Наприклад, якщо потрібно буде створювати новий 
    клас користувача з іншими полями, код створення такого класу можна буде легко 
    перевикористати, змінивши лише методи в класі UserBuilder, які відповідають 
    за задання полів.
    */

    
    // Клас, який будує об'єкт User
    class UserBuilder {
        private User _user = new User();                                // Створюємо новий об'єкт User

        public UserBuilder SetFirstName(string firstName) {             // Встановлює ім'я користувача та повертає поточний об'єкт
            _user.FirstName = firstName;
            return this;
        }

        public UserBuilder SetLastName(string lastName) {               // Встановлює прізвище користувача та повертає поточний об'єкт
            _user.LastName = lastName;
            return this;
        }

        public UserBuilder SetEmail(string email) {                     // Встановлює email користувача та повертає поточний об'єкт
            _user.Email = email;
            return this;
        }

        public UserBuilder SetPhoneNumber(string phoneNumber) {         // Встановлює номер телефону користувача та повертає поточний об'єкт
            _user.PhoneNumber = phoneNumber;
            return this;
        }

        public User Build() {                                           // Повертає готовий об'єкт User
            return _user;
        }
    }

    // Клас користувача
    class User {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

}
