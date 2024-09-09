using System;

namespace BaiToanGiaiPTB2
{
    internal class Program
    {
        static void giaiPTb2(float a, float b, float c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem: x = {0}", (-c / 2*a));
                }
                return;
            }
            float delta = b * b - 4 * a * c;
            float x1, x2;
            if (delta > 0)
            {
                x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem la: x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("Phuong trinh co 1 nghiem kep x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap he so a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Nhap he so b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Nhap he so c: ");
                float c = float.Parse(Console.ReadLine());

                giaiPTb2(a, b, c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Gia tri nhap khong hop le. Vui long nhap so thuc.");
            }
            Console.ReadLine();
        }
    }
}
