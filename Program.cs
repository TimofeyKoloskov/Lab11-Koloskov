// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 10;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

int variant = 12;
bool isPrime = true;
bool isVariant = false;
if (variant == 1)
{
    isVariant = true;
}
else

    for (int divisor = 2; divisor < variant; divisor++)
    {
        if (variant % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }

if (isVariant == false)
{
    Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
}
else
{
    Console.WriteLine("Введённый вариант не является ни простым ни составным, введите другое число");
}