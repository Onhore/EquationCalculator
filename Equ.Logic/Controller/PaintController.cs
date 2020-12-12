using System;
using System.Collections.Generic;
using Equ.Logic.Model;

namespace Equ.Logic.Controller
{
    public class PaintController
    {
        public List<Vector2> GetDrawData(Equation equation, double step, double radiusSize)
        {
            var result = new List<Vector2>();

            var Vertex = GetVertex(equation);
            var min = Vertex.X - Math.Abs(equation.A * radiusSize);
            var max = Vertex.X + Math.Abs(equation.A * radiusSize);

            for (double x = min; x <= max; x += step)
            {
                var y = (equation.A * x * x) + (equation.B * x) + equation.C;
                result.Add(new Vector2(x, y));
            }

            return result;

        }

        public bool GetBranchesDirection(Equation equation) => equation.A > 0 ? true : false;
        public Vector2 GetVertex(Equation equation)
        { 
            double xVertex = (-equation.B) / (2 * equation.A);
            double yVertex = (equation.A * xVertex * xVertex) + (equation.B * xVertex) + equation.C;
            return new Vector2(xVertex, yVertex);
        }
        // Область определений
        public Vector2 GetDomain() => new Vector2(double.NegativeInfinity, double.PositiveInfinity); 
        // Область значений
        public Vector2 GetRangeOfValues(Equation equation) => GetBranchesDirection(equation) ? new Vector2(GetVertex(equation).Y, double.PositiveInfinity) : new Vector2(double.NegativeInfinity, GetVertex(equation).Y);
    
    
    }
}
