// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. (палиндром - число 
// читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
char[] arr = N.ToString().ToCharArray();
if(arr.Length == 5 && arr[0] == arr[4] && arr[1] == arr[3])
{
    Console.WriteLine("Да");
}
if(arr.Length == 5 && (arr[0] != arr[4] || arr[1] != arr[3]))
{
    Console.WriteLine("Нет");
}
if(arr.Length != 5)
{
    Console.WriteLine("Число не пятизначное");
}