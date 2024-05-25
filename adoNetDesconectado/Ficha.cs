using System;
using System.Windows.Forms;

namespace adoNetDesconectado
{
    public partial class Ficha : Form
    {
        public alumno a { get; set; }
        public bool insert { get; set; }
        public Ficha()
        {
            a = new alumno();
            InitializeComponent();
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            if (!insert)
            {
                textBoxID.Text = a.id.ToString();
                textBoxNOM.Text = a.nombre;
                textBoxAPEL.Text = a.apellido;
                textBoxDIR.Text = a.direccion;
                textBoxFNAC.Text = a.fechaNac;
                textBoxTIT.Text = a.universidad.ToString();
            }
           

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
                a.nombre = textBoxNOM.Text;
                a.apellido = textBoxAPEL.Text;
                a.direccion = textBoxDIR.Text;
                a.fechaNac = textBoxFNAC.Text;
                a.universidad = int.Parse(textBoxTIT.Text);

            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
