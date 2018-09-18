using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades07_08;

namespace TestWFClase08_
{
    public partial class Form1 : Form
    {
        Paleta _miPaleta;
        public Form1()
        {
            InitializeComponent();
            this._miPaleta = 5;
            this.groupBox1.Text = "Paleta de colores";
            this.textBox1.Multiline = true;

            this.button1.Text = "+";
            this.button2.Text = "-";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.groupBox1.Visible=true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();
            DialogResult rta = frm.ShowDialog();
            if (rta == DialogResult.OK)
            {
                this._miPaleta += frm.MiTempera;
                this.textBox1.Text = (string)this._miPaleta;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.SelectedText;
            int index=0;

            foreach (string item in this.textBox1.Lines)
            {
                if (text == item)
                {
                    break;
                }
                index++;
            }
            index = (index - 2) / 2;
            text += " " + index.ToString();
            MessageBox.Show(text);

            FrmTempera frmMinus = new FrmTempera();
            DialogResult rta = frmMinus.ShowDialog();


        }
    }
}
