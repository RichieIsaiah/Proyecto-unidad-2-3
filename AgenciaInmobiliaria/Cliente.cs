using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaInmobiliaria
{
   public  class Cliente
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public int Celular { get; set; }


        public string Direccion { get; set; }
        public string Correo { get; set; }

        public void Menu(Cliente cliente)

        {

            Console.WriteLine("Muy Buenos Dias/ Tardes!, Me Gustaria Observar sus productos");
            
            Console.WriteLine("Hola, Mucho Gusto ");
        }
        public void IngreseNombre(Cliente cliente)
        {
            Console.WriteLine("Ingrese Nombre Del Cliente");
            cliente.Nombre = Console.ReadLine();
        }
        public void IngreseDireccion(Cliente cliente)
        {
            Console.WriteLine("Ingrese Direccion");
            cliente.Direccion = Console.ReadLine();
        }
        public void IngreseCelular(Cliente cliente)
        {
            Console.WriteLine("Ingrese Numero De Celular");
            cliente.Celular = Convert.ToInt16(Console.ReadLine());
        }
        public void IngreseCorreo(Cliente cliente)
        {
            Console.WriteLine("Ingrese Email");
            cliente.Correo = Console.ReadLine();
        }
    }
}
