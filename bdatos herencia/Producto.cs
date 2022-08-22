using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Producto : BaseDatosAccess
    {
       
        public String Codigo;
        public String Descripcion;
        public String Marca;
        public String Tipo;
        public double Precio;  

        public Producto(string _nombre, string _tipoid, string _ID, string _genero, string _correo, string _direccion, string _telefono, string _fnacimiento, Consola _consola) : base(_nombre, _tipoid, _ID, _genero, _correo, _direccion, _telefono, _fnacimiento, _consola)   
        {
            Precio = 0;
            
        }
        public  override void  mostrarMembreteTabla()
        {
            base.mostrarMembreteTabla();
            consola.Escribir(5, 5, ConsoleColor.Blue, "N°");
            consola.Escribir(10, 5, ConsoleColor.Blue, "Código");
            consola.Escribir(25, 5, ConsoleColor.Blue, "Descripción");
            consola.Escribir(50, 5, ConsoleColor.Blue, "Marca");
            consola.Escribir(65, 5, ConsoleColor.Blue, "Tipo");
            consola.Escribir(80, 5, ConsoleColor.Blue, "Valor");
            consola.Marco(3, 4, 90, 15);
        }
        public override void mostrarInfoComoFila(int Num, int fila)
        {

            base.mostrarInfoComoFila(Num , fila );
            consola.Escribir(5, fila, ConsoleColor.White, Num.ToString());
            consola.Escribir(10, fila, ConsoleColor.White, Codigo);
            consola.Escribir(25, fila, ConsoleColor.White, Descripcion);
            consola.Escribir(50, fila, ConsoleColor.White, Marca);
            consola.Escribir(65, fila, ConsoleColor.White, Tipo);
            consola.Escribir(80, fila, ConsoleColor.White,
            Precio.ToString("0.00"));
        }
        public override void mostrarInfo()
        {
            consola.Escribir(30, 2, ConsoleColor.Red, "INFORMACIÓN DEL PRODUCTO");
            base.mostrarInfo();
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Código: ");
            consola.Escribir(35, 5, ConsoleColor.White, Codigo);
            consola.Escribir(20, 6, ConsoleColor.Yellow, "Descripción: ");
            consola.Escribir(35, 6, ConsoleColor.White, Descripcion);
            consola.Escribir(20, 7, ConsoleColor.Yellow, "Marca: ");
            consola.Escribir(35, 7, ConsoleColor.White, Marca);
            consola.Escribir(20, 8, ConsoleColor.Yellow, "Tipo: ");
            consola.Escribir(35, 8, ConsoleColor.White, Tipo);
            consola.Escribir(20, 9, ConsoleColor.Yellow, "Precio: ");
            consola.Escribir(35, 9, ConsoleColor.White, Precio.ToString("0.00"));
        }
        public override void leerInfo(BaseDatosAccess BD)
        {
            consola.Escribir(30, 2, ConsoleColor.Red, "NUEVO PRODUCTO");
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Código: ");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "Descripción: ");
            consola.Escribir(20, 7, ConsoleColor.Yellow, "Marca: ");
            consola.Escribir(20, 8, ConsoleColor.Yellow, "Tipo: ");
            consola.Escribir(20, 9, ConsoleColor.Yellow, "Precio: ");
            do
            {
                Codigo = consola.leerCadena(35, 5);
                if (BD.buscar(Codigo) == null) //Si es Igual aNULL significa NO encontrado
                {
                    break;
                }
                else
                {
                    consola.Escribir(20, 13, ConsoleColor.Red, "Código Producto: " + Codigo + " Ya registrado");
                    Console.ReadLine();
                    consola.Escribir(20, 13, ConsoleColor.Red, "  ");
                }
            } while (true);
            Descripcion = consola.leerCadena(35, 6);
            Marca = consola.leerCadena(35, 7);
            Tipo = consola.leerCadena(35, 8);
            Precio = consola.leerNumeroDecimal(35, 9);
        }


        public void actualizarPrecio()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);
            mostrarInfo();
            consola.Escribir(20, 10, ConsoleColor.Red, "Nuevo Precio: ");
            double NuevoPrecio = consola.leerNumeroDecimal(35, 10);
            Precio = NuevoPrecio;
            consola.Escribir(20, 13, ConsoleColor.Blue, "Precio Actualizado! ");
            Console.ReadLine();
        }
       
}   }
