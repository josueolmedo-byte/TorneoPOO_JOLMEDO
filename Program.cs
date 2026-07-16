using TorneoPOO_JOLMEDO.Generales;
using TorneoPOO_JOLMEDO.Models;


int opcion = 0;
do
{
    Console.Clear();
    Console.WriteLine("*********Bienvenido al Torneo de Fútbol*********");
    Console.WriteLine("Menu de Opciones:");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Crear Jugadores");
    Console.WriteLine("2. Listar Jugadores");
    Console.WriteLine("3. Crear Equipos");
    Console.WriteLine("4. Crear Partidos");
    Console.WriteLine("5. Salir");
    Console.WriteLine("");
    Console.WriteLine("Ingrese una Opcion: ");
    opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            crearJugador();
            break;
        case 2:
            listarJugadores();
            break;
        case 3:
            crearEquipo();
            break;
        case 4:
            crearPartido();
            break;
        case 5:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, intente nuevamente.");
            break;
    }
} while (opcion != 5);

void listarJugadores()
{
    Console.Clear();
    Console.WriteLine("**********Jugadores Creados**********");
    foreach(Jugador jugador in Database.Jugadores)
    {
        jugador.Presentar();
    }
    Console.ReadLine();
}

void crearPartido()
{
    Console.Clear();
}

void crearEquipo()
{
    Console.Clear();
}

void crearJugador()
{
    Console.Clear();
    Console.WriteLine("**********Crear Jugador**********");
    Console.WriteLine("Ingrese el nombre del jugador: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la edad del jugador: ");
    int edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el numero del jugador: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la posicion del jugador: ");
    string posicion = Console.ReadLine();
    Console.Write("Ingrese la nacionalidad del jugador: ");
    string nacionalidad = Console.ReadLine();
    Console.Write("Ingrese la altura del jugador: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el pie dominante: ");
    string pieDominante = Console.ReadLine();

    Jugador objJugador = new Jugador(nombre, edad, numero, posicion, nacionalidad, altura, pieDominante);
    Database.Jugadores.Add(objJugador);
    Console.WriteLine("Jugador creado exitosamente.");
    Console.ReadLine();
}


////Jugadores
//Jugador objJugador1 = new Jugador("Lamine Yamal", 20, 19, "Extremo Derecho", "Español", 1.81, "Izquierdo");
//Jugador objJugador2 = new Jugador("Lionel Messi", 39, 10, "Delantero", "Argentino", 1.70, "Izquierdo");

////Primer Equipo
//Equipo objEquipo1 = new Equipo("Barcelona FC", "Barcelona", "Hansi Flick", "Lamine Yamal", "LaLiga");

////Mostrar datos del equipo
//Console.WriteLine($"Equipo: {objEquipo1.Nombre}");
//Console.WriteLine($"Ciudad: {objEquipo1.Ciudad}");
//Console.WriteLine($"Director Técnico: {objEquipo1.DirectorTecnico}");
//Console.WriteLine($"Capitán: {objEquipo1.Capitan}");
//Console.WriteLine($"Liga: {objEquipo1.Liga}");
//Console.WriteLine();

////Agregar Jugadores
//objEquipo1.AgregarJugador(objJugador1);
//objEquipo1.AgregarJugador(objJugador2);

////Prueba de validacion
//objEquipo1.AgregarJugador(null);

////Mostrar Plantilla
//objEquipo1.ListarPlantilla();

////Cambiar Posicion
//objJugador1.CambiarPosicion("Mediocampista");

////Cantidad de Jugadores
//Console.WriteLine($"El equipo tiene {objEquipo1.ContarJugadores()} jugadores.");

////Jugadores
//Jugador objJugador3 = new Jugador("Erling Haaland", 25, 9, "Delantero", "Noruego", 1.94, "Izquierdo");
//Jugador objJugador4 = new Jugador("Mikel Oyarzabal", 29, 21, "Delantero", "Español", 1.81, "Izquierdo");

////Segundo Equipo
//Equipo objEquipo2 = new Equipo("Manchester City", "Manchester", "Pep Guardiola", "Erling Haaland", "Premier League");

////Mostrar datos del equipo
//Console.WriteLine($"Equipo: {objEquipo2.Nombre}");
//Console.WriteLine($"Ciudad: {objEquipo2.Ciudad}");
//Console.WriteLine($"Director Técnico: {objEquipo2.DirectorTecnico}");
//Console.WriteLine($"Capitán: {objEquipo2.Capitan}");
//Console.WriteLine($"Liga: {objEquipo2.Liga}");
//Console.WriteLine();

////Agregar Jugadores
//objEquipo2.AgregarJugador(objJugador3);
//objEquipo2.AgregarJugador(objJugador4);

////Mostrar Plantilla
//objEquipo2.ListarPlantilla();

////Partido
//Partido objPartido1 = new Partido(
//    objEquipo1,
//    objEquipo2,
//    DateTime.Now,
//    "Barcelona",
//    "Clément Turpin",
//    "Champions League",
//    1
//);

////Mostrar datos del partido
//Console.WriteLine($"Árbitro: {objPartido1.Arbitro}");
//Console.WriteLine($"Torneo: {objPartido1.Torneo}");
//Console.WriteLine($"Jornada: {objPartido1.Jornada}");
//Console.WriteLine();

////Cambiar el lugar del partido
//objPartido1.CambiarLugar("Camp Nou");

////Mostrar resumen del partido
//objPartido1.MostrarResumen();