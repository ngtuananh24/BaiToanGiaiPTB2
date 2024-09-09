﻿using System;

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
                return "Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                float nghiemKep = -b / (2 * a);
                return $"Phuong trinh co mot nghiem khep: x1 = x2 = {nghiemKep}";
            }
            else
            {
                float x1, x2;
                x1 = (float)(-b + Math.Sqrt(delta))/(2*a);
                x2 = (float)(-b - Math.Sqrt(delta))/(2*a);
                return $"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}";
            }
        }
    }
}
