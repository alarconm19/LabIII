using Zoologico;

namespace Zoologico_WinForms
{
    public partial class FichaCuidador : Form, IFicha<Cuidador>
    {
        public Cuidador? Objeto { get; set; }
        public bool Modificacion { get; set; }

        public FichaCuidador(Cuidador? objeto = null)
        {
            InitializeComponent();

            comboBoxTurno.SelectedIndex = 0;

            numericUpDownEdad.Minimum = 0;
            numericUpDownEdad.Maximum = 100;
            numericUpDownEdad.Value = 18;

            if (objeto == null) return;

            Objeto = objeto;
            Modificacion = true;

            textBoxNombre.Text = Objeto.Nombre;
            comboBoxTurno.SelectedIndex = Objeto.Turno switch
            {
                Turno.Mañana => 0,
                Turno.Tarde => 1,
                Turno.Noche => 2,
                _ => comboBoxTurno.SelectedIndex
            };
            numericUpDownEdad.Value = Objeto.Edad;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show(@"Ingrese un nombre para continuar.", @"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Objeto = new Cuidador(textBoxNombre.Text, (int)numericUpDownEdad.Value, (Turno)comboBoxTurno.SelectedIndex);
            DialogResult = DialogResult.OK;
        }
    }
}
