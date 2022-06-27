// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int A = Prompt("Введите цифрц от 1 до 7: ");

if (A>0 & A<8) {

if (A==6 | A==7) {
    Console.WriteLine($"{A}-> Да");
}
else Console.WriteLine($"{A}-> Нет");
}
else Console.WriteLine("Введенная цифра не является днем недели");