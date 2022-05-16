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

        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool EsRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int PesoActual { get => pesoActual; set => pesoActual = value; }

        public Container() { }

        public void SacarPeso() { }

        /// <summary>
        /// Calcula el valor a pagar por una inspección de container.
        /// </summary>
        /// <returns>Valor de la inspección.</returns>
        public int ValorPagoInspeccion()
        {
            return (pesoActual * 5);
        }

        public int CalcularGastosEnvio()
        {
            return 0;
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
    }
}
