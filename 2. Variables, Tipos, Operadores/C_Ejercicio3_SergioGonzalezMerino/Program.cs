//Número es mayor o igual a 18

int num = 20;

bool isOlder = num >= 18;

//¿Será mayor de edad?

if (isOlder)
{
    Console.WriteLine("El número es mayor o igual a 18.");
} else
{
    Console.WriteLine("El número es menor que 18.");
}

//Un char es igual a 'a'

char character = 'a';

bool isCharA = character == 'a';

if (isCharA)
{
    Console.WriteLine("El carácter es \"a\".");
}
else
{
    Console.WriteLine("El carácter no es \"a\".");
}

// Se cumplen dos condiciones a la vez (ambas verdaderas)

int yearsOld = 18;
bool isLicense = true;
bool isOlderYears = yearsOld >= 18;

bool isDriveCar = isLicense && isOlderYears;

//¿Podrá o no podrá conducir coche de empresa?

if (isDriveCar)
{
    Console.WriteLine("Puede conducir coche de empresa.");
}else
{
    Console.WriteLine("No puede conducir coche de empresa.");
}


//Se cumple una de dos condiciones a la vez (una true y otra false)

//¿Aprobará el exámen? Es necesario tener mínimo un 8 en el teórico o un 10 en el práctico, con una de las dos se aprueba.

bool theoretical = 10 >= 8;
bool practical = 0 >= 10;

bool isApproved = theoretical || practical;

if (isApproved)
{
    Console.WriteLine("¡¡APROVADO!!");
} else
{
    Console.WriteLine("SUSPENDIDO");
}


