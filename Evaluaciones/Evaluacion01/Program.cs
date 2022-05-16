using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear 2 buques */
            Buque alfa = new Buque("35899", 2050000);
            Buque beta = new Buque("35877", 2170000);

            /* Crear 4 containers y asociarlos a un buque. El cuarto container que cree, lo debe crear con el peso máximo
            que puede cargar ya ocupado. */
            Container primero = new Container("00001", alfa, 43000);
            Container segundo = new Container("00002", alfa, 91000);
            Container tercero = new Container("00003", beta, 82000);
            Container cuarto = new Container("00004", beta, 200000, 200000);

            alfa.SubirContainer(primero);
            alfa.SubirContainer(segundo);
            beta.SubirContainer(tercero);
            beta.SubirContainer(cuarto);

            /* Listar los datos de los containers que se encuentran en el buque */
            Console.WriteLine("CONTENEDORES BUQUE ALFA");
            Console.WriteLine("------------------------------------");
            foreach (Container c in alfa.ListaContainers)
            {
                Console.WriteLine("CODIGO: " + c.Codigo);
                Console.WriteLine("MARCA: " + c.Marca);
                Console.WriteLine("CAPACIDAD MÁXIMA: " + c.CapacidadMaxima + " kg");
                Console.WriteLine("TAMAÑO: " + c.Tamaño + " pies");
                Console.Write("REFRIGERADO: ");

                if (c.EsRefrigerado) Console.WriteLine("Si");
                else Console.WriteLine("No");

                Console.WriteLine("PESO ACTUAL: " + c.PesoActual + " kg");
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("CONTENEDORES BUQUE BETA");
            Console.WriteLine("------------------------------------");
            foreach (Container c in beta.ListaContainers)
            {
                Console.WriteLine("CODIGO: " + c.Codigo);
                Console.WriteLine("MARCA: " + c.Marca);
                Console.WriteLine("CAPACIDAD MÁXIMA: " + c.CapacidadMaxima + " kg");
                Console.WriteLine("TAMAÑO: " + c.Tamaño + " pies");
                Console.Write("REFRIGERADO: ");

                if (c.EsRefrigerado) Console.WriteLine("Si");
                else Console.WriteLine("No");

                Console.WriteLine("PESO ACTUAL: " + c.PesoActual + " kg");
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine();

            /* Mostrar el valor a pagar por conceptos de inspección para el container 3. */
            Console.WriteLine("Valor inspección container tercero: " + tercero.ValorPagoInspeccion() + " CLP");
            Console.WriteLine();

            /* Mostrar el valor que debe pagar cada uno de los containers creados por conceptos de gastos de envío. */
            Console.WriteLine("VALOR DE GASTOS DE ENVIO PARA CADA CONTAINER");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Buque " + primero.Codigo + ": " + primero.CalcularGastosEnvio());
            Console.WriteLine("Buque " + segundo.Codigo + ": " + segundo.CalcularGastosEnvio());
            Console.WriteLine("Buque " + tercero.Codigo + ": " + tercero.CalcularGastosEnvio());
            Console.WriteLine("Buque " + cuarto.Codigo + ": " + cuarto.CalcularGastosEnvio());
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            /* Mostrar si al container 4 puedo subir una caja con mercadería que pesa 2000 kilos. */
            if (cuarto.PuedeSubir(2000)) Console.WriteLine("Es posible subir una caja de 2000 kilos.");
            else Console.WriteLine("No es posible subir una caja de 2000 kilos.");
            Console.WriteLine();

            /* Quitar 200 kilos de peso desde el primero de los containers y mostrar el peso actual. */
            primero.SacarPeso(200);
            Console.WriteLine("Peso de container primero: " + primero.PesoActual);

            // Congelar consola
            Console.ReadKey();
        }
    }
}
