namespace ConsoleApp1
{
    partial class Program
    {
        class Rectangle: GeometricalFigure
        {
            public Rectangle(params double[] arr)
            {
                this.CharacteristicsOfFigures = new double[2];
                this.type = "Прямоугольник";
                
                for (int i = 0; i < arr.Length; i++)
                    CharacteristicsOfFigures[i] = arr[i];
            }

            public override double GetArea()
            {
                return CharacteristicsOfFigures[0] * CharacteristicsOfFigures[1]; 
            }

            public override double GetPerimeter()
            {
                return 2 * (CharacteristicsOfFigures[0] + CharacteristicsOfFigures[1]);
            }
        }
    }
    
}
