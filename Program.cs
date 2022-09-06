using System;
using System.Text;

namespace labs
{

    class Program
    {

        static void Main()
        {
            bool a = true;
            Console.WriteLine("bool: " + a);
            byte b = 128;
            Console.WriteLine("byte: " + b);
            sbyte c = 127;
            Console.WriteLine("sbyte: " + c);
            char d = '\x173';
            Console.WriteLine("char: " + d);
            decimal e = 2.1m;
            Console.WriteLine("decimal: " + e);
            double f = 12.3;
            Console.WriteLine("double: " + f);
            float g = 134.45E-2f;
            Console.WriteLine("float: " + g);
            int h = 24;
            Console.WriteLine("int: " + h);
            uint k = 48;
            Console.WriteLine("uint: " + k);
            nint l = 72;
            Console.WriteLine("nint: " + l);
            nuint m = 96;
            Console.WriteLine("nuint: " + m);
            long n = 128;
            Console.WriteLine("long: " + n);
            ulong o = 256;
            Console.WriteLine("ulong: " + o);
            short p = 512;
            Console.WriteLine("short: " + p);
            ushort r = 1024;
            Console.WriteLine("ushort: " + r);
            // Явные
            //1
            double qq = 1234.7;
            int aa;
            aa = (int)qq;
            Console.WriteLine("aa: " + aa);
            //2
            short ww = 123;
            byte ee;
            ee = (byte)ww;
            Console.WriteLine("ee: " + ee);
            //3
            float rr = 2411;
            decimal tt;
            tt = (decimal)rr;
            Console.WriteLine("tt: " + tt);
            //4
            sbyte yy = 127;
            byte qa;
            qa = (byte)yy;
            Console.WriteLine("qa:" + qa);
            //5
            nuint qaz = 1234;
            int qw;
            qw = (int)qaz;
            Console.WriteLine("qw: " + qw);
            //Невяные
            //1
            sbyte z = 123;
            int az = z;
            Console.WriteLine("az:" + az);
            //2
            byte zxc = 121;
            short cxz = zxc;
            Console.WriteLine("cxz: " + cxz);
            //3
            long qwe = 23;
            double ewq = qwe;
            Console.WriteLine("ewq:" + ewq);
            //4
            int pp = 4;
            double po = pp;
            Console.WriteLine("po: " + po);
            //5
            long nn = 32;
            float mn = nn;
            Console.WriteLine("mn: " + mn);
            //convert
            int q = Convert.ToInt32("23");
            bool t = true;
            double j = Convert.ToDouble(t);
            Console.WriteLine($"q={q}  j={j}");
            //упаковка
            int i = 321;
            object oop = i;
            i = 123;
            Console.WriteLine(oop);
            Console.WriteLine(i);
            //распаковка
            oop = 123;
            i = (int)oop;
            Console.WriteLine(oop);
            Console.WriteLine(i);
            //Невяно типизированная переменная
            var abc = 123.7;
            var qwerty = "qwe";
            Console.WriteLine(abc.GetType());
            Console.WriteLine(qwerty.GetType());
            //Nullable
            System.Nullable<int> one = 123;
            // int ome = null;
            var zxv = 234; //var строго типизированная
            long bv = zxv;
            Console.WriteLine(bv.GetType());
            //Строковые литералы
            // Используем перенос строки
            Console.WriteLine("Первая строка\nВторая строка\nТретья строка\n");

            // Используем вертикальную табуляцию
            Console.WriteLine("Первый столбец \vВторой столбец \vТретий столбец \n");

            // Используем горизонтальную табуляцию
            Console.WriteLine("One\tTwo\tThree");
            Console.WriteLine("Four\tFive\tSix\n");

            //Вставляем кавычки
            Console.WriteLine("\"Зачем?\", - спросил он");

            string s1 = "hi";
            string s2 = "hello";
            string s3 = "bye, see you later";
            //Сцепление
            string s4 = s1 + s2;
            //Копирование
            string s5 = s1;
            //Выделение подстроки
            int found = 0;
            found = s3.IndexOf(", ");
            Console.WriteLine(s3.Substring(found + 2));
            //Разделение строки на слова
            string text = "И поэтому все так произошло";

            string[] words = text.Split(' ');

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            //вставка подстроки в заданную позицию
            string text1 = "Hello, are you?";
            string text2 = "how ";
            text1 = text1.Insert(7, text2);
            Console.WriteLine(text1);

            //удаление заданной подстроки
            s3 = s3.Remove(0, 5);
            Console.WriteLine(s3);
            //Интерполирование
            string s11 = "Jhon";
            var date = DateTime.Now;
            Console.WriteLine($"Hello, {s11}! Today is {date.DayOfWeek}, its {date:HH:mm}.");
            //isNullOrEmppty
            string a1 = "";
            string b1 = null;
            string c1 = "agh";
            bool a1IsNullOrEmpty = string.IsNullOrEmpty(a1);
            bool b1IsNullOrEmpty = string.IsNullOrEmpty(b1);
            bool c1IsNullOrEmpty = string.IsNullOrEmpty(c1);
            Console.WriteLine("{0} \n{1} \n{2}\n", a1IsNullOrEmpty, b1IsNullOrEmpty, c1IsNullOrEmpty);

            Console.WriteLine("Введите слово: ");
            string? word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Вы не ввели слово.");
            }
            else
            {
                Console.WriteLine($"Вы ввели слово: {word}");
            }
            StringBuilder sb = new StringBuilder("Привет, как дела?");
            sb = sb.Remove(0, 8);
            sb = sb.Insert(0, "Хэй, ");
            sb = sb.AppendFormat("!");
            Console.WriteLine(sb);
        }

    }

}