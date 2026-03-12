using System.Security.Cryptography.X509Certificates;

Console.Write("Hola ");
Console.Write("mundo");
Console.WriteLine("!");

Console.WriteLine("Segunda linea");
Console.WriteLine();
Console.WriteLine("Cuarta linea");

Console.WriteLine("Nombre\t\tEdad\tCiudad");
Console.WriteLine("------\t\t----\t------");
Console.WriteLine("Jaume\t\t18\tTarragona");
Console.WriteLine("Elizabeth\t20\tBilbao");

Console.WriteLine("Ruta: C:\\Usuarios\\Documentos");
Console.WriteLine("Dijo: \"Hola mundo\"");
Console.WriteLine("Linea 1\nLinea 2\nLinea 3");
Console.WriteLine("Col1\tCol2\tCol3");
Console.WriteLine("100\u20AC");

Console.ForegroundColor = ConsoleColor.Green; 
Console.WriteLine("Operación completada con éxito");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Error: archivo no encontrado");

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("   TÍTULO DEL PROGRAMA   ");

Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Texto normal de nuevo");

double precio = 1234.567;
int codigo = 42;
double ratio = 0.7523;
int valor = 255;

Console.WriteLine($"Moneda: {precio:C2}");
Console.WriteLine($"Fijo 2 dec: {precio:F2}");
Console.WriteLine($"Con sep: {precio:N2}");
Console.WriteLine($"Código: {codigo:D6}");
Console.WriteLine($"Porcentaje: {ratio:P1}");
Console.WriteLine($"Hexadecimal: {valor:X}");
Console.WriteLine($"Científico: {precio:E2}");

double num = 1234.5;
Console.WriteLine (num.ToString("0.00"));
Console.WriteLine (num.ToString("#,##0.00"));
Console.WriteLine (num.ToString("000000.000"));
Console.WriteLine ((0.05).ToString("0.##%"));

Console.WriteLine ($"{"Producto",-20} {"Precio",10} {"Stock",8}");
Console.WriteLine (new string ('-', 40));
Console.WriteLine ($"{"Teclado",-20} {49.99,10:C2} {12,8}");
Console.WriteLine ($"{"Ratón inalámbrico", -20} {29.95,10:C2} {5,8}");
Console.WriteLine ($"{"Monitor 24\"",-20} {199.00,10:C2} {3,8}");

Console.WriteLine (string.Format("{0,-25} {1,10}", "Concepto", "Importe"));
Console.WriteLine (new string('=', 35));
Console.WriteLine (string.Format("{0,-25} {1,10:C2}", "Suscripción mensual", 9.99));
Console.WriteLine (string.Format("{0,-25} {1,10:C2}", "Almacenamiento extra", 2.49));
Console.WriteLine (string.Format("{0,-25} {1,10:C2}", "IVA (21%)", 2.62));
Console.WriteLine (new string('-', 35));
Console.WriteLine (string.Format("{0,-25} {1,10:C2}", "TOTAL", 15.10));

string nombre = "Ana";
string apellido = "García";

Console.WriteLine (nombre.PadRight(15) + apellido.PadLeft(15));
