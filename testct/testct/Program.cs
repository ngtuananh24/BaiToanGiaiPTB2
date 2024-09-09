using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_giaiptb2;
namespace testct
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string kq =  giaiptb2.GiaiPTB2(1, -49, -50);
            Console.Write(kq);
            Console.ReadLine();
        }
    }
}
