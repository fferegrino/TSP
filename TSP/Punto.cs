using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSP
{
    public class Punto
    {

        #region Propiedades y campos

        /// <summary>
        /// Obtiene o establece el nombre del punto
        /// </summary>
        public String Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece la corrdenada X del punto
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Obtiene o establece la corrdenada Y del punto
        /// </summary>
        public int Y { get; set; }

        static Random r = new Random();

        #endregion

        #region Constructores

        /// <summary>
        /// Crea un nuevo Punto
        /// </summary>
        /// <param name="nombre">El nombre asignado para el punto</param>
        /// <param name="x">La coordenada en X</param>
        /// <param name="y">La coordenada en Y</param>
        public Punto(int nombre, int x, int y)
        {
            int asciiStart = 65;
            int nuevoNombre = asciiStart + nombre;
            if (nuevoNombre > 90)
            {
                this.Nombre += Char.ConvertFromUtf32(nuevoNombre - 65);
                nuevoNombre = nuevoNombre - 90 + 65;
            }
            this.Nombre += Char.ConvertFromUtf32(nuevoNombre);
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Crea un nuevo punto con coordenadas X, Y = 0
        /// </summary>
        /// <param name="nombre">El nombre asignado para el punto</param>
        public Punto(int nombre)
        {
            int asciiStart = 65;
            this.Nombre = Char.ConvertFromUtf32(asciiStart + nombre);
        }

        /// <summary>
        /// Crea un nuevo punto con coordenadas X, Y = 0
        /// </summary>
        /// <param name="nombre">El nombre asignado para el punto</param>
        public Punto(String nombre)
            : this(nombre, 0, 0)
        {
        }

        /// <summary>
        /// Crea un nuevo punto
        /// </summary>
        /// <param name="nombre">El nombre asignado para el punto</param>
        /// <param name="x">La coordenada en X</param>
        /// <param name="y">La coordenada en Y</param>
        public Punto(String nombre, int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Métodos de instancia

        /// <summary>
        /// Calcula la distancia entre el punto y un par de coordenadas
        /// </summary>
        /// <param name="x">Coordenada en X</param>
        /// <param name="y">Coordenada en Y</param>
        /// <returns>El valor total de la distancia</returns>
        public double Distancia(int x, int y)
        {
            int nX = X - x;
            int nY = Y - y;
            return Math.Sqrt(Math.Pow(nX, 2) + Math.Pow(nY, 2));
        }

        /// <summary>
        /// Calcula la distancia entre dos puntos
        /// </summary>
        /// <param name="punto">El punto al cual se desea medir la distancia</param>
        /// <returns>El valor total de la distancia</returns>
        public double Distancia(Punto punto)
        {
            return this.Distancia(punto.X, punto.Y);
        }

        #endregion

        #region Métodos de clase

        /// <summary>
        /// Genera un arreglo de puntos aleatorios
        /// </summary>
        /// <param name="numeroPuntos">El número de puntos a generar</param>
        /// <param name="width">El valor máximo que puede tomar un punto en su coordenada Y</param>
        /// <param name="height">El valor máximo que puede tomar un punto en su coordenada X</param>
        /// <returns>El set de puntos aleatorios</returns>
        public static Punto[] PuntosAleatorios(int numeroPuntos, int width, int height)
        {
            return PuntosAleatorios(numeroPuntos, width, height, 0);
        }

        /// <summary>
        /// Genera un arreglo de puntos aleatorios
        /// </summary>
        /// <param name="numeroPuntos">El número de puntos a generar</param>
        /// <param name="width">El valor máximo que puede tomar un punto en su coordenada Y</param>
        /// <param name="height">El valor máximo que puede tomar un punto en su coordenada X</param>
        /// <param name="offset"></param>
        /// <returns>El set de puntos aleatorios</returns>
        public static Punto[] PuntosAleatorios(int numeroPuntos, int width, int height, int offset)
        {
            Punto[] aleatorias = new Punto[numeroPuntos];

            for (int i = 0; i < numeroPuntos; i++)
            {
                aleatorias[i] = new Punto(i
                , ((int)(r.NextDouble() * (width - offset * 2)) + offset)
                , ((int)(r.NextDouble() * (height - offset * 2)) + offset));
            }

            return aleatorias;
        }

        #endregion

        #region Sobreescritos

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Punto)
            {
                Punto aux = (Punto)obj;
                return aux.Nombre.Equals(this.Nombre);
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        #endregion

    }
}
