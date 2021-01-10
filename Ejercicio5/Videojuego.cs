using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Videojuego : iEntregable
    {
        private string titulo;
        private int horas_estimadas;
        private bool entregado;
        private string genero;
        private string compañia;

        public Videojuego()
        {
            this.horas_estimadas = 10;
            this.entregado = false;
            this.titulo = "";
            this.genero = "";
            this.compañia = "";
        }

        public Videojuego(string titulo, int horas_estimadas)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
            this.entregado = false;
            this.genero = "";
            this.compañia = "";

        }

        public Videojuego(string titulo, int horas_estimadas, string genero, string compañia) : this(titulo, horas_estimadas)
        {
            this.genero = genero;
            this.compañia = compañia;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Horas_estimadas { get => horas_estimadas; set => horas_estimadas = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Compañia { get => compañia; set => compañia = value; }

        public override string ToString()
        {
            return "Título: " + this.titulo + "; Horas estimadas: " + this.horas_estimadas + "; Genero: " + this.genero + "; Compañía: " + this.compañia;

        }

        public void entregar()
        {
            this.entregado = true;
        }

        public void devolver()
        {
            this.entregado = false;
        }

        public bool isEntregado()
        {
            return this.entregado;
        }

        public bool compareTo(Object a)
        {
            Videojuego nuevoVideojuego = (Videojuego)a;
            if (this.horas_estimadas > nuevoVideojuego.horas_estimadas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
