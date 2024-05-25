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
    public partial class Form1 : Form
    {
        List<Empresa> listaEmpresas = new List<Empresa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        public void refrescar()
        {
            dataGridView1.DataSource = null;
            BindingSource db=new BindingSource();
            db.DataSource = listaEmpresas;
            dataGridView1.DataSource = db;
            
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FichaEmpresa f = new FichaEmpresa();
            f.ShowDialog();
            if (f.DialogResult==DialogResult.OK)
            {
                if (!f.modificacion)
                {
                    listaEmpresas.Add(f.Empresa_local);

                    refrescar();
                }
                
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Empresa getEmpresa()
        {
            string sector = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string direccion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string telefono = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Empresa oldEmpresa = listaEmpresas.FirstOrDefault(q => q.nombre == nombre);
            return oldEmpresa;
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FichaEmpresa f = new FichaEmpresa();
                f.Empresa_local = getEmpresa();
                Empresa oldEmpresa = getEmpresa();
                f.ShowDialog();
                if (f.DialogResult==DialogResult.OK)
                {
                    if (f.modificacion)
                    {
                        listaEmpresas.Remove(oldEmpresa);
                        listaEmpresas.Add(f.Empresa_local);
                        refrescar();
                    }
                    

                }
            }
            catch (Exception)
            {

                MessageBox.Show("No selecciono un registro");
            }
           
        
        }

        private void buttonTEST_Click(object sender, EventArgs e)
        {

            listaEmpresas.Add(new Empresa("industrial", "alpargatas", "los sauces 44", "343434", "alpargatas@alpargatas.com"));
            listaEmpresas.Add(new Empresa("industrial", "alpargatas", "los sauces 44", "343434", "alpargatas@alpargatas.com"));
            listaEmpresas.Add(new Empresa("industrial", "alpargatas", "los sauces 44", "343434", "alpargatas@alpargatas.com"));
            listaEmpresas.Add(new Empresa("industrial", "alpargatas", "los sauces 44", "343434", "alpargatas@alpargatas.com"));


            listaEmpresas.Add(new Empresa("industrial","alpargatas","los sauces 44","343434","alpargatas@alpargatas.com"));
            listaEmpresas.Add(new Empresa("industrial", "alpargatas", "los sauces 44", "343434", "alpargatas@alpargatas.com"));
            refrescar();
        
        
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            Empresa oldEmpresa = getEmpresa();
            listaEmpresas.Remove(oldEmpresa);
            refrescar();
        }
    }
}
