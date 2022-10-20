using System;
using System.Collections.Generic;
using System.Text;
using IcarusBot.Core;

namespace BenderBot.Common
{
    public class Location2
    {
        public Location2(float cx, float cy, float cz)
        {
            x = cx; y = cy; z = cz;
        }

        public Location2(float cx, float cy, float cz, float co)
        {
            x = cx; y = cy; z = cz; o = co;
        }

        public Location2(String s)
        {
            String[] t = s.Split(new char[] {' '});

            if (t.Rank >= 0)
                float.TryParse(t[0], out x);
            if (t.Rank >= 1)
                float.TryParse(t[1], out y);
            if (t.Rank >= 2)
                float.TryParse(t[2], out z);
            if (t.Rank >= 3)
                float.TryParse(t[3], out o);
        }

        public override String ToString()
        {
            return String.Format("xyz = ({0}, {1}, {2})  Orient = ({3})", x, y, z, o);
        }

        public double DistanceTo(Location c)
        {
            double dx = x - c.X;
            double dy = y - c.Y;
            double dz = z - c.Z;
            return (double)Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float Z
        {
            get { return z; }
            set { z = value; }
        }

        public float O
        {
            get { return o; }
            set { o = value; }
        }

     
    } 
}
