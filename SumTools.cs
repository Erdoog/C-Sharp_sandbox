using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class SumTools
    {
        public static double JumpByTwo(double Nin)
        {
            double Nout = Nin + 2.0;
            int NInt = Convert.ToInt32(Nout);
            if (NInt == Nout)
            {
                return Convert.ToInt32(Nout);
            }
            else
            {
                return Nout;
            }
        }
    }
}