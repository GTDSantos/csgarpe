using System;

namespace My_Awesome_Program
{
    class My_Awesome_Program
    {

        enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
        
        static void Main(){

            DiasSemana ds = (DiasSemana)0;
            //int ds =(int)DiasSemana.Sexta;

            Console.WriteLine(ds);

        }
    }
}