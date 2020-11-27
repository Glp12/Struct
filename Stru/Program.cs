using System;

namespace Struct
{
    public struct Simulation { 
        public double t;
        public int v0;
        public int al;
        public Simulation GetVector(double t, int v0, int al)
        {
            this.t = t;
            this.v0 = v0;
            this.al = al;
            return this;
        }
        public void StartSimulation(Vector3 vector, double t, int v0, int al)
        {
            double h = 0;
            while (vector.y >= 0)
            {
                (vector.y, t) = Expirement(vector, t, v0, al,h);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private (double,double) Expirement(Vector3 vector, double t, int v0, int al,double h)
        {
            vector.x = v0 * t * Math.Cos(al);
            vector.y = v0 * t * Math.Sin(al) - (9.8 * t * t) / 2;
            t += 0.016;
            if (h < vector.y)
            {
                h = vector.y;
            }
            Console.WriteLine(vector);
            Console.WriteLine(t);
            Console.WriteLine(vector.x);
            Console.WriteLine(h);
            return (vector.y,t);
        }
    }
    public struct Vector3
    {
        public double x;
        public double y;
        public double z;
        public Vector3 GetVector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            return this;
        }
        public override string ToString() 
            => "(" + x + "," + y + "," + z + ")";
        public double Length() 
            => Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        public static Vector3 operator +(Vector3 Vector, Vector3 Vector1) 
            => new Vector3().GetVector(Vector.x + Vector1.x, Vector.y + Vector1.y, Vector.z + Vector1.z);
        public static Vector3 operator -(Vector3 Vector, Vector3 Vector1)
            => new Vector3().GetVector(Vector.x - Vector1.x, Vector.y - Vector1.y, Vector.z - Vector1.z);
        public static Vector3 operator *(Vector3 Vector, Vector3 Vector1)
            => new Vector3().GetVector(Vector.x * Vector1.x, Vector.y * Vector1.y, Vector.z * Vector1.z);
        public static Vector3 operator *(Vector3 Vector, int i)
            => new Vector3().GetVector(Vector.x * i, Vector.y * i, Vector.z * i);
        public static Vector3 operator /(Vector3 Vector, int i)
            => new Vector3().GetVector(Vector.x / i, Vector.y / i, Vector.z / i);
    }
   public class Program
    {
        static void Main()
        {
            Vector3 a = new Vector3().GetVector(0, 0, 0);
            Simulation b = new Simulation().GetVector(0, 10, 45);
            b.StartSimulation(a, b.t, b.v0, b.al);
    }
    }
}
