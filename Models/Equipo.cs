using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_JOLMEDO.Models
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo(string nombre, string ciudad)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre del equipo no puede estar vacío.");
            }

            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador objJugador)
        {
            if (objJugador == null)
            {
                Console.WriteLine("Error: No se puede agregar un jugador nulo a la lista.");
                return; 
            }

            this.Jugadores.Add(objJugador);
            Console.WriteLine($"Jugador {objJugador.Nombre} agregado correctamente");
        }
        public void ListarPlantilla()
        {
            Console.WriteLine($"La lista de jugadores del equipo {this.Nombre} de la ciudad de {this.Ciudad} es:");

            foreach (Jugador objJugador in Jugadores)
            {
                objJugador.Presentar();
            }
        }
        public int ContarJugadores()
        {
            return Jugadores.Count;
        }
    }
}
