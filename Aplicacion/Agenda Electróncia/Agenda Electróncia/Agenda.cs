using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Electróncia
{
    public class Agenda
    {
        //Crea un objeto de tipo List que almacena objetos de tipo Contacto
        public List<Contacto> _contactos;

        public Agenda()
        {
            //Al ser creada una Agenda, se crea automaticamente la lista de Tipo Contacto
            _contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto contacto)
        {
            //Método Add de la clase Lista para añadir a la lista _contactos
            _contactos.Add(contacto);
        }
        
        //Método que verifica si hay o no hay contactos
        private bool NoHayContactos()
        {
            if(_contactos.Count== 0)
            {
                return true;
            }

            return false;
        }
        //Retorna la List _contactos 
        public List<Contacto> MostrarContactos()
        {
            if (NoHayContactos()) { return null; }
          
           return _contactos;
        }
       
    }
}
