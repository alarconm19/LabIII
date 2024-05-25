using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresas
{
    public partial class FichaEmpresa : Form
    {
         
        public Empresa Empresa_local { get; set; }
        public bool modificacion { get; set; }
        public FichaEmpresa()
        {
            InitializeComponent();
        }

        private void FichaEmpresa_Load(object sender, EventArgs e)
        {
            if (Empresa_local!=null)
            {
                comboSector.Text = Empresa_local.sector;
                textBoxNombre.Text = Empresa_local.nombre;
                textBoxDireccion.Text = Empresa_local.direccion;
                textBoxTelefono.Text = Empresa_local.telefono;
                textBoxEmail.Text = Empresa_local.email;
                modificacion = true;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Empresa_local = new Empresa(comboSector.Text
                ,textBoxNombre.Text,textBoxDireccion.Text
                ,textBoxTelefono.Text,textBoxEmail.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
