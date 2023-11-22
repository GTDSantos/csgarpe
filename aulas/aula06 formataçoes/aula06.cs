using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {

        static void Main()
        {

            /*int n1, n2, n3;

            n1 = 10; n2 = 20; n3 = 30;
            Console.Write("n1={0}, n2={1}, n3={2}", n1, n2, n3);*/


            double valorCompra=5.50;
            double valorVenda=0;
            double lucro=0.1;
            String produto="Pastel";

            valorVenda=valorCompra+(valorCompra*lucro);

            Console.WriteLine("Produto........{0,15}",produto);
            Console.WriteLine("Val.Compra.....{0,15:c}",valorCompra);
            Console.WriteLine("Lucro..........{0,15:p}",lucro);
            Console.WriteLine("Val.venda......{0,15:c}",valorVenda);

        }
    }
}       /*  Produto........Pastel
            Val.Compra.....        R$ 5,50
            Lucro..........         10,00%
            Val.venda......        R$ 6,05  */


