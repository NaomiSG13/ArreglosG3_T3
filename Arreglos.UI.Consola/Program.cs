//using Arreglos.Logica;

//Console.WriteLine("Arreglos");

//MiArreglo oMiArreglo = new MiArreglo(20);

//oMiArreglo.Llenar(5, 50);

//Console.WriteLine(oMiArreglo.ToString());
using Arreglos.Logica;

Console.WriteLine("Arreglos");

MiArreglo oMiArreglo = new MiArreglo(10);

oMiArreglo.Llenar(1, 100);


Console.WriteLine("Arreglo desordenado");
Console.WriteLine(oMiArreglo);
//oMyArreglo.ToString();

Console.WriteLine("Arreglo ordenado");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);

Console.ReadKey();

// Versión 03: Estructura base para la siguiente clase
