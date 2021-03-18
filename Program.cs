using System;

namespace GuidVector
{
    // http://www.mathprofi.ru/uravnenie_pryamoi_na_ploskosti.html#p
    // Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.
    // Если прямая задана общим уравнением  ax + by + c = 0, то вектор p(-b; a) является направляющим вектором данной прямой,
    // а вектор p(a; b) является вектором нормали данной прямой.
    class Program
    {
        class Vector
        {
            public double A { get; set; }
            public double B { get; set; }
            public Vector(double a, double b)
            {
                A = a;
                B = b;
             }

            public void PrintVector(string s)
            {
                Console.WriteLine("{0} - ({1}, {2})", s, A, B);  
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение прямой задано Аx + By + C = 0.");
            Console.WriteLine("Введите коэффициент А:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент B:");
            double b = double.Parse(Console.ReadLine());
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Нулевые векторы");
                return;
            }
            Vector v = new Vector(-b, a);
            // можно учесть ситуацию, когда А или В = 0, тогда вектор будет иметь координаты (1;0) и (0;1) соот-но
            v.PrintVector("Направляющий вектор прямой");
            Vector vv = new Vector(a, b);
            vv.PrintVector("Нормальный вектор прямой")
        }
    }
}
