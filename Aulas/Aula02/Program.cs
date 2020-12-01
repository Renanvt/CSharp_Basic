using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*UTILIZANDO OS PARAMETROS DE ENTRADA*/
            Console.WriteLine("Hello World!");
            //Verificar se foi passado algum argumento no íncide do array
            if(args.GetLength(0)>0){
                 Console.Write(args.GetValue(0)); //Exibe o parâmetro de entrada na posição 0
            }

           
            
        }
    }
}
