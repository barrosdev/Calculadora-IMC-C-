using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");

        // Entrada do peso
        Console.Write("Digite seu peso em kg (ex: 70.5): ");
        if (!double.TryParse(Console.ReadLine(), out double peso) || peso <= 0)
        {
            Console.WriteLine("Peso inválido. Por favor, insira um número válido.");
            return;
        }

        // Entrada da altura
        Console.Write("Digite sua altura em metros (ex: 1.75): ");
        if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0)
        {
            Console.WriteLine("Altura inválida. Por favor, insira um número válido.");
            return;
        }

        // Cálculo do IMC
        double imc = peso / (altura * altura);

        // Exibição do resultado
        Console.WriteLine($"\nSeu IMC é: {imc:F2}");

        // Classificação do IMC
        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso.");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Classificação: Peso normal.");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Classificação: Sobrepeso.");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
