using System;
using System.Collections.Generic;
using System.Text;

using TorneoPOO_JOLMEDO.Generales;

namespace TorneoPOO_JOLMEDO.Models
{
    public class Partido
    {
        private int id;
        private Equipo local;
        private Equipo visitante;
        private DateTime fecha;
        private string lugar;
        private string arbitro;
        private string torneo;
        private int jornada;
        private int? localId { get; set; }
        private int? visitanteId { get; set; }


        public Equipo Local { get => local; set => local = value; }
        public Equipo Visitante { get => visitante; set => visitante = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Lugar { get => lugar; set => lugar = value; }
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
        public int ? LocalId { get => localId; set => localId = value; }
        public int ? VisitanteId { get => visitanteId; set => visitanteId = value; }

        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar, string arbitro, string torneo, int jornada)
        {
            if (local != null && visitante != null && local.Nombre == visitante.Nombre)
            {
                Console.WriteLine("Error: El equipo Local y el Visitante no pueden ser el mismo.");
            }
            Local = local;
            Visitante = visitante;
            Fecha = fecha;
            Lugar = lugar;
            this.Arbitro = arbitro;
            this.Torneo = torneo;
            this.Jornada = jornada;
        }
        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }
        public void Imprimir()
        {
            Console.WriteLine($"Id del partido: {this.Id}");
            Console.WriteLine($"Equipo Local: {this.Local.Nombre}");
            Console.WriteLine($"Equipo Visitante: {this.Visitante.Nombre}");
            Console.WriteLine($"Fecha: {this.Fecha}");
            Console.WriteLine($"Lugar: {this.Lugar}");
            Console.WriteLine($"Árbitro: {this.Arbitro}");
            Console.WriteLine($"Torneo: {this.Torneo}");
            Console.WriteLine($"Jornada: {this.Jornada}");
        }
        public void CambiarLugar(string nuevoLugar)
        {
            Lugar = nuevoLugar;
            Console.WriteLine($"El partido ahora se jugará en {Lugar}.");
        }
    }
}