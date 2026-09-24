
using Arreglos.Logica;


MiArreglo oMyArreglo = new MiArreglo(10);

oMyArreglo.Llenar(1, 100);


Console.WriteLine("Arreglo desordenado");
Console.WriteLine(oMyArreglo);
//oMyArreglo.ToString();

Console.WriteLine("Arreglo ordenado ascendente");
oMyArreglo.Ordenar(true); // con o sin true debe funcionar correctamente 
Console.WriteLine(oMyArreglo);

Console.WriteLine("Arreglo ordenado adescendente");
oMyArreglo.Ordenar(false);
Console.WriteLine(oMyArreglo);


Console.ReadKey();

// Versión 03: Estructura base para la siguiente clase
