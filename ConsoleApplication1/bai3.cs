using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bai3
    {
        private int ma;
        private int mb;
        private int mc;

        public int getCanhA()
        {
            return ma;
        }
        public int getCanhB()
        {
            return mb;
        }
        public int getCanhC()
        {
            return mc;
        }
        public void setCanhA(int a)
        {
            ma = a;
        }
        public void setCanhB(int b)
        {
            mb = b;
        }
        public void setCanhC(int c)
        {
            mc = c;
        }
       
        public double ChuVi()
        {
            return ma + mb + mc;
        }
        public double dientich()
        {

        }
    }
}
