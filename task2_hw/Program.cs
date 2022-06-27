// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int Rnd (int min, int max){
    Random rnd = new Random();
    return rnd.Next(min, max+1);
}

int a = Rnd (100,999);
Console.WriteLine(a);

int temp1 = a%10;
int temp2 = a/100;

Console.Write(temp2);
Console.WriteLine(temp1);
