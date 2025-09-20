using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoria7
{
    public partial class FormContenedores : Form
    {

        Queue<Contenedor> colaContenedores = new Queue<Contenedor>(); 

        public FormContenedores()
        {
            InitializeComponent();
        }

        private void FormContenedores_Load(object sender, EventArgs e)
        {
            cmbLugarProcedencia.SelectedIndex = 0;
            cmbRubro.SelectedIndex = 0;
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            Contenedor nuevoContenedor = new Contenedor();
            nuevoContenedor.NumeroContenedor= int.Parse(txtNumeroContendor.Text);
            nuevoContenedor.Encargado= txtEncargado.Text;
            nuevoContenedor.tiempoAtencion = (int )nudTiempoAtencion.Value;
            nuevoContenedor.Valor = decimal.Parse(txtValor.Text);
            nuevoContenedor.Rubro = cmbRubro.SelectedItem.ToString();
            nuevoContenedor.PaisProcedencia = cmbLugarProcedencia.SelectedItem.ToString();
            nuevoContenedor.NumeroCajas= (int) nudNumeroCajas.Value;

            foreach(Contenedor cont in colaContenedores)
            {
                if (nuevoContenedor.NumeroContenedor == cont.NumeroContenedor)
                {
                    MessageBox.Show($"Ya existe un contenedor con codigo {nuevoContenedor.NumeroContenedor}");
                    return;
                }

            }
            colaContenedores.Enqueue(nuevoContenedor);
            MessageBox.Show("Contenedor agregado a la cola de forma exitosa");
            
            dataGridView1.DataSource = colaContenedores.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //colaContenedores.MostrarCola();
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
           Contenedor eliminado= colaContenedores.Dequeue();
            if (eliminado != null)
            {
                MessageBox.Show($"Contenedor con id {eliminado.NumeroContenedor} desencolado exitosamente");
                dataGridView1.DataSource = colaContenedores.ToList();
            }
            else
            {
                MessageBox.Show("Cola vacia");
            }
        }
    }
}
