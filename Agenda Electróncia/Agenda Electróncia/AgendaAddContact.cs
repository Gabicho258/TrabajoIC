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
        public String newContact;
        public String newNumberContact;
        public addContact()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addContact_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nameContact = nameNewContact.Text;
            String numberContact = numNewContact.Text;
            AgendaLista.control.AgregarContacto(nameContact,numberContact);
            this.Close();
        }

        
    }
}
