using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_JOLMEDO.Models
{
    public class Equipo
    {
        private string nombre;
        private string ciudad;
        private List<Jugador> jugadores;
        private string directorTecnico;
        private string capitan;
        private string liga;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string DirectorTecnico
        {
            get => directorTecnico;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El director técnico no puede estar vacío.");
                }
                directorTecnico = value;
            }
        }
        public string Capitan
        {
            get => capitan;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El capitán no puede estar vacío.");
                }
                capitan = value;
            }
        }
        public string Liga
        {
            get => liga;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("La liga no puede estar vacía.");
                }
                liga = value;
            }
        }

        public Equipo(string nombre, string ciudad, string directorTecnico, string capitan, string liga)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre del equipo no puede estar vacío.");
            }

            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Jugadores = new List<Jugador>();
            this.DirectorTecnico = directorTecnico;
            this.Capitan = capitan;
            this.Liga = liga;
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
                objJugador.Imprimir();
                Console.WriteLine("---------------------");
            }
        }
        public int ContarJugadores()
        {
            return Jugadores.Count;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nombre del equipo: {this.Nombre}");
            Console.WriteLine($"Ciudad del equipo: {this.Ciudad}");
            Console.WriteLine($"Director Técnico del equipo: {this.DirectorTecnico}");
            Console.WriteLine($"Capitán del equipo: {this.Capitan}");
            Console.WriteLine($"Liga del equipo: {this.Liga}");
            ListarPlantilla();
        }
    }
}
