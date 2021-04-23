using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DemoFactEven
    {

        public int  n, fact = 1,num;
        public void factorial()
        {
            for(int j=1;j<=n;j++)
            {
                fact = fact * j;
            }
            Console.WriteLine("factorial of a number is " + fact);
            Console.ReadLine();
        }

       

        public void even()
        {
            if(n%2==0)
            {
                Console.WriteLine("the number is even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("number is odd");
                Console.ReadLine();
            }
        }
        public void DemoWhile()
        {
            int i = 1;
            Console.WriteLine("table of 5 is");
            while (i <= 10)
            {
                num = n * i;
                Console.WriteLine("" + num);
                i++;
            }
          
            Console.ReadLine();
        }
        public void DemoDoWhile()

        {
            int i = 1;
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;
               
            } while (i < 6);
            Console.ReadLine();
           
           
        }
       
    }
}
