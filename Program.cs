using System;

namespace Exercicio___Revisão
{
    class Program
    {
        static void Main(string[] args)
        {   

        Console.WriteLine("Tabuada até o 10");
        Console.WriteLine("-------------------");


        for(var multiplicador = 0; multiplicador < 11; multiplicador++){
            Console.WriteLine($"Essa é a tabuada do {multiplicador}");

            for(var numero =0; numero < 11; numero++)
        {
            int calculo = multiplicador * numero;
            Console.WriteLine(multiplicador+ "X" +numero+ "+" +calculo);
        }
             
        }      

	
        }
    }
}
