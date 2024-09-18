using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // LOOPS SÃO UTILIZADOS PARA REPETIR UM BLOCO DE CÓDIGO VÁRIAS VEZES,
            // ECONOMIZAR TEMPO, REDUZIR ERROS E DEIXAR CÓDIGOS MAIS LEGIVEIS.


            // WHILE
            // ENQUANTO FOR VERDADEIRO, EXECUTA O BLOCO DE CÓDIGO

            int i = 0; // variavel

            while (i < 10) 
            {
                Console.WriteLine(i);
                i++; // INCREMENTA O VALOR DE i ATÉ QUE ELE SE COMPLETE ( CHEGUE EM 10 ) 
            }

            // DO WHILE,
            // MESMA FUNÇÃO, PORÉM O BLOCO DE CÓDIGO SERÁ VERIFICADO POR ÚLTIMO
            // ELE EXECUTA O BLOCO DE CÓDIGO PRIMEIRO E DEPOIS VERIFICA.

            int j = 0; // variavel
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 20);
        }
    }
}