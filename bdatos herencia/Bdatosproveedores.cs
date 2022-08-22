using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Bdatosproveedores : BaseDatosAccess
    {
        List<Bdatosproveedores> bdProveedores;
        public Bdatosproveedores(string _nombre, string _tipoid, string _ID, string _genero, string _correo, string _direccion, string _telefono, string _fnacimiento, Consola _consola) : base(_nombre, _tipoid, _ID, _genero, _correo, _direccion, _telefono, _fnacimiento, _consola)
        {
            bdProveedores = new List<Bdatosproveedores>();
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
            consola.Escribir(50, 1, ConsoleColor.Yellow, "BÚSQUEDA DE PROVEEDORES");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el ID del proveedor a buscar: ");
        }

        public override void eliminar()
        {
            base.eliminar();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ELIMINAR PROVEEDOR");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el ID del proveedor a eliminar: ");
        }

        public override void mostrarTabla()
        {
            base.mostrarTabla();
            consola.Escribir(40, 1, ConsoleColor.Yellow, "LISTA DE PROVEEDORES");
        }



    }
}

