using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Ficha : Form
    {
        public Contacto c;
        public bool insert { get; set; }
        public Ficha()
        {
            InitializeComponent();
            c = new Contacto();

        }

        private void Ficha_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                c.nombre = textBoxNombre.Text;
                c.direccion = textBoxDireccion.Text;
                c.telefono = textBoxTelefono.Text;
                c.email = textBoxEmail.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
