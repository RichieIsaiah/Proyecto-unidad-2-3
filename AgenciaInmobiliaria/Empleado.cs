using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaInmobiliaria
{
    public class Empleado 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Genero { get; set; }

        public int Edad { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }





        public void Menu(Empleado empleado)
        {
            Console.WriteLine("Bienvenido De Vuelta");
        }

        public void IngreseNombre(Empleado empleado)
        {
            Console.WriteLine("Ingrese Nombre Del Cliente");
            empleado.Nombre = Console.ReadLine();
        }
        public void IngreseDireccion(Empleado empleado)
        {
            Console.WriteLine("Ingrese Direccion");
            empleado.Direccion = Console.ReadLine();
        }
        public void IngreseCelular(Empleado empleado)
        {
            Console.WriteLine("Ingrese Genero");
            empleado.Genero = Console.ReadLine();
        }
        public void IngreseCorreo(Empleado empleado)
        {
            Console.WriteLine("Ingrese Email");
            empleado.Correo = Console.ReadLine();
        }
        public void IngreseEdad(Empleado empleado)
        {
            Console.WriteLine("Ingrese Edad");
            empleado.Edad = Convert.ToInt16(Console.ReadLine());
        }
        public void IngreseTelefono(Empleado empleado)
        {
            Console.WriteLine("Ingrese Numero de Telefono");
            empleado.Telefono= Convert.ToInt16(Console.ReadLine());
            
        }





    }

}
