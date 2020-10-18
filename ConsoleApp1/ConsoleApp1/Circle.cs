namespace ConsoleApp1
{
    class Circle : GeometricalFigure
    {
        public Circle(params double[] arr)
        {
            this.type = "Круг";
            this.CharacteristicsOfFigures = new double[1];
            
            for (int i = 0; i < arr.Length; i++)
                CharacteristicsOfFigures[i] = arr[i];
        }

        public override double GetArea()
        {
            return CharacteristicsOfFigures[0] * CharacteristicsOfFigures[0] * System.Math.PI;
        }

        public override double GetPerimeter()
        {
            return 2 * CharacteristicsOfFigures[0] * System.Math.PI;
        }
    }
}
