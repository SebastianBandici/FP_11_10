using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setul1_Pr1();
            //Setul1_Pr2();
            //Setul1_Pr3();
            //Setul1_Pr4();
            //Setul1_Pr5();
            //Setul1_Pr6();
            //Setul1_Pr7();
            //Setul1_Pr8();
            //Setul1_Pr9();
            //Setul1_Pr10();
            //Setul1_Pr11();
            //Setul1_Pr12();
            //Setul1_Pr13();
            //Setul1_Pr14();
            //Setul1_Pr15();
            //Setul1_Pr16();
            //Setul1_Pr17();
            //Setul1_Pr18();
            Setul1_pr19();


        }

        private static void Setul1_pr19()
        {
            Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");
            Console.WriteLine();
            Console.Write("n =");
            int n = int.Parse(Console.ReadLine());
            int a, r;

            a = n % 10;
            while (n > 0)
            {
                n = n / 10;
                
                if (n % 10 == a)
                {

                }
                
            }

            int val = 4;
            var builder = new StringBuilder();

            builder.Append("There are ");
            builder.Append(val).ToString();
            builder.Append(" hawks");

            Console.WriteLine(builder);


        }

        private static void Setul1_Pr18()
        {
            Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.");
            Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            Console.Write("n =");
            int count;
            while (n != 1)
            {
                if (n % i == 0)
                {
                    count = 0;
                    while (n % i == 0)
                    {
                        count++;
                        n = n / i;
                    }
                    
                    Console.Write($" {i}^{count} x");
                }
                else
                {
                    
                    i++;
                    count = 0;
                }
            }
            


        }

        private static void Setul1_Pr17()
        {
            Console.WriteLine("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
            Console.WriteLine();
            Console.WriteLine("Introduceti 2 numere:");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            int a = x;
            int b = y;
            
            while (b != a)
            {
                if (a > b)
                {
                    a = a - b;
                }
                if (b > a)
                {
                    b = b - a;
                }
                    
            }
            Console.WriteLine($"C.M.M.D.C. = {a}");
            int c = x;
            int d = y;
            int Produs, r, cmmmc;

            Produs = c * d;
            r = c % d;
            while (r != 0)
            {
                c = d;
                d = r;
                r = c % d;
            }
            cmmmc = Produs / d;

            Console.WriteLine($"C.M.M.M.C. = {cmmmc}");

        }

        private static void Setul1_Pr16()
        {
            Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            Console.WriteLine();
            Console.WriteLine("Introduceti 5 numere a, b, c, d si e");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());
            int max = 0;

            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (c > d)
            {
                max = c;
                c = d;
                d = max;
            }
            if (d > e)
            {
                max = d;
                d = e;
                e = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (c > d)
            {
                max = c;
                c = d;
                d = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }

            Console.WriteLine($"Numerele ordonate crescator sunt {a}, {b}, {c}, {d} si {e}");

        }

        private static void Setul1_Pr15()
        {
            Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
            Console.WriteLine();
            Console.WriteLine("Introduceti 3 numere a, b si c");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            int max = 0;

            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            Console.WriteLine($"Numerele ordonate crescator sunt {a}, {b} si {c}");

        }

        private static void Setul1_Pr14()
        {
            Console.WriteLine("Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, \nde ex. 121 sau 12321.");
            Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n.estePalindrom())
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }


        }

        private static void Setul1_Pr13()
        {
            Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine();
            Console.WriteLine("Introduceti doi ani y1 si y2");
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = y1; i <= y2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Intre anul {y1} si {y2} sunt {count} de ani bisecti.");


        }

        private static void Setul1_Pr12()
        {
            Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
            Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valori intervalului [a, b] din care vreti sa aflati numerele care se impart la n!");
            string data = Console.ReadLine();
            string[] local_data = data.Split(' ');
            int a = int.Parse(local_data[0]);
            int b = int.Parse(local_data[1]);
            Console.WriteLine($"Numerele care se impart la {n} din intervalul [{a}, {b}] sunt :");
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    Console.Write(i + " ");
                }
                
            }
            Console.WriteLine();
            
        }

        private static void Setul1_Pr11()
        {
            Console.WriteLine("Afisati in ordine inversa cifrele unui numar n.");
            Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int n_rasturnat = 0;
            int r = 0;
            while (n != 0)
            {
                r = n % 10;
                n /= 10;
                n_rasturnat = n_rasturnat * 10 + r;
            }
            Console.WriteLine($"Inversul lui n este: {n_rasturnat}");

        }

        private static void Setul1_Pr10()
        {
            Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");
            Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            n.estePrim();
        }

        private static void Setul1_Pr9()
        {
            Console.WriteLine("Afisati toti divizorii numarului n.");
            Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            n.CatiDivizori();

        }

        private static void Setul1_Pr8()
        {
            Console.WriteLine("(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se \ninverseze valorile lor fara a folosi alte variabile suplimentare.");
            Console.WriteLine();
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"Noile valori sunt a= {a} si b = {b}");
        }

        private static void Setul1_Pr7()
        {
            Console.WriteLine("(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze \nvalorile lor.");
            Console.WriteLine();
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"Schimbarea a avut loc (pe cuvant de onoare :D) : a = {a} si b = {b}");

        }

        private static void Setul1_Pr6()
        {
            Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            Console.WriteLine();
            Console.WriteLine("Introduceti 3 lungimmi cu spatiu intre ele: ");
            string data = Console.ReadLine();
            string[] local_data = data.Split(' ');
            int a = int.Parse(local_data[0]);
            int b = int.Parse(local_data[1]);
            int c = int.Parse(local_data[2]);
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    Console.WriteLine("a, b si c pot forma un triunghi!");
                }
                else
                {
                    Console.WriteLine("a, b si c nu pot forma un triunghi!");
                }
            }
            else
            {
                Console.WriteLine("Cel putin un numar introdus nu poate reprezenta o latura al unu triunghi. este <= 0");
            }
        }

        private static void Setul1_Pr5()
        {
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
            Console.WriteLine();
            Console.Write("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("A cat-a cifra de la dreapta spre stanga a numarului vreti sa o aflati?");
            int k = int.Parse(Console.ReadLine());
            int cont = 0;
            int r = 0;
            while (cont != k)
            {
                r = n % 10;
                n /= 10;
                cont++;

            }
            Console.WriteLine($"A {cont}-a cifra din numar este {r}");

        }

        private static void Setul1_Pr4()
        {
            Console.WriteLine("Detreminati daca un an y este an bisect. ");
            Console.WriteLine();
            Console.Write("Introduceti anul pe care vreti sa-l verificati: ");
            int y = int.Parse(Console.ReadLine());
            DateTime dt = DateTime.Now;

            if (dt.Year < y)
            {
                if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
                {
                    Console.WriteLine("Anul v-a fi bisect!");
                }
                else
                {
                    Console.WriteLine("Anul nu v-a fi bisect!");
                }
            }
            else
            {
                if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
                {
                    Console.WriteLine("Anul a fost bisect");
                }
                else
                {
                    Console.WriteLine("Anul nu a fost bisect!");
                }
            }

        }

        private static void Setul1_Pr3()
        {
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("k este divizor al lui n");
            }
            else
            {
                Console.WriteLine("k nu este divizor al lui n");
            }
        }

        private static void Setul1_Pr2()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. \nTratati toate cazurile posibile. ");
            Console.WriteLine();
            Console.Write("Introduceti trei numere a, b si c separandu-le prin spatiu : ");
            string data = Console.ReadLine();
            string[] local_data = data.Split(' ');

            double a = int.Parse(local_data[0]);
            double b = int.Parse(local_data[1]);
            double c = int.Parse(local_data[2]);
            double x1, x2, d;
            x1 = 0;
            x2 = 0;

            if (a == 0)
            {
                Console.WriteLine("Ecuatia nu este de gradul 2");
            }
            else
            {
                
                d = b * b - 4 * a * c;

                if (d >= 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                }
                else
                {
                    Console.WriteLine("x1 si x2 nu apartin multimii nr reale!");
                }

                Console.WriteLine($"Solutiile ecuatiei de gradul 2 sunt x1 = {x1} si x2 = {x2}");
            }
            
        }

        private static void Setul1_Pr1()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine();
            Console.Write("Introduceti doua numere a si b separandu-le prin spatiu : ");
            string data = Console.ReadLine();
            string[] local_data = data.Split(' ');

            double a = int.Parse(local_data[0]);
            double b = int.Parse(local_data[1]);
            double x;

            Console.WriteLine("Vom rezolva ecuatia a * x + b = 0:");

            x = -(b / a);

            Console.WriteLine($"x = {x}");
        }
    }
}
