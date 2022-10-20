// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int Degree(int x)
{
    int count = 1;
    int decade = 1;
    while (count <= x)
    {
        decade = decade * 10;
        count++;
    }
return decade;
}
int number = Prompt("Введите число: ");
int number1 = number;
if (ValidateNumber(number))
{
    int count1 = 0;
    while (number1 > 0)
    {  
         count1++;
         number1 = number1 / 10;  
    }
    int count2 = count1 - 3;
    int decade = Degree(count2);
    int temp = number / decade;
    int thirdDigit = temp % 10;  
    Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
}
