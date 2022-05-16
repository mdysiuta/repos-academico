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

        public int ValorPagoInspeccion()
        { 
            return 0;
        }

        public int CalcularGastosEnvio()
        {
            return 0;
        }
    }
}
