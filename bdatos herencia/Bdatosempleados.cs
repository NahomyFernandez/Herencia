using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Bdatosempleados : BaseDatosAccess
    {

        
        List<Bdatosempleados> bdEmpleados;

        public Bdatosempleados(string _nombre, string _tipoid, string _ID, string _genero, string _correo, string _direccion, string _telefono, string _fnacimiento, Consola _consola) : base (_nombre, _tipoid, _ID, _genero, _correo, _direccion, _telefono, _fnacimiento, _consola)
        {
            bdEmpleados = new List<Bdatosempleados>();
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
            consola.Escribir(50, 1, ConsoleColor.Yellow, "BÚSQUEDA DE EMPLEADOS");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el ID del empleado a buscar: ");
        }

        public override void eliminar()
        {
            base.eliminar();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ELIMINAR EMPLEADO");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el ID del empleado a eliminar: ");
        }

        public override void mostrarTabla()
        {
            base.mostrarTabla();
            consola.Escribir(40, 1, ConsoleColor.Yellow, "LISTA DE EMPLEADOS");
        }



    }
}
