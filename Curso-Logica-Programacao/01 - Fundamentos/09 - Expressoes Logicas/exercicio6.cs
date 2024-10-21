using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma hora para verificar o periodo:");

            int numeroDigitadoPeloUsuario = Convert.ToInt32(Console.ReadLine());

            int valorMinimoMatutino = 0;
            int valorMaximoMatutino = 11;

            int valorMinimoVespertino = 12;
            int valorMaximoVespertino = 17;

            int valorMinimoNoturno = 18;
            int valorMaximoNoturno = 23;

            if(numeroDigitadoPeloUsuario >= valorMinimoMatutino && numeroDigitadoPeloUsuario <= valorMaximoNoturno)
            {
                Console.Write("O periodo do dia é ");
                if (numeroDigitadoPeloUsuario >= valorMinimoMatutino && numeroDigitadoPeloUsuario <= valorMaximoMatutino)
                    Console.WriteLine("matutino");
                else if (numeroDigitadoPeloUsuario > valorMinimoVespertino && numeroDigitadoPeloUsuario <= valorMaximoVespertino)
                    Console.WriteLine("vespertino");
                else if (numeroDigitadoPeloUsuario > valorMinimoNoturno && numeroDigitadoPeloUsuario <= valorMaximoNoturno)
                    Console.WriteLine("noturno");
            }          
            else
                Console.WriteLine("Hora invalida");

            Console.ReadLine();

        }
    }
}
