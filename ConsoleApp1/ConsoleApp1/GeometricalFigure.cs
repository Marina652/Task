namespace ConsoleApp1
{
    abstract class GeometricalFigure
    {
        abstract public double GetArea();
        abstract public double GetPerimeter();

        protected double [] CharacteristicsOfFigures;
        protected string type;
        public string Type => type;
    }
}
