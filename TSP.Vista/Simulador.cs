using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TSP.Vista
{
    public partial class Simulador : Form
    {
        public Simulador()
        {
            InitializeComponent();
        }

        private int poblacionInicial
            , poblacionFavorecida
            , poblacionParaCruza
            , numeroCiudades
            , longitudCorte
            , w
            , h
            , generacion
            , maxGeneraciones
            , variedad
            , delay;
        double mutacion;
        Cromosoma[] conjuntoSolucion;
        Punto[] puntos;

        /// <summary>
        /// Este evento se lanza al dar click en el botón de iniciar simulación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bIniciarSimulacion_Click(object sender, EventArgs e)
        {
            // Revisamos si existen los puntos a evaluar
            if (puntos != null)
            {
                delay = Int32.Parse(tbDelay.Text);
                poblacionInicial = Int32.Parse(tbPoblacionSize.Text);
                mutacion = Double.Parse(tbPMutacion.Text) / 100;
                maxGeneraciones = Int32.Parse(tbMaxGeneraciones.Text);
                variedad = Int32.Parse(tbVariacion.Text);
                poblacionParaCruza = poblacionInicial / 2;
                poblacionFavorecida = poblacionParaCruza / 2;
                longitudCorte = numeroCiudades / 5;
                conjuntoSolucion = new Cromosoma[poblacionInicial];

                for (int i = 0; i < poblacionInicial; i++)
                {
                    conjuntoSolucion[i] = new Cromosoma(puntos, mutacion, longitudCorte);
                    conjuntoSolucion[i].CalculaCosto();
                }

                Cromosoma.QuickSort(conjuntoSolucion, 0, conjuntoSolucion.Length - 1);

                mapArea.Invalidate();

                generacion = 0;

                Simular();
            }
            else
            {
                MessageBox.Show("¡Debes generar las ciudades antes!");
            }
        }

        /// <summary>
        /// Aquí es donde se dibujarán las ciudades y la poible solución
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapArea_Paint(object sender, PaintEventArgs e)
        {
            Pen penCiudades = new Pen(Color.Red, 5);
            Pen penRuta = new Pen(Color.Black, 5);
            SolidBrush sb = new SolidBrush(System.Drawing.Color.Red);

            if (conjuntoSolucion != null)
            {
                // Obtenemos la mejor solución
                Cromosoma mejorSolucion = conjuntoSolucion[0];
                for (int i = 0; i < mejorSolucion.Longitud - 1; i++)
                {
                    e.Graphics.DrawLine(penRuta
                        , mejorSolucion[i].X
                        , mejorSolucion[i].Y
                        , mejorSolucion[i + 1].X
                        , mejorSolucion[i + 1].Y);
                }
            }

            if (puntos != null)
            {
                for (int i = 0; i < numeroCiudades; i++)
                {
                    String nombreCiudad = puntos[i].Nombre;
                    SizeF sF = e.Graphics.MeasureString(puntos[i].Nombre, new Font("Courier", 15));
                    e.Graphics.DrawString(nombreCiudad, new Font("Courier", 15), sb, new PointF(puntos[i].X - (sF.Width / 2), puntos[i].Y - 25));
                    e.Graphics.DrawEllipse(penCiudades, puntos[i].X, puntos[i].Y, 3, 3);
                }
            }
        }

        /// <summary>
        /// Iniciamos la simulación con este método
        /// </summary>
        public void Simular()
        {
            BackgroundWorker bw = new BackgroundWorker();

            bw.WorkerReportsProgress = true;

            int noVariacion = 0;
            int variacionMinima = 1;
            int reemplazados = poblacionFavorecida;
            double costoAnterior = 0;

            // En este método se reporta el progreso del algoritmo:
            bw.ProgressChanged += new ProgressChangedEventHandler(
            delegate(object o, ProgressChangedEventArgs args)
            {
                listBox1.Items.Clear();

                for (int i = 0; i < conjuntoSolucion[0].Longitud; i++ )
                {
                    Punto e = conjuntoSolucion[0][i];
                    listBox1.Items.Add((i + 1).ToString() + ") " + e.Nombre);
                }

                tbMejorValor.Text = String.Format("{0:##0.00}", conjuntoSolucion[0].Costo);

                labelGeneraciones.Text = String.Format("Generacion {0}", generacion);
                labelVariaciones.Text = String.Format("Variacion continua {0}", noVariacion);
                labelMejorValor.Text = String.Format("Mejor Valor {0:##0.00}", conjuntoSolucion[0].Costo);
                mapArea.Invalidate();

            });


            /// Aquí es donde se realiza el trabajo de manera asíncrona
            bw.DoWork += new DoWorkEventHandler(
            delegate(object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;
                while (noVariacion < variedad
                    && generacion < maxGeneraciones)
                {
                    generacion++;
                    int iOff = poblacionParaCruza;
                    for (int i = 0; i < poblacionFavorecida; i++)
                    {
                        Cromosoma madre = conjuntoSolucion[i]
                            , padre = conjuntoSolucion[i + 1];

                        int indexPadre = Cromosoma.NextInt(0, poblacionParaCruza);
                        padre = conjuntoSolucion[indexPadre];

                        Cromosoma[] hijos = Cromosoma.CruzaCiclica(padre, madre);

                        hijos[0].Mutar();
                        hijos[1].Mutar();

                        if (iOff < conjuntoSolucion.Length - 1)
                        {
                            conjuntoSolucion[iOff] = hijos[0];
                            conjuntoSolucion[iOff + 1] = hijos[1];
                        }
                        iOff += 2;
                    }
                    for (int i = 0; i < poblacionParaCruza; i++)
                    {
                        conjuntoSolucion[i] = conjuntoSolucion[i + poblacionParaCruza];
                        conjuntoSolucion[i].CalculaCosto();
                    }

                    Cromosoma.QuickSort(conjuntoSolucion, 0, conjuntoSolucion.Length - 1);

                    double costoActual = conjuntoSolucion[0].Costo;
                    if (Math.Abs(((int)costoAnterior) - ((int)costoActual)) < variacionMinima)
                    {
                        noVariacion++;
                    }
                    else
                    {
                        noVariacion = 0;
                        costoAnterior = costoActual;
                    }
                    // Reportamos el progreso, así se actualizará la vista del usuario.
                    Thread.Sleep(delay);
                    b.ReportProgress(10);
                }

            });


            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate(object o, RunWorkerCompletedEventArgs args)
            {
                labelGeneraciones.Text = String.Format("Generacion {0}", generacion, noVariacion);
                labelMejorValor.Text = String.Format("Mejor Valor {0}", conjuntoSolucion[0].Costo);
                mapArea.Invalidate();
                MessageBox.Show("Hemos terminado");
            });

            bw.RunWorkerAsync();
        }


        /// <summary>
        /// Generamos el conjunto de valores aleatorios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bGeneraAleatorios_Click(object sender, EventArgs e)
        {
            // Obtenemos las dimensiones del área de dibujo
            w = mapArea.Width;
            h = mapArea.Height;
            // Asignamos el número de ciudades de acuerdo con el valor que ingresó el usuario
            numeroCiudades = Int32.Parse(tbNumeroCiudades.Text);
            // Generamos los puntos aleatorios
            puntos = Punto.PuntosAleatorios(numeroCiudades, w, h, 50);
            conjuntoSolucion = null;
            mapArea.Invalidate();
        }

        #region Debug

        /// <summary>
        /// Método diagnóstico, para escribir una línea en la consola de salida
        /// </summary>
        /// <param name="s"></param>
        public void debug(String s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        /// <summary>
        /// Método diagnóstico, imprime un cromosoma y su costo total
        /// </summary>
        /// <param name="generacion"></param>
        public void debug(Cromosoma[] generacion)
        {
            foreach (Cromosoma c in generacion)
            {
                debug(c.ToString() + " : " + c.Costo);
            }
        }

        #endregion

        private void tbEnteroValidacion(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


    }



}

