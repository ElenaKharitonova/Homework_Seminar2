// // Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if (number < 1 || number > 7)
    {
        Console.WriteLine("Введенное число не соответствует дню недели");
        return false;
    }
    return true;
}
int number = Prompt("Введите число от 1 до 7, соответствующее дню недели: ");
if (ValidateNumber(number))
{
    if (number > 1 && number < 6)
    {
        Console.WriteLine($"{number} не является выходным днем");
    }
    else
    {
        Console.WriteLine($"{number} является выходным днем");
    }
}