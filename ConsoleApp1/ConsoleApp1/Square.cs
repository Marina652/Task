namespace ConsoleApp1
{
    partial class Program
    {
        class Square: GeometricalFigure
        {
            public Square(params double[] arr)
            {
                this.CharacteristicsOfFigures = new double[1];
                this.type = "Квадрат";
               
                for (int i = 0; i < arr.Length; i++)
                    CharacteristicsOfFigures[i] = arr[i];   
            }

            public override double GetArea()
            {
                return 2 * CharacteristicsOfFigures[0];
            }

            public override double GetPerimeter()
            {
                return 4 * CharacteristicsOfFigures[0];
            }
        }
    }
}
