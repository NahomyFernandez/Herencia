using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Proveedores : BaseDatosAccess
    {
        public string empresa;
        public string marcaofr;
        public string prod;
        public int tventas;

        public Proveedores (string _nombre, string _tipoid, string _ID, string _genero, string _correo, string _direccion, string _telefono, string _fnacimiento, Consola _consola , string _empresa , string _marcaofr , string _prod , string _tventas) : base(_nombre, _tipoid, _ID, _genero, _correo, _direccion, _telefono, _fnacimiento, _consola)
        {
            this.empresa = _empresa;
            this.marcaofr = _marcaofr;
            this.prod = _prod;
            tventas = 0;
        }
        public override void mostrarMembreteTabla()
        {
            base.mostrarMembreteTabla();
            consola.Escribir(5, 5, ConsoleColor.Blue, "Empresa");
            consola.Escribir(10, 5, ConsoleColor.Blue, "Marca del producto a proveer");
            consola.Escribir(25, 5, ConsoleColor.Blue, "Producto que provee");
            consola.Escribir(50, 5, ConsoleColor.Blue, "Total de ventas");    
            consola.Marco(3, 4, 90, 15);
        }

        public override void mostrarInfoComoFila(int Num, int fila)
        {
            base.mostrarInfoComoFila(Num, fila);


           
            consola.Escribir(25, fila, ConsoleColor.White, empresa);
            consola.Escribir(50, fila, ConsoleColor.White, marcaofr);
            consola.Escribir(65, fila, ConsoleColor.White, prod);
            tventas.ToString();
            


        }
        public override void leerInfo(BaseDatosAccess BD)
        {
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(30, 2, ConsoleColor.Red, "NUEVO PROVEEDOR");
            base.leerInfo(BD);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Empresa: ");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "Marca del producto a proveer: ");
            consola.Escribir(20, 7, ConsoleColor.Yellow, "Producto a proveer: ");
            consola.Escribir(20, 8, ConsoleColor.Yellow, "Total de ventas: ");
          

           
            empresa = consola.leerCadena(35, 7);
            marcaofr = consola.leerCadena(35, 7);
            prod = consola.leerCadena(35, 7);
            tventas = consola.leerNumeroEntero(35, 7);
            


        }

    }
}
    

