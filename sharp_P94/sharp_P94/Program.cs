using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_P94
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "12345";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "1.234";
            float h = float.Parse(g);
            Console.WriteLine(h);
        }
    }
}
