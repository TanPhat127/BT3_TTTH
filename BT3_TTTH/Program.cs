using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BT3_TTTH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int chon = 0;
            do
            {
                Console.WriteLine("Chon bai: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1: //bai 1
                        Console.WriteLine("Nhap so nguyen: ");
                        n = int.Parse(Console.ReadLine());
                        if (n % 3 == 0) Console.WriteLine($"{n} chia het cho 3");
                        else Console.WriteLine($"{n} khong chia het cho 3");
                        break;
                    case 2: //bai 2\
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine($"bang cuu chuong {i}");
                            for (int j = 1; j < 11; j++)
                            {
                                Console.WriteLine($"{i} * {j} = {i * j}");
                            }
                        }
                        break;
                    case 3: // bai 3
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        int tong = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            int tich = 1;
                            for (int j = 1; j <= i; j++)
                                tich *= j;
                            tong += tich;
                        }
                        Console.WriteLine($"Tong giai thua tu 1 den {n} la: {tong}");
                        break;
                    case 4://bai 4
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        if (Math.Pow(Math.Sqrt((double)n), 2) == n)
                            Console.WriteLine($"{n} la so chinh phuong");
                        else Console.WriteLine($"{n} khong phai la so chinh phuong");
                        break;
                    case 5: //bai5
                        Console.WriteLine("Nhap thang: ");
                        n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                Console.WriteLine("Thang {0} co 31 ngay", n);
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                Console.WriteLine("Thang {0} co 30 ngay", n);
                                break;
                            case 2:
                                if (DateTime.Now.Year % 4 == 0) Console.WriteLine("Thang 2 có 29 ngay");
                                else Console.WriteLine("Thang 2 co 28 ngay"); break;
                        }
                        break;
                    case 6://bai 6
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        double tong6 = 0;
                        for (int i = 1; i < n; i++)
                            tong6 += Math.Pow(i, i);
                        Console.WriteLine($"Tong = {tong6}");
                        break;//bai 7
                    case 7:
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        int tong7 = 0;
                        for (int i = 1; i < n; i += 2)
                            tong7 += i;
                        Console.WriteLine($"Tong = {tong7}");
                        break;
                    case 8://bai 8
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            int dem = 0;
                            for (int j = 1; j <= n; j++)
                            {
                                if (i % j == 0)
                                {
                                    dem++;
                                }
                            }
                            if (dem == 2)
                                Console.WriteLine("{0} la so nguyen to", i);
                        }
                        break;
                    case 9://bai 9
                        Console.WriteLine("Nhap so hang: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 10://bai 10
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        int fn_1 = 0, fn_2 = 1;
                        for (int i = 0; i < n; i++)
                        {
                            int tong10 = 0;
                            if (i < 2)
                                Console.Write($"{i}\t");
                            else
                            {
                                tong10 += fn_1 + fn_2;
                                fn_1 = fn_2;
                                fn_2 = tong10;
                                Console.Write($"{tong10}\t");
                            }
                        }
                        break;
                }
            } while (chon != 0);
        }
    }
}
