using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion01
{
    internal class Container
    {
        private string codigo;
        private string marca;
        private int capacidadMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        public Buque buque;

        public string Codigo { get => codigo; }
        public string Marca { get => marca; set => marca = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool EsRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int PesoActual
        {
            get => pesoActual;
            set
            {
                if (value < 0) pesoActual = 0;
                else if (value > capacidadMaxima) pesoActual = capacidadMaxima;
                else pesoActual = value;
            }
        }

        public Container() { }

        public Container(string codigo, Buque buque = null, int pesoActual = 0, int capacidadMaxima = 100000, byte tamaño = 20, string marca = "Sin especificar", bool esRefrigerado = false)
        {
            this.codigo = codigo;
            this.buque = buque;
            this.capacidadMaxima = capacidadMaxima;
            this.pesoActual = pesoActual;

            // Si la condición no se cumple, el container será creado con el valor 20 por defecto
            if (tamaño >= 30) tamaño = 40;

            this.marca = marca;
            this.esRefrigerado = esRefrigerado;
        }

        /// <summary>
        /// Remueve aproximadamente un 10% del peso cargado en el container.
        /// </summary>
        public void SacarPeso(int peso)
        {
            pesoActual -= peso;
            if (pesoActual < 0) pesoActual = 0;
        }

        /// <summary>
        /// Calcula el valor a pagar por una inspección de container.
        /// </summary>
        /// <returns>Valor de la inspección.</returns>
        public int ValorPagoInspeccion()
        {
            return (pesoActual * 5);
        }

        /// <summary>
        /// Calcula el gasto de envio que el container añadirá al buque.
        /// </summary>
        /// <returns>Valor del gasto.</returns>
        public int CalcularGastosEnvio()
        {
            int gastoEnvio = buque.GastoTransporte / buque.CantidadContainers;

            if (tamaño == 40)
            {
                gastoEnvio += gastoEnvio + 9000;
            }
            else gastoEnvio += 3500;

            return gastoEnvio;
        }

        /// <summary>
        /// Determina si el container puede ser cargado con peso extra sin excederse de la capacidad máxima.
        /// </summary>
        /// <param name="peso"></param>
        /// <returns>True si puede cargarse, y false si se excede del peso máximo.</returns>
        public bool PuedeSubir(int peso)
        {
            if ((peso + pesoActual) > capacidadMaxima) return false;
            else return true;
        }
        
        public override string ToString()
        {
            return codigo + " " + marca;
        }
    }
}
