using TorneoPOO_EMANOSALVAS.Models;
using TorneoPOO_JOLMEDO.Models;
//Clase Jugador
Jugador objJugador1 = new Jugador("Lamine Yamal", 20, 19, "Extremo Derecho");

Jugador objJugador2 = new Jugador("Lionel Messi", 39, 10, "Delantero");

//Clase equipo
Equipo objEquipo1 = new Equipo("Barcelona FC", "Barcelona");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);

objEquipo1.ListarPlantilla();

//Clase Jugador
Jugador objJugador3 = new Jugador("Erling Haaland", 25, 9, "Delantero");

Jugador objJugador4 = new Jugador("Mikel Oyarzabal", 29, 21, "Delantero");

//Clase Equipo
Equipo objEquipo2 = new Equipo("Manchester City", "Manchester");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);

objEquipo2.ListarPlantilla();

//Clase Partido
Partido objPartido1 = new Partido(objEquipo1, objEquipo2, DateTime.Now, "Barcelona");
objPartido1.MostrarResumen();

objJugador1.Entrenar();

objEquipo1.BuscarJugadorPorNumero(10);

objPartido1.RegistrarResultado(3, 1);