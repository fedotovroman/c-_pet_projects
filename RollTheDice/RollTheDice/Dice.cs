using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheDice
{
    class Dice
    {
        int[,] a;
        public Dice(int [,] split)
            =>a = split;
        public int NeighboursNumber(int[,] va,int x,int y)
        {
            int res = 0;
            foreach (int[] el in new int[][]{new int[] { 1, 0 }, new int[]  { 0, 1 }, new int[] { -1,0 }, new int[] { 0, -1 } })
            {
                int xx = x + el[0];
                int yy = y + el[1];
                res += Convert.ToInt32(-1<xx && 4 > xx && -1 < yy && 4 > yy && va[xx,yy]!=0);
            }
            return res;
        }
        public int[,] Clear(ref int res,int [,] va)
        {
            int[,] b=new int[4,4];    
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                {
                    if (va[x, y] == 0)
                    {
                        continue;
                    }
                    if (va[x, y]!=NeighboursNumber(va,x,y))
                    {
                        b[x, y] = va[x, y];
                    }
                    else
                    {
                        res++;
                    }
                }
            return b;
        }


        public int ReplaceClear(int[,] supa ,int x1,int  x2, int y1,int y2)//Поставь на ( x2 y2 ) фишку с (x1 y1)
        {
            int [,] va=(int[,])supa.Clone();
            va[x2, y2] = va[x1, y1];
            va[x1, y1] = 0;
            int res = 0;
            while (true)
            {
                int q = 0;
                va = Clear(ref q,va);
                if (q == 0)
                {
                    return res;      
                }
                else { res += q; }
            }
        }

        public int Solve(int[,] va)
        {
            int ans = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (va[x, y] == 0)
                    {
                        continue;
                    }
                    for (int xx = 0; xx < 4; xx++)
                    {
                        for (int yy = 0; yy < 4; yy++)
                        {
                            if (va[xx, yy] != 0)
                            {
                                continue;
                            }
                            int t= ReplaceClear(va,x,y,xx,yy);
                            if (t > ans){
                                ans = t;
                            }
                        }
                    }
                }
            }
            return ans;
        }

    }
}
