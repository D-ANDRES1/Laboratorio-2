//Practica para entender c#//

int entero = 0;
double deci = 0.1;
string cadena ="ejemplo";
bool logico = false;

Console.WriteLine("--Tipos de datos--");
Console.WriteLine(entero);
Console.WriteLine(deci);
Console.WriteLine(cadena);
Console.WriteLine(logico);


try
{
    Console.WriteLine("\nIngrese un numero entero");
    entero = int.Parse(Console.ReadLine());
    Console.WriteLine($"Se ingreso correctamente el numero entero: {entero}\n");
}
catch (Exception ex)
{
    Console.WriteLine($"Dato entero ingresado invalido: {ex.Message}\n");
}

try
{
    Console.WriteLine("Ingrese un numero decimal");
    deci = double.Parse(Console.ReadLine());
    Console.WriteLine($"Se ingreso correctamente el numero decimal: {deci} \n");
}
catch (Exception ex)
{
    Console.WriteLine($"Dato decimal ingresado invalido: {ex.Message} \n");
}

try
{
    Console.WriteLine("Ingrese una palabra");
    cadena = Console.ReadLine();
    if (string.IsNullOrEmpty(cadena))
        throw new Exception("no puede estar vacio\n");

    Console.WriteLine($"Se ingreso correctamente un dato string: {cadena} \n");
}
catch (Exception ex)
{
    Console.WriteLine($"Dato string invalido: {ex.Message}\n");
}

try
{
    Console.WriteLine("Ingrese  un valor logico, que sea (true/false): ");
    logico = bool.Parse(Console.ReadLine());
    Console.WriteLine($"Se ingreso correctamente un dato booleano: {logico}  \n");
}
catch (Exception ex)
{
 Console.WriteLine($"Dato booleano invalido: {ex.Message}");
}
