using System.Data;
using System.Data.SqlClient;

namespace AdoRepaso
{
    internal class AdoNetConectado
    {
        private const string ConnectionString = "your_connection_string_here";

        public void CargarDatosConectado(DataGridView dataGridView)
        {
            using var connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                const string query = "SELECT * FROM TuTabla"; // Ajusta el nombre de la tabla según tu base de datos
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                // Crear un DataTable para almacenar los datos temporalmente
                var dataTable = new DataTable();
                dataTable.Load(reader);

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView.DataSource = dataTable;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        public void ModificarDatosConectado(DataGridView dataGridView)
        {
            using var connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["Id"].Value == null) continue;

                    const string query = "UPDATE TuTabla SET Columna1 = @Columna1, Columna2 = @Columna2 WHERE Id = @Id"; // Ajusta los nombres de las columnas
                    var command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Columna1", row.Cells["Columna1"].Value);
                    command.Parameters.AddWithValue("@Columna2", row.Cells["Columna2"].Value);
                    command.Parameters.AddWithValue("@Id", row.Cells["Id"].Value);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        public void EliminarDatosConectado(DataGridView dataGridView)
        {
            using var connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (row.Cells["Id"].Value == null) continue;

                    const string query = "DELETE FROM TuTabla WHERE Id = @Id"; // Ajusta el nombre de la tabla
                    var command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", row.Cells["Id"].Value);

                    command.ExecuteNonQuery();
                    dataGridView.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        public void AgregarDatosConectado(DataGridView dataGridView)
        {
            using var connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["Id"].Value != null) continue; // Verifica si es un nuevo registro

                    const string query = "INSERT INTO TuTabla (Columna1, Columna2) VALUES (@Columna1, @Columna2)";
                    var command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Columna1", row.Cells["Columna1"].Value);
                    command.Parameters.AddWithValue("@Columna2", row.Cells["Columna2"].Value);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

    }
}
