using System;
using System.Text;

namespace labs
{

    class Program
    {

        static void Chao()
        {
            checked
            {
                int max = int.MaxValue;
                max = max + 1;
                Console.WriteLine(max);
            }

        }

        static void Kao()
        {
            unchecked
            {
                int max = int.MaxValue;
                max = max + 1;
                Console.WriteLine(max);
            }
        }

        static (int max, int min, int sum, string letter) function(int[] arr, string st)
        {
            var resultt = (max: 0, min: 0, sum: 0, let: "");
            resultt.min = arr[0];
            resultt.max = arr[0];
            resultt.sum = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > resultt.max)
                {
                    resultt.max = arr[i];
                }
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < resultt.min)
                {
                    resultt.min = arr[i];
                }
            }

            resultt.let = st.Substring(0, 1);

            for (int i = 0; i < arr.Length; i++)
            {
                resultt.sum += arr[i];
            }

            return resultt;
        }

        static void Main()
        {
            // bool a = true;
            // Console.WriteLine("bool: " + a);
            // byte b = 128;
            // Console.WriteLine("byte: " + b);
            // sbyte c = 127;
            // Console.WriteLine("sbyte: " + c);
            // char d = '\x173';
            // Console.WriteLine("char: " + d);
            // decimal e = 2.1m;
            // Console.WriteLine("decimal: " + e);
            // double f = 12.3;
            // Console.WriteLine("double: " + f);
            // float g = 134.45E-2f;
            // Console.WriteLine("float: " + g);
            // int h = 24;
            // Console.WriteLine("int: " + h);
            // uint k = 48;
            // Console.WriteLine("uint: " + k);
            // nint l = 72;
            // Console.WriteLine("nint: " + l);
            // nuint m = 96;
            // Console.WriteLine("nuint: " + m);
            // long n = 128;
            // Console.WriteLine("long: " + n);
            // ulong o = 256;
            // Console.WriteLine("ulong: " + o);
            // short p = 512;
            // Console.WriteLine("short: " + p);
            // ushort r = 1024;
            // Console.WriteLine("ushort: " + r);
            // // Явные
            // //1
            // double qq = 1234.7;
            // int aa;
            // aa = (int)qq;
            // Console.WriteLine("aa: " + aa);
            // //2
            // short ww = 123;
            // byte ee;
            // ee = (byte)ww;
            // Console.WriteLine("ee: " + ee);
            // //3
            // float rr = 2411;
            // decimal tt;
            // tt = (decimal)rr;
            // Console.WriteLine("tt: " + tt);
            // //4
            // sbyte yy = 127;
            // byte qa;
            // qa = (byte)yy;
            // Console.WriteLine("qa:" + qa);
            // //5
            // nuint qaz = 1234;
            // int qw;
            // qw = (int)qaz;
            // Console.WriteLine("qw: " + qw);
            // //Невяные
            // //1
            // sbyte z = 123;
            // int az = z;
            // Console.WriteLine("az:" + az);
            // //2
            // byte zxc = 121;
            // short cxz = zxc;
            // Console.WriteLine("cxz: " + cxz);
            // //3
            // long qwe = 23;
            // double ewq = qwe;
            // Console.WriteLine("ewq:" + ewq);
            // //4
            // int pp = 4;
            // double po = pp;
            // Console.WriteLine("po: " + po);
            // //5
            // long nn = 32;
            // float mn = nn;
            // Console.WriteLine("mn: " + mn);
            // //convert
            // int q = Convert.ToInt32("23");
            // bool t = true;
            // double j = Convert.ToDouble(t);
            // Console.WriteLine($"q={q}  j={j}");
            // //упаковка
            // int i = 321;
            // object oop = i;
            // i = 123;
            // Console.WriteLine(oop);
            // Console.WriteLine(i);
            // //распаковка
            // oop = 123;
            // i = (int)oop;
            // Console.WriteLine(oop);
            // Console.WriteLine(i);
            // //Невяно типизированная переменная
            // var abc = 123.7;
            // var qwerty = "qwe";
            // Console.WriteLine(abc.GetType());
            // Console.WriteLine(qwerty.GetType());
            // //Nullable
            // System.Nullable<int> one = 123;
            // // int ome = null;
            // var zxv = 234; //var строго типизированная
            // long bv = zxv;
            // Console.WriteLine(bv.GetType());
            // //Строковые литералы
            // // Используем перенос строки
            // Console.WriteLine("Первая строка\nВторая строка\nТретья строка\n");

            // // Используем вертикальную табуляцию
            // Console.WriteLine("Первый столбец \vВторой столбец \vТретий столбец \n");

            // // Используем горизонтальную табуляцию
            // Console.WriteLine("One\tTwo\tThree");
            // Console.WriteLine("Four\tFive\tSix\n");

            // //Вставляем кавычки
            // Console.WriteLine("\"Зачем?\", - спросил он");

            // string s1 = "hi";
            // string s2 = "hello";
            // string s3 = "bye, see you later";
            // //Сцепление
            // string s4 = s1 + s2;
            // //Копирование
            // string s5 = s1;
            // //Выделение подстроки
            // int found = 0;
            // found = s3.IndexOf(", ");
            // Console.WriteLine(s3.Substring(found + 2));
            // //Разделение строки на слова
            // string text = "И поэтому все так произошло";

            // string[] words = text.Split(' ');

            // foreach (string s in words)
            // {
            //     Console.WriteLine(s);
            // }
            // //вставка подстроки в заданную позицию
            // string text1 = "Hello, are you?";
            // string text2 = "how ";
            // text1 = text1.Insert(7, text2);
            // Console.WriteLine(text1);

            // //удаление заданной подстроки
            // s3 = s3.Remove(0, 5);
            // Console.WriteLine(s3);
            // //Интерполирование
            // string s11 = "Jhon";
            // var date = DateTime.Now;
            // Console.WriteLine($"Hello, {s11}! Today is {date.DayOfWeek}, its {date:HH:mm}.");
            // //isNullOrEmppty
            // string a1 = "";
            // string b1 = null;
            // string c1 = "agh";
            // bool a1IsNullOrEmpty = string.IsNullOrEmpty(a1);
            // bool b1IsNullOrEmpty = string.IsNullOrEmpty(b1);
            // bool c1IsNullOrEmpty = string.IsNullOrEmpty(c1);
            // Console.WriteLine("{0} \n{1} \n{2}\n", a1IsNullOrEmpty, b1IsNullOrEmpty, c1IsNullOrEmpty);

            // Console.WriteLine("Введите слово: ");
            // var word = Console.ReadLine();
            // if (string.IsNullOrEmpty(word))
            // {
            //     Console.WriteLine("Вы не ввели слово.");
            // }
            // else
            // {
            //     Console.WriteLine($"Вы ввели слово: {word}");
            // }
            // StringBuilder sb = new StringBuilder("Привет, как дела?");
            // sb = sb.Remove(0, 8);
            // sb = sb.Insert(0, "Хэй, ");
            // sb = sb.AppendFormat("!");
            // Console.WriteLine(sb);

            // Console.WriteLine("Введите количество строк массива");
            // int nnn = int.Parse(Console.ReadLine());
            // Console.WriteLine("Введите количество столбцов массива");
            // int mm = int.Parse(Console.ReadLine());
            // int[,] aaa = new int[nnn, mm];



            // for (int ii = 0; ii < nnn; ii++)

            //     for (int jj = 0; jj < mm; jj++)
            //     {

            //         Console.WriteLine("Введите X{0},{1} эллемент массива A", ii, jj);
            //         aaa[ii, jj] = Convert.ToInt32(Console.ReadLine());


            //     }

            // for (int ii = 0; ii < nnn; ii++)
            // {
            //     Console.WriteLine();
            //     for (int jj = 0; jj < mm; jj++)
            //     {
            //         Console.Write($"{aaa[ii, jj]}\t");

            //     }
            // }
            // Console.WriteLine();
            // string[] names = { "James", "Michael", "Antony", "Jackson", "Franklin" };
            // for (int iq = 0; iq < names.Length; iq++)
            // {
            //     Console.Write($"{names[iq]} ");
            // }
            // Console.WriteLine($"\nДлина массива: {names.Length}");
            // Console.Write("Введите позицию: ");
            // int num = int.Parse(Console.ReadLine());
            // Console.Write("\nВведите значение: ");
            // var num1 = (Console.ReadLine());
            // if (num >= 0)
            // {
            //     names[num - 1] = num1;
            // }
            // for (int iq1 = 0; iq1 < names.Length; iq1++)
            // {
            //     Console.Write($"{names[iq1]} ");
            // }

            // int[][] stup = new int[3][];
            // stup[0] = new int[2];
            // stup[1] = new int[3];
            // stup[2] = new int[4];

            // for (int icq = 0; icq < stup.Length; icq++)
            // {
            //     for (int jq = 0; jq < stup[icq].Length; jq++)
            //     {
            //         Console.Write($"\nВведите {jq + 1} элемент {icq + 1} строки: ");
            //         stup[icq][jq] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            // for (int icq = 0; icq < stup.Length; icq++)
            // {
            //     for (int jq = 0; jq < stup[icq].Length; jq++)
            //     {
            //         Console.Write(stup[icq][jq] + "\t");
            //     }
            //     Console.WriteLine();
            // }

            // var A = new[] { 5, 6, 7, 8, 9, 10 };
            // var B = new[] { "A", "B", "C", "D" };

            (int, string, char, string, ulong) tuple = (25, "Hello", 'A', "Bye", 12);
            Console.WriteLine($"{tuple.Item1} {tuple.Item2} {tuple.Item3} {tuple.Item4} {tuple.Item5}");
            Console.WriteLine($"{tuple.Item1} {tuple.Item3} {tuple.Item4}");
            // (int date, string word, char letter, string word2, ulong number) = tuple;
            // var (date, word, letter, word2, number) = tuple;
            // int date = 12;
            // string word = "qwe";
            // char letter = 'B';
            // string word2 = "ewq";
            // ulong number = 11;
            // (date, word, letter, word2, number) = tuple;
            // var (_, _, _, word2, number) = tuple;

            var tupleA = (one: 1, two: 2, three: 3);
            var tupleB = (a: 1, b: 2, c: 3);
            if (tupleA == tupleB)
            {
                Console.WriteLine("Значения кортежей одинаковы");
            }
            else
                Console.WriteLine("Значения котрежей различны");


            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            string stringg = "Hello";
            var tuple2 = function(new int[] { 10, 20, 30, 40, 50 }, stringg);


            Console.WriteLine($"Кортеж: {tuple2}");
            Console.WriteLine($"Max = {tuple2.max}");
            Console.WriteLine($"Min = {tuple2.min}");
            Console.WriteLine($"Sum = {tuple2.sum}");
            Console.WriteLine($"Letter = {tuple2.letter}");


            Kao();
            Chao();
        }

    }

}
