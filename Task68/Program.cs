// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = EnterPositiveInteger();
int n = EnterPositiveInteger();
int akkermanMN = GetAkkerman(m, n);
Console.WriteLine($"Akkerman({m}, {n}) = {akkermanMN}");

//....................Specific method for this task......................//
int GetAkkerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    if (m > 0 && n == 0)
        return GetAkkerman(m - 1, 1);
    else
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
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