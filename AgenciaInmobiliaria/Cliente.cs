using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaInmobiliaria
{
   public  class Cliente : Agencia_Inmobiliaria
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public int Id { get; set; }


        public void IngreseNombre(Cliente cliente)
        {
            Console.WriteLine("Ingrese Nombre Del Cliente");
            cliente.Nombre = Console.ReadLine();
        }
        public void IngreseCelular(Cliente cliente)
        {
            Console.WriteLine("Ingrese Numero De Celular");
            cliente.Celular = Console.ReadLine();
        }
        public void IngreseCorreo(Cliente cliente)
        {
            Console.WriteLine("Ingrese Email");
            cliente.Correo = Console.ReadLine();
        }
        public void IngreseId(Cliente cliente)
        {
            Console.WriteLine("Ingrese Id");
            cliente.Id = Convert.ToInt16(Console.ReadLine());
        }

       
    }
}
