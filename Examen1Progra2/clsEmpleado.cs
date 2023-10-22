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

        static int cantidad = 5;
        static int indice = 1;

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
        public static void setCedulaEmpleado(string[] cedulaEmpleado)
        {
            cedulaEmpleado = cedulaEmpleado;
        }
        public static void setNombreEmpleado(string[] nombreEmpleado)
        {
            nombreEmpleado = nombreEmpleado;
        }
        public static void setDireccionEmpleado(string[] direccionEmpleado)
        {
            direccionEmpleado = direccionEmpleado;
        }
        public static void setTelefonoEmpleado(string[] telefonoEmpleado)
        {
            telefonoEmpleado = telefonoEmpleado;
        }
        public static void setSalarioEmpleado(float[] salarioEmpleado)
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

        static public void Agregar()
        {
            char respuesta = ' ';
            int i = indice - 1;
            do
            {
                Console.Clear();

                Console.WriteLine($"Digite el número de cédula del empleado {indice}: ");
                cedulaEmpleado[i] = Console.ReadLine();

                Console.WriteLine($"Digite el nombre del empleado {indice}: ");
                nombreEmpleado[i] = Console.ReadLine();

                Console.WriteLine($"Digite la dirección del empleado {indice}: ");
                direccionEmpleado[i] = Console.ReadLine();

                Console.WriteLine($"Digite el número de teléfono del empleado {indice}: ");
                telefonoEmpleado[i] = Console.ReadLine();

                Console.WriteLine($"Digite el salario del empleado {indice}: ");
                float.TryParse(Console.ReadLine(), out salarioEmpleado[i]);

                if (indice < 5)
                {
                    Console.WriteLine("¿Desea continuar? S/N: ");
                    respuesta = Console.ReadLine().ToUpper()[0];
                }
                                

                

                indice++;
                i++;

                

                if (!respuesta.Equals('N') && !respuesta.Equals('S'))
                {
                    Console.WriteLine("Opcion incorrecta");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine($"respuesta: {respuesta} i: {i} indice: {indice}");
            } while (respuesta != 'N' && i < cantidad);  
        }

        static public void Consultar(string ced)
        {
            bool existe = false;

            Console.Clear();

            for (int indice = 0; indice < cantidad; indice++)
            {
                if (ced.Equals(cedulaEmpleado[indice]))
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Datos del empleado consultado");
                    Console.WriteLine("*******************************");
                    Console.WriteLine($"Cédula: {cedulaEmpleado[indice]}");
                    Console.WriteLine($"Nombre: {nombreEmpleado[indice]}");
                    Console.WriteLine($"Dirección: {direccionEmpleado[indice]}");
                    Console.WriteLine($"Teléfono: {telefonoEmpleado[indice]}");
                    Console.WriteLine($"Salario: {salarioEmpleado[indice]}");

                    Console.WriteLine("Presione cualquier tecla para volver al menú principal");
                    Console.ReadLine();
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("Empleado no existe en el sistema");
            }
        }

        static public void Modificar(string ced)
        {
            bool existe = false;

            Console.Clear();

            for (int indice= 0; indice < cantidad; indice++)
            {
                if (ced.Equals(cedulaEmpleado[indice]))
                {
                    Console.WriteLine($"Digite el nombre del empleado {indice}: ");
                    nombreEmpleado[indice] = Console.ReadLine();

                    Console.WriteLine($"Digite la dirección del empleado {indice}: ");
                    direccionEmpleado[indice] = Console.ReadLine();

                    Console.WriteLine($"Digite el número de teléfono del empleado {indice}: ");
                    telefonoEmpleado[indice] = Console.ReadLine();

                    Console.WriteLine($"Digite el salario del empleado {indice}: ");
                    float.TryParse(Console.ReadLine(), out salarioEmpleado[indice]);

                    Console.WriteLine("Empleado modificado correctamente");
                    Console.ReadLine();
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("Empleado no existe en el sistema");
            }
        }
        static public void Eliminar(string ced)
        {
            bool existe = false;

            Console.Clear();

            for (int indice = 0; indice < cantidad; indice++)
            {
                if (ced.Equals(cedulaEmpleado[indice]))
                {
                    cedulaEmpleado[indice] = "";
                    nombreEmpleado[indice] = "";
                    direccionEmpleado[indice] = "";
                    telefonoEmpleado[indice] = "";
                    salarioEmpleado[indice] = 0;

                    Console.WriteLine("Empleado eliminado correctamente");
                    Console.ReadLine();
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("Empleado no existe en el sistema");
            }

        }

        static public void Listar(string titulo)
        {
            
            Array.Sort(nombreEmpleado.ToArray(), cedulaEmpleado);
            Array.Sort(nombreEmpleado.ToArray(), direccionEmpleado);
            Array.Sort(nombreEmpleado.ToArray(), telefonoEmpleado);
            Array.Sort(nombreEmpleado.ToArray(), salarioEmpleado);
            Array.Sort(nombreEmpleado);

            Console.WriteLine("***********************");
            Console.WriteLine($"{titulo}");
            Console.WriteLine("***********************");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Nombre: {nombreEmpleado[i]} | Cédula: {cedulaEmpleado[i]} | Dirección: {direccionEmpleado[i]} | Teléfono: {telefonoEmpleado[i]} | Salario: {salarioEmpleado[i]}");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú anterior");
            Console.ReadLine();

        }

        static public void Promedio(string titulo)
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine($"{titulo}");
            Console.WriteLine("***********************");
            Console.WriteLine($"El promedio de salarios de los empleados es de: {salarioEmpleado.Average()}");
        }

        static public void MinMax(string titulo)
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine($"{titulo}");
            Console.WriteLine("***********************");
            Console.WriteLine($"El salario más alto de la empresa es de: {salarioEmpleado.Max()}");
            Console.WriteLine($"El salario más bajo de la empresa es de: {salarioEmpleado.Min()}");
        }

    }
}
