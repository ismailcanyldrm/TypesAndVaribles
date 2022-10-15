using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVaribles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veri Tipleri
            int numara1 = 215625862;
            long numara2 = 999999999999999;
            short numara3 = 32767;
            byte numara4 = 255;
            bool numara5 = false;
            double numara6 = 10.4;
            decimal numara7 = 10.5663554m;
            char karakter = 'a';

            Console.WriteLine("numara1 :  {0}", numara1);
            Console.WriteLine("numara2 :  {0}", numara2);
            Console.WriteLine("numara3 :  {0}", numara3);
            Console.WriteLine("numara4 :  {0}", numara4);
            Console.WriteLine("numara5 :  {0}", numara5);
            Console.WriteLine("numara6 :  {0}", numara6);
            Console.WriteLine("numara7 :  {0}", numara7);
            Console.WriteLine("karakter : {0}", karakter);
            Console.WriteLine("karakter : {0}", days.1);
            Console.ReadLine();
        }
    }
    enum days
    {
        cuma, pazar, salı
    }
}