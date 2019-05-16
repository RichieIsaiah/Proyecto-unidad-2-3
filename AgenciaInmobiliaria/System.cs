using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaInmobiliaria
{
    class System
    {
        public void Menu()
        {
            Console.WriteLine("Bienvenido, Ingrese Si es Cliente, Dueño o Empleado"
                       + "\n1.Cliente"
                       + "\n2.- Empleado"
                       + "\n3.- Gerente"
                       + "\n4.- Cerrar\n");

            string S1 = null;
            S1 = Console.ReadLine();

            switch (S1)
            {
                case "1":

                    System.menu();

                    break;

                case "2":


                    break;

                case "3":
                    


                    break;
                case "4":
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("no existe la opcion");
                    break;
            }
        }
    }
}
