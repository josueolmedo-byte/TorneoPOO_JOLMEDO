using TorneoPOO_EMANOSALVAS.Models;
using TorneoPOO_JOLMEDO.Models;

Jugador objJugador1 = new Jugador("Lamine Yamal", 18, 19, "Extremo Derecho");

Jugador objJugador2 = new Jugador("Lionel Messi", 39, 10, "Delantero");


Equipo objEquipo1 = new Equipo("Barcelona FC", "Barcelona");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);


objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador("Erling Haaland", 25, 9, "Delantero");

Jugador objJugador4 = new Jugador("Mikel Oyarzabal", 29, 21, "Delantero");


Equipo objEquipo2 = new Equipo("Manchester City", "Manchester");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1 = new Partido();
objPartido1.Programar(objEquipo1, objEquipo2, DateTime.Now, "Manchester");
objPartido1.MostrarResumen();