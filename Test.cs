//Задача: Написать программу, которая из имеющегося массива строк формирует 
//новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

using System.Globalization;
using System.Linq.Expressions;

string[] array = new string[] { "Hello", "2", "world", ":-)" };
// string[] array = new string[] { "1234", "1567", "-2", "computer science" };
// string[] array = new string[] { "Russia", "Denmark", "Kazan" };
int count = 0;
for(int i = 0; i < array.Length; i++)
{
     if (array[i].Length <= 3)
     {
     count++;   
     }
}
string[] arrayRes = new string[count];


void ReleaseArray(string[] array, string[] arrayRes)
{
     int j = 0;
     for(int i = 0; i < array.Length; i++)
     {
          if (array[i].Length <= 3)
          {
          arrayRes[j] = array[i];     
          j++;   
          }
     }     
}

ReleaseArray(array, arrayRes);
Console.WriteLine($"[{string.Join(", ", arrayRes)}]");
