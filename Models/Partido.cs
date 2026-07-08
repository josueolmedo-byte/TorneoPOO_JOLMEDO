using System;
using System.Collections.Generic;
using System.Text;

using TorneoPOO_JOLMEDO.Models;

namespace TorneoPOO_JOLMEDO.Models
{
    public class Partido
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar)
        {
            if (local != null && visitante != null && local.Nombre == visitante.Nombre)
            {
                Console.WriteLine("Error: El equipo Local y el Visitante no pueden ser el mismo.");
            }

            Local = local;
            Visitante = visitante;
            Fecha = fecha;
            Lugar = lugar;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }
        public void CambiarLugar(string nuevoLugar)
        {
            Lugar = nuevoLugar;
            Console.WriteLine($"El partido ahora se jugará en {Lugar}.");
        }
    }
}
