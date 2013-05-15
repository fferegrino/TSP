using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace TSP
{
    public class Cromosoma
    {

        #region Constructores
        /// <summary>
        /// Genera un cromosoma vacío
        /// </summary>
        /// <param name="longitud">La longitud del cromosoma</param>
        /// <param name="probabilidadMutacion">Probabilidad de mutar</param>
        /// <param name="puntoCorte">Punto de corte</param>
        public Cromosoma(int longitud, double probabilidadMutacion, int puntoCorte)
        {
            this.ProbabilidadMutacion = probabilidadMutacion;
            this.estaciones = new Punto[longitud];
            this.PuntoCorte = puntoCorte;
        }

        /// <summary>
        /// Crea un cromosoma relleno aleatoriamente con los puntos especificados
        /// </summary>
        /// <param name="puntos">Los puntos que almacenará el cromosoma</param>
        /// <param name="probabilidadMutacion">Probabilidad de mutar</param>
        /// <param name="puntoCorte">Punto de corte</param>
        public Cromosoma(Punto[] puntos, double probabilidadMutacion, int puntoCorte)
        {
            this.ProbabilidadMutacion = probabilidadMutacion;
            this.PuntoCorte = puntoCorte;
            this.estaciones = new Punto[puntos.Length];

            bool[] usadas = new bool[puntos.Length];

            for (int i = 0; i < this.Longitud; i++) usadas[i] = false;

            for (int i = 0; i < this.Longitud; i++)
            {
                int candidata;
                do
                {
                    candidata = NextInt(0, this.Longitud); ;
                } while (usadas[candidata]);
                this[i] = puntos[candidata];//.Clone();
                usadas[candidata] = true;
                PuntoCorte = 1;
            }
        }

        #endregion

        #region Campos y propiedades



        Punto[] estaciones;
        private double costo;


        /// <summary>
        /// Obtiene la longitud del cromosoma
        /// </summary>
        public int Longitud
        {
            get { return this.estaciones.Length; }
        }

        /// <summary>
        /// Obtiene el resultado de evaluar la función con el cromosoma
        /// <para><remarks>No olvides llamar a CalculaCosto antes</remarks></para>
        /// </summary>
        public double Costo
        {
            get { return costo; }
            private set { costo = value; }
        }

        public double ProbabilidadSeleccion { get; set; }

        /// <summary>
        /// Obtiene el índice en el que se encuetra la estación proporcionada
        /// </summary>
        /// <param name="estacion"></param>
        /// <returns>Un entero de 0 a la longitud del cromosoma menos uno, menos uno en caso de que no se encuentre</returns>
        private int IndexEstacion(Punto estacion)
        {
            for (int i = 0; i < estaciones.Length; i++)
            {
                if (estaciones[i].Equals(estacion))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Obtiene o establece el Punto localizado en el índice proporcionado
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Punto this[int index]
        {
            get { return this.estaciones[index]; }
            set { this.estaciones[index] = value; }
        }

        /// <summary>
        /// Obtiene el índice en el que se encuetra la estación proporcionada
        /// </summary>
        /// <param name="estacion"></param>
        /// <returns>Un entero de 0 a la longitud del cromosoma menos uno, menos uno en caso de que no se encuentre</returns>
        public int this[Punto estacion]
        {
            get { return IndexEstacion(estacion); }
        }

        /// <summary>
        /// Obtiene o establece el punto de corte
        /// </summary>
        public int PuntoCorte { get; set; }

        /// <summary>
        /// Obtiene o establece la probabilidad de mutación 
        /// </summary>
        public double ProbabilidadMutacion { get; set; }

        /// <summary>
        /// Obitene o establece los puntos que conforman el cromosoma
        /// </summary>
        public Punto[] Puntos
        {
            get { return estaciones; }
            set { estaciones = value; }
        }

        #endregion

        #region Métodos de clase

        static RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();

        /// <summary>
        /// Genera un entero pseudoaleatorio comprendido entre los valores especificados
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int NextInt(int min, int max)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(min, max);
        }

        /// <summary>
        /// Ordena de menor a mayor los cromosomas, basado en el costo que representa recorrer la ruta que en ellos se almacena.
        /// <para>Método que usa bubble sort</para>
        /// </summary>
        /// <param name="poblacion"></param>
        /// <param name="numero"></param>
        public static void Sort(Cromosoma[] poblacion, int numero)
        {
            Cromosoma temporal;
            bool cambio = true;
            while (cambio)
            {
                cambio = false;
                for (int i = 0; i < numero - 1; i++)
                {
                    if (poblacion[i].Costo > poblacion[i + 1].Costo)
                    {
                        temporal = poblacion[i];
                        poblacion[i] = poblacion[i + 1];
                        poblacion[i + 1] = temporal;
                        cambio = true;
                    }
                }
            }
        }

        /// <summary>
        /// Ordena de menor a mayor los cromosomas, basado en el costo que representa recorrer la ruta que en ellos se almacena.
        /// <para>Método que usa quick sort</para>
        /// </summary>
        /// <param name="poblacion"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void QuickSort(Cromosoma[] poblacion, int left, int right)
        {
            int i = left, j = right;
            Cromosoma pivote = poblacion[(left + right) / 2];

            while (i <= j)
            {
                while (poblacion[i].Costo < pivote.Costo)
                {
                    i++;
                }

                while (poblacion[j].Costo > pivote.Costo)
                {
                    j--;
                }

                if (i <= j)
                {
                    Cromosoma tmp = poblacion[i];
                    poblacion[i] = poblacion[j];
                    poblacion[j] = tmp;

                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                QuickSort(poblacion, left, j);
            }

            if (i < right)
            {
                QuickSort(poblacion, i, right);
            }

        }


        /// <summary>
        /// Cruza cíclica
        /// </summary>
        /// <param name="padre">Cromosoma padre</param>
        /// <param name="madre">Cromosoma madre</param>
        /// <returns>Un par de hijos nuevos, resultado de la cruza de los dos cromosomas proporcionados</returns>
        public static Cromosoma[] CruzaCiclica(Cromosoma padre, Cromosoma madre)
        {
            Cromosoma[] hijos = new Cromosoma[] { 
                new Cromosoma(padre.Longitud,padre.ProbabilidadMutacion,padre.PuntoCorte), 
                new Cromosoma(padre.Longitud,madre.ProbabilidadMutacion, padre.PuntoCorte) 
            };



            int longitudCromosoma = padre.Longitud;
            int inicioCruzaHijo1 = NextInt(0, longitudCromosoma - 1);
            int inicioCruzaHijo2 = inicioCruzaHijo1;

            Punto aux = padre[inicioCruzaHijo1];
            Punto aux2 = null;

            while (!aux.Equals(aux2))
            {
                aux2 = padre[inicioCruzaHijo1];
                hijos[0][inicioCruzaHijo1] = aux2;
                Punto i = madre[inicioCruzaHijo1];
                inicioCruzaHijo1 = padre[i];
                aux2 = i;
            }

            aux = madre[inicioCruzaHijo2];
            aux2 = null;

            while (!aux.Equals(aux2))
            {
                aux2 = madre[inicioCruzaHijo2];
                hijos[1][inicioCruzaHijo2] = aux2;
                Punto i = padre[inicioCruzaHijo2];
                inicioCruzaHijo2 = madre[i];
                aux2 = i;
            }

            for (int i = 0; i < padre.Longitud; i++)
            {
                if (hijos[0][i] == null)
                {
                    hijos[0][i] = madre[i];
                }
                if (hijos[1][i] == null)
                {
                    hijos[1][i] = padre[i];
                }
            }
            return hijos;
        }

        #endregion

        #region Métodos de instancia
        /// <summary>
        /// Muta el cromosoma permutando genes entre el contenido
        /// </summary>
        /// <returns>true si se realizó la cruza, false en otro caso</returns>
        public bool Mutar()
        {

            if (ProbabilidadMutacion > new Random().NextDouble())
            {
                int p1 = NextInt(0, this.Longitud)
                    , p2 = NextInt(0, this.Longitud);

                Punto aux = this[p1];//.Clonar();
                this[p1] = this[p2];
                this[p2] = aux;

                return true;
            }
            return false;
        }

        /// <summary>
        /// Esta es la función aptitud de nuestro cromosoma, la función que deseamos minimizar
        /// </summary>
        public void CalculaCosto()
        {
            // El valor del costo será la suma de las distancias entre las ciudades contiguas en el cromosoma
            Costo = 0;
            for (int i = 0; i < Longitud - 1; i++)
            {
                Costo += this[i].Distancia(this[i + 1]);
            }
        }
        #endregion

        #region Sobreescritos

        public override string ToString()
        {
            String s = "";
            for (int i = 0; i < this.Longitud; i++)
            {
                s += (i == 0 ? "" : " ");
                s += String.Format("{0,3}", this[i]);
            }
            return s;
        }

        #endregion

    }
}
