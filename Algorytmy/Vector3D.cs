using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    struct Vector3D
    {
        public double x, y, z, normEuclides;
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.normEuclides = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        public void PrintVector()
        {
            Console.WriteLine("[{0} ; {1} ; {2}]", this.x, this.y, this.z);
        }
        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static double operator *(Vector3D a, Vector3D b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
    }
}
