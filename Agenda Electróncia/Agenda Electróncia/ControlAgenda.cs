using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Electróncia
{
    public class ControlAgenda
    {
        private Agenda _agenda;

        public ControlAgenda(Agenda agenda)
        {
            _agenda = agenda;
        }

        public List<Contacto> VerContactos()
        {
             return _agenda.MostrarContactos();
        }

        public void AgregarContacto(string name, string number)
        {
            
            //Console.WriteLine("Nuevo Contacto");
            Contacto contacto = new Contacto();
            //Console.Write("Nombre: ");
            contacto.Nombre = name;
            //Console.Write("Teléfono: ");
            contacto.Telefono = number;
            //Console.Write("Email: ");
            //contacto.Email = Console.ReadLine();

            _agenda.AgregarContacto(contacto);
            //Console.WriteLine("Contacto agregado exitosamente");
           
        }
        public void BorrarUltimoContacto()
        {
            //_agenda.BorrarUltimoContacto();
        }
        public void BuscarPorNombre()
        {
            
            Console.WriteLine("Buscar contacto");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Contacto contacto = _agenda.BuscarPorNombre(nombre);
            if (contacto != null)
            {
                //Console.WriteLine("Datos: \n" + contacto);
            }
            else
            {
                //Console.WriteLine("Contacto no encontrado");
            }
        }




        /* public void MenuMostrar()
         {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine("1. Mostrar orden ascendente");
             sb.AppendLine("2. Mostrar orden descendente");
             sb.AppendLine("3. Volver al menú principal");
             sb.Append("Seleccione una opción: ");

             Console.Write(sb.ToString());
         }*/


    }
}
