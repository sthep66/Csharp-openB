
// *** EJERCICIO 1

Console.WriteLine("Escribe tu nombre: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Escribe tu apellido: ");
string? apellido = Console.ReadLine();

Console.WriteLine("Escribe tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Sabes programar? ");
string? sabe_programar = Console.ReadLine();

Console.WriteLine($"Nombre: {nombre}\nApellido: {apellido}\nEdad: {edad}\nSabe programar: {sabe_programar}");


// *** EJERCICIO 2

// Coche:
int puertas = 2;
int ruedas = 4;
string marca = "Tesla";
bool ITV_vigente = true;

// Mesa:
double peso = 12.5;
double largo = 2.3;
string material = "roble";
string color = "natural";


// *** EJERCICIO 3

int a = 10;
Console.WriteLine(a >= 18);

char letra = 'a';
Console.WriteLine(letra == 'a');

string uno = "manzana";
string dos = "manzana";
string tres = "pera";
Console.WriteLine(uno == "manzana" && dos == "manzana");

Console.WriteLine(tres == "pera" || uno == "pera");