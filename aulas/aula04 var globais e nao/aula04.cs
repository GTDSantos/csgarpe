using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program{



        static void Main(){
            int num=0;               //variavel local, so funciona dentro desse metodo 
        }

        void teste(){
            
            Console.WriteLine(num); // Erro, pos a variavel q ele tenta buscar n existe nesse metodo

        }
    }
}