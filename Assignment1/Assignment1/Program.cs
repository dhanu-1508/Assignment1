using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
       // int ch;
        static void Main(string[] args)
        {
            DemoFactEven df = new DemoFactEven();
          
            // ch chi value kuthun ghety?
            //input wali line 
            Console.WriteLine("enter the choice");
          int ch= Convert.ToInt32 (Console.ReadLine());
            //just a sec asach asu de mi baghto majya side la
            // i think type casting karav lgel mala nai watat tham,b bhgtoy
            // nhi hot he
            //enjoy wait run kru de
            // while ani do while ch output nhi yet heit wait baghto bachu

            switch (ch)
            {
                case 1:
                    df.n = 5;

                    df.factorial();
                    break;
                case 2:
                    df.n = 5;
                    df.even();
                    break;
                case 3:
                    df.n = 5;
                    df.DemoWhile();
                    break;
                case 4:
                    df.DemoDoWhile();
                    break;
                default:
                    break;
            }
        }
    }
}