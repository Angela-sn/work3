// Задача 23/ Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите любое число: ");  
int a = 0;
a = Convert.ToInt32(Console.ReadLine());

string CubeTable(int a)
{
    int count = 1;
    string table = "";
    while (count <= a)
    {
        table = table + $" {count} -> | {count * count * count} \a,";
        count++;
    }
    return table;
}
string cubeTable = CubeTable(a);
Console.Write(cubeTable);



 