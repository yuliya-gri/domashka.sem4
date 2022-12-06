//напишите цикл, который принимает на вход 2 числа (A и B)
//и возводит число (А) в натуральную степень (В)

Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());


int DegNum(int num1, int num2)

{
    int x = num1;
    for(int i = 1; i < num2; i++)

     x *= num1;
    return x;
}
Console.WriteLine($"Значение первого числа ,возведенное в степень,равную второму числу = ");
Console.WriteLine($"{DegNum(num1,num2)}");
