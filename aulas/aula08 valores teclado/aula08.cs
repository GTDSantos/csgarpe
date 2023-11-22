using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {
        static void Main(){
            int v1, v2,soma;
            string nome;

           /* Console.Write("Digite seu nome: ");
            nome=Console.ReadLine();
            Console.WriteLine("Ola {0}",nome);  */

            Console.Write("Digite o primeiro valor: ");
                v1=int.Parse (Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
                v2=Convert.ToInt32 (Console.ReadLine());
                soma=v1+v2;
            Console.WriteLine("a soma é {0}",soma);

        }
    }
}