using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adoNetDesconectado
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresco();
        }

        public void refresco()
        {
            dataGridView1.DataSource = null;
            string connectionString = "Data Source=DESKTOP-FBA643A\\SQLEXPRESS;Initial Catalog=UNIVERSIDAD;Integrated Security=True";
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM alumnos";
                /*string query2 = "select a.nombre+' '+a.apellido, asis.fecha, asis.presente "+
                    "from asistencia2 asis inner join alumnos a" +
                    "on asis.id_alumno = a.id order by asis.fecha desc";
                */

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                // Asigna el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            using (Ficha f = new Ficha())
            {
                f.insert = true;
                if (f.ShowDialog()==DialogResult.OK)
                {
                    string connectionString = "Data Source=DESKTOP-FBA643A\\SQLEXPRESS;Initial Catalog=UNIVERSIDAD;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // Ejemplo de inserción
                        string insertQuery = "INSERT INTO alumnos (nombre,apellido,direccion,fechaNacimiento,tituloSecundario)" +
                            " VALUES (@nombre, @apellido,@direccion,@fechaNacimiento,@titulosecundario)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@nombre", f.a.nombre);
                            insertCommand.Parameters.AddWithValue("@apellido", f.a.apellido);
                            insertCommand.Parameters.AddWithValue("@direccion", f.a.direccion);
                            insertCommand.Parameters.AddWithValue("@fechaNacimiento", f.a.fechaNac);
                            insertCommand.Parameters.AddWithValue("@tituloSecundario", f.a.universidad);
                            
                            insertCommand.ExecuteNonQuery();
                        }

                    }
                    refresco();
                }

            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            using (Ficha f = new Ficha())
            {
                f.insert = false;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    f.a.id = int.Parse(selectedRow.Cells["id"].Value.ToString());
                    f.a.nombre = selectedRow.Cells["nombre"].Value.ToString();
                    f.a.apellido = selectedRow.Cells["apellido"].Value.ToString();
                    f.a.direccion = selectedRow.Cells["direccion"].Value.ToString();
                    f.a.fechaNac = selectedRow.Cells["fechaNacimiento"].Value.ToString();
                    f.a.universidad = int.Parse(selectedRow.Cells["tituloSecundario"].Value.ToString());

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        string connectionString = "Data Source=DESKTOP-FBA643A\\SQLEXPRESS;Initial Catalog=UNIVERSIDAD;Integrated Security=True";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            // Ejemplo de inserción
                            string UpdateQuery = "UPDATE alumnos set" +
                                " nombre = @nombre ," +
                                " apellido =@apellido ," +
                                " direccion =@direccion ," +
                                " fechaNacimiento=@fechaNacimiento ," +
                                " tituloSecundario=@titulo " +
                                " where id=@id";
                                
                            using (SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, connection))
                            {
                                UpdateCommand.Parameters.AddWithValue("@nombre", f.a.nombre);
                                UpdateCommand.Parameters.AddWithValue("@apellido", f.a.apellido);
                                UpdateCommand.Parameters.AddWithValue("@direccion", f.a.direccion);
                                UpdateCommand.Parameters.AddWithValue("@fechaNacimiento",DateTime.Parse(f.a.fechaNac) );
                                UpdateCommand.Parameters.AddWithValue("@titulo", f.a.universidad);
                                UpdateCommand.Parameters.AddWithValue("@id", f.a.id);

                                UpdateCommand.ExecuteNonQuery();
                            }

                        }
                        refresco();
                    }



                }


            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-FBA643A\\SQLEXPRESS;Initial Catalog=UNIVERSIDAD;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = int.Parse(selectedRow.Cells["id"].Value.ToString());

                    // Ejemplo de inserción
                    string deleteQuery = "Delete from alumnos where id=@id";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", id);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

            }
            refresco();
        }
    }
}
