using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act3
{
    public partial class Form1 : Form
    {
        int tam;
        int i = 0;
        int cantidad;
        AlumnosInf[] arreglo = new AlumnosInf[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////////cantidad = int.Parse(txtCantidad.Text);
            ////////arreglo = new AlumnosInf[cantidad];
            tam = int.Parse(txtCantidad.Text);
            arreglo = new AlumnosInf[tam];
            txtCantidad.Clear();
            groupBox1.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (i > cantidad)
            {
                arreglo[i] = new AlumnosInf();
                arreglo[i].Matricula = int.Parse(txtMatricula.Text);
                arreglo[i].Nombre = txtNombre.Text;
                arreglo[i].Paterno = txtPaterno.Text;
                arreglo[i].Materno = txtMaterno.Text;
                arreglo[i].Edad = int.Parse(txtEdad.Text);
                txtMatricula.Clear();
                txtNombre.Clear();
                txtPaterno.Clear();
                txtMaterno.Clear();
                txtEdad.Clear();
                i++;
            }
            else
            {
                for(int x = 0; x < tam; x++)
                {
                    ListViewItem lista = new ListViewItem(arreglo[x].Matricula.ToString());
                    lista.SubItems.Add(arreglo[x].Nombre);
                    lista.SubItems.Add(arreglo[x].Paterno);
                    lista.SubItems.Add(arreglo[x].Materno);
                    lista.SubItems.Add(arreglo[x].Edad.ToString());
                    listView1.Items.Add(lista);
                }
            }
           


        }
    }
}
