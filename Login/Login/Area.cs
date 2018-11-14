using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Area
    {
        public static int AreaTriangulo(int ladoA, int ladoB)
        {
            return (ladoA * ladoB) / 2;
        }

        public static int AreaCuadrado(int lado)
        {
            return lado * lado;
        }

        public static int AreaRectangulo(int ladoA, int ladoB)
        {
            return ladoA * ladoB;
        }

        public static int AreaRombo(int ladoA, int ladoB)
        {
            return (ladoA * ladoB) / 2;
        }

        public static int AreaRomboide(int ladoA, int ladoB)
        {
            return ladoA * ladoB;
        }

        public static int AreaTrapecio(int ladoA, int ladoB, int ladob)
        {
            return ladoA * (ladoB + ladob) / 2;
        }

        public static int AreaTrapezoide(int ladoA, int ladoB, int ladoa, int ladob)
        {
            int Area1 = (ladoA * ladoB) / 2;
            int Area2 = (ladoa * ladob) / 2;
            return Area1 + Area2;
        }

        public static int AreaPoligonoRegular(int ladoA, int ladoB)
        {
            return (6 * ladoA * ladoB) / 2;
        }
    }
}
