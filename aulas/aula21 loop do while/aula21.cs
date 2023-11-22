using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {
        static void Main(){

            string senha="123";
            string senhauser;
            int tentativas=0;
            
            do{
                Console.Clear();
                Console.WriteLine("Digite a senha");
                senhauser=Console.ReadLine();
                tentativas++
                
            }while(senha != senhauser);

            Console.WriteLine("Senha correta, Tentativas: {0}", tentativas);

            
        }
    }
}