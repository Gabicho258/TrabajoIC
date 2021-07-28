using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda_Electróncia
{
    
    public partial class AgendaLista : Form
    {
        //Se crea una variable de tipo ControlAgenda que recibe de parametro una Agenda
        public static ControlAgenda control = new ControlAgenda(new Agenda());
        
        // string user se refiere al usuario que se ingresa en la pantalla principal
        private string user;
        public AgendaLista(string name)
        {
            //Constructor recibe de argumento el nombre del usuario de la pantalla de inicio
            //y lo asigna a la variable user creada anteriormente
            InitializeComponent();
            user = name;
        }
        private void AgendaLista_Load(object sender, EventArgs e)
        {
            //Al label de bienvenida le añade el nombre del usuario dinámicamente
            welcome.Text += user;
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            //Las dos lineas siguientes crean y abren la nueva ventana para agregar contactos
            using (addContact ventanaAddContact = new addContact())
                ventanaAddContact.ShowDialog();
            //Formatea la lsita de contactos para poder agregar más
            listBox1.DataSource = null;
            //Muestra los contactos en la lista de contactos
            listBox1.DataSource = control.VerContactos();
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            //Las dos lineas siguientes crean y abren la nueva ventana para eliminar contactos
            using (deleteContact ventanaDeleteContact = new deleteContact())
                ventanaDeleteContact.ShowDialog();
            //Formatea la lsita de contactos para poder agregar más
            listBox1.DataSource = null;
            //Muestra los contactos en la lista de contactos
            listBox1.DataSource = control.VerContactos();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Ciera la ventana de AngedaLista
            this.Close();
        }
    }
}
