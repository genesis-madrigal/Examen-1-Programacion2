using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    internal class clsEmpleado
    {
        //atributos


        static private int indice;
        static private int cantidad;

        static private string[] cedulaEmpleado = new string[cantidad];
        static private string[] nombreEmpleado = new string[cantidad];
        static private string[] direccionEmpleado = new string[cantidad];
        static private string[] telefonoEmpleado = new string[cantidad];
        static private float[] salarioEmpleado = new float[cantidad];

        //constructor
        public clsEmpleado()
        {
            indice = 1;
            cantidad = 5;
            cedulaEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            nombreEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            direccionEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            telefonoEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            salarioEmpleado = Enumerable.Repeat(0f, cantidad).ToArray();
        }

        //getters

        public int getIndice()
        {
            return indice;
        }

        public int getCantidad()
        {
            return cantidad;
        }
        public string[] getCedulaEmpleado()
        {
            return cedulaEmpleado;
        }
        public string[] getNombreEmpleado()
        {
            return nombreEmpleado;
        }
        public string[] getDireccionEmpleado()
        {
            return direccionEmpleado;
        }
        public string[] getTelefonoEmpleado()
        {
            return telefonoEmpleado;
        }
        public float[] getSalarioEmpleado()
        {
            return salarioEmpleado;
        }


        //setters
        public void setIndice(int indice)
        {
            indice = indice;
        }

        public void setCantidad(int cantidad)
        {
            cantidad = cantidad;
        }

        public void setCedulaEmpleado(string[] cedulaEmpleado)
        {
            cedulaEmpleado = cedulaEmpleado;
        }
        public void setNombreEmpleado(string[] nombreEmpleado)
        {
            nombreEmpleado = nombreEmpleado;
        }
        public void setDireccionEmpleado(string[] direccionEmpleado)
        {
            direccionEmpleado = direccionEmpleado;
        }
        public void setTelefonoEmpleado(string[] telefonoEmpleado)
        {
            telefonoEmpleado = telefonoEmpleado;
        }
        public void setSalarioEmpleado(float[] salarioEmpleado)
        {
            salarioEmpleado = salarioEmpleado;
        }



        //metodos

        static public void Inicializar()
        {
            cedulaEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            nombreEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            direccionEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            telefonoEmpleado = Enumerable.Repeat("", cantidad).ToArray();
            salarioEmpleado = Enumerable.Repeat(0f, cantidad).ToArray();

            Console.WriteLine("Su sistema ha sido inicializado correctamente.");
            Console.ReadLine();
        }

        public static string solicitarCedula()
        {
            Console.WriteLine("Digite la cédula: ");
            string ced = Console.ReadLine();
            return ced;
        }



        static public void Promedio(string titulo)
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine($"{titulo}");
            Console.WriteLine("***********************");
            Console.WriteLine($"El promedio de salarios de los empleados es de: {salarioEmpleado.Average()}");
            Console.ReadLine();
        }

        static public void MinMax(string titulo)
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine($"{titulo}");
            Console.WriteLine("***********************");
            Console.WriteLine($"El salario más alto de la empresa es de: {salarioEmpleado.Max()}");
            Console.WriteLine($"El salario más bajo de la empresa es de: {salarioEmpleado.Min()}");
            Console.ReadLine();
        }

    }
}
