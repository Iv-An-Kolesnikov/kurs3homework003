//21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//========================================================================================================
Console.Clear();
double[] input(string text)
{
    Console.Write($"Введите пожалуйста координату X {text}: ");
    double numX = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите пожалуйста координату Y {text}: ");
    double numY = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите пожалуйста координату Z {text}: ");
    double numZ = Convert.ToInt32(Console.ReadLine());
    double[] arr = {numX, numY, numZ};
    return arr;
}
double[] arr1 = input("первой точки");//Вызов функции ввода координат первой точки
double[] arr2 = input("второй точки");//Вызов функции ввода координат второй точки
double result = Math.Sqrt(Math.Pow((arr2[0] - arr1[0]), 2) + Math.Pow((arr2[1] - arr1[1]), 2) +  Math.Pow((arr2[2] - arr1[2]), 2));//Расчет
Console.WriteLine(Math.Round(result, 2));//Вывод результата