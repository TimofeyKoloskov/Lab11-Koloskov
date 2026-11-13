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

// 

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
//     if (points >= 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Количество сданных работ: {count}");

// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             Console.WriteLine($"Первая совпавшая пара: {groupIds[i]} и {groupIds[j]}");
//             break;
//         }
//     }
// }

// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");

// int[] numbersList = { 2, 6, 8 };
// int variant = 2;
// bool found = false;
// foreach (int number in numbersList)
// {
//     if (variant == number)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Индекс числа найден" : "Индекс числа не найден");

// int number = 4;
// bool isPrime = true;
// for (int divisor = 2; divisor < number; divisor++)
// {
//     if (number % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }

// Console.WriteLine(isPrime ? "Составное" : "Простое");

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// int[] numberList = { 2, 3, 4, 5, 6, 7, 8, 9 };
// int sum = 0;

// foreach (int number in numberList)
// {
//     if (number % 3 == 0)
//     {
//         continue;
//     }
//     sum += number;
// }

// Console.WriteLine($"Сумма чисел не кратных трём: {sum}");

// int[] numberList = Enumerable.Range(1, 100).ToArray();
// foreach (int number in numberList) {
//     if (number % 2 == 0 && number % 3 == 0)

//         {
//         Console.WriteLine($"Первое число, удовлетворяющее условию: {number}");
//         break;
//         }
//     }
