using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Bdatosproducto : BaseDatosAccess
    {
        List<Producto> bdProductos;
        public Bdatosproducto(string nombre, string tipoid, string ID, string genero, string correo, string direccion, string telefono, string fnacimiento, Consola _consola) : base(nombre, tipoid, ID, genero, correo, direccion, telefono, fnacimiento, _consola)
        {
            bdProductos = new List<Producto>();

        }

        public override void Crear()
        {
            base.Crear();
        }
      
        public override void Mostrar()
        {
            base.Mostrar();
        }

        public override bool Vacia()
        {
            return base.Vacia();
        }

        public override void busqueda()
        {
            base.busqueda();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "BÚSQUEDA DE PRODUCTOS");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el código del producto a buscar: ");
        }

        public override void eliminar()
        {
            base.eliminar();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ELIMINAR PRODUCTO");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el código del producto a eliminar: ");
        }

        public override void mostrarTabla()
        {
            base.mostrarTabla();
            consola.Escribir(40, 1, ConsoleColor.Yellow, "LISTA DE PRODUCTOS");
        }



    }
    

}     