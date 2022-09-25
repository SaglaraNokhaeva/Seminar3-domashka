// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
Console.WriteLine("Введите  число n");
double n = double.Parse(Console.ReadLine());
string arr = n.ToString();
int len= arr.Length;
int i=len/2;
int count=0;
int j=0;
for (j=0;j<i-1;j++)
{
   if (arr[j]!=arr[len-j-1])
   {
    Console.WriteLine("Введённое число не палиндром"); 
     break;  
   }
   count=count+1;   
}
if (count==i-1) 
{Console.WriteLine("Введённое число палиндром");
}

