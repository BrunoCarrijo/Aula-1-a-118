using System;

namespace PropOpDate_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Propriedades
            //• Date(DateTime)
            //• Day(int)
            //• DayOfWeek(DayOfWeek)
            //• DayOfYear(int)
            //• Hour(int)
            //• Kind(DateTimeKind)
            //• Millisecond(int)
            //• Minute(int)
            //• Month(int)
            //• Second(int)
            //• Ticks(long)
            //• TimeOfDay(TimeSpan)
            //• Year(int

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d2 = new DateTime(2003, 11, 18, 15, 49, 58, 275);
            TimeSpan ts = new TimeSpan(1, 2, 11, 21, 321);


            Console.WriteLine("----------------------------");
            Console.WriteLine("- Propriedades -");
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);


            Console.WriteLine("----------------------------");
            Console.WriteLine("-Formatação (DateTime -> string)-");
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("----------------------------");
            Console.WriteLine("- Operações com Datetime -");
            DateTime y1 = d.Add(ts);
            DateTime y2 = d.AddDays(1.25);
            DateTime y3 = d.AddHours(1.6);
            DateTime y4 = d.AddMilliseconds(1.9);
            DateTime y5 = d.AddMinutes(1.5);
            DateTime y6 = d.AddMonths(5);
            DateTime y7 = d.AddSeconds(30);
            DateTime y8 = d.AddTicks(900000000L);
            DateTime y9 = d.AddYears(10);
            DateTime y10 = d.Subtract(ts);
            TimeSpan t = d.Subtract(d2);

            Console.WriteLine("Valores Referência");
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(ts);

            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.WriteLine(y3);
            Console.WriteLine(y4);
            Console.WriteLine(y5);
            Console.WriteLine(y6);
            Console.WriteLine(y7);
            Console.WriteLine(y8);
            Console.WriteLine(y9);
            Console.WriteLine(y10);
            Console.WriteLine(t);
           
        }
    }
}
