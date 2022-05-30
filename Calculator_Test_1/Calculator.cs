using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Test_1
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool CheckNamNhuan(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {            
                return true;
            }
            return false;
        }
        public int CheckNgayTrongThang(int month, int year)
        {
            int nNumOfDays = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    nNumOfDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    nNumOfDays = 30;
                    break;
                case 2:
                    if (CheckNamNhuan(year))
                    {
                        nNumOfDays = 29;
                    }
                    else
                    {
                        nNumOfDays = 28;
                    }
                    break;
            }
            return nNumOfDays;
        }
        public bool CheckNgay(int day, int month, int year)
        {
            if (year < 0)
            {
                Console.WriteLine("Not Success !");
                return false;
            }
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Not Success !");
                return false;
            }
            if (day < 1 || day > CheckNgayTrongThang(month, year))
            {
                Console.WriteLine("Not Success !");
                return false;
            }
            Console.WriteLine("Success !");
            return true;
        }
    }
}
