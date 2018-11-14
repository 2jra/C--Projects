using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Perimetro
    {
        public static int PeriTriangulo(int ladoA, int ladoB, int ladoC)
        {
            return ladoA + ladoB + ladoC;
        }

        public static int PeriCuadrado(int lado)
        {
            return lado * 4;
        }

        public static int PeriRectangulo(int ladoA, int ladoB)
        {
            return 2 * (ladoA + ladoB);
            
        }

        public static int PeriRombo(int ladoA)
        {
            return ladoA * 4;     
        }

        public static int PeriRomboide(int ladoA, int ladoB)
        {
            return 2 * (ladoA + ladoB);
        }

        public static int PeriTrapecio(int ladoA, int ladoB, int ladob, int ladoa)
        {
            return ladoA + ladoB + ladob + ladoa;
            
        }

        public static int PeriTrapezoide(int ladoA, int ladoB, int ladoa, int ladob)
        {
            return ladoa + ladoA + ladoB + ladob; 
        }

        public static int PeriPoligReg(int ladoA)
        {
            return ladoA * 6;
        }
    }
}
