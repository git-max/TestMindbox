using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double a, b, c; // длины сторон треугольника

        /// <summary>
        /// Длина первой стороны треугольника
        /// </summary>
        public double A
        {
            get { return a; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("A", "Длина стороны треугольника должна быть больше 0");
                }
                a = value;
            }
        }

        /// <summary>
        /// Длина второй стороны треугольника
        /// </summary>
        public double B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("B", "Длина стороны треугольника должна быть больше 0");
                }
                b = value;
            }
        }

        /// <summary>
        /// Длина третьей стороны треугольника
        /// </summary>
        public double C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("C", "Длина стороны треугольника должна быть больше 0");
                }
                c = value;
            }
        }

        /// <summary>
        /// Создаёт новый треугольник по заданным сторонам
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            if(!(this.Area() > 0))
            {
                throw new ArgumentOutOfRangeException("Неправильные значения сторон треугольника");
            }
        }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double p = (a + b + c) / 2; // полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Обозначает, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle
        {
            get
            {
                List<double> sides = new List<double>() { a, b, c };
                sides.Sort(); // поиск гипотенузы (самой длинной стороны)

                return Math.Pow(sides[2], 2).CompareTo(Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2)) == 0;
            }
        }
    }
}
