using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda_Electróncia
{
    public partial class deleteContact : Form
    {
        public deleteContact()
        {
            InitializeComponent();
            //Añade los contactos que estpen a la List al selecciondor(comboBox)
            //Para así poder seleccionar un contacto específico a eliminar
            addingContacts();
        }
        //Método que se ejecuta cuando se da Click en Eliminar
        private void button1_Click(object sender, EventArgs e)
        {
            //Crea con el contacto seleccionado del comboBox, un objeto de tipo Contacto temporal
            Contacto contacto = (Contacto)(comboBox1.SelectedItem);
            //Accede al método Remove de la List donde se almacenan los contactos,
            //y elimina el contacto temporal creado anteriormente
            AgendaLista.control.VerContactos().Remove(contacto);
            //Cierra la ventana
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void addingContacts() 
        {
            //Añade los elementos de la List a los items del comboBox seleccionador
            foreach (var contact in AgendaLista.control.VerContactos()) {
                comboBox1.Items.Add(contact);
            }
        }
    }
}
