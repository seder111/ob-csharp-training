// Pedir datos: Nombre, email, cupon descuento.
// Determinar si tiene un cupon descuento.
// Mostrar el precio rebajado si tiene descuento.
// Mostrar precio real si no tiene descuento.

Console.WriteLine("El precio del producto son 100 Euros\n");

const double priceProduct = 100d;

Console.Write("Introduce tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Introduce tu email: ");
string email = Console.ReadLine();

Console.Write("¿Código descuento? -> ");
string code = Console.ReadLine();

bool isCode = false;

double finallyPrice = priceProduct;

if (code.ToUpper() == "DESCUENTO10") { isCode = true; }

if (isCode)
{
    finallyPrice = priceProduct - (priceProduct * 0.1);
}

Console.WriteLine($"El precio final del producto son {finallyPrice} Euros");

