using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Инкапсуляция
// В языке C# инкапсуляция реализована модификаторами доступа и get/set methods.
// В отличие от С++, где один модификатор применяется к множеству членов,
// С# модификаторы доступа пишутся перед каждым полем.
// По умолчанию, у всех полей приватный доступ.
// кроме private, public, protected, есть internal & protected internal.
// internal-fields доступны в пределах сборки.
// protected-internal for baby classes and сборки.
// Besides get/set methods incapsulation can be realised by properties:
// Свойства - синтаксическая конструкция, которая объединяет методы.
// Благодаря свойствам get/set методы можно использовать, как самые обычные переменные в классе.
namespace Point
{
    internal class Point
    {
        double x;
        double y;
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }

        //    Proprerties:
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        

        // Methods:
        public void Print()
        { 
            Console.WriteLine($"X = {x}, \tY = {y}");
        }
    }
}
