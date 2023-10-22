using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    internal class clsMenu
    {
        static int opcion = 0;
        static clsEmpleado empleados = new clsEmpleado();
        static int indice = empleados.getIndice();

        public static void desplegarMenu()
        {

            do
            {
                Console.Clear();

                Console.WriteLine("Bienvenido/a al Menú Principal del Sistema de Recursos Humanos \n");

                Console.WriteLine("1. Agregar empleados");
                Console.WriteLine("2. Consultar empleados");
                Console.WriteLine("3. Modificar empleados");
                Console.WriteLine("4. Eliminar empleados");
                Console.WriteLine("5. Inicializar arreglos");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. Salir del sistema");

                Console.WriteLine("\nSeleccione el número correspondiente a la opción a realizar: ");
                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1: Agregar(); break;
                    case 2: Consultar(clsEmpleado.solicitarCedula()); break;
                    case 3: Modificar(clsEmpleado.solicitarCedula()); break;
                    case 4: Eliminar(clsEmpleado.solicitarCedula()); break;
                    case 5: clsEmpleado.Inicializar(); break;
                    case 6: menuReportes(); break;
                    case 7: break;

                    default:
                        Console.WriteLine("Opcion digitada no existe");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (opcion != 7);
        }

        public static void menuReportes()
        {
            Console.Clear();
            do
            {
                Console.Clear();
                Console.WriteLine("1. Consultar empleados por número de cédula");
                Console.WriteLine("2. Listar todos los empleados");
                Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo de todos los empleados");
                Console.WriteLine("5. Volver al menú principal");

                Console.WriteLine("Seleccione el número correspondiente a la opción a realizar: ");
                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1: Consultar(clsEmpleado.solicitarCedula()); break;
                    case 2: Listar("Lista de empleados"); break;
                    case 3: clsEmpleado.Promedio("Promedio de salarios"); break;
                    case 4: clsEmpleado.MinMax("Mínimo y máximo de salarios"); break;
                    case 5: break;

                    default:
                        Console.WriteLine("Opcion digitada no existe");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (opcion != 5);
        }


        static public void Agregar()
        {
            char respuesta = ' ';
            int i = indice - 1;

            do
            {
                Console.Clear();

                Console.WriteLine($"Digite el número de cédula del empleado {indice}: ");
                empleados.getCedulaEmpleado()[i] = Console.ReadLine();

                Console.WriteLine($"Digite el nombre del empleado {indice}: ");
                empleados.getNombreEmpleado()[i] = Console.ReadLine();

                Console.WriteLine($"Digite la dirección del empleado {indice}: ");
                empleados.getDireccionEmpleado()[i] = Console.ReadLine();

                Console.WriteLine($"Digite el número de teléfono del empleado {indice}: ");
                empleados.getTelefonoEmpleado()[i] = Console.ReadLine();

                Console.WriteLine($"Digite el salario del empleado {indice}: ");
                float.TryParse(Console.ReadLine(), out empleados.getSalarioEmpleado()[i]);

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
            } while (respuesta != 'N' && i < empleados.getCantidad());
        }


        static public void Consultar(string ced)
        {
            bool existe = false;

            Console.Clear();

            for (int indice = 0; indice < empleados.getCantidad(); indice++)
            {
                if (ced.Equals(empleados.getCedulaEmpleado()[indice]))
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Datos del empleado consultado");
                    Console.WriteLine("*******************************");
                    Console.WriteLine($"Cédula: {empleados.getCedulaEmpleado()[indice]}");
                    Console.WriteLine($"Nombre: {empleados.getNombreEmpleado()[indice]}");
                    Console.WriteLine($"Dirección: {empleados.getDireccionEmpleado()[indice]}");
                    Console.WriteLine($"Teléfono: {empleados.getTelefonoEmpleado()[indice]}");
                    Console.WriteLine($"Salario: {empleados.getSalarioEmpleado()[indice]}");

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

            for (int indice = 0; indice < empleados.getCantidad(); indice++)
            {
                if (ced.Equals(empleados.getCedulaEmpleado()[indice]))
                {
                    Console.WriteLine($"Digite el nombre del empleado {indice}: ");
                    empleados.getNombreEmpleado()[indice] = Console.ReadLine();

                    Console.WriteLine($"Digite la dirección del empleado {indice}: ");
                    empleados.getDireccionEmpleado()[indice] = Console.ReadLine();

                    Console.WriteLine($"Digite el número de teléfono del empleado {indice}: ");
                    empleados.getTelefonoEmpleado()[indice] = Console.ReadLine();

                    Console.WriteLine($"Digite el salario del empleado {indice}: ");
                    float.TryParse(Console.ReadLine(), out empleados.getSalarioEmpleado()[indice]);

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

            for (int indice = 0; indice < empleados.getCantidad(); indice++)
            {
                if (ced.Equals(empleados.getCedulaEmpleado()[indice]))
                {
                    empleados.getCedulaEmpleado()[indice] = "";
                    empleados.getNombreEmpleado()[indice] = "";
                    empleados.getDireccionEmpleado()[indice] = "";
                    empleados.getTelefonoEmpleado()[indice] = "";
                    empleados.getSalarioEmpleado()[indice] = 0;

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

            Array.Sort(empleados.getNombreEmpleado().ToArray(), empleados.getCedulaEmpleado());
            Array.Sort(empleados.getNombreEmpleado().ToArray(), empleados.getDireccionEmpleado());
            Array.Sort(empleados.getNombreEmpleado().ToArray(), empleados.getTelefonoEmpleado());
            Array.Sort(empleados.getNombreEmpleado().ToArray(), empleados.getSalarioEmpleado());
            Array.Sort(empleados.getNombreEmpleado());

            Console.WriteLine("***********************");
            Console.WriteLine($"{titulo}");
            Console.WriteLine("***********************");

            for (int i = 0; i < empleados.getCantidad(); i++)
            {
                Console.WriteLine($"Nombre: {empleados.getNombreEmpleado()[i]} | Cédula: {empleados.getCedulaEmpleado()[i]} | Dirección: {empleados.getDireccionEmpleado()[i]} | Teléfono: {empleados.getTelefonoEmpleado()[i]} | Salario: {empleados.getSalarioEmpleado()[i]}");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú anterior");
            Console.ReadLine();

        }

    }
}
