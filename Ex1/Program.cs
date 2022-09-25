Console.Clear();
Console.WriteLine("Введите номер задачи (19, 21 или 23) для проверки:");
int num = int.Parse(Console.ReadLine());
if (num==19) Task19();
    else {if (num==21) Task21(); 
        else {if (num==23) Task23();
        else Console.WriteLine("Дополнительные задачи не выполняла.");
             };
        
        };

void Task19(){
   
// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
Console.WriteLine("Введите  число пятизначное число n");
double n = double.Parse(Console.ReadLine());
string arr = n.ToString();
int count=0;
int j=0;
for (j=0;j<2;j++)
{
   if (arr[j]!=arr[5-j-1])
   {
    Console.WriteLine("Введённое число не палиндром"); 
     break;  
   }
   count=count+1;   
}
if (count==2) 
{Console.WriteLine("Введённое число палиндром");
}
};


void Task21(){

// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine());

double len = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2)),2);

Console.WriteLine($"Расстояние между точками = {len}");
};



void Task23(){

// Задача 23
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
int i=1;
Console.Write($"Таблица кубов от 1 до {n} : ");
for (i=1;i<n+1;i++)
{
   
    double three =Math.Pow(i,3);
    Console.Write($" {three}");
}
}
