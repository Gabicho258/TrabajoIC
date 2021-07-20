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
        public static ControlAgenda control = new ControlAgenda(new Agenda());
        //public ArrayList Lista;
        
        string user;
        public AgendaLista(string name)
        {
            InitializeComponent();
            user = name;
            
        }

        private void AgendaLista_Load(object sender, EventArgs e)
        {
            welcome.Text += user;
            Lista we = new Lista();
            
                
            
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            using (addContact ventanaAddContact = new addContact())
                ventanaAddContact.ShowDialog();
            listBox1.DataSource = null;
            listBox1.DataSource = control.VerContactos();
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            using (deleteContact ventanaDeleteContact = new deleteContact())
                ventanaDeleteContact.ShowDialog();
            //control.VerContactos().Remove();
            listBox1.DataSource = null;
            listBox1.DataSource = control.VerContactos();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
