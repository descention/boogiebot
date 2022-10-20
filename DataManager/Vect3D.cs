using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Vector3
    {
        private double x, y, z;

        public Vector3(double cx, double cy, double cz)
        {
            x = cx; y = cy; z = cz;
        }

        public float Length
        {
            get { return (float)Math.Sqrt(x * x + y * y + z * z); }
        }

        // Returns length of Vector, without performing square root. Useful if you just want
        // to compare vector sizes and don't want to take the performance hit.
        public double LengthFast
        {
            get { return (x * x + y * y + z * z); }
        }

        public override String ToString()
        {
            return String.Format("xyz = [{0}, {1}, {2}]", x, y, z);
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }
    }

    public class Vector4
    {
        private double x, y, z,o;

        public Vector4(double cx, double cy, double cz, double co)
        {
            x = cx; y = cy; z = cz; o = co;
        }

        public float Length
        {
            get { return (float)Math.Sqrt(x * x + y * y + z * z); }
        }

        // Returns length of Vector, without performing square root. Useful if you just want
        // to compare vector sizes and don't want to take the performance hit.
        public double LengthFast
        {
            get { return (x * x + y * y + z * z); }
        }

        public override String ToString()
        {
            return String.Format("xyz = [{0}, {1}, {2}]", x, y, z);
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public double O
        {
            get { return o; }
            set { o = value; }
        }
    }
}
