using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {
        static void Main()
        {
            string MouH = "minutos";
            int tempo = 0;
            char Escolha = 'a';

            inicio:

            Console.Clear();

            Console.WriteLine("Belo Horisonte a Vitória/ES");
            Console.WriteLine("Escolha o Transporte: [a] para Avião | [c] para Carro | [o] para onibus");

            Escolha = char.Parse(Console.ReadLine());
            switch (Escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'C':
                case 'c':
                    tempo = 480;
                    break;
                case 'O':
                case 'o':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }


            if (tempo > 60)
            {
                tempo /= 60;
                MouH = "Horas";
            }

            if (tempo < 0)
            {
                Console.WriteLine("Transporte Indisponivel");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é de {0} {1}", tempo, MouH);
            }

            Console.WriteLine("\nCaucular outro transporte [s/n]: ");
            Escolha = char.Parse(Console.ReadLine());

            if (Escolha == 's' || Escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do program");
            }

        }
    }
}