using System;
using System.Collections.Generic;
using System.Text;

namespace Prakt4
{
    /// <summary>
    /// Класс Triad - тройка чисел.
    /// </summary>
    public class Triad
    {
        // Три числа триады (автоматические свойства)
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        /// <summary>
        /// Конструктор: задает три числа сразу при создании объекта
        /// </summary>
        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        /// <summary>
        /// Сложение триады с числом: к каждому элементу прибавляется число
        /// </summary>
        /// <param name="number">Число, которое прибавляем</param>
        /// <returns>Новая триада</returns>
        public Triad Add(int number)
        {
            return new Triad(First + number, Second + number, Third + number);
        }

        /// <summary>
        /// Перегруженный метод Add: сложение триады с другой триадой.
        /// Элементы складываются попарно: (a1+a2, b1+b2, c1+c2)
        /// </summary>
        /// <param name="other">Вторая триада</param>
        /// <returns>Новая триада</returns>
        public Triad Add(Triad other)
        {
            return new Triad(First + other.First,
                             Second + other.Second,
                             Third + other.Third);
        }

        /// <summary>
        /// Умножение триады на число: каждый элемент умножается на число
        /// </summary>
        /// <param name="number">Множитель</param>
        /// <returns>Новая триада</returns>
        public Triad Multiply(int number)
        {
            return new Triad(First * number, Second * number, Third * number);
        }

        /// <summary>
        /// Проверка на равенство двух триад
        /// </summary>
        /// <param name="other">Триада для сравнения</param>
        /// <returns>true - все элементы равны, false - иначе</returns>
        public bool IsEqual(Triad other)
        {
            return First == other.First &&
                   Second == other.Second &&
                   Third == other.Third;
        }

        /// <summary>
        /// Строка для вывода триады на экран, например (1; 2; 3)
        /// </summary>
        public override string ToString()
        {
            return $"({First}; {Second}; {Third})";
        }
    }
}
