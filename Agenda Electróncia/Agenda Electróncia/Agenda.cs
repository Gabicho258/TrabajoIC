using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Electróncia
{
    public class Agenda
    {
        private const int TAM = 100;
        //private Contacto[] _contactos;
        public List<Contacto> _contactos;
        //private int _index;

        /*public int NumContactos
        {
            get
            {
                //return _index;
            }
        }*/

        public Agenda()
        {
            //_index = 0;
            _contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto contacto)
        {
            _contactos.Add(contacto);
            //_contactos[_index] = contacto;
            //_index++;
        }
        /*public void BorrarUltimoContacto()
        {
            if (_index > 0)
            {
                _contactos[_index] = null;
                _index--;
            }
            else
            {
                Console.WriteLine("La agenda ya está vacía");
            }
        }*/
        private bool NoHayContactos()
        {
            if(_contactos.Count== 0)
            {
                
                return true;
            }

            return false;
        }

        public List<Contacto> MostrarContactos()
        {
            if (NoHayContactos()) { return null; }

            /*Contacto[] ordenados = new Contacto[_index];
            Array.Copy(_contactos, ordenados, _index);
            Array.Sort(ordenados);
            */
           //return CadenaContactos(_contactos);
           return _contactos;
        }
        public Contacto BuscarPorNombre(string nombre)
        {
            foreach (Contacto contacto in _contactos)
            {
                if (contacto != null && contacto.Nombre == nombre)
                {
                    return contacto;
                }
            }

            return null;
        }
        /*public object MostrarContactos()
        {
            return this;
        }*/

        public override string ToString()
        {
            return CadenaContactos(_contactos);
        }

        private string CadenaContactos(List<Contacto> contactos)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < contactos.LongCount(); i++)
            {
                if(_contactos[i] == null) { continue; }

                string dato = string.Format("{0}. {1}", i + 1, contactos[i]);
                sb.AppendLine(dato);
            }

            return sb.ToString();
        }
    }
}
