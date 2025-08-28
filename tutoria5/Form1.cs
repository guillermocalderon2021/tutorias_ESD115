using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoria5
{
    public partial class Form1 : Form
    {
        static Stack<int> p1 = new Stack<int>();
        static Stack<int> p2 = new Stack<int>();
        static Stack<int> p3 = new Stack<int>();
        static Stack<int> p4 = new Stack<int>();
        static Stack<int> p5 = new Stack<int>();

        Stack<int>[] pilas = { p1, p2, p3, p4, p5 };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(txtI.Text);
                int j = int.Parse(txtJ.Text);
                if (Math.Abs(i) > 5)
                {
                    MessageBox.Show("El valor absoluto de i debe ser menor o igual a 5");
                    return;
                }
                if (i > 0) // Insertar j en la pila i
                {
                    pilas[i - 1].Push(j);
                }
                else if (i < 0)
                {
                    if(pilas[Math.Abs(i) - 1].Count == 0)
                    {
                        MessageBox.Show("La pila esta vacia");
                    }
                    else
                    {
                        // Eliminar el tope de la pila
                        pilas[Math.Abs(i) - 1].Pop();
                    }
                        
                }
                else
                {
                    MessageBox.Show("Fin del proceso de ingreso");
                }
                MostrarPilas();
                txtI.Clear();
                txtJ.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void MostrarPilas()
        {
            ListBox[] listboxes = { lst1, lst2, lst3, lst4, lsi5 };
            for (int i = 0; i < listboxes.Length; i++)
            {
                listboxes[i].Items.Clear();
                foreach (int n in pilas[i])
                {
                    listboxes[i].Items.Add(n);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text); //285
            Pila pila = new Pila();
            int temp=num; // temp = 2 , digito= 2
            while (temp > 0)
            {
                int digito = temp % 10; // Tomando el ultimo digito
                pila.Push(digito);
                temp = temp / 10; // Quitando el ultimo digito
            }
            // pila: 

            // Reconstruir el numero inverso
            int inverso = 0;
            int multiplicador = 1; // multiplicador =1000
            while (pila.Count > 0)
            {
                int digito= pila.Pop(); // digito = 5
                inverso+=  digito*multiplicador; // inverso = 582
                multiplicador *= 10;
            }
            if (inverso == num)
            {
                MessageBox.Show($"{num} es capicua");
            }
            else
            {
                MessageBox.Show($"{num} NO es capicua");
            }
        }
    }
}
