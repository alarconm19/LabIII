using System.Text.Json;
using System.Text.Json.Serialization;
using Zoologico;

namespace Zoologico_WinForms
{
    public partial class MainForm : Form
    {
        private readonly BindingSource _bindingSource = [];
        private List<Animal> _animales = [];
        private List<Planta> _plantas = [];
        private List<Cuidador> _cuidadores = [];
        private readonly JsonSerializerOptions _jsonSerializerOptions = new() { Converters = { new AnimalConverter(), new PlantaConverter() }, IncludeFields = true, WriteIndented = true };

        public class AnimalConverter : JsonConverter<Animal>
        {
            public override Animal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                // Read the JSON into a JsonDocument
                using var doc = JsonDocument.ParseValue(ref reader);

                // Determine the type of the Animal from the JSON
                var type = doc.RootElement.GetProperty("Especie").GetInt32();

                // Deserialize the JSON into the correct type of Animal
                return type switch
                {
                    0 => JsonSerializer.Deserialize<Leon>(doc.RootElement.GetRawText(), options),
                    1 => JsonSerializer.Deserialize<Chimpance>(doc.RootElement.GetRawText(), options),
                    2 => JsonSerializer.Deserialize<AguilaReal>(doc.RootElement.GetRawText(), options),
                    3 => JsonSerializer.Deserialize<Pio>(doc.RootElement.GetRawText(), options),
                    4 => JsonSerializer.Deserialize<PezDorado>(doc.RootElement.GetRawText(), options),
                    5 => JsonSerializer.Deserialize<PezPayaso>(doc.RootElement.GetRawText(), options),
                    // Add cases for other types of Animals here...
                    _ => throw new JsonException($"Unknown animal type: {type}")
                };
            }

            public override void Write(Utf8JsonWriter writer, Animal value, JsonSerializerOptions options)
            {
                // Serialize the Animal using the JsonSerializer
                JsonSerializer.Serialize(writer, (dynamic)value, options);
            }
        }

        public class PlantaConverter : JsonConverter<Planta>
        {
            public override Planta? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                // Read the JSON into a JsonDocument
                using var doc = JsonDocument.ParseValue(ref reader);

                // Determine the type of the Animal from the JSON
                var type = doc.RootElement.GetProperty("Especie").GetInt32();

                // Deserialize the JSON into the correct type of Animal
                return type switch
                {
                    0 => JsonSerializer.Deserialize<PlantaCarnivora>(doc.RootElement.GetRawText(), options),
                    // Add cases for other types of Animals here...
                    _ => throw new JsonException($"Unknown plant type: {type}")
                };
            }

