using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // BREAK E CONTINUE SÃO UTILIZADOS PARA ALTERAR O FLUXO DE UM LOOP

            for (int i = 0; i <= 10; i++)
            {
                if(i == 4) // PARA O LOOP QUANDO O NÚMERO 4 FOR ENCONTRADO
                {
                    Console.WriteLine("O número 4 foi encontrado");
                    break;
                }

                if (i == 5) // PULA O NÚMERO 5
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }

}
