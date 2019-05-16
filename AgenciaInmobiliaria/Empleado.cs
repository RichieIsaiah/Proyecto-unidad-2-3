using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaInmobiliaria
{
    public class Empleado : Agencia_Inmobiliaria
    {
        public new int Id { get; set; }
        public new string Nombre { get; set; }
        public string Correo { get; set; }
        public new string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Puesto { get; set; }

        public void IngreseNombre(Empleado empleado)
        {
            Console.WriteLine("Ingrese Nombre Del Empleado");
            empleado.Nombre = Console.ReadLine();
        }
        public void IngreseDireccion(Empleado empleado)
        {
            Console.WriteLine("Ingrese Direccion");
            empleado.Direccion = Console.ReadLine();
        }
        public void IngreseCorreo(Empleado empleado)
        {
            Console.WriteLine("Ingrese Email");
            empleado.Correo = Console.ReadLine();
        }
        public void IngreseTelefono(Empleado empleado)
        {
            Console.WriteLine("Ingrese Numero de Telefono");
            empleado.Telefono = Console.ReadLine();
        }
        public void IngresePuesto(Empleado empleado)
        {
            Console.WriteLine("Ingrese Puesto");
            empleado.Puesto = Console.ReadLine();
        }
        public void IngreseId(Empleado empleado)
        {
            Console.WriteLine("Ingrese Id del empleado");
            empleado.Id = Convert.ToInt16(Console.ReadLine());
        }

    }

}
