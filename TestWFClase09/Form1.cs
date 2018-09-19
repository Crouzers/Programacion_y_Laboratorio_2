using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Indexadas;

namespace TestWFClase09
{
    public partial class Form1 : Form
    {
        Paleta _miPaleta;
        public Form1()
        {
            _miPaleta = 5;
            InitializeComponent();
            this.groupBox1.Text = "Paleta de colores";
            this.textBox1.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this._miPaleta += frm.miTempera;
                this.textBox1.Text = (string)_miPaleta;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
           // string tempera = "";
            string seleccionado = "";
            string[] todoElTexto = textBox1.Lines;
            seleccionado = textBox1.SelectedText;

            for (i = 2; i < textBox1.Lines.Count(); i++) //Aca se inicia el i en 2 por la linea en la que se selecciona las temperas, si se modifica el MOSTRAR se tiene que modificar el i
            {
                if (todoElTexto[i] == seleccionado)
                {
                    i -= 2;
                    MessageBox.Show("\nTempera seleccionada: " + seleccionado + "\nIndice: " + i);
                    break;
                }
            }
            frmTempera frm = new frmTempera(_miPaleta[i]);
            DialogResult resultado = frm.ShowDialog();
        }
    }
}
