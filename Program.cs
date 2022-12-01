//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число
//большее, а какое меньшее.
//a = 5; b = 7 
//a = 2 b = 10 
//a = -9 b = -3
Console.WriteLine("Определение большего и меньшего из двух чисел");
  Console.WriteLine("Введите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите второе число: ");
int b1 = Convert.ToInt32(Console.ReadLine());
if (a1 > b1) {
  Console.WriteLine("Большее число равно" + (a1));
  Console.WriteLine("Меньшее число равно" + (b1));
}
else
{ Console.WriteLine("Большее число равно:"+ " "+(b1));
  Console.WriteLine("Меньшее число равно:"+ " "+(a1));         
}
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
//22 3 9 -> 22
  Console.WriteLine("Определение максимального из трех чисел");
  Console.WriteLine("Введите первое число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите второе число: ");
int b2 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите третье число: ");
int c2 = Convert.ToInt32(Console.ReadLine());
int max=0;
if (max < a2) 
  max=a2;  
if (max < b2)
  max=b2;
if (max < c2)
  max=c2;
  Console.WriteLine("Максимальное число равно" + " "+(max));

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
  Console.WriteLine("Определение четное или нечетное число");
  Console.WriteLine("Введите число: ");
int a3 = Convert.ToInt32(Console.ReadLine());
if (a3 % 2==0){  
  Console.WriteLine("Число" + " " + (a3) +" является чётным");
}
  else {
  Console.WriteLine("Число" + " " + (a3) +" является нечётным");
  }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
  Console.WriteLine("Определение четных чисел от 1 до N"); 
  Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Все чётные числа от 1 до "+ (N) +":");
for (int i = 1; i <= N; i++)
{  if (i % 2==0)
  { 
    Console.WriteLine(i);
  }
}