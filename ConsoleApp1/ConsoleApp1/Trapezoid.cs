using System;
using System.Linq;

namespace ConsoleApp1
{
    partial class Program
    {
        class Trapezoid: GeometricalFigure
        {
            public Trapezoid(params double [] arr)
            {
                this.CharacteristicsOfFigures = new double[4];
                this.type = "Трапеция";
               
                for (int i = 0; i < arr.Length; i++)
                    CharacteristicsOfFigures[i] = arr[i];
            }

            public override double GetArea()
            {
                return Height() * (CharacteristicsOfFigures[0] + CharacteristicsOfFigures[1]) / 2;
            }

            public override double GetPerimeter()
            {
                return CharacteristicsOfFigures.Sum();
            }

            private double Height()
            {
                double temp = (Math.Pow(CharacteristicsOfFigures[1] - CharacteristicsOfFigures[0], 2) + (CharacteristicsOfFigures[2] * CharacteristicsOfFigures[2]) - (CharacteristicsOfFigures[3] * CharacteristicsOfFigures[3])) / (2 * (CharacteristicsOfFigures[1] - CharacteristicsOfFigures[2]));
                return Math.Sqrt(CharacteristicsOfFigures[2] * CharacteristicsOfFigures[2] - (temp * temp));
            }
        }
    }
}
