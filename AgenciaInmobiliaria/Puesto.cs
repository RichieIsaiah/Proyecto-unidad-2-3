using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaInmobiliaria
{
    public class Puesto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFin { get; set; }
    }
}
