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
            addingContacts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Contacto contacto = (Contacto)(comboBox1.SelectedItem);
            AgendaLista.control.VerContactos().Remove(contacto);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void addingContacts() 
        {
            foreach (var contact in AgendaLista.control.VerContactos()) {
                comboBox1.Items.Add(contact);
            
            }
        
        }
    }
}
