// *** EJERCICIO 1

Clientes cli = new Clientes("Lola Bunny", 12356, "Looney Tunes 123", "lolab@gmail.com", true);
Console.WriteLine(cli);

public struct Clientes {
    public Clientes( string nom, int telf, string dir, string mail, bool nuevo){
        nombre = nom;
        telefono = telf;
        direccion = dir;
        email = mail;
        nuevo_cliente = nuevo;
    }

    public string nombre {get; set;}
    public int telefono {get; set;}
    public string direccion {get; set;}
    public string email {get; set;}
    public bool nuevo_cliente {get; set;}

    public override string ToString()
    {
        return $"Nombre completo: {nombre}\n Teléfono: {telefono}\n Dirección: {direccion}\n Email: {email}\n Cliente nuevo: {nuevo_cliente}";
    }
}

