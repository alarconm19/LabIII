using Zoologico;

namespace Zoologico_WinForms
{
    public partial class FichaAnimal : Form, IFicha<Animal>
    {
        public Animal? Objeto { get; set; }
        public bool Modificacion { get; set; }

        public FichaAnimal(Animal? objeto = null)
        {
            InitializeComponent();

            comboBoxEspecie.SelectedIndex = 0;

            if (objeto == null) return;

            Objeto = objeto;
            Modificacion = true;

            textBoxNombre.Text = Objeto.Nombre;
            comboBoxEspecie.SelectedIndex = Objeto switch
            {
                Leon => 0,
                Chimpance => 1,
                AguilaReal => 2,
                Pio => 3,
                PezDorado => 4,
                PezPayaso => 5,
                _ => comboBoxEspecie.SelectedIndex
            };
            checkBoxEnfermo.Checked = Objeto.Enfermo;
            checkBoxAlimentado.Checked = Objeto.Alimentado;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show(@"Ingrese un nombre para continuar.", @"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Objeto = comboBoxEspecie.SelectedIndex switch
            {
                0 => new Leon(textBoxNombre.Text, checkBoxEnfermo.Checked, checkBoxAlimentado.Checked),
                1 => new Chimpance(textBoxNombre.Text, checkBoxEnfermo.Checked, checkBoxAlimentado.Checked),
                2 => new AguilaReal(textBoxNombre.Text, checkBoxEnfermo.Checked, checkBoxAlimentado.Checked),
                3 => new Pio(textBoxNombre.Text, checkBoxEnfermo.Checked, checkBoxAlimentado.Checked),
                4 => new PezDorado(textBoxNombre.Text, checkBoxEnfermo.Checked, checkBoxAlimentado.Checked),
                5 => new PezPayaso(textBoxNombre.Text, checkBoxEnfermo.Checked, checkBoxAlimentado.Checked),
                _ => Objeto
            };
            DialogResult = DialogResult.OK;
        }
    }
}
