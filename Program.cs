using TorneoPOO_EMANOSALVAS.Models;
using TorneoPOO_JOLMEDO.Models;

Jugador objJugador1 = new Jugador();

objJugador1.Nombre = "Lamine Yamal";
objJugador1.Numero = 19;
objJugador1.Posicion = "Extremo Derecho";
objJugador1.Edad = 18;


Jugador objJugador2 = new Jugador();

objJugador2.Nombre = "Lionel Messi";
objJugador2.Numero = 10;
objJugador2.Posicion = "Delantero";
objJugador2.Edad = 39;


Equipo objEquipo1 = new Equipo();

objEquipo1.Nombre = "Barcelona FC";
objEquipo1.Ciudad = "Barcelona";
objEquipo1.Jugadores = new List<Jugador>();

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);



objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador();

objJugador3.Nombre = "Erling Haaland";
objJugador3.Numero = 9;
objJugador3.Posicion = "Delantero";
objJugador3.Edad = 25;


Jugador objJugador4 = new Jugador();

objJugador4.Nombre = "Mikel Oyarzabal";
objJugador4.Numero = 21;
objJugador4.Posicion = "Delantero";
objJugador4.Edad = 29;


Equipo objEquipo2 = new Equipo();

objEquipo2.Nombre = "Manchester City";
objEquipo2.Ciudad = "Manchester";
objEquipo2.Jugadores = new List<Jugador>();

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1 = new Partido();
objPartido1.Programar(objEquipo1, objEquipo2, DateTime.Now, "Manchester");
objPartido1.MostrarResumen();