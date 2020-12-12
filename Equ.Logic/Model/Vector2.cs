using System;

namespace Equ.Logic.Model
{
    public class Vector2
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vector2() { }
        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vector2)) return false;
            if (obj == null) return false;

            return X == ((Vector2)obj).X && Y == ((Vector2)obj).Y ? true : false;
        }

        // Я не тупой, просто warn'ы мне мешают.
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"({Math.Round(X, 2)}; {Math.Round(Y, 2)})";
        }

        public string ExactValueToString()
        {
            return $"({X}; {Y})";
        }

        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            if (v1 == null || v2 == null) return false;

            return v1.X == v2.X && v1.Y == v2.Y ? true : false;

        }

        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            if (v1 == null || v2 == null) return false;

            return v1.X == v2.X && v1.Y == v2.Y ? false : true;
        }
    }
}
