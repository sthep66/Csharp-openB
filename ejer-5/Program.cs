// *** Ejercicio 1 - IF

Console.WriteLine("Escribe tu nombre: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Escribe tu email: ");
string? email = Console.ReadLine();

Console.WriteLine("¿Tienes cupón? ( 1 = Si o 2 = No)");
int cupon = Convert.ToInt32(Console.ReadLine());

if (cupon == 1)
{
    Console.WriteLine("¿De cuanto es el descuento?");
    double descuento = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Precio con descuento: ${10500 - descuento}");

} else
{
    Console.WriteLine($"Precio actual sin cupón: $10.500");
}


// *** Ejercicio 2 - Switch

Console.WriteLine("Elige uno de los lenguajes de programación:\n1 - C#\n2 - Java\n3 - Python");
int opcion = Convert.ToInt32(Console.ReadLine());   

switch (opcion)
{
    case 1: 
        Console.WriteLine("Console.WriteLine(\"Hello C#\")");
        break;
    case 2:
        Console.WriteLine("System.out.println(\"Hello Java\")");
        break;

    case 3:
        Console.WriteLine("print(\"Hello Python\")");
    break;
};

