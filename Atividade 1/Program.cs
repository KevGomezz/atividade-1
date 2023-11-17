// Questão 01

using System.ComponentModel.Design;

int  A = 10;
A = 10;
Console.WriteLine(A);

int B = 20;
Console.WriteLine(B);

//troca de valores
 (A,B) = (B,A);
Console.WriteLine("valor em A: " + A);
Console.WriteLine("valor em B: " + B);

//Questão 02

        // Declaração de variáveis
        int totalEleitores, votosBrancos, votosNulos, votosValidos;

        // Entrada de dados
        Console.Write("Informe o número total de eleitores: ");
        totalEleitores = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos brancos: ");
        votosBrancos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos nulos: ");
        votosNulos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos válidos: ");
        votosValidos = int.Parse(Console.ReadLine());

        // Cálculo dos percentuais
        double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
        double percentualNulos = (double)votosNulos / totalEleitores * 100;
        double percentualValidos = (double)votosValidos / totalEleitores * 100;

        // Saída dos resultados
        Console.WriteLine($"Percentual de votos brancos: {percentualBrancos:F2}%");
        Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
        Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");

//Questão 03




    
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();

        
        if (double.TryParse(input, out double numero))
        {
            if (numero >= 0)
            {
                Console.WriteLine("O número é positivo ou zero.");
            }
            else
            {
                Console.WriteLine("O número é negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
}

        //questão 04

  


        Console.Write("Digite o salário fixo do vendedor: ");
        if (double.TryParse(Console.ReadLine(), out double salarioFixo))
        {
            Console.Write("Digite o valor das vendas efetuadas pelo vendedor: ");
            if (double.TryParse(Console.ReadLine(), out double valorVendas))
            {
                // Calcula a comissão
                double comissao;
                if (valorVendas <= 1500)
                {
                    comissao = valorVendas * 0.03; // 3% sobre o total das vendas
                }
                else
                {
                    comissao = 1500 * 0.03 + (valorVendas - 1500) * 0.05; // 3% sobre R$ 1500 + 5% sobre o excedente
                }

                // Calcula o salário total
                double salarioTotal = salarioFixo + comissao;

                // Exibe o resultado
                Console.WriteLine($"O salário total do vendedor é: {salarioTotal:C}");
            }
            else
            {
                Console.WriteLine("Valor de vendas inválido. Por favor, insira um número válido.");
            }
        }
        else
        {
            Console.WriteLine("Salário fixo inválido. Por favor, insira um número válido.");
}
    
        //Questão 05

        // Leitura do nome do primeiro time
        Console.Write("Digite o nome do primeiro time: ");
        string time1 = Console.ReadLine();

        // Leitura do número de gols marcados pelo primeiro time
        Console.Write($"Digite o número de gols marcados por {time1}: ");
        if (int.TryParse(Console.ReadLine(), out int golsTime1))
        {
            // Leitura do nome do segundo time
            Console.Write("Digite o nome do segundo time: ");
            string time2 = Console.ReadLine();

            // Leitura do número de gols marcados pelo segundo time
            Console.Write($"Digite o número de gols marcados por {time2}: ");
            if (int.TryParse(Console.ReadLine(), out int golsTime2))
            {
                // Determina o vencedor ou se houve empate
                string vencedor = DeterminarVencedor(time1, golsTime1, time2, golsTime2);

                // Exibe o resultado
                Console.WriteLine($"Resultado: {vencedor}");
            }
            else
            {
                Console.WriteLine("Número de gols do segundo time inválido. Por favor, insira um número válido.");
            }
        }
        else
        {
            Console.WriteLine("Número de gols do primeiro time inválido. Por favor, insira um número válido.");
        }
    

    // Função para determinar o vencedor ou se houve empate
    static string DeterminarVencedor(string time1, int golsTime1, string time2, int golsTime2)
    {
        if (golsTime1 > golsTime2)
        {
            return $"{time1} é o vencedor!";
        }
        else if (golsTime2 > golsTime1)
        {
            return $"{time2} é o vencedor!";
        }
        else
        {
            return "EMPATE!";
        }
}

//Quesstão 06
    
        // Leitura do primeiro valor
        Console.Write("Digite o primeiro valor: ");
        if (double.TryParse(Console.ReadLine(), out double valor1))
        {
            // Leitura do segundo valor
            double valor2;
            do
            {
                Console.Write("Digite o segundo valor (não pode ser zero): ");
            } while (!double.TryParse(Console.ReadLine(), out valor2) || valor2 == 0);

            // Cálculo e exibição do resultado da divisão
            double resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }
        else
        {
            Console.WriteLine("Valor inválido. Por favor, insira um número válido.");
}
    
 // Questão 07

    
        Console.WriteLine("Tabuada do 8:");

        // Loop de 1 a 10 para calcular e imprimir a tabuada
        for (int i = 1; i <= 10; i++)
        {
            int resultado = 8 * i;
            Console.WriteLine($"8 x {i} = {resultado}");
}
    
//Questão 08 

       int quantidadeValores = 10;
        double soma = 0;

        Console.WriteLine($"Digite {quantidadeValores} valores:");

        // Loop para ler e somar os valores
        for (int i = 1; i <= quantidadeValores; i++)
        {
            Console.Write($"Valor {i}: ");
            if (double.TryParse(Console.ReadLine(), out double valor))
            {
                soma += valor;
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido.");
                i--; // Decrementa o índice para que o usuário insira novamente o valor atual
            }
        }

        // Calcula a média aritmética
        double media = soma / quantidadeValores;

        // Exibe o resultado
        Console.WriteLine($"A média aritmética dos valores é: {media}");


// Questão 09

    static void CalcularMedia(double nota1, double nota2, double nota3, char tipoMedia, out double resultado)
    {
        resultado = 0;

        switch (tipoMedia)
        {
            case 'A':
                resultado = (nota1 + nota2 + nota3) / 3;
                break;
            case 'P':
                resultado = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
                break;
            case 'H':
                resultado = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
                break;
            default:
                Console.WriteLine("Tipo de média inválido. Use A, P ou H.");
                break;
        }
    }

    static void Main()
    {
        double nota1 = 7.5;
        double nota2 = 8.0;
        double nota3 = 9.2;
        char tipoMedia = 'A'; // Substitua por 'P' ou 'H' para calcular outros tipos de média
        double resultado;

        CalcularMedia(nota1, nota2, nota3, tipoMedia, out resultado);

        Console.WriteLine($"A média do aluno é: {resultado}");
}

// Questão 10


static void Main()
    {
        // Exemplo de uso da função
        double altura = 1.75; // Altura em metros
        char sexo = 'M'; // 'M' para masculino, 'F' para feminino

        double pesoIdeal = CalcularPesoIdeal(altura, sexo);

        Console.WriteLine($"Altura: {altura} m");
        Console.WriteLine($"Sexo: {sexo}");
        Console.WriteLine($"Peso Ideal: {pesoIdeal:F2} kg");
    }

    static double CalcularPesoIdeal(double altura, char sexo)
    {
        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = 72.7 * altura - 58;
        }
        else if (sexo == 'F')
        {
            pesoIdeal = 62.1 * altura - 44.7;
        }
        else
        {
            // Sexo inválido, retorna um valor negativo para indicar erro
            pesoIdeal = -1;
            Console.WriteLine("Sexo inválido. Use 'M' para masculino ou 'F' para feminino.");
        }

        return pesoIdeal;
    }









