using System;
using System.Linq;

namespace ConsoleApp1
{
    class Triangle : GeometricalFigure
    {
        public Triangle(params double[] arr)
        {
            this.CharacteristicsOfFigures = new double[3];
            this.type = "Треугольник";
            
            for (int i = 0; i < arr.Length; i++)
                CharacteristicsOfFigures[i] = arr[i];
        }

        public override double GetArea()
        {
            double p = CharacteristicsOfFigures.Sum() / 2;
            return Math.Sqrt(p * (p - CharacteristicsOfFigures[0]) * (p - CharacteristicsOfFigures[1]) * (p - CharacteristicsOfFigures[2]));
        }

        public override double GetPerimeter()
        {
            return CharacteristicsOfFigures.Sum();
        }
    }
}
