using System;

namespace Aula04
{
    class Program
    {
        //Variavel global
        static int num=10; //A variável precisa ser estática para rodar no Main
        static void Main(string[] args)
        {
            //Variavel local
            int num2=0;
            System.Console.WriteLine(num); //Exibe 10
        }
        void teste(){
            int num2=1;
            System.Console.WriteLine(num2);
        }
    }
}
