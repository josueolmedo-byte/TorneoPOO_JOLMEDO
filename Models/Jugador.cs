using System;
using System.Collections.Generic;
using System.Text;

namespace TorneoPOO_JOLMEDO.Models
{
    public class Jugador
    {
        //ATRIBUTOS O CARACTERISTICAS
        private string nombre;
        private int edad;
        private int numero;
        private string posicion;
        private string nacionalidad;
        private double altura;
        private string pieDominante;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad
        {
            get => edad;
            set
            {
                if (!EsMayorEdad(value))
                {
                    throw new Exception("El jugador debe ser mayor de edad");
                }
                edad = value;
            }
        }
        public int Numero 
        {
            get => numero;
            set
            {
                if (!EsNumeroValido(value))
                {
                    throw new Exception("El número de la camiseta no es válido");
                }
                numero = value;
            }
        }
        public string Posicion { get => posicion; set => posicion = value; }
        public string Nacionalidad
        {
            get => nacionalidad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("La nacionalidad no puede estar vacía.");
                }
                nacionalidad = value;
            }
        }
        public double Altura
        {
            get => altura;
            set
            {
                if (value < 1.30 || value > 2.50)
                {
                    throw new Exception("La altura no es válida.");
                }
                altura = value;
            }
        }
        public string PieDominante
        {
            get => pieDominante;
            set
            {
                if (value != "Derecho" &&
                    value != "Izquierdo" &&
                    value != "Ambidiestro")
                {
                    throw new Exception("El pie dominante debe ser Derecho, Izquierdo o Ambidiestro.");
                }
                pieDominante = value;
            }
        }

        public Jugador(string nombre, int edad, int numero, string posicion, string nacionalidad, double altura, string pieDominante)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre del jugador no puede estar vacío.");
            }
            if (!EsMayorEdad(edad))
            {
                throw new Exception("El jugador debe ser mayor de edad");
            }
            if (!EsNumeroValido(numero))
            {
                throw new Exception("El número de la camiseta no es válido");
            }
            this.Nombre = nombre;
            this.Edad = edad;
            this.Numero = numero;
            this.Posicion = posicion;
            this.Nacionalidad = nacionalidad;
            this.Altura = altura;
            this.PieDominante = pieDominante;
        }

        //METODOS, COMPORTAMIENTOS O FUNCIONES
        public void Presentar()
        {
            Console.WriteLine($"Hola soy {this.Nombre} tengo {this.Edad} años y mi número es el {this.Numero}");
        }

        public Boolean EsMayorEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EsNumeroValido(int numero)
        {
            if (numero > 0 && numero < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CambiarPosicion(string nuevaPosicion)
        {
            Posicion = nuevaPosicion;
            Console.WriteLine($"{Nombre} ahora juega como {nuevaPosicion}.");
        }
    }
}