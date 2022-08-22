using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consola consola = new Consola(ConsoleColor.White);
            BaseDatosAccess bdAccess = new BaseDatosAccess(consola);
            Bdatosproducto bdProductos = new Bdatosproducto(consola);
            Bdatoscliente bdClientes = new BaseDatosAccess(consola);
            Bdatosproveedores  bdProveedores= new Bdatosproveedores(consola);
            Bdatosempleados bdEmpleados = new Bdatosempleados(consola);

            int opcion = 6;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpciones();
                opcion = consola.leerOpcion();
                switch (opcion)
                {
                    case 1:
                        int oproducto = 6;
                        do
                        {
                            Console.Clear();
                            consola.PintarFondo(ConsoleColor.Black);
                            consola.MenuOpcionesProducto();
                            oproducto = consola.leerOpcion();
                            switch (oproducto)
                            {
                                case 1:
                                    bdProductos.Crear();
                                    break;
                                case 2:
                                    bdProductos.mostrarTabla();
                                    break;
                                case 3:
                                    bdProductos.busqueda();
                                    break;
                                case 4:
                                    bdProductos.eliminar();
                                    break;
                                case 5:
                                    bdProductos.ActualizarPrecioProducto();
                                    break;
                                case 6:
                                    consola.MenuOpciones();
                                    break;
                            }
                        } while (oproducto != 6);
                        break;
                    case 2:
                        int ocliente = 5;
                        do
                        {
                            Console.Clear();
                            consola.PintarFondo(ConsoleColor.Black);
                            consola.MenuOpcionesCliente();
                            ocliente = consola.leerOpcion();
                            switch (ocliente)
                            {
                                case 1:
                                    bdClientes.Crear();
                                    break;
                                case 2:
                                    bdClientes.mostrarTabla();
                                    break;
                                case 3:
                                    bdClientes.busqueda();
                                    break;
                                case 4:
                                    bdClientes.eliminar();
                                    break;
                                case 5:
                                    consola.MenuOpciones();
                                    break;
                            }
                        } while (ocliente != 5);
                        break;
                    case 3:

                        int oproveedor = 5;
                        do
                        {
                            Console.Clear();
                            consola.PintarFondo(ConsoleColor.Black);
                            consola.MenuOpcionesCliente();
                            ocliente = consola.leerOpcion();
                            switch (ocliente)
                            {
                                case 1:
                                    bdProveedores.Crear();
                                    break;
                                case 2:
                                    bdProveedores.mostrarTabla();
                                    break;
                                case 3:
                                    bdProveedores.busqueda();
                                    break;
                                case 4:
                                    bdProveedores.eliminar();
                                    break;
                                case 5:
                                    consola.MenuOpciones();
                                    break;
                            }
                        } while (oproveedor != 5);
                        break;
                    case 4:

                        int oempleado = 5;
                        do
                        {
                            Console.Clear();
                            consola.PintarFondo(ConsoleColor.Black);
                            consola.MenuOpcionesCliente();
                            ocliente = consola.leerOpcion();
                            switch (ocliente)
                            {
                                case 1:
                                    bdEmpleados.Crear();
                                    break;
                                case 2:
                                    bdEmpleados.mostrarTabla();
                                    break;
                                case 3:
                                    bdEmpleados.busqueda();
                                    break;
                                case 4:
                                    bdEmpleados.eliminar();
                                    break;
                                case 5:
                                    consola.MenuOpciones();
                                    break;
                            }
                        } while (oempleado != 5);
                        break;
                    case 5:
                        break;
                    default:
                        Console.Clear();
                        consola.Escribir(50, 1, ConsoleColor.Yellow, "FIN DEL PROGRAMA");
                        bdProductos = null;
                        GC.Collect();
                        Console.Read();
                        break;
                }
            }
            while (opcion != 6);
        }
    }
}

