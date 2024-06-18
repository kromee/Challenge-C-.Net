
using System.Data;

Console.WriteLine("Bienvenido al Student Challenge C# .Net");

Console.WriteLine("Master C# .net Fundamentals");
Console.WriteLine("\n");
Console.WriteLine("Tema 1-Matrices");

string [] OrdenFraudulentaIDs = new string[5];
OrdenFraudulentaIDs[0] = "A333";
OrdenFraudulentaIDs[1] = "B446";
OrdenFraudulentaIDs[2] = "C789";
OrdenFraudulentaIDs[3] = "C7IY";
OrdenFraudulentaIDs[4] = "C734";
//OrdenFraudulentaIDs[5] = "D000";




Console.WriteLine($"Primer elemento: {OrdenFraudulentaIDs[0]}");
Console.WriteLine($"Segundo elemento: {OrdenFraudulentaIDs[1]}");
Console.WriteLine($"Tercer elemento: {OrdenFraudulentaIDs[2]}");


// reasignar un valor a un elemento
OrdenFraudulentaIDs[0] = "F000";
Console.WriteLine($"Reasignacion al primer elemento: {OrdenFraudulentaIDs[0]}");



//Inicialización de una matriz

string[] OrdenIDs = { "A123", "B456", "C789", "09324", "4Q345" };
Console.WriteLine($"Primer elemento: {OrdenIDs[0]}");
Console.WriteLine($"Segundo elemento: {OrdenIDs[1]}");
Console.WriteLine($"Tercer elemento: {OrdenIDs[2]}");
Console.WriteLine($"Primer elemento: {OrdenIDs[3]}");
Console.WriteLine($"Segundo elemento: {OrdenIDs[4]}");

Console.WriteLine($"Esta matriz contiene {OrdenIDs.Length} elementos.");


Console.WriteLine("\n");
Console.WriteLine("Tema 2-instrucción foreach");

string[] nombres = { "Soledad", "Juan", "Roberto", "Memo"};
foreach (string nombre in nombres){
    Console.WriteLine(nombre);
}

int[] inventario = {4, 7, 3, 5,102};
int sum = 0;
int bin = 0;
foreach (int item in inventario){
sum += item;
bin++;
Console.WriteLine($"Bin {bin} = {item} item (Running total: {sum})");

}


Console.WriteLine($"Usted tiene {sum} elementos en el invenrario.");



//Prueba
Console.WriteLine("Prueba");
Console.WriteLine("\n");

string [] items = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string item in items){
    if(item.StartsWith("B")){
        Console.WriteLine("El elemento inicia con 'B'! "+ item );
    }
}




Console.WriteLine("if-else if-else");
Console.WriteLine("\n");

bool even = false;
bool even1 = false;
if (even) Console.WriteLine("El elemento");
else if(even1) Console.WriteLine("El elemento");
else  Console.WriteLine("El elemento");


      
Console.WriteLine("switch");
Console.WriteLine("\n");


int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


Console.WriteLine("Ciclo for");
Console.WriteLine("\n");


for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
Console.WriteLine("\n");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
Console.WriteLine("\n");

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

for (int counter = 20; counter < 80; counter++){

}





Console.WriteLine("variables literales");
Console.WriteLine("\n");
Console.WriteLine("Ejercicio: Impresión de distintos tipos de datos literales");
Console.WriteLine("\n");

Console.WriteLine("Hello World!"); // palabras o frases, dato alfanumérico
Console.WriteLine(0.25F); //sufijo literal. f flotante
Console.WriteLine(2.625); // valor predeterminado un literal double  por default es doble cuando se escribe un número con punto decimal
Console.WriteLine(12.39816m); //sufijo literal. m decimal

Console.WriteLine(true);//  literal bool.
Console.WriteLine(false);// literal bool.


Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("variables locales con tipo implícito");
Console.WriteLine("\n");
var texto = "Hello world!"; // var siempre debe inicializarse, indica al compilador que deduzca el tipo de datos de la variable en función del valor en el que se inicializa.
Console.WriteLine(texto);



decimal gradePointAverage = 3.99872831m;
Console.WriteLine(gradePointAverage);






Console.WriteLine("Ciclo While");
Console.WriteLine("\n");

/*Random random = new Random();
int current = 0;
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

/*
string? readResult;
string roleName = "";
bool validEntry = false;


do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/

Console.WriteLine("Evaluación de expresiones booleanas para tomar decisiones");
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: Falseed



Console.WriteLine("Evaluación de expresiones booleanas para tomar decisiones");
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
Console.WriteLine("Uso del operador condicional insertado\n");

// int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");


Console.WriteLine("Conversión de tipos de datos\n\n");
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}


if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

Console.WriteLine("Ejericio-------");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var valuex in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(valuex, out number))
    {
        total += number;
    } else
    {
        message += valuex;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");



Console.WriteLine(" Operaciones en matrices mediante métodos auxiliares en C# ");
Console.WriteLine("\n\n");

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}



Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


Console.WriteLine("Descubrimiento de Split() y Join()");
string valuesss = "abc123";
char[] valueArray = valuesss.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string results = String.Join(",", valueArray);
Console.WriteLine(results);


Console.WriteLine("Ejercicio \n\n");
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] messages = pangram.Split(' ');

//Step 2
string[] newMessage = new string[messages.Length];

// Step 3
for (int i = 0; i < messages.Length; i++)
{
    char[] letters = messages[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string resultss = String.Join(" ", newMessage);
Console.WriteLine(resultss);

string orderStreams = "B123,C234,A345,C15,B177,G3003,C235,B179";
string []array = orderStreams.Split(',');
Array.Sort(array);
 for (int  i = 0; i < array.Length; i++){
    if(array[i].Length==4){
 Console.WriteLine(array[i]);
    }else{
 Console.WriteLine(array[i] + "\t- Error");
    }
 }



Console.WriteLine("interpolación de cadenas \n\n");

 string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");



Console.WriteLine("método sobrecargado.. \n\n");

 string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));



Console.WriteLine("IndexOf() y Substring() \n\n");
string messagesd = "Find what is (inside the parentheses)";

int openingPosition = messagesd.IndexOf('(');
int closingPosition = messagesd.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(messagesd.Substring(openingPosition, length));