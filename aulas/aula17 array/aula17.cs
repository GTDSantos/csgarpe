using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {
        static void Main(){
            //int n1, n2, n3, n4, n5;
            int[] n=new int[5];
            //int[] num=new int[3]{55,77,99};
            int[] num={55,77,99,66,88};     //o numero q ira no [] é contado automaticamente
            string[] veicolos=new string[3];

            veicolos[0]="Carro";
            veicolos[1]="Aviao";
            veicolos[2]="Navio";

            n[0]=11;
            n[1]=22;
            n[2]=33;
            n[3]=44;
            n[4]=55;

            Console.WriteLine(n[0]);
            Console.WriteLine(num[2]);
        }
    }
}