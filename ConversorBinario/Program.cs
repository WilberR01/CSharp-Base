using System.Globalization;

Console.WriteLine("Digite um número decimal:");
double inputNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int integerPart = (int)inputNumber;
double fractionalPart = inputNumber - integerPart;
int maxIterations = 32;
string binaryString = "";

// Converte a parte inteira
while (integerPart > 0)
{
    int remainder = integerPart % 2;
    binaryString = remainder.ToString() + binaryString;
    integerPart /= 2;
}

// Adiciona o ponto decimal na representação binária
binaryString += ".";

// Converte a parte fracionária
while (fractionalPart > 0 && maxIterations > 0)
{
    fractionalPart *= 2;
    if (fractionalPart >= 1)
    {
        binaryString += "1";
        fractionalPart -= 1;
    }
    else
    {
        binaryString += "0";
    }
    maxIterations--;
}

if (fractionalPart > 0)
{
    Console.WriteLine("Erro: O número máximo de iterações foi atingido.");
}
else
{
    Console.WriteLine("A representação binária de " + inputNumber + " é: " + binaryString);
}