            public override void Write(Utf8JsonWriter writer, Planta value, JsonSerializerOptions options)
            {
                // Serialize the Animal using the JsonSerializer
                JsonSerializer.Serialize(writer, (dynamic)value, options);
            }
        }

        public MainForm()
        {
            InitializeComponent();

            comboBoxSelectorDGV.SelectedIndex = 0;
            CargarList(_animales);
        }

        private void Refrescar()
        {
            _bindingSource.ResetBindings(false);
        }

        private void CargarList<T>(List<T> list)
        {
            dataGridViewZoologico.DataSource = _bindingSource;
            _bindingSource.DataSource = list; // Inicializaci�n de datos

            if (dataGridViewZoologico.Columns.Count <= 0) return;

            switch (comboBoxSelectorDGV.SelectedIndex)
            {
                case 0:
                    dataGridViewZoologico.Columns[1].ReadOnly = true; // Clase columna
                    dataGridViewZoologico.Columns[2].ReadOnly = true; // Especie columna
                    dataGridViewZoologico.Columns[3].ReadOnly = true; // Comida columna
                    break;
                case 1:
                    dataGridViewZoologico.Columns[0].ReadOnly = true; // columna ID
                    break;
                case 2:
                    dataGridViewZoologico.Columns[2].ReadOnly = true; // Clase columna
                    break;
            }
        }

        private void ButtonCrearZoo_Click(object sender, EventArgs e)
        {
            switch (comboBoxSelectorDGV.SelectedIndex)
            {
                case 0:
                    using (FichaAnimal fichaAnimal = new())
                    {
                        fichaAnimal.ShowDialog();

                        if (fichaAnimal.DialogResult != DialogResult.OK) return;
                        if (fichaAnimal.Modificacion) return;

                        _animales.Add(fichaAnimal.Objeto!);
                    }

                    break;
                case 1:
                    using (FichaPlanta fichaPlanta = new())
                    {
                        fichaPlanta.ShowDialog();

                        if (fichaPlanta.DialogResult != DialogResult.OK) return;
                        if (fichaPlanta.Modificacion) return;

                        _plantas.Add(fichaPlanta.Objeto!);
                    }

                    break;
                case 2:

                    using (FichaCuidador fichaCuidador = new())
                    {
                        fichaCuidador.ShowDialog();

                        if (fichaCuidador.DialogResult != DialogResult.OK) return;
                        if (fichaCuidador.Modificacion) return;

                        _cuidadores.Add(fichaCuidador.Objeto!);
                    }
                    break;
            }
            Refrescar();

        }

        private void ButtonModificarZoo_Click(object sender, EventArgs e)
        {
            // Obtener todas las filas seleccionadas
            var selectedRows = dataGridViewZoologico.SelectedCells
                .Cast<DataGridViewCell>().Select(cell => cell.OwningRow).Distinct().ToList();

            switch (comboBoxSelectorDGV.SelectedIndex)
            {
                case 0:
                    ModificarList(_animales, selectedRows, index => new FichaAnimal(_animales[index]));
                    break;
                case 1:
                    ModificarList(_plantas, selectedRows, index => new FichaPlanta(_plantas[index]));
                    break;
                case 2:
                    ModificarList(_cuidadores, selectedRows, index => new FichaCuidador(_cuidadores[index]));
                    break;
            }
        }

        private void ModificarList<T>(List<T> lista, List<DataGridViewRow> selectedRows, Func<int, Form> crearFormulario)
        {
            switch (selectedRows.Count)
            {
                case 1:
                    {
                        var selectedIndex = selectedRows[0].Index;

                        // Crear y mostrar el formulario de edición
                        var formulario = crearFormulario(selectedIndex);
                        formulario.ShowDialog();

                        if (formulario.DialogResult == DialogResult.OK)
                        {
                            // Si se confirmaron los cambios, actualiza el objeto en la lista
                            if (formulario is IFicha<T> ficha)
                            {
                                lista[selectedIndex] = ficha.Objeto!;
                                Refrescar();
                            }
                        }

                        break;
                    }
                case > 1:
                    MessageBox.Show(@"Seleccione solo una fila para modificar.", @"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    MessageBox.Show(@"Seleccione un elemento para modificar.", @"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ComboBoxSelectorDGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectorDGV.SelectedIndex)
            {
                case 0:
                    CargarList(_animales);
                    break;
                case 1:
                    CargarList(_plantas);
                    break;
                case 2:
                    CargarList(_cuidadores);
                    break;
            }
        }

        private void SaveCurrentWork()
        {
            Zoologico.Zoologico zoologico = new(_animales, _plantas, _cuidadores);

            using var dialog = new SaveFileDialog();

            dialog.Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            string saveDialogFileName;

            if (dialog.ShowDialog() == DialogResult.OK)
                saveDialogFileName = dialog.FileName;
            else
                // The user cancelled the dialog, so don't save the file
                return;

            var json = JsonSerializer.Serialize(zoologico, _jsonSerializerOptions);
            File.WriteAllText(saveDialogFileName, json);
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            if (_animales.Count == 0 && _plantas.Count == 0 && _cuidadores.Count == 0)
                // There is no current work, so don't prompt the user
                return;

            var result = MessageBox.Show(@"Do you want to save your current work before starting a new file?", @"Confirmation", MessageBoxButtons.YesNoCancel);

            switch (result)
            {
                case DialogResult.Yes:
                    // Save the current work
                    SaveCurrentWork();
                    break;
                case DialogResult.Abort:
                    return;
                case DialogResult.Cancel:
                    // The user cancelled the operation, so don't start a new file
                    return;
            }

            // Clear the current workspace
            _animales.Clear();
            _plantas.Clear();
            _cuidadores.Clear();

            // Update the UI
            Refrescar();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            var zoologico = LoadZoologico();

            if (zoologico == null) return;

            _animales = zoologico.GetAnimales() ?? throw new InvalidOperationException();
            _plantas = zoologico.GetPlantas() ?? throw new InvalidOperationException();
            _cuidadores = zoologico.GetCuidadores() ?? throw new InvalidOperationException();

            switch (comboBoxSelectorDGV.SelectedIndex)
            {
                case 0:
                    CargarList(_animales);
                    break;
                case 1:
                    CargarList(_plantas);
                    break;
                case 2:
                    CargarList(_cuidadores);
                    break;
            }
        }

        private Zoologico.Zoologico? LoadZoologico()
        {
            using var dialog = new OpenFileDialog();

            openFileDialog.Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return null;

            var filePath = openFileDialog.FileName;
            var json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<Zoologico.Zoologico>(json, _jsonSerializerOptions);
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            Zoologico.Zoologico zoologico = new(_animales, _plantas, _cuidadores);

            using var dialog = new SaveFileDialog();

            saveFileDialog.Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            var filePath = saveFileDialog.FileName;
            var json = JsonSerializer.Serialize(zoologico, _jsonSerializerOptions);

            File.WriteAllText(filePath, json);
        }
    }
}
