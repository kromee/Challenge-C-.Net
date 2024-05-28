
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




