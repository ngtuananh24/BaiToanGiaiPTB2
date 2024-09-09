using System;

namespace lib_giaiptb2
{
    public class giaiptb2
    {
        public static string GiaiPTB2(float a, float b, float c)
        {
            float delta = b * b - 4 * a * c;
            if (a == 0) { return "day khong phai ptb2"; }
            if (delta < 0)
            {
                return "PTVN";
            }
            else if (delta == 0)
            {
                float nghiemKep = -b / (2 * a);
                nghiemKep = (float)((int)(nghiemKep * 100)) / 100;
                return $"{nghiemKep}";
            }
            else
            {
                float x1 = (float)((int)((-b + Math.Sqrt(delta)) / (2 * a) * 100)) / 100;
                float x2 = (float)((int)((-b - Math.Sqrt(delta)) / (2 * a) * 100)) / 100;
                return $"{x1},{x2}";
            }
        }
    }
}
