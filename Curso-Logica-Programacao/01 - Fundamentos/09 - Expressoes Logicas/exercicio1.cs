namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 10;
            int maxValue = 50;

            Console.WriteLine("Digite um número válido");

            int convertedInput = Convert.ToInt32(Console.ReadLine());

            if (convertedInput > minValue && convertedInput >= maxValue)
                Console.WriteLine($"O número esta entre {minValue} e {maxValue}");
            else
            {
                Console.WriteLine($"O número não esta entre {minValue} e {maxValue}");
            }                       

        }
    }
}
