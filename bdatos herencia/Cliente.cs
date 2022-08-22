using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Cliente : BaseDatosAccess
    {
        public string MPago;
        public string FechaComp;


        
        public Cliente(string _nombre, string _tipoid, string _ID, string _genero, string _correo, string _direccion, string _telefono, string _fnacimiento, Consola _consola ,string _Mpago , string _FechaComp) : base(_nombre, _tipoid, _ID, _genero, _correo, _direccion, _telefono, _fnacimiento, _consola )
        {
            this.MPago = _Mpago;
            this.FechaComp = _FechaComp;
        }
        public override void mostrarMembreteTabla()
        {
            consola.Escribir(15, 5, ConsoleColor.Blue, "Método de pago");
            consola.Escribir(40, 5, ConsoleColor.Blue, "FechaComp");
            
        }
        public override void mostrarInfoComoFila(int Num, int fila)
        {
            base.mostrarInfoComoFila(Num, fila);
            consola.Escribir(15, fila, ConsoleColor.White, MPago);
            consola.Escribir(25, fila, ConsoleColor.White, FechaComp);
           

        }

        public override void mostrarInfo()
        {
            consola.Escribir(30, 2, ConsoleColor.Red, "INFORMACIÓN DEL CLIENTE");
            consola.Marco(10, 3, 65, 11);
            base.mostrarInfo();
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Método de pago: ");
            consola.Escribir(35, 5, ConsoleColor.White, MPago);
            consola.Escribir(20, 6, ConsoleColor.Yellow, "Fecha de compra: ");
            consola.Escribir(35, 6, ConsoleColor.White, FechaComp); 
           

        }

        public override void leerInfo(BaseDatosAccess BD)
        {
            base.leerInfo(BD);
            consola.Escribir(30, 2, ConsoleColor.Red, "NUEVO CLIENTE");
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Método de pago: ");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "Fecha de compra: ");
            MPago = consola.leerCadena(35, 7);
            FechaComp = consola.leerCadena(35, 7);
        }
    }
}
    

