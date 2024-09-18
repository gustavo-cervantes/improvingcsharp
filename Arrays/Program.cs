using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carros = {"Nivus", "Onix", "T-Cross", "Creta", "Renegade" };
            int[] numeros = { 1, 2, 3, 4 };

            carros[4] = "S-10"; //MUDANÇA DE VALOR NO ARRAY JÁ EXISTENTE, ESTE RECURSO É CONHECIDO COMO MODIFICADOR DE ACESSO

            Console.WriteLine(carros[2]); // ACESSANDO O ARRAY DE CARROS NA POSIÇÃO 2
            Console.WriteLine(carros[4]); // ACESSANDO O ARRAY DE CARROS NA POSIÇÃO 4
            Console.WriteLine(numeros[1]); // ACESSANDO O ARRAY DE NÚMEROS NA POSIÇÃO 1
            Console.WriteLine(carros.Length); // TAMANHO DO ARRAY DE CARROS

            // LOOP PARA PERCORRER O ARRAY DE CARROS / USANDO DEBUG

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }
        }
    }
}