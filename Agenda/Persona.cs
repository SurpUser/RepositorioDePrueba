using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Persona
    {
        public string Nombre { get; set; }
        public Persona() { }

        public Persona(string Nombre)
        {
            this.Nombre = Nombre; 
        }
    }
}
