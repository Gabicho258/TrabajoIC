using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Electróncia
{
    public class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Contacto()
        {
        }
        
        public Contacto(string nombre, string telefono)
        {
            //Constructor que asigna las variables
            Nombre = nombre;
            Telefono = telefono;
        }
        //Reescribe el método ToString y retorna los atributos en un formato asignado
        public override string ToString()
        {
            return string.Format("Nombre: {0}  \nTeléfono: {1}\n", Nombre, Telefono);
        }
        //Actualmente no está en uso, pero se podrá hacer una actualización de la app con nuevos funcionamientos
        public int CompareTo(Contacto other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
    }
}
