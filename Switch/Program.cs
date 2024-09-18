using System;

namespace Switch
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 8;
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default: // NÃO OBRIGATORIO
                    Console.WriteLine("Dia inválido");
                    break;
            }
        }
    }

}


