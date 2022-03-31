string nombre1;
string nombre2;

Console.WriteLine("Ingrese el Primer Nombre");
nombre1 = Console.ReadLine();

Console.WriteLine("Ingrese el Segundo Nombre");
nombre2 = Console.ReadLine();

if (nombre1 == nombre2)
{
    Console.WriteLine("--- Los Nombres son Iguales ---");
}
else
{
    Console.WriteLine("--- Los Nombres son Diferentes ---");
}
Console.ReadKey(true);