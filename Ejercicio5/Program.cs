using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serie S1 = new Serie("soprano","david chase");
            //Console.WriteLine(S1);
            //Serie S2 = new Serie("The wire", 2, "Policiaca", "Jose Luis Moreno");

            //Console.WriteLine(S1.compareTo(S2));

            Serie[] ListaSeries = new Serie[5];
            ListaSeries[0]= new Serie("Los Soprano", "david chase");
            ListaSeries[1] = new Serie("The wire", 1, "Policiaca", "Jose Luis Moreno");
            ListaSeries[2] = new Serie("Manos a la obra", 9,"Humor","Vicente Escriba");
            ListaSeries[3] = new Serie("Breaking Bad", "No se sabe");
            ListaSeries[4] = new Serie("Gambito de dama", 7,"Drama","NS/NC");

            Videojuego[] ListaVideojuegos = new Videojuego[5];
            ListaVideojuegos[0] = new Videojuego("PC Futbol", 1000);
            ListaVideojuegos[1] = new Videojuego("GTA V", 1300, "Mundo Libre", "Rockstar");
            ListaVideojuegos[2] = new Videojuego("PES 2021", 700, "Deportes", "Konami");
            ListaVideojuegos[3] = new Videojuego("Worms", 521);
            ListaVideojuegos[4] = new Videojuego("Street Fighter", 1200, "Lucha", "Capcom");

            
            ListaSeries[2].entregar();
            ListaSeries[3].entregar();
            ListaVideojuegos[0].entregar();

            int cont_series = 0;
            int cont_juegos = 0;

            int max_juegos = 0;
            int max_series = 0;


            for (int i = 0; i <= ListaSeries.Length - 1; i++)
            {
                if (ListaSeries[i].isEntregado() == true)
                {
                    cont_series++;
                }

                if (ListaVideojuegos[i].isEntregado() == true)
                {
                    cont_juegos++;
                }

                if (ListaSeries[i].compareTo(ListaSeries[max_series]) == true)
                {
                    max_series = i;
                }

                if (ListaVideojuegos[i].compareTo(ListaVideojuegos[max_juegos]) == true)
                {
                    max_juegos = i;
                }
            }

           

            Console.WriteLine("Series entregadas: {0}", cont_series);
            Console.WriteLine("Juegos entregados: {0}",cont_juegos);

            Console.WriteLine("---------------------- Serie con más temporadas: ");
            Console.WriteLine(ListaSeries[max_series].ToString());

            Console.WriteLine("---------------------- Juego con más horas: ");
            Console.WriteLine(ListaVideojuegos[max_juegos].ToString());
        }
    }
}
