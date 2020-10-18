using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)

        {
            string[] figure = { "Круг", "Квадрат", "Прямоугольник", "Треугольник", "Трапеция" };
            LinkedList<string> ListFigure = new LinkedList<string>(figure);
            LinkedList<GeometricalFigure> lst = new LinkedList<GeometricalFigure>();

            lst.AddLast(new Trapezoid(5, 4, 2, 2));
            lst.AddLast(new Circle(3));
            lst.AddLast(new Circle(3));   
            lst.AddLast(new Square(9));
            lst.AddLast(new Circle(10));
            lst.AddLast(new Triangle(20, 30, 10));
            lst.AddLast(new Rectangle(20, 10));
            lst.AddLast(new Rectangle(1, 1));

            Menu(lst, ListFigure);

            Console.ReadKey();
        }

        static void Menu(LinkedList<GeometricalFigure> lst, LinkedList<string> ListFigure)
        {
            Console.WriteLine("1.Вычислить средний периметр и площадь всех фигур");
            Console.WriteLine("2.Найти фигуру наибольшей площади");
            Console.WriteLine("3.Найти тип фигуры с наибольшим значением среднего периметра среди всех других типов фигур");
            Console.WriteLine("4.Выход");
            Console.Write("Выберите пункт меню: ");

            while (true)
            {
                try
                {
                    int key = Convert.ToInt32(Console.ReadLine());
                    switch (key)
                    {

                        case 1:
                            Console.WriteLine("Средняя площадь всех фигур: " + TaskCompletion.AverageArea(lst));
                            Console.WriteLine("Средний периметр всех фигур: " + TaskCompletion.AveragePerimeter(lst));
                            break;

                        case 2:
                            Console.WriteLine("Фигура наибольшей площади: " + TaskCompletion.MaxArea(lst));
                            break;

                        case 3:
                            Console.WriteLine("3.Тип фигуры с наибольшим значением среднего периметра среди всех других типов фигур: " + TaskCompletion.FigureTypeWithTheHighestMeanPerimeter(ListFigure, lst));
                            break;
                        case 4:

                            Environment.Exit(0);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
        }
    }
}
