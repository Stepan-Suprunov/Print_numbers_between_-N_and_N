// Выводит числа в промежутке от -N до -N
Console.WriteLine("Задайте число N");
int Nmax = int.Parse(Console.ReadLine());
int Nmin = - Nmax;
while (Nmin <= Nmax) {
    Console.Write(Nmin + ",");
    Nmin ++;
}