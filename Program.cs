//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число:");
   var number1 = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите второе число:");
     var number2 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Большее число число:");
    if (number1 > number2)
      Console.WriteLine(number1);
    else 
      Console.WriteLine(number2);

 