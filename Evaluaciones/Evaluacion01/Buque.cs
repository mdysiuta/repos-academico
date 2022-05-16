using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion01
{
    internal class Buque
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        private List<Container> listaContainers;

        public string Codigo { get => codigo; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int CantidadContainers { get => cantidadContainers; set => cantidadContainers = value; }
        public int CantidadContainersCargados
        {
            get => cantidadContainersCargados;
            set
            {
                if (value > cantidadContainers) cantidadContainersCargados = cantidadContainers;
                else cantidadContainersCargados = value;
            }
        }
        public int GastoTransporte { get => gastoTransporte; set => gastoTransporte = value; }

        public Buque() { }

        public Buque(string codigo, int cantidadContainers = 20, int cantidadContainersCargados = 0, int gastoTransporte = 0, string nombre = "Sin especificar", string pais = "Sin especificar")
        {
            if (codigo.Length < 5)
            {
                for (int i = 0; i < (5 - codigo.Length); i++)
                {
                    // Se concatena el codigo hasta que contenga 5 carácteres
                    codigo = string.Concat("0", codigo);
                }
            }
            this.codigo = codigo;
            this.cantidadContainers = cantidadContainers;
            this.cantidadContainersCargados = cantidadContainersCargados;
            this.gastoTransporte = gastoTransporte;
            this.nombre = nombre;
            this.pais = pais;
        }

        /// <summary>
        /// Sube container que se haya asociado a un buque.
        /// </summary>
        /// <param name="container"></param>
        /// <returns>True si el container puede ser cargado, false si no.</returns>
        public bool SubirContainer(Container container)
        {
            if (container.Tamaño == 40)
            {
                if (cantidadContainersCargados == 39) return false;
            }
            else if (container.Tamaño == 20)
            {
                if (cantidadContainersCargados == 40) return false;
            }

            listaContainers.Add(container);
            if (container.Tamaño == 40) listaContainers.Add(container);

            return true;
        }
    }
}
