using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdatos_herencia
{
    internal class BaseDatosAccess
    {
        public string nombre;
        public string tipoid;// R ruc , C cédula , P pasaporte , O otros
        public string ID;
        public string genero; //F femenino M masculino
        public string correo;
        public string direccion;
        public string telefono;
        public string fnacimiento;
        protected Consola consola;
        List<BaseDatosAccess> bdAccess;





        public BaseDatosAccess(string _nombre, string _tipoid, string _ID, string _genero, string _correo, string _direccion, string _telefono, string _fnacimiento, Consola _consola  )
        {
            this.nombre = _nombre;
            this.tipoid = _tipoid;
            this.ID = _ID;
            this.genero = _genero;
            this.correo = _correo;
            this.direccion = _direccion;
            this.telefono = _telefono;
            this.fnacimiento = _fnacimiento;
            this.consola = _consola;
            bdAccess = new List<BaseDatosAccess>();



        }

        public virtual void mostrarMembreteTabla()
        {
            consola.Escribir(5, 5, ConsoleColor.Blue, "Nombre");
            consola.Escribir(10, 5, ConsoleColor.Blue, "Tipoid");
            consola.Escribir(25, 5, ConsoleColor.Blue, "ID");
            consola.Escribir(50, 5, ConsoleColor.Blue, "Género");
            consola.Escribir(65, 5, ConsoleColor.Blue, "Correo");
            consola.Escribir(80, 5, ConsoleColor.Blue, "Direccion");
            consola.Escribir(95, 5, ConsoleColor.Blue, "Teléfono");
            consola.Escribir(115, 5, ConsoleColor.Blue, "Fecha de nacimiento");

            consola.Marco(3, 4, 90, 15);
        }
        public virtual void mostrarInfoComoFila(int Num, int fila)
        {

            consola.Escribir(10, fila, ConsoleColor.White, nombre);
            consola.Escribir(25, fila, ConsoleColor.White, tipoid);
            consola.Escribir(50, fila, ConsoleColor.White, ID);
            consola.Escribir(65, fila, ConsoleColor.White, genero);
            consola.Escribir(80, fila, ConsoleColor.White, correo);
            consola.Escribir(95, fila, ConsoleColor.White, direccion);
            consola.Escribir(115, fila, ConsoleColor.White, telefono);
            consola.Escribir(125, fila, ConsoleColor.White, fnacimiento);


        }
        public virtual void mostrarInfo()
        {

            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Nombre: ");
            consola.Escribir(35, 5, ConsoleColor.White, nombre);
            consola.Escribir(20, 6, ConsoleColor.Yellow, "TipoId: ");
            consola.Escribir(35, 6, ConsoleColor.White, tipoid);
            consola.Escribir(20, 7, ConsoleColor.Yellow, "ID: ");
            consola.Escribir(35, 7, ConsoleColor.White, ID);
            consola.Escribir(20, 8, ConsoleColor.Yellow, "Género: ");
            consola.Escribir(35, 8, ConsoleColor.White, genero);
            consola.Escribir(20, 9, ConsoleColor.Yellow, "Correo: ");
            consola.Escribir(35, 9, ConsoleColor.White, correo);
            consola.Escribir(20, 10, ConsoleColor.Yellow, "Dirección: ");
            consola.Escribir(35, 10, ConsoleColor.White, direccion);
            consola.Escribir(20, 11, ConsoleColor.Yellow, "Teléfono: ");
            consola.Escribir(35, 11, ConsoleColor.White, telefono);
            consola.Escribir(20, 12, ConsoleColor.Yellow, "Fecha de nacimiento: ");
            consola.Escribir(35, 12, ConsoleColor.White, fnacimiento);


        }
        public virtual void leerInfo(BaseDatosAccess BD)
        {

            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Blue, "Nombre");
            consola.Escribir(20, 6, ConsoleColor.Blue, "Tipoid");
            consola.Escribir(20, 7, ConsoleColor.Blue, "ID");
            consola.Escribir(20, 8, ConsoleColor.Blue, "Género");
            consola.Escribir(20, 9, ConsoleColor.Blue, "Correo");
            consola.Escribir(20, 10, ConsoleColor.Blue, "Direccion");
            consola.Escribir(20, 11, ConsoleColor.Blue, "Teléfono");
            consola.Escribir(20, 12, ConsoleColor.Blue, "Fecha de nacimiento");

            do
            {
                ID = consola.leerCadena(35, 5);
                if (BD.buscar(ID) == null) //Si es Igual aNULL significa NO encontrado
                {
                    break;
                }
                else
                {
                    consola.Escribir(20, 13, ConsoleColor.Red, "Número de ID: " + ID + " Ya registrado");
                    Console.ReadLine();
                    consola.Escribir(20, 13, ConsoleColor.Red, "  ");


                }

                nombre = consola.leerCadena(35, 6);
                tipoid = consola.leerCadena(35, 7);
                genero = consola.leerCadena(35, 8);
                correo = consola.leerCadena(35, 9);
                direccion = consola.leerCadena(35, 10);
                telefono = consola.leerCadena(35, 11);
                fnacimiento = consola.leerCadena(35, 12);


            } while (true);
        }
        public virtual void Crear()
        {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                BaseDatosAccess nuevabase = new BaseDatosAccess(consola);
                nuevabase.leerInfo(this);
                BaseDatosAccess encontrado = buscar(nuevabase.ID);
                if (encontrado == null) //NO HAY PRODUCTO CON EL MISMO CODIGO
                {
                    bdAccess.Add(nuevabase);
                    consola.Escribir(25, 13, ConsoleColor.Blue, "AGREGADO!!");
                }
                else
                {
                    consola.Escribir(25, 13, ConsoleColor.Red, " DUPLICADO!!");
                }
                Console.ReadLine();
        }
        public  virtual void Mostrar()
        {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                foreach (BaseDatosAccess itembase in bdAccess)
                {
                    itembase.mostrarInfo();
                    Console.ReadLine();
                }
        }
        public BaseDatosAccess buscar(String id)
        {
                foreach (BaseDatosAccess itembase in bdAccess)
                {
                    if (itembase.ID == id)
                    {
                        return itembase;
                    }
                }
                return null; //Not found by code
        }
        public  virtual void eliminar()
        {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
               
                string idbase = consola.leerCadena(70, 3);
                BaseDatosAccess encontrado = buscar(idbase);
                if (encontrado == null)
                {
                    consola.Escribir(25, 13, ConsoleColor.Red," No encontrado!!");
                }
                else
                {
                    Console.Clear();
                    consola.PintarFondo(ConsoleColor.Black);
                    encontrado.mostrarInfo();
                    bdAccess.Remove(encontrado);
                    consola.Escribir(25, 13, ConsoleColor.Red, "Eliminado!!");
                }
                Console.ReadLine();
        }
        public  virtual void busqueda()
        {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
               
                string idbase = consola.leerCadena(70, 3);
                BaseDatosAccess encontrado = buscar(idbase); 
                if (encontrado == null)
                {
                    consola.Escribir(25, 13, ConsoleColor.Red, " No encontrado!!");
                }
                else
                {
                    Console.Clear();
                    consola.PintarFondo(ConsoleColor.Black);
                    encontrado.mostrarInfo();
                }
                Console.ReadLine();
        }
        public void ActualizarPrecioProducto()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ACTUALIZAR PRECIO PRODUCTO");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el código del producto a actualizar: ");
            string idbase = consola.leerCadena(70, 3);
            BaseDatosAccess encontrado = buscar(idbase);
            if (encontrado == null)
            {
                consola.Escribir(25, 13, ConsoleColor.Red, "Producto no encontrado!!");
            }
            else
            {

                encontrado.actualizarPrecio(); Console.ReadLine();
            }
        }
        public virtual Boolean Vacia()
        {
                if (bdAccess.Count > 0)
                    return false;
                else
                    return true;
        }
        public virtual void mostrarTabla()
        {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                if (Vacia())
                {
                    consola.Escribir(40, 3, ConsoleColor.Red, "BASE DE DATOS VACÍA");
                }
                else
                {
                    BaseDatosAccess bd = new BaseDatosAccess(consola);
                    bd.mostrarMembreteTabla();
                    int num = 1; int fila = 7;
                    foreach (BaseDatosAccess itembase in bdAccess)
                    {
                        //sim Multiplo 7
                        if (num % 7 == 0)
                        {
                            Console.ReadLine();
                            Console.Clear();
                            consola.PintarFondo(ConsoleColor.Black); consola.Escribir(40, 1,ConsoleColor.Yellow, "SISTEMA DE FACTURACIÓN");
                            bd.mostrarMembreteTabla();
                            fila = 7;
                        }
                        itembase.mostrarInfoComoFila(num++,
                        fila++);
                    }
                }
                Console.ReadLine();
        }
    }

}

       
   

       
