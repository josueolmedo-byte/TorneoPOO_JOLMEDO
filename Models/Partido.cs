using System;
using System.Collections.Generic;
using System.Text;

using TorneoPOO_JOLMEDO.Models;

namespace TorneoPOO_JOLMEDO.Models
{
    public class Partido
    {
        private int id;
        private Equipo Local;
        private Equipo Visitante;
        private DateTime Fecha;
        private string Lugar;
        private string arbitro;
        private string torneo;
        private int jornada;
        public Equipo Local1 { get => Local; set => Local = value; }
        public Equipo Visitante1 { get => Visitante; set => Visitante = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string Lugar1 { get => Lugar; set => Lugar = value; }
        public string Arbitro
        {
            get => arbitro;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El árbitro no puede estar vacío.");
                }
                arbitro = value;
            }
        }
        public string Torneo
        {
            get => torneo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El torneo no puede estar vacío.");
                }
                torneo = value;
            }
        }

        public int Jornada
        {
            get => jornada;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La jornada debe ser mayor que 0.");
                }
                jornada = value;
            }
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        public Partido(int id, Equipo local, Equipo visitante, DateTime fecha, string lugar, string arbitro, string torneo, int jornada)
        {
            if (local != null && visitante != null && local.Nombre == visitante.Nombre)
            {
                Console.WriteLine("Error: El equipo Local y el Visitante no pueden ser el mismo.");
            }
            this.Id = id;
            Local1 = local;
            Visitante1 = visitante;
            Fecha1 = fecha;
            Lugar1 = lugar;
            this.Arbitro = arbitro;
            this.Torneo = torneo;
            this.Jornada = jornada;
            
        }
        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local1.Nombre} y el visitante {this.Visitante1.Nombre} en el lugar {this.Lugar1}");
        }
        public void Imprimir()
        {
            Console.WriteLine($"ID: {this.Id}");
            Console.WriteLine($"Equipo Local: {this.Local1.Nombre}");
            Console.WriteLine($"Equipo Visitante: {this.Visitante1.Nombre}");
            Console.WriteLine($"Fecha: {this.Fecha1}");
            Console.WriteLine($"Lugar: {this.Lugar1}");
            Console.WriteLine($"Árbitro: {this.Arbitro}");
            Console.WriteLine($"Torneo: {this.Torneo}");
            Console.WriteLine($"Jornada: {this.Jornada}");
        }
        public void CambiarLugar(string nuevoLugar)
        {
            Lugar1 = nuevoLugar;
            Console.WriteLine($"El partido ahora se jugará en {Lugar1}.");
        }
    }
}