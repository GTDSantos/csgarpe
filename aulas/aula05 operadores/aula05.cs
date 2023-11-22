using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {
        static void Main(string[] args){

            //int res = (10+5)*2;

            bool res= 10!=5;

            Console.WriteLine(res);

            int num= 10;

            //num+=1; ou num++; ou num=num+1;
            num*=2; // ou num=num+2;     +,-,/,*

            Console.WriteLine(num);



            bool res2=(5>3) | (10<5);
            bool res3=(5>3) & (10<5);

            Console.WriteLine(res2);
            Console.WriteLine(res3);

        


        }
    }
}