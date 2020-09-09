/*Создать необобщенный класс точки
в трехмерном пространстве с целочисленными
координатами(Point3D), который наследуется от
generic-класса Point2D<T>, рассмотренного в уроке.
Реализовать в классе:
■ конструктор с параметрами, который принимает
начальные значения для координат точки;
■ метод ToString().*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_02
{
    /// <summary>
    /// Обобщенный класс точки
    /// </summary>
    /// <typeparam name="T">
    /// координаты точки могут быть любого типа
    /// </typeparam>
    public class Point2D<T>
    {
        // параметр типа используется для задания типа свойства
        public T X { get; set; }
        public T Y { get; set; }
        // параметр типа используется для задания типов
        // параметров метода
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
    }
    public class Point3D : Point2D<double>
    {
        public double Z { get; set; }
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Координаты нашей точки: X = {X}, Y = {Y}, Z = {Z}";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            // тестирование обобщенного класса - точки в 2D
            Point2D<int> p1 = new Point2D<int>();
            Console.WriteLine($"x = {p1.X} y = {p1.Y}");
            Console.WriteLine(typeof(Point2D<int>));

            Point2D<double> p2 = new Point2D<double>(10.5, 20.5);
            Console.WriteLine($"\nx = {p2.X} y = {p2.Y}");
            Console.WriteLine(typeof(Point2D<double>));
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            Point3D p3 = new Point3D(12.7, 11.28, 34.12);
            WriteLine(p3);
            ReadKey();

        }
    }
}
