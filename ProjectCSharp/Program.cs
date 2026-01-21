using System;
using System.ComponentModel.Design;
class Program
{
    static void Bai1()
    {
        Console.WriteLine("Nhap so tuoi cua ban:");
        string inputStr = Console.ReadLine();
        bool success = int.TryParse(inputStr, out int tuoi);
        if (!success || tuoi <= 0 || tuoi > 120)
        {
            Console.WriteLine("So tuoi nhap khong phu hop. Xin nhap lai");
        }
        else
        {
            int soNgay = tuoi * 365;
            Console.WriteLine("So ngay da song: " + soNgay);
        }
    }
    static void Bai2()

    {
        Console.WriteLine("Nhap vao hai so a va b");
        string inputStrA = Console.ReadLine();
        bool successA = int.TryParse(inputStrA, out int a);
        string inputStrB = Console.ReadLine();
        bool successB = int.TryParse(inputStrB, out int b);
        if (!successA || !successB)
        {
            Console.WriteLine("Vui long nhap lai");
            return;
        }
        if (a != 0)
        {
            float x = -(float)b / a;
            Console.WriteLine("PT co nghiem x = " + x);
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine(" PT co vo so nghiem");
            }
            else
            {
                Console.WriteLine(" PT vo nghiem");
            }
        }
    }

    static void Bai3()
    {
        Console.WriteLine("Nhap chieu cao va can nang");
        string a = Console.ReadLine();
        bool succesA = double.TryParse(a, out double chieucao);
        string b = Console.ReadLine();
        bool succesB = double.TryParse(b, out double cannang);
        if (!succesA || !succesB || chieucao <= 0 || cannang <= 0)
        {
            Console.WriteLine("Nhap sai! Vui long nhap lai");
            return;
        }
        if (cannang != 0 && chieucao != 0)
        {
            double bmi = cannang / (chieucao * chieucao);
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("Chi so BMI:" + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("Qua gay");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Binh  thuong");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Thua can");
            }
            else
            {
                Console.WriteLine("Beo Phi");
            }
        }
    }

    static void Bai4()
    {
        Console.WriteLine("Tinh nam nhuan");
        string year = Console.ReadLine();
        bool succes = int.TryParse(year, out int nam);
        bool isNamNhuan = false;
        if (!succes || nam <= 0)
        {
            Console.WriteLine("Nhap sai! Vui long nhap lai");
            return;
        }
        if (nam != 0)
        {
            if (nam % 4 == 0)
            {
                if (nam % 100 == 0)
                {
                    if (nam % 400 == 0)
                    {
                        isNamNhuan = true;
                    }

                }
            }
            if (isNamNhuan)
            {
                Console.WriteLine("{0} la nam nhuan", nam);
            }
            else
            {
                Console.WriteLine("{0} khong la nam nhuan", nam);
            }
        }
    }
    static void Bai5()
    {
        Console.WriteLine("Ban muon tinh ngay cua thang may? Hay nhap thang:");
        string month = Console.ReadLine();
        bool succes = int.TryParse(month, out int iMonth);
        if (!succes || iMonth < 1 || iMonth > 12)
        {
            Console.WriteLine("Thang khong hop le");
            return;
        }
        switch (iMonth)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
            Console.WriteLine("Thang {0} co 31 ngay", iMonth);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
            Console.WriteLine("Thang {0} co 30 ngay", iMonth);
                break;
            case 2:
            Console.WriteLine("Thang {0} co 28 hoac 29 ngay", iMonth);
                break;
        }

    }
    static void Main()
    {
        Bai1();
        Bai2();
        Bai3();
        Bai4();
        Bai5();
    }
}
  
