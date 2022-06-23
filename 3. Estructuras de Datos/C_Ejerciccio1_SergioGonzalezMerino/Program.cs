// Nuevo cliente base.

Cliente cliente1 = new Cliente("Sergio González", 666666666, "Calle del percebe", "correo@electronico.com", true);
Console.WriteLine(cliente1.ToString());

// Copiamos el cliente a otro nuevo y cambiamos el telefono y el nombre.

Cliente cliente2 = cliente1 with { name="Miriam González", phone = 777777777};
Console.WriteLine(cliente2.ToString());

public struct Cliente
{
    public Cliente(string nombreCompleto, int telefono, string direccion, string correo, bool isClient)
    {
        name = nombreCompleto;
        phone = telefono;
        direcction = direccion;
        email = correo;
        newClient = isClient;
    }

    public string name { get; set; }
    public int phone { get; set; }
    public string direcction { get; set; }
    public string email { get; set; }
    public bool newClient { get; set; }

    public override string ToString()
    {
        return $"nombre: {name}, teléfono: {phone}, dirección: {direcction}, email: {email}, nuevo cliente {newClient}";
    }

}