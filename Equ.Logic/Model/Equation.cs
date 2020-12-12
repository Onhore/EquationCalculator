using System;

namespace Equ.Logic.Model
{
    public struct Equation
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public Vector2 Roots { get; private set; }
        public bool HasSolution { get; private set; }

        public Equation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Roots = new Vector2();
            HasSolution = false;
        }

        public override string ToString()
        {
            return $"{A}x² {GetSign(B, "x")} {GetSign(C)}";
        }

        public static string GetSign(double value, string addition = "")
        {
            var str = "";

            if (value > 0) str = $"+ {value}" + addition;
            else if (value < 0) str = $"- {Math.Abs(value)}" + addition;

            return str;
        }

        public static string GetSimpleSign(double value)
        {
            var str = "0";

            if (value > 0) str = value.ToString();
            else if (value < 0) str = $"({value})";

            return str;
        }

        public void SetRoots(double x1, double x2)
        {
            Roots = new Vector2(x1, x2);
            HasSolution = true;
        }
    }
}
