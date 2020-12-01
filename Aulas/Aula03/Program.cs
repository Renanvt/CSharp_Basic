using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {

            /*VARIÁVEIS */
            int num; //Declaração de variável. Por padrão  é 0
            int num2=0; //Tipo inteiro com sinal, com tamanho de 32 bits
            byte n1=10; //Inteiro de 8 bits. Armazena entre 0 e 255
            /* - Tipo primitivo de dados 
                char, float
            */
            char letra='c';
            float valor= 5.3f; //Ponto flutuante
            string nome="Bruno";

            var aux=10; //Não é especificado o tipo da variável, é definido no ato da compilação. Nesse exemplo a variável do tipo inteira
            var aux2=nome; //Nesse exemplo a variável é do tipo string

            //Lendo uma variável:
            Console.WriteLine(aux2);

            //Contatenação
            System.Console.WriteLine("Valor da variável: "+aux+"...");

            //Declaração de múltiplas variáveis
            //Precisam ser do mesmo tipo
            int num3,num4,res;
            int x=1,y=2,z=3;
            

            //Atribuicao
            num3=10;
            num4=2;
            res=num3 * num4;

            System.Console.WriteLine("A Multiplicacao de "+num3+ " e "+num4+" é igual a: "+res);
        }
    }
}
