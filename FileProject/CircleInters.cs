using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProject
{
    public class CircleInters
    {
        public double x1=0, y1=0, rad1=0, x2=0, y2=0, rad2=0;
        


        public bool GetIntersection()
        {
            double d = Math.Sqrt((x1 - x2)* (x1 - x2) + (y1 - y2) * (y1 - y2));
            if ((rad1 + rad2 >= d )&& (rad1 + d >= rad2) && (rad2 + d >= rad1))
                return true;
            else
                return false;
        }



    }
}
