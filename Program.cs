using System;

Console.WriteLine ("¡Bienvenido a la biblioteca del Pascual!");
Console.WriteLine ("Validemos primero tu identidad");

//Declarar al menos 3 variables con tipos distintos
int Edad;
string? NombreCompleto;
bool Activo;
int LibrosDisponibles = 5;
int LibrosPrestados = 1;
double Promedio;

//Pedir al menos 2 datos por teclado con Console.ReadLine, convertidos con TryParse
Console.WriteLine("Ingrese su nombre completo");
NombreCompleto = Console.ReadLine () ?? "";

Console.WriteLine("Ingresa su edad");
string? EdadInput = Console.ReadLine();
int.TryParse(EdadInput, out Edad);

Console.Write("Ingrese su promedio académico: ");
string? PromedioInput = Console.ReadLine();
double.TryParse(PromedioInput, out Promedio);

Console.Write("¿Está activo? (escriba 'true' o 'false'): ");
string? ActivoInput = Console.ReadLine();
bool.TryParse(ActivoInput, out Activo); 


//Aplicar al menos 2 operadores

int disponibles = LibrosDisponibles - LibrosPrestados;
Console.WriteLine($"Disponibles: {disponibles}");

bool HayDisponibilidad = disponibles > 0;
Console.WriteLine($"Se puede prestar: {HayDisponibilidad}");

bool Opcion = true;
Console.WriteLine ($"¿Desea pedir un libro prestado:{Opcion} ");


//Mostrar un resultado por consola con interpolación}
Console.WriteLine("\n RESULTADO DEL PROCESO");
Console.WriteLine($"Estudiante: {NombreCompleto}");
Console.WriteLine($"¿Estado de préstamo aprobado?: {HayDisponibilidad}");
Console.WriteLine($"Resultado final: El usuario de {Edad} años tiene {disponibles} libros a su disposición.");