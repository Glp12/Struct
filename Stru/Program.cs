using System;

namespace Struct
{
    public struct Vector3
    {
        public int x;
        public int y;
        public int z;
        public Vector3 GetVector(int x,int y,int z)
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
            
        }
    }
}
