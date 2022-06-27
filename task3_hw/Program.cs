// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int A = Prompt("Введите любое число: ");

//if (A<1)

while (A>999) {
    A=A/10;
}

if (A>99) {
Console.WriteLine(A%10);
}
else Console.WriteLine("Третьей цифры нет");