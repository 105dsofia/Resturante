using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_restaurante_JS_5toA
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Pollo", 15, cantidad * 15);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                suma += (int)fila.Cells[3].Value;
            }
            textBox1.Text = suma.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Hamburguesa", 15, cantidad * 15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Papas", 15, cantidad * 15);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Pancaque", 15, cantidad * 15);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Taco", 15, cantidad * 15);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Panqueques ", 15, cantidad * 15);
        }
    }
}
