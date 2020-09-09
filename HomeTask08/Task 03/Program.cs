/*3. Создать обобщенный класс прямой на плоскости.
В классе предусмотреть 2 поля типа обобщенной
точки — точки, через которые проходит прямая.
Реализовать в классе:
■ конструктор, который принимает 2 точки;
■ конструктор, которые принимает 4 координаты
(x и у координаты для первой и второй точки);
■ метод ToString().*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_03
{
    public class Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
    public class Line<T>
    {
        public Point<T> P1;
        public Point<T> P2;
        public Line (Point<T> p1, Point<T> p2)
        {
            P1 = p1;
            P2 = p2;
        }
        public Line (T x1, T y1, T x2, T y2)
        {
            P1 = new Point<T>(x1, y1);
            P2 = new Point<T>(x2, y2);
        }

        public override string ToString()
        {
            return $"Прямая проходит через две точки с координатами: X1 = {P1.X}, Y1 = {P1.Y} и X2 = {P2.X}, Y2 = {P2.Y}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Green;
            Point<int> p1 = new Point<int>(11, 17);
            Point<int> p2 = new Point<int>(20, 37);
            Line<int> line1 = new Line<int>(p1, p2);
            WriteLine(line1);
            WriteLine(typeof(Line<int>));
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            Line<double> line2 = new Line<double>(10.5, 20.5, 17.6, 22.1);
            WriteLine(line2);
            WriteLine(typeof(Line<double>));
            WriteLine();
                     
            ReadKey();
        }
    }
}
