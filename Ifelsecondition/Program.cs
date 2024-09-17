using System;

namespace Ifelsecondition
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF ELSE CONDITION

            bool barCodeExists = true; 

            if (barCodeExists == false) // SE O CODIGO DE BARRAS NÃO EXISTIR NO BANCO DE DADOS
            {
                Console.WriteLine("Barcode does not exist in database");

            }
            else // SE O CÓDIGO DE BARRAS EXISTIR NO BANCO DE DADOS
            {
                Console.WriteLine("Barcode exists in database");
            }


            // IF ELSE IF CONDITION

            int cafeMelitta = 13;
            int cafeBomJesus = 10;

            if (cafeMelitta < 12)  // SE A QUANTIDADE DE CAFÉS FOR MENOR QUE 12 EXIBE A MENSAGEM 
            {
                Console.WriteLine("Cafe Melitta is less than 10, -> low storage <-");
            }
            else if (cafeMelitta > 12) // SE A QUANTIDADE DE CAFÉS FOR MAIOR QUE 25 EXIBE A MENSAGEM
            {
                Console.WriteLine("Cafe Melitta is greater than 12 -> medium storage <-");

            }

            // TERNARIO OPERATOR
            string quantiaCafeBomJesus = (cafeBomJesus < 12) ? "Cafe Bom Jesus is greater than 10 -> medium storage <-" : "Cafe Bom Jesus is less than 10 -> low storage <-";

            Console.WriteLine(quantiaCafeBomJesus);


        }
    }
}