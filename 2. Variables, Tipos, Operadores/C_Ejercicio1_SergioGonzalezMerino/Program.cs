//Pedimos al usuario: Nombre, apellidos, edad, ciudad donde reside, si sabe programar.

Console.WriteLine("Nombre:");
string? name = Console.ReadLine();

Console.WriteLine("Apellidos:");
string? lastName = Console.ReadLine();

Console.WriteLine("Ciudad de residencia:");
string? city = Console.ReadLine();

Console.WriteLine("¿Sabes programar? (S/N):");
string? isDeveloper = Console.ReadLine();

if (isDeveloper != null && isDeveloper.ToLower().Equals("s"))
{
    isDeveloper = "sabes programar :)!";
} else
{
    isDeveloper = "no sabes programar :(";
}


string message = "Hola " + name + " " +lastName + ", vives en " + city + " y " + isDeveloper + ".";

Console.WriteLine(message); 