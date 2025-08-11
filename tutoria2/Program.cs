// See https://aka.ms/new-console-template for more information

using EjerciciosTutoria2;

List<string> dias = new List<string> { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
/*foreach (string dia in dias)
    Console.WriteLine(dia);*/
// El metodo Add agrega elementos al final de la lista
// El metodo Insert me permite especificar el indice donde quiero insertar
dias.Insert(4, "Juerneses");
// List<string> lista2 = new List<string>(dias); - > Forma clasica de copiar una lista
List<string> lista2 = [..dias]; // -> Forma moderna de copiar una lista
// List<string> lista3 = dias; -> CUIDADO: Esto no crea una copia sino una referencia
/*
foreach (string dia in dias)
    Console.WriteLine(dia);*/
Console.WriteLine($"Posicion 3: { dias[3]} / Posicion 4: {dias[4]}");

// Eliminar elemento y comprobar si se elimino o no 
bool eliminado = dias.Remove("Juerneses");
Console.WriteLine("Se elimino el elemento Juerneses?" + (eliminado?"Si":"No"));

//Creando iterador y mostrando un elemento de la lista
using (var iterador= dias.GetEnumerator())
{
    if (iterador.MoveNext())
    {
        Console.WriteLine($"Elemento actual del iterador:{iterador.Current}");
    }
}

// Comparacion exacta
bool encontrado = dias.Contains("Lunes");
Console.WriteLine($"Esta el lunes en la lista?{encontrado}");
// Comparacion IgnoreCase
string cadenaBuqueda = "lUneS";
bool encontrado2 = Comparador.Contiene(dias,cadenaBuqueda );
Console.WriteLine($"Esta el lunes en la lista?{encontrado2}");

bool encontrado3 = dias.Any(n => n.ToUpper().Equals(cadenaBuqueda.ToUpper()));

Console.WriteLine((encontrado3) ? "Encontrado2" : "No encontrado2");

// EJERCICIO
HashSet<string> jugadores = new HashSet<string> { "Cubarsi", "Lamine","Pedri"};
Console.WriteLine("----- LISTADO DE JUGADORES ------------");
foreach (string jugador in jugadores)
{
    Console.WriteLine(jugador);
}
bool encontradoJugador = jugadores.Contains("Neymar Jr");
Console.WriteLine(encontradoJugador);

HashSet<string> jugadores2 = new HashSet<string> { "Pique", "Busi" };
Console.WriteLine($"Todos los elementos de jugadores2 estan en jugadores? {jugadores2.IsSubsetOf(jugadores)}"); 

// Union de conjuntos
jugadores.UnionWith(jugadores2);
Console.WriteLine("----- LISTADO DE JUGADORES ------------");
foreach (string jugador in jugadores)
{
    Console.WriteLine(jugador);
}
Console.WriteLine($"Todos los elementos de jugadores2 estan en jugadores? {jugadores2.IsSubsetOf(jugadores)}");

//Eliminando todos los elementos de jugadores2
jugadores2.Clear();
Console.WriteLine($"Numero de elementos de jugadores2: {jugadores2.Count}");