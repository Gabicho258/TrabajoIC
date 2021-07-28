using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda_Electróncia
{
    public partial class addContact : Form 
    {
        public addContact()
        {
            InitializeComponent();
        }
        private void addContact_Load(object sender, EventArgs e)
        {

        }
        //Método que se ejecuta cuando se da Click en añadir
        private void button1_Click(object sender, EventArgs e)
        {
            //Asigna a la variable nameContact el texto que se escriba en el TextBox Nombre: 
            string nameContact = nameNewContact.Text;
            //Asigna a la variable numberContact el texto que se escriba en el TextBox Celular:
            string numberContact = numNewContact.Text;
            //Agrega el contacto a una List de otra Clase
            AgendaLista.control.AgregarContacto(nameContact,numberContact);
            //Cierra ventana
            this.Close();
        }

        
    }
}
