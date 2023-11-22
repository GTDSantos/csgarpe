using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {
        static void Main(){

            int[] num=new int[10];

            for(int i=0;i<num.Length;i++){
                num[i]=0;
               
            }

             for(int i=0;i<10;i++){
                Console.WriteLine("valor{0}: {1}",i,num[i]);
            }

        }
    }
}