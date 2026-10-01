string alumnoB = "Nerea";
Console.WriteLine($"Desarrollador 2: {alumnoB}");
string alumnoA = "Laura";
Console.WriteLine($"Desarrollador 1: {alumnoA}");

Console.WriteLine("========================");
Console.WriteLine("      DAW DEVELOPERS");
Console.WriteLine("========================");

string equipo = "Los programadores";
int puntos = 350;
double presupuesto = 50;

Console.WriteLine("Hola Nerea, ¿cómo estás? Vengo a crear conflictos :D");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Iteración {i + 1}: ¡Conflicto creado!");
    puntos += 50;
    presupuesto += 20;
}

Console.WriteLine($"Equipo: {equipo}");
Console.WriteLine($"Puntos: {puntos}");
Console.WriteLine($"Presupuesto: {presupuesto} €");
double precioFinal = presupuesto * 1.5;

Console.WriteLine("------------------------");
Console.WriteLine("       GAME OVER");
Console.WriteLine("       Gracias por jugar");
Console.WriteLine("========================");

string lenguaje = "Java";
Console.WriteLine($"Lenguaje favorito: {lenguaje}");

string nuevoLenguaje = "C#";
Console.WriteLine($"Lenguaje: {nuevoLenguaje}");