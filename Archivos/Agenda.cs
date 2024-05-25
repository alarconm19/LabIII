using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archivos
{
    public partial class Agenda : Form
    {


        List<Contacto> Lc = new List<Contacto>();
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            refrezcar();
        }

        public void refrezcar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Lc;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Ficha f = new Ficha();
            f.insert = true;
            if (f.ShowDialog()==DialogResult.OK)
            {
                
                Lc.Add(new Contacto(f.c.nombre,f.c.direccion,f.c.telefono,f.c.email));
                refrezcar();
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (StreamWriter f=new StreamWriter(saveFileDialog1.FileName))
                {

                    foreach (Contacto item in Lc)
                    {
                        f.WriteLine($"{item.nombre},{item.direccion},{item.telefono},{item.email}");
                    }
                   
                }
            }
          
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            Lc.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader f = new StreamReader(openFileDialog1.FileName))
                {
                    string l;
                    while ((l = f.ReadLine())!=null)
                    {
                        string[] r = l.Split(',');
                                                
                        Lc.Add(new Contacto(r[0], r[1], r[2], r[3]));

                    }
                    

                }
            }

            refrezcar();
        
        }
    }
}
