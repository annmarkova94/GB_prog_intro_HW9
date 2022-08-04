// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

TextColorGreen();
int M = EnterPositiveInteger();
int N = EnterPositiveInteger();
int sumMtoN = GetSumFromMtoN(M, N);
Console.WriteLine($"Sum of numbers from M to N equals {sumMtoN}");
Console.ResetColor();

//....................Specific method for this task......................//
int GetSumFromMtoN(int M, int N)
{
    if (N == M)
        return M;
    return GetSumFromMtoN(M, N - 1) + N;
}


//....................Basic methods......................//
int EnterPositiveInteger()
{
    int number;
    Console.Write("Enter positive integer: ");
    while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
    {
        TextColorRed();
        Console.Write("This is not a positive integer, try again: ");
    }
    TextColorGreen();
    return number;
}

void TextColorGreen()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
}
void TextColorRed()
{
    Console.ForegroundColor = ConsoleColor.Red;
}