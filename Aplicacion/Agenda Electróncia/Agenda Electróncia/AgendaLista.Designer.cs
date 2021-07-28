
namespace Agenda_Electróncia
{
    partial class AgendaLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaLista));
            this.welcome = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.addContact = new System.Windows.Forms.Button();
            this.deleteContact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.welcome.Location = new System.Drawing.Point(46, 47);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(219, 33);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Bienvenid@, ";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.exit.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(46, 359);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(160, 64);
            this.exit.TabIndex = 1;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addContact
            // 
            this.addContact.BackColor = System.Drawing.SystemColors.Highlight;
            this.addContact.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addContact.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addContact.Location = new System.Drawing.Point(46, 137);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(160, 76);
            this.addContact.TabIndex = 2;
            this.addContact.Text = "Añadir contacto";
            this.addContact.UseVisualStyleBackColor = false;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // deleteContact
            // 
            this.deleteContact.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteContact.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteContact.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteContact.Location = new System.Drawing.Point(46, 252);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(160, 76);
            this.deleteContact.TabIndex = 3;
            this.deleteContact.Text = "Eliminar contacto";
            this.deleteContact.UseVisualStyleBackColor = false;
            this.deleteContact.Click += new System.EventHandler(this.deleteContact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(473, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de contactos";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(473, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 362);
            this.listBox1.TabIndex = 5;
            // 
            // AgendaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteContact);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgendaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Electrónica";
            this.Load += new System.EventHandler(this.AgendaLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addContact;
        private System.Windows.Forms.Button deleteContact;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox1;
    }
}