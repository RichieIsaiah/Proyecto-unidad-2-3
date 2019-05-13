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
        public string Correo { get; set; }

        public DateTime HorarioInicio { get; set; }

        public DateTime HorarioFin { get; set; }

        public void Menu(Agencia_Inmobiliaria agencia_Inmobiliaria)

        {
            Console.WriteLine("Welcome Back"+"Bienvenue di Volta"+"Bienvenido De Vuelta"+"Obrigado");
            Console.WriteLine("Desea Comprar Inmuebles?");
            Console.WriteLine(value: "Desea Obervar Bienes?");
        }
    }
}
