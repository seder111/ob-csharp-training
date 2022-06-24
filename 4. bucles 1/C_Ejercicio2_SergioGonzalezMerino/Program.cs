Console.Write("Cuantos números quieres introducir: ");
int num_do_while = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int i = 0;
int[] arr = new int[num_do_while];


do
{
    Console.Write("Introduce un número: ");
    int user_num = Convert.ToInt32(Console.ReadLine());

    arr[i] = user_num;
    i++;

} while (i < num_do_while);

Console.WriteLine($"\nHas introducido {num_do_while} números.");

int con_pos = 0;
int con_neg = 0;
int con_cero = 0;

foreach (int item in arr)
{
    if (item < 0)
    {
        con_neg++;
    }
    else if (item > 0)
    {
        con_pos++;
    }
    else
    {
        con_cero++;
    }
}

Console.WriteLine($"\nNúmeros positivos: {con_pos}\nNúmeros negativos: {con_neg}\nNúmeros cero: {con_cero}");