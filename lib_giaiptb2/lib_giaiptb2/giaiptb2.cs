using System;

namespace lib_giaiptb2
{
    public class giaiptb2
    {
        public static void GiaiPTB2(float a, float b, float c)
        {
            float delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co mo nghiem khep: x1 = x2 = {0}", (-b / (2*a)));
            }
            else
            {
                float x1, x2;
                x1 = (float)(-b + Math.Sqrt(delta))/(2*a);
                x2 = (float)(-b - Math.Sqrt(delta))/(2*a);
                Console.WriteLine("Nghiem thu nhat la: {0}", x1);
                Console.WriteLine("Nghiem thu hai la: {0}", x2);
            }
        }
    }
}
