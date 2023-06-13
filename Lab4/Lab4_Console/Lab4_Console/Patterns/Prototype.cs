using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Console.Patterns {

    /*
    ● Дозволяє клонувати об’єкти без прив’язки до їхніх конкретних класів: Клас 
    Shape - абстрактний, тобто не має конкретної реалізації, а клас Rectangle - 
    конкретний прототип, який наслідується від класу Shape. Функція Clone у класі 
    ectangle створює копію об'єкту Rectangle, а не його посилання. Таким чином, 
    можна клонувати будь-який об'єкт, що наслідується від класу Shape, без 
    прив'язки до конкретних класів.

    ● Менша кількість повторень коду ініціалізації об’єктів: Клас Shape містить 
    поля, які потрібні для всіх класів-потомків, тому не потрібно кожен раз 
    дублювати ці поля у кожному класі-потомку. Крім того, конструктор Shape 
    копіює всі поля вхідного об'єкту, що також допомагає уникнути повторень.

    ● Прискорює створення об’єктів: Клонування об'єкта займає менше часу і 
    ресурсів, ніж створення нового об'єкту з нуля. Таким чином, клонування може 
    покращити продуктивність програми.

    ● Альтернатива створенню підкласів під час конструювання складних об’єктів: 
    За допомогою клонування можна створювати складні об'єкти без необхідності 
    створювати підкласи для кожного варіанту об'єкта. Таким чином, програміст 
    може легко створювати нові типи об'єктів, не розширюючи ієрархію класів.
    */

    
    // Прототип
    abstract class Shape {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public Shape() { }                                              // Конструктор за замовчуванням

        public Shape(Shape source) {                                    // Конструктор копіювання
            this.X = source.X;
            this.Y = source.Y;
            this.Color = source.Color;
        }

        public abstract Shape Clone();                                  // Метод клонування
    }

    // Конкретний прототип - прямокутник
    class Rectangle : Shape {   
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }                                          // Конструктор за замовчуванням

        public Rectangle(Rectangle source) : base(source) {             // Конструктор копіювання, що викликає конструктор копіювання базового класу
            this.Width = source.Width;
            this.Height = source.Height;
        }

        public override Shape Clone() {                                 // Метод клонування, що повертає новий об'єкт типу Rectangle
            return new Rectangle(this);
        }
    }
}
