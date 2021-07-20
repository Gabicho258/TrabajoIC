using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Electróncia
{
    public partial class AgendaInicio : Form
    {
        public AgendaInicio()
        {
            InitializeComponent();
        }

        private void AgendaInicio_Load(object sender, EventArgs e)
        {
            buttonEnter.Enabled= false;
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AgendaLista ventanaList = new AgendaLista(user.Text))
                ventanaList.ShowDialog();
            
            
        }
        private void controlButtons()
        {
            if (user.Text.Trim() != string.Empty && user.Text.All(Char.IsLetter))
            {
                buttonEnter.Enabled = true;
                errorProvider1.SetError(user, "");
            }
            else
            {
                if (!(user.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(user, "Usuario inválido, solo se permite letras.");

                }
                else 
                {
                    errorProvider1.SetError(user, "Debe introducir un usuario.");
                }
                buttonEnter.Enabled = false;
                user.Focus();
            }   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
