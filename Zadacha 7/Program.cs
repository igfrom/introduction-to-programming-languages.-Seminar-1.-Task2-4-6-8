// **Задача 8:** Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 48 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for(int i = 0; i <= numberA; i +=2)
{
if(i == 0){
    continue;
}
Console.WriteLine(i);
}

