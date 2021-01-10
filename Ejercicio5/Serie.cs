using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Serie : iEntregable
    {
        private string titulo;
        private int num_temp;
        private bool entregado;
        private string genero;
        private string creador;

        public Serie()
        {
            this.num_temp = 3;
            this.entregado = false;
            this.titulo = "";
            this.genero = "";
            this.creador = "";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.num_temp = 3;
            this.entregado = false;
            this.genero = "";
        }

        public Serie(string titulo, int num_temp, string genero, string creador)
        {
            this.titulo = titulo;
            this.num_temp = num_temp;
            this.genero = genero;
            this.creador = creador;
            this.entregado = false;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Num_temp { get => num_temp; set => num_temp = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }

        public override string ToString()
        {
            return "Título: " + this.titulo+ "; Num. temp.: "+ this.num_temp+"; Genero: "+this.genero+"; Creador: " +this.creador;

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
            Serie nuevaSerie = (Serie)a;
            
            if (this.num_temp >= nuevaSerie.num_temp)
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
