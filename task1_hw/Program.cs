// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int A = Prompt("Введите трехзначное число = ");

if (A>99 && A<1000) {
int temp = A/10;
int secont_number = temp%10;

Console.WriteLine(secont_number);
}
else Console.WriteLine("Введено не трехзначное число");
