using System;

namespace LabRob5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, S, a, p, d, ch, zn;
            int k;
        m1: Console.WriteLine(" Введите значение х");
            x = double.Parse((Console.ReadLine()));
            Console.WriteLine('\t' + "Промежуточные результати "+'\n');
            k = 0;
            S = 0; p = 1;
            d = 1;
            a = x;
            while (Math.Abs(a) >= 0.000001)
            {
                S += a;
                ch = x*d;
                zn = p;
                p += 2;
                d = x * x;
                a =2*( ch / zn);
                k++;
                Console.WriteLine('\t' + " Итерация №" + k + '\n' + " a = " + a + " S = " + S + "\n");
            }
            y = Math.Log((1f + x) / (1f - x));
            Console.WriteLine('\t' + "    Результаты:" + '\n' + " Заданый х = " + x + '\n' + " Вычеслиная сумма ряда S = " + S + '\n' + " Количество членов ряда " + k + '\n' + " Функция Ln = " + y + '\n');
            Console.WriteLine('\n' + "Для повторного ввода" + " Набрать любую клавишу." + '\n' + " Для завершения программы нажмите Enter.");
            string rep = Console.ReadLine();
            if (rep != "") goto m1;
        
        }
    }
}
