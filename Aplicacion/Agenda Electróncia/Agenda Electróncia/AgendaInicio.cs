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
            //Al abrir el programa, el boton no se podra presionar.
            buttonEnter.Enabled= false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Controla que se haya añadido un usuario válido, sin caracteres especiales
            controlButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crea la nueva ventana y la muestra
            using (AgendaLista ventanaList = new AgendaLista(user.Text))
                ventanaList.ShowDialog();
        }
        //Método que controla que se haya añadido un usuario válido, sin caracteres especiales
        private void controlButtons()
        {
            //Si el texto del usuario sin espacios es diferente es un string vacio && todos los caracteres son letras
            if ((user.Text.Trim() != string.Empty) && user.Text.All(Char.IsLetter))
            {
                //Habilita el botón para ser presionado
                buttonEnter.Enabled = true;
                //Borra el error
                errorProvider1.SetError(user, "");
            }
            //sino
            else
            {
                //Si los caracteres NO son letras
                if (!(user.Text.All(Char.IsLetter)))
                {
                    //Muestra un mensaje de error
                    errorProvider1.SetError(user, "Usuario inválido, solo se permite letras.");

                }
                else //Caso sobrante que pasaría cuando esté vacio
                {
                    //Muestra el mensaje de error
                    errorProvider1.SetError(user, "Debe introducir un usuario.");
                }
                //Deshabilita el botón
                buttonEnter.Enabled = false;
                //Pone el cursor de escritura en la caja de texto
                user.Focus();
            }   
        }
        //Se ejecuta al ahcer click en el boton Salir
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }
    }
}
