// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 19

// System.Console.Write("Введите пятизначное число -> ");
// string num = Console.ReadLine();

// void CheckNum(string num)
// {
//     if (num [0] == num [4] || num [1] ==num [3])
//     {
//     System.Console.WriteLine($"Данное число {num} - палиндром ");
//     }
//    else
//     {
//     System.Console.WriteLine($"Данное число {num} не палиндром ");
//     }
   
    
// }

// if (num.Length==5)  
// CheckNum(num);
//  else System.Console.WriteLine($"Введите число правильно !");
    
    
//  Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance ( double xa,double ya,double za,double xb,double yb,double zb)
// {
//    return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2)+Math.Pow(zb-za,2)),2);
// }

// System.Console.WriteLine("input x coordinate point A : ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input y coordinate point A : ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input y coordinate point A : ");
// double za = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input x coordinate point B : ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input y coordinate point B : ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input y coordinate point B : ");
// double zb = Convert.ToDouble(Console.ReadLine());


// System.Console.WriteLine($"Distance between point A and B -> { FindDistance (xa,ya,za,xb,yb,zb)} ");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//  void Cube( int x )
// {  
//    int count = 1; 
//    while (count <= x)
//  {
//   System.Console.WriteLine($" {count} -> {Math.Pow(count, 3)}");  
//   count ++;
//  }

   
// }
// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// Cube(x);