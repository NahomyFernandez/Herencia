using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Consola
    {
        public ConsoleColor colorTextoDeaulft;
        public Consola(ConsoleColor _colorTextoDeaulft)
        {
            this.colorTextoDeaulft = _colorTextoDeaulft;
        }
        public void Marco(int x, int y, int x2, int y2)
        {
            Escribir(x, y, ConsoleColor.White, "╔");
            Escribir(x2, y2, ConsoleColor.White, "╝");
            Escribir(x, y2, ConsoleColor.White, "╚");
            Escribir(x2, y, ConsoleColor.White, "╗");
            for (int i = x + 1; i < x2; i++)
            {
                Escribir(i, y, ConsoleColor.White, "═");
                Escribir(i, y2, ConsoleColor.White, "═");
            }
            for (int i = y + 1; i < y2; i++)
            {
                Escribir(x, i, ConsoleColor.White, "║");
                Escribir(x2, i, ConsoleColor.White, "║");
            }
        }
        public void Escribir(int left, int top, ConsoleColor color, String Texto)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = color;
            Console.Write(Texto);
            Console.ForegroundColor = colorTextoDeaulft;
        }
        public String leerCadena(int left, int top)
        {
            String valor = "";
            do
            {
                Console.SetCursorPosition(left, top); Console.Write(" ");
                Console.SetCursorPosition(left, top);
                valor = Console.ReadLine();
            } while (valor == ""); 

            return valor;
        }
        public int leerNumeroEntero(int left, int top)
        {
            int valor;
            do
            {
                Console.SetCursorPosition(left, top); Console.Write(" ");

                Console.SetCursorPosition(left, top);
            } while (!int.TryParse(Console.ReadLine(), out valor));
            return valor;
        }
        public double leerNumeroDecimal(int left, int top)
        {
            double valor;
            do
            {
                Console.SetCursorPosition(left, top); Console.Write(" ");

                Console.SetCursorPosition(left, top);
            } while (!double.TryParse(Console.ReadLine(), out valor));
            return valor;
        }
        public void MenuOpciones()
        {
            Marco(25, 3, 65, 12);
            Escribir(35, 1, ConsoleColor.Yellow, "MENÚ DE OPCIONES");
            Escribir(32, 4, ConsoleColor.Yellow, "1.- ");
            Escribir(35, 4, ConsoleColor.White, "PRODUCTOS");
            Escribir(32, 5, ConsoleColor.Yellow, "2.- ");
            Escribir(35, 5, ConsoleColor.White, "CLIENTES");
            Escribir(32, 6, ConsoleColor.Yellow, "3.- ");
            Escribir(35, 6, ConsoleColor.White, "PROVEEDORES");
            Escribir(32, 7, ConsoleColor.Yellow, "4.- ");
            Escribir(35, 7, ConsoleColor.White, "EMPLEADOS..");
            Escribir(32, 8, ConsoleColor.Yellow, "5.- ");
            Escribir(35, 8, ConsoleColor.White, "FACTURACIÓN");
            Escribir(32, 9, ConsoleColor.Yellow, "6.- ");
            Escribir(35, 9, ConsoleColor.White, "SALIR..");
        }
        public void MenuOpcionesProducto()
        {
            Marco(25, 3, 65, 12);
            Escribir(35, 1, ConsoleColor.Yellow, "MENÚ DE PRODUCTOS");
            Escribir(32, 4, ConsoleColor.Yellow, "1.- ");
            Escribir(35, 4, ConsoleColor.White, "AGREGAR PRODUCTO");
            Escribir(32, 5, ConsoleColor.Yellow, "2.- ");
            Escribir(35, 5, ConsoleColor.White, "VER PRODUCTOS");
            Escribir(32, 6, ConsoleColor.Yellow, "3.- ");
            Escribir(35, 6, ConsoleColor.White, "BÚSQUEDA DE PRODUCTO");
            Escribir(32, 7, ConsoleColor.Yellow, "4.- ");
            Escribir(35, 7, ConsoleColor.White, "ELIMINAR PRODUCTO");
            Escribir(32, 8, ConsoleColor.Yellow, "5.- ");
            Escribir(35, 8, ConsoleColor.White, "ACTUALIZAR PRODUCTO");
            Escribir(32, 9, ConsoleColor.Yellow, "6.- "); Escribir(35, 9, ConsoleColor.White, "REGRESAR AL MENÚ PRINCIPAL");
            }
        public void MenuOpcionesCliente()
        {
            Marco(25, 3, 65, 12);
            Escribir(35, 1, ConsoleColor.Yellow, "MENÚ DE CLIENTES");
            Escribir(32, 4, ConsoleColor.Yellow, "1.- ");
            Escribir(35, 4, ConsoleColor.White, "AGREGAR CLIENTE");
            Escribir(32, 5, ConsoleColor.Yellow, "2.- ");
            Escribir(35, 5, ConsoleColor.White, "VER LISTA DE CLIENTES");
            Escribir(32, 6, ConsoleColor.Yellow, "3.- ");
            Escribir(35, 6, ConsoleColor.White, "BÚSQUEDA DE CLIENTE");
            Escribir(32, 7, ConsoleColor.Yellow, "4.- ");
            Escribir(35, 7, ConsoleColor.White, "ELIMINAR CLIENTE");
            Escribir(32, 8, ConsoleColor.Yellow, "5.- ");
            Escribir(35, 8, ConsoleColor.White, "REGRESAR AL MENÚ PRINCIPAL");
        }
        public void PintarFondo(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            for (int i = 0; i < 100; i++)
                for (int j = 0; j < 25; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }
        }
        public int leerOpcion()
        {
            int opcion = 0;
            do
            {
                Escribir(25, 14, ConsoleColor.White, "Ingrese una opción:  ");
                opcion = leerNumeroEntero(45, 14);
            } while (opcion <= 0 || opcion > 7);
            return opcion;
        }
}   }

