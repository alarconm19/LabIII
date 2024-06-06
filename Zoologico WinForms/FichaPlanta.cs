using Zoologico;

namespace Zoologico_WinForms
{
    public partial class FichaPlanta : Form, IFicha<Planta>
    {
        public Planta? Objeto { get; set; }
        public bool Modificacion { get; set; }

        public FichaPlanta(Planta? objeto = null)
        {
            InitializeComponent();

            comboBoxEspecie.SelectedIndex = 0;

            if (objeto == null) return;

            Objeto = objeto;
            Modificacion = true;

            textBoxID.Text = Objeto.Id.ToString();
            comboBoxEspecie.SelectedIndex = Objeto switch
            {
                PlantaCarnivora => 0,
                _ => comboBoxEspecie.SelectedIndex
            };
            checkBoxHidratada.Checked = Objeto.Hidratada;

            if (objeto is not PlantaCarnivora) return;

            var plantaCarnivora = (PlantaCarnivora)Objeto;
            checkBoxAlimentada.Checked = plantaCarnivora.Alimentada;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            Objeto = comboBoxEspecie.SelectedIndex switch
            {
                0 => new PlantaCarnivora(checkBoxHidratada.Checked, checkBoxAlimentada.Checked),
                _ => Objeto
            };
            DialogResult = DialogResult.OK;
        }

        private void ComboBoxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxAlimentada.Visible = comboBoxEspecie.SelectedIndex switch
            {
                0 => true,
                _ => false
            };
        }
    }
}
