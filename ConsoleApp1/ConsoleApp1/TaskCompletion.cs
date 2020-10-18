using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class TaskCompletion
    {
        static public string MaxArea(LinkedList<GeometricalFigure> lst)
        {
            string TypemaxArea = "";
            count = lst.Count;
            for(int i = 0; i < count; i++)
            {
                if(maxArea < lst.ElementAt(i).GetArea())
                    maxArea = lst.ElementAt(i).GetArea();
                TypemaxArea = lst.ElementAt(i).Type;           
            }
            return TypemaxArea;
        }

        static public double AveragePerimeter(LinkedList<GeometricalFigure> lst)
        {
            count = lst.Count;
            for (int i = 0; i < count; i++)
                SumPerimeter += lst.ElementAt(i).GetPerimeter();
            return SumPerimeter / count;
        }

        static public double AverageArea(LinkedList<GeometricalFigure> lst)
        {
            count = lst.Count;
            for (int i = 0; i < count; i++)
                SumArea += lst.ElementAt(i).GetArea();
            return SumArea / count;
        }

        static public string FigureTypeWithTheHighestMeanPerimeter(LinkedList<string> ListFigure, LinkedList<GeometricalFigure> lst)
        {
            count = lst.Count;
            string TypeOfFigure = "";
           
            foreach(var figure in ListFigure)
            {
                SumPerimeter = 0;
                TempCount = 0;
                foreach (var list in lst)
                {
                    if (list.Type == figure)
                    {
                        SumPerimeter += list.GetPerimeter();
                        TempCount++;
                    }
                }

                if (averagePerimeter < SumPerimeter / TempCount)
                {
                    averagePerimeter = SumPerimeter / TempCount;
                    TypeOfFigure = figure;
                }
            }
            return TypeOfFigure;
        }

        static private int count, TempCount;
        static private double maxArea = 0, SumPerimeter = 0, averagePerimeter = 0, SumArea = 0;
    

    }
}
