using System;

namespace md02_CadernoExercicios_02
{
    class Program
    /*
        2. Faça um algoritmo que leia os valores A, B e C. Mostre uma mensagem
        que informe se a soma de A com B é menor, maior ou igual a C.
     */
    {
        static void Main(string[] args)
        {
            int a, b, c, res;
            string i ="não";
            do
            {
                Console.WriteLine("Digite um valor para A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um valor para B:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um valor para C:");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nValor digitado para A foi: {0}", a.ToString("0.0"));
                Console.WriteLine("Valor digitado para B foi: {0}", b.ToString("0.0"));
                Console.WriteLine("Valor digitado para C foi: {0}", c.ToString("0.0") +"\n");
                res = a + b;
                if (res < c)
                {
                    Console.WriteLine("Portanto, A + B é menor que C\n");
                }
                else if (res > c)
                {
                    Console.WriteLine("Portanto, A + B é maior que C\n");

                }
                else
                {
                    Console.WriteLine("Portanto, A + B é igual a C\n");
                }
                Console.WriteLine("Deseja sair do sistema?");
                i = Console.ReadLine();

            } while (i == "não");

            Console.WriteLine("Obrigado e até a próxima!");

        }
    }
}
