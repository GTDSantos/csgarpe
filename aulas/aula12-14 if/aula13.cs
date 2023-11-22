using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {
        static void Main()
        {
            int n1, n2, n3;
            int res = 0;
            string aprov;

            Console.WriteLine("Escreva a nota do Primeiro bi: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a nota do Segundo bi: ");
            n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escreva a nota do Terceiro bi: ");
            n3 = int.Parse(Console.ReadLine());

            res = (n1 + (n2 * 2) + (n3 * 3)) / 6;

            if (res <40)
            {
                Console.WriteLine("Reprovado");
            }else if(res >= 40 & res <= 59 ){
                Console.WriteLine("Reprovado");
            }else{
                Console.WriteLine("Aprovado");
            }

            


        }
    }
} 