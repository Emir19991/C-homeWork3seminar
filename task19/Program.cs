// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// 1 КОД C РАЗВЕРНУТЫМ ЧИСЛОМ

// Console.WriteLine("Введите пятизначное число = ");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = number;
// int conversely = 0;
// int div = 0;
// Palindrom(number);


// void Palindrom(int num)
// {
//     if(number > 9999 && number < 100000)
//     {
//         while (number > 0)
//         {
//         div = number % 10;
//         conversely = conversely * 10 + div;
//         number = number / 10;
//         }
//     }
// }

// if (temp == conversely)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// 2 КОД

// Console.WriteLine("Введите пятизначное число = ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrom(number);

// void Palindrom(int num)
// {
//     if(number / 10000 == number % 10 && number / 1000 == number / 100)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }


// 3 КОД

Console.WriteLine("Введите пятизначное число = ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Palindrom(number);
Console.WriteLine(result ?"Да" : "Нет");

bool Palindrom(int num)
{
    return number / 10000 == number % 10 || number / 1000 == number / 100;     // С && постоянно выдает нет
}
