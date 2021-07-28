using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Electróncia
{
    public class Lista
    {
        ArrayList listaNameNums;
        public Lista() 
        {
            listaNameNums = new ArrayList();
        }
        public void addContact(string contact) 
        {
            listaNameNums.Add(contact);
        }
        public void removeContact(string contact) 
        {
            listaNameNums.Remove(contact);
        }

    }
}
