using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double MEmKm = 0.001;
            double MEmCm = 100;
            double MEmMm = 1000;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*__________*");
            Console.ResetColor();
            
            Console.WriteLine(@"Olá usuário!
Esse programa exibirá equivalências entre metros, centímetros e quilômetros.");
            
            Console.Write("Entre com a medida (em metros): ");
            string MetrosDigitados = Console.ReadLine();
            
            double MetrosDouble = Convert.ToDouble(MetrosDigitados);
            
            Console.WriteLine("Eis as equivalências:");
            Console.WriteLine($"{MetrosDouble * MEmCm:N} cm");
            Console.WriteLine($"{MetrosDouble:N} m");
            Console.WriteLine($"{MetrosDouble * MEmKm:N} Km");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Bônus Milímetros: {MetrosDouble * MEmMm:N} mm");
            Console.ResetColor();
            
            Console.WriteLine("Gratidão!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(";-P");
            Console.ResetColor();

        }
    }
}
