Console.Write("Introduce un número: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nTabla de multiplicar del número {num}\n");

int i = 1;

while (i <= 10)
{
    int result = num * i;
    Console.WriteLine($"{num} x {i} = {result}");
    i++;
}