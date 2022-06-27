string[] devLangs = { "C#", "Java", "Python", "Rust", "JavaScript", "C++", "Kotlin", "PHP", "Swift" };
string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i" };

string titulo = "Lenguajes de programación disponibles";
string seleccionado = "Has seleccionado ";
bool isLetter = false;
bool underLine = true;
int select = 0;



Console.WriteLine(titulo);
for (int i= 0; i < titulo.Length; i++)
{
    Console.Write("-");
}
Console.WriteLine("\n");
for (int i = 0; i < devLangs.Length; i++)
{
    Console.WriteLine($"{i+1} o {letters[i]} - {devLangs[i]}");
}

Console.Write("\nIntroduce el número o la vocal del lenguaje que desea: ");
string? txtSelect = Console.ReadLine();


for (int i = 0; i < letters.Length; i++)
{
    if (txtSelect == letters[i])
    {
        select = i + 1;
        isLetter = true;
        break;
    }
}

if(!isLetter)
{
    select = Convert.ToInt32(txtSelect);
}



Console.Write($"\n{seleccionado}");
switch (select)
{
    case 1:
        Console.WriteLine("C# - Hola mundo!.");
        break;
    case 2:
        Console.WriteLine("Java.");
        break;
    case 3:
        Console.WriteLine("Python.");
        break;
    case 4:
        Console.WriteLine("Rust.");
        break;
    case 5:
        Console.WriteLine("JavaScript.");
        break;
    case 6:
        Console.WriteLine("C++.");
        break;
    case 7:
        Console.WriteLine("Kotlin.");
        break;
    case 8:
        Console.WriteLine("PHP.");
        break;
    case 9:
        Console.WriteLine("Swift.");
        break;
    default:
        Console.WriteLine("No has seleccionado ninguno...");
        underLine = false;
        break;
}




if (underLine)
{
    for (int i = 0; i < (seleccionado.Length + devLangs[select - 1].Length); i++)
    {
        if (i < seleccionado.Length) { Console.Write(" "); } else { Console.Write("-"); }
    }
    Console.WriteLine();
}