

// *** EJERCICIO 1 *** - WHILE
Console.WriteLine("Ingrese un numero para multiplicar: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= 10)
{
    int resul = num * i;
    Console.WriteLine($"{num} x {i} = {resul}");
    i++;
}



// *** EJERCICIO 2 *** - DO WHILE

Console.WriteLine("Ingrese un numero: ");
int x =  Convert.ToInt32(Console.ReadLine());
int cpos = 0;
int cneg = 0;

do
{
    if (x > 0)
    {
        Console.WriteLine("Es un numero positivo!");
        cpos++;
    } else
    {
        Console.WriteLine("Es un numero negativo!");
        cneg++;
    }

    Console.WriteLine("Ingrese un numero: ");
    x = Convert.ToInt32(Console.ReadLine());

} while (x != 0);

Console.WriteLine($"Ingresaste {cpos} numeros positivos y {cneg} numeros negativos.");




// *** EJERCICIO 3 *** - FOR

Console.WriteLine("Ingrese el ancho:");
int ancho = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el alto:");
int alto = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("¿Relleno? (1 = Si, 0 = No)");
bool relleno = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));


if (ancho == alto)
{
    Console.WriteLine("Dibujando un cuadrardo de lado " + ancho);
    for (int j = 0; j < ancho; j++)
    {
        for (int k = 0; k < ancho; k++)
        {
            if (relleno || j == 0 || k == 0 || j == ancho - 1 || k == ancho - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Dibujando un ractangulo de ancho " + ancho + " y alto " + alto);
    for (int m = 0; m < alto; m++)
    {
        for (int v = 0; v < ancho; v++)
        {
            if (relleno || m == 0 || v == 0 || m == alto - 1 || v == ancho - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

Console.ReadKey();