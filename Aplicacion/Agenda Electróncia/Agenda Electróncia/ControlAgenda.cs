using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Electróncia
{
    public class ControlAgenda
    {
        //Crea la variable de tipo Agenda para acceder a sus métodos y propiedades
        private Agenda _agenda;

        public ControlAgenda(Agenda agenda)
        {
            //Asigna el parametro a la variable local
            _agenda = agenda;
        }
        public List<Contacto> VerContactos()
        {
            //Retorna una List de tipo contacto mediante el método de la clase Agenda MostrarContactos
             return _agenda.MostrarContactos();
        }

        public void AgregarContacto(string name, string number)
        {
            //Crea variable local de tipo Contacto
            Contacto contacto = new Contacto();
            //Asigna el parámetro name a la propiedad Name de la clase Contacto
            contacto.Nombre = name;
            //Asigna el parámetro number a la propiedad Telefono de la clase Contacto
            contacto.Telefono = number;
            //Agrega el contacto creado a la variable de tipo Agenda mediante su método AgregarContacto
            _agenda.AgregarContacto(contacto);
           
        }
        
    }
}
