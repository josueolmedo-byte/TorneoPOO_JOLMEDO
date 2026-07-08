using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoPOO_JOLMEDO.Models;

namespace TorneoPOO_EMANOSALVAS.Models
{
    public class Partido
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar)
        {
            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }
        public void RegistrarResultado(int golesLocal, int golesVisitante)
        {
            Console.WriteLine($"{Local.Nombre} {golesLocal} - {golesVisitante} {Visitante.Nombre}");
        }
    }
}
