using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        
        {
            /*  Console.WriteLine($"bool: {sizeof(bool)}, values: {true} or {false}");
              Console.WriteLine($"char: {sizeof(char)}"); //unicode
                                                          //short, ushort;
                                                          //int, uint;
              Console.WriteLine($"short: {sizeof(short)} Байт памяти, диапазон значений: {short.MinValue} ... {short.MaxValue}");
              Console.WriteLine($"short: {sizeof(ushort)} Байт памяти, диапазон значений: {ushort.MinValue} ... {ushort.MaxValue}");

              Console.WriteLine($"float: {sizeof(float)} Байт памяти, диапазон значений: {float.MinValue} ... {float.MaxValue}");
              Console.WriteLine($"double: {sizeof(double)} Байт памяти, диапазон значений: {double.MinValue} ... {double.MaxValue}");
              Console.WriteLine($"decimal: {sizeof(decimal)} Байт памяти, диапазон значений: {decimal.MinValue} ... {decimal.MaxValue}");

              Console.WriteLine('+'.GetType());
              Console.WriteLine(5.GetType());
              Console.WriteLine(5.5.GetType());
              Console.WriteLine(5.5f.GetType());
              Console.WriteLine(5.5m.GetType());  //m - Money
            */
            // first task
            Console.Write("Write a number to modify: ");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Your number: {number}");
            int f_number = (int)number; //Convert.ToInt32(number);
            int remainder = (int)((number - f_number)*100);
            Console.WriteLine($" --> {f_number}rub {remainder}k");  // if .>5 then .x=100-secpart of digit in minus position
            Console.WriteLine("\n\n");

            // second task
            Console.Write("Write some data about notebooks price(double): ");
            double notebook_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write some data about notebooks amount(int): ");
            int amount_notebook = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write some data about pencil price(double): ");
            double pencil_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write some data about pencil amount(int): ");
            int amount_pencil = Convert.ToInt32(Console.ReadLine());
            double price = notebook_price * amount_notebook + pencil_price * amount_pencil;
            Console.WriteLine($"Alright, cost of your goods: {price}");
            Console.WriteLine("\n\n");


            // third task
            Console.Write("Write some data about notebooks price(double): ");
            double sec_notebook_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write some data about notebooks cover(double): ");
            double notebook_cover_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write some data about quantity of these sets(int): ");
            int quantity_set = Convert.ToInt32(Console.ReadLine());
            double sec_price = (sec_notebook_price + notebook_cover_price) * quantity_set;
            Console.WriteLine($"Alright, cost of your goods: {sec_price}");
            Console.WriteLine("\n\n");


            //fourth task
            Console.Write("Write some data about lenght of road(int): ");
            int lenght_road = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write some data about fuel consumption(double): ");
            double fuel_consumption = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write some data about fuel price(double) : ");
            double fuel_price = Convert.ToDouble(Console.ReadLine());
            double cost_of_trip = lenght_road*2/100*fuel_consumption*fuel_price;
            Console.WriteLine($"Cost of trip: {cost_of_trip}rub");
            Console.WriteLine("\n\n");
        }
    }
}