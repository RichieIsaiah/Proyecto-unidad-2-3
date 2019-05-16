using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaInmobiliaria
{
    public class Agencia_Inmobiliaria 
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string Direccion { get; set; }       
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFin { get; set; }
        public string Inmueble { get; set; }
        public int Cantidad { get; set; }

        public void IngreseNombre(Agencia_Inmobiliaria agencia_Inmobiliaria)
        {
            Console.WriteLine("Ingrese Nombre Del Cliente");
            agencia_Inmobiliaria.Nombre = Console.ReadLine();
        }
        public void IngreseDireccion(Agencia_Inmobiliaria agencia_Inmobiliaria)
        {
            Console.WriteLine("Ingrese Direccion");
            agencia_Inmobiliaria.Direccion = Console.ReadLine();
        }
        public void IngreseInmueble(Agencia_Inmobiliaria agencia_Inmobiliaria)
        {
            Console.WriteLine("Ingrese Tipo De Inmueble ");
            agencia_Inmobiliaria.Inmueble = Console.ReadLine();
        }
        public void IngreseId(Agencia_Inmobiliaria agencia_Inmobiliaria)
        {
            Console.WriteLine("Ingrese Id");
            agencia_Inmobiliaria.Id = Convert.ToInt16(Console.ReadLine());
        }
        public void IngreseCantidad(Agencia_Inmobiliaria agencia_Inmobiliaria)
        {
            Console.WriteLine("Ingrese Id");
            agencia_Inmobiliaria.Cantidad = Convert.ToInt16(Console.ReadLine());
        }


    }
}
