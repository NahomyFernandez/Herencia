using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class Empleado : BaseDatosAccess
    {
        public double sueldo;
        public string cargo;
        public string departamento;
        public string añosexp;
        public string titulo;
        public string horario;
        

        public Empleado (string _nombre, string _tipoid, string _ID, string _genero, string _correo, string _direccion, string _telefono, string _fnacimiento, Consola _consola, double _sueldo ,string _cargo ,string _departamento , string _añosexp, string _titulo , string _horario ) : base(_nombre, _tipoid, _ID, _genero, _correo, _direccion, _telefono, _fnacimiento, _consola)
        {
            sueldo = 0;
            this.cargo = _cargo;
            this.departamento = _departamento;
            this.añosexp = _añosexp;
            this.titulo = _titulo;
            this.horario = _horario;

        }

        public override void mostrarMembreteTabla()
        {
            base.mostrarMembreteTabla();
            consola.Escribir(5, 5, ConsoleColor.Blue, "Sueldo");
            consola.Escribir(10, 5, ConsoleColor.Blue, "Cargo");
            consola.Escribir(25, 5, ConsoleColor.Blue, "Departamento");
            consola.Escribir(50, 5, ConsoleColor.Blue, "Años de experiencia");
            consola.Escribir(65, 5, ConsoleColor.Blue, "Título");
            consola.Escribir(80, 5, ConsoleColor.Blue, "Horario de trabajo");
            consola.Marco(3, 4, 90, 15);
        }

        public override void mostrarInfoComoFila(int Num, int fila)
        {
            base.mostrarInfoComoFila(Num, fila);

           
            sueldo.ToString("0.00");
            consola.Escribir(25, fila, ConsoleColor.White, cargo);
            consola.Escribir(50, fila, ConsoleColor.White, departamento);
            consola.Escribir(65, fila, ConsoleColor.White, añosexp);
            consola.Escribir(80, fila, ConsoleColor.White, titulo);
            consola.Escribir(80, fila, ConsoleColor.White, horario);


        }
        public override void leerInfo(BaseDatosAccess BD)
        {
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(30, 2, ConsoleColor.Red, "NUEVO EMPLEADO");
            base.leerInfo(BD);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Sueldo: ");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "Cargo: ");
            consola.Escribir(20, 7, ConsoleColor.Yellow, "Departamento: ");
            consola.Escribir(20, 8, ConsoleColor.Yellow, "Años de experiencia: ");
            consola.Escribir(20, 9, ConsoleColor.Yellow, "Horario de trabajo: ");

            sueldo=consola.leerNumeroDecimal(35, 13);
            cargo=consola.leerCadena(35, 7);
            departamento=consola.leerCadena(35, 7);
            añosexp= consola.leerCadena(35, 7);
            titulo= consola.leerCadena(35, 7);
            horario=consola.leerCadena(35, 7);


        }

    }
}
