Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Первое число большее, второе меньшее");
}
else if (num1 < num2)
{
    Console.WriteLine("Второе число большее, первое меньшее");
}
else
{
    Console.WriteLine("Оба числа равны");
}