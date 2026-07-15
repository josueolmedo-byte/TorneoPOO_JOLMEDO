using TorneoPOO_JOLMEDO.Models;

//Jugadores
Jugador objJugador1 = new Jugador("Lamine Yamal", 20, 19, "Extremo Derecho", "Español", 1.81, "Izquierdo");
Jugador objJugador2 = new Jugador("Lionel Messi", 39, 10, "Delantero", "Argentino", 1.70, "Izquierdo");

//Primer Equipo
Equipo objEquipo1 = new Equipo("Barcelona FC", "Barcelona", "Hansi Flick", "Lamine Yamal", "LaLiga");

//Mostrar datos del equipo
Console.WriteLine($"Equipo: {objEquipo1.Nombre}");
Console.WriteLine($"Ciudad: {objEquipo1.Ciudad}");
Console.WriteLine($"Director Técnico: {objEquipo1.DirectorTecnico}");
Console.WriteLine($"Capitán: {objEquipo1.Capitan}");
Console.WriteLine($"Liga: {objEquipo1.Liga}");
Console.WriteLine();

//Agregar Jugadores
objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);

//Prueba de validacion
objEquipo1.AgregarJugador(null);

//Mostrar Plantilla
objEquipo1.ListarPlantilla();

//Cambiar Posicion
objJugador1.CambiarPosicion("Mediocampista");

//Cantidad de Jugadores
Console.WriteLine($"El equipo tiene {objEquipo1.ContarJugadores()} jugadores.");

//Jugadores
Jugador objJugador3 = new Jugador("Erling Haaland", 25, 9, "Delantero", "Noruego", 1.94, "Izquierdo");
Jugador objJugador4 = new Jugador("Mikel Oyarzabal", 29, 21, "Delantero", "Español", 1.81, "Izquierdo");

//Segundo Equipo
Equipo objEquipo2 = new Equipo("Manchester City", "Manchester", "Pep Guardiola", "Erling Haaland", "Premier League");

//Mostrar datos del equipo
Console.WriteLine($"Equipo: {objEquipo2.Nombre}");
Console.WriteLine($"Ciudad: {objEquipo2.Ciudad}");
Console.WriteLine($"Director Técnico: {objEquipo2.DirectorTecnico}");
Console.WriteLine($"Capitán: {objEquipo2.Capitan}");
Console.WriteLine($"Liga: {objEquipo2.Liga}");
Console.WriteLine();

//Agregar Jugadores
objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);

//Mostrar Plantilla
objEquipo2.ListarPlantilla();

//Partido
Partido objPartido1 = new Partido(
    objEquipo1,
    objEquipo2,
    DateTime.Now,
    "Barcelona",
    "Clément Turpin",
    "Champions League",
    1
);

//Mostrar datos del partido
Console.WriteLine($"Árbitro: {objPartido1.Arbitro}");
Console.WriteLine($"Torneo: {objPartido1.Torneo}");
Console.WriteLine($"Jornada: {objPartido1.Jornada}");
Console.WriteLine();

//Cambiar el lugar del partido
objPartido1.CambiarLugar("Camp Nou");

//Mostrar resumen del partido
objPartido1.MostrarResumen();