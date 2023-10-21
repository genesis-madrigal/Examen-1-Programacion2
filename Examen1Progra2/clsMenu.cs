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
                    case 1: clsEmpleado.Agregar(); break;
                    case 2: clsEmpleado.Consultar(clsEmpleado.solicitarCedula()); break;
                    case 3: clsEmpleado.Modificar(clsEmpleado.solicitarCedula()); break;
                    case 4: clsEmpleado.Eliminar(clsEmpleado.solicitarCedula()); break;
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
                    case 1: clsEmpleado.Consultar(clsEmpleado.solicitarCedula());  break;
                    case 2: clsEmpleado.Listar(); break;
                    case 3: clsEmpleado.Promedio(); break;
                    case 4: clsEmpleado.MinMax(); break;
                    case 5: break;

                    default:
                        Console.WriteLine("Opcion digitada no existe");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (opcion != 5);
        }
    }
}
