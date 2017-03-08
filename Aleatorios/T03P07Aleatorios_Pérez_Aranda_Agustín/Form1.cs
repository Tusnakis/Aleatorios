using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T03P07Aleatorios_Pérez_Aranda_Agustín
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        string[] lista_aleatorios = new string[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero = textBox1.Text;
            bool numEsta = Array.Exists(lista_aleatorios, element => element == numero);
            if (numEsta == true)
            {
                String[] repetidos = Array.FindAll(lista_aleatorios, element => element == numero);
                label2.Text = "El número está y se repite " + repetidos.Length + " veces";
            }
            else {
                label2.Text = "El número no está";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                lista_aleatorios[i] = aleatorio.Next(0, 99).ToString();
            }
            foreach (string valor in lista_aleatorios)
            {
                label1.Text += valor + " ";
            }
        }
    }
}
