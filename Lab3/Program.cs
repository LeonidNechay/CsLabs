using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traveler tourist = new Traveler();
            tourist.EndOfTermin();
            tourist.LiveTermin();
            Console.WriteLine(tourist);
            Console.ReadLine();
        }
    }
    class Traveler
    {
        private int day = 1;
        public int Day
        {
            get { return day; }
            set 
            {
                if (value < 0)
                    throw new Exception("Value is incorect");
                day = value; 
            }
        }
        private int month = 1;
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 0)
                    throw new Exception("Value is incorect");
                month = value;
            }
        }
        private int year = 2022;
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new Exception("Value is incorect");
                year = value;
            }
        }
        private int termin = 10;
        public int Termin
        {
            get { return termin; }
            set
            {
                if (value < 0)
                    throw new Exception("Value is incorect");
                termin = value;
            }
        }
        public Traveler(int day, int month, int year, int termin)
        {
            Day = day;
            Month = month;  
            Year = year;
            Termin = termin;
        }
        public Traveler()
        {
            Console.Write("День подання заяви: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Місяць подання заяви: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Рік подання заяви: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Термін проживання: ");
            termin = int.Parse(Console.ReadLine());
        }
        public void EndOfTermin()
        {
            int today = DateTime.Now.Day;
            if (month < DateTime.Now.Month)
            {
                int nDaysLater = 30*(DateTime.Now.Month-month) - day + today;
                if (nDaysLater > termin)
                    Console.WriteLine("Ваш термін проживання закінчився");
                else if (nDaysLater < termin)
                    Console.WriteLine($"Ваш термін проживання ще дійсний {termin - nDaysLater} днів");
                else
                    Console.WriteLine("Ваш термін проживання закінчується сьогодні");
            }
            else if(month == DateTime.Now.Month)
            {
                if(day > DateTime.Now.Day)
                {
                    Console.WriteLine("Ви ще не заселилися");
                }
                else
                {
                    int nDaysLater = today - day;
                    if (nDaysLater > termin)
                        Console.WriteLine("Ваш термін проживання закінчився");
                    else if (nDaysLater < termin)
                        Console.WriteLine($"Ваш термін проживання ще дійсний {termin - nDaysLater} днів");
                    else
                        Console.WriteLine("Ваш термін проживання закінчується сьогодні");
                }
            }
            else
            {
                Console.WriteLine("Ви ще не заселилися");
            }
            
        }
        public void LiveTermin()
        {
            int liveTermin = 0;
            liveTermin = termin / 30;
            Console.WriteLine($"Термін вашого перебування в місяцях: {liveTermin}");
        }
        public override string ToString()
        {
            return $"Дата подачі заяви: {day}.{month}.{year}. Термін перебування: {termin}";
        }
    }
}
