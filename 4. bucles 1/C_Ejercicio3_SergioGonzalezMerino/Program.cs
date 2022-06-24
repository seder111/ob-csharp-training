Console.Write("Introduce el alto: ");
int alto = Convert.ToInt32(Console.ReadLine());
Console.Write("\nIntroduce el ancho: ");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.Write("\n¿Quieres relleno? (S/N), si lo dejas vacío será como si dijeras no -> ");
string? relleno = Console.ReadLine().ToLower();
Console.Write("\n¿Cuantos quieres mostrar en pantalla? -> ");
int num_veces = Convert.ToInt32(Console.ReadLine());

string[,] arra1 = new string[ancho, alto];
Console.WriteLine("");
for (int k = 0; k < alto; k++)
{
    for (int n = 0; n < num_veces; n++)
    {
        for (int m = 0; m < ancho; m++)
        {
            if (relleno.Equals("s") || relleno.Equals("si"))
            {
                Console.Write("*");

            }
            else
            {

                if (k == 0 || k == alto - 1 || m == 0 || m == ancho - 1)
                {
                    Console.Write("*");
                    continue;
                }

                Console.Write(" ");

            }
        }
        Console.Write("  ");

    }
    Console.WriteLine("");
}