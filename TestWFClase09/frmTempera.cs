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
    public partial class frmTempera : Form
    {
        private Tempera _miTempera;
        public Tempera miTempera
        {
            get
            {
                return this._miTempera;
            }
        }
        public frmTempera()
        {
            InitializeComponent();

            this.label1.Text = "Color";
            this.label2.Text = "Marca";
            this.label3.Text = "Cantidad";
            this.button1.Text = "Aceptar";
            this.button2.Text = "Cancelar";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (ConsoleColor colores in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(colores);
            }
            this.comboBox1.Items.Add("---Seleccione uno---");
            this.comboBox1.SelectedItem = "---Seleccione uno---";
            
        }

        public frmTempera(Tempera temp) : this()
        {
            this._miTempera = temp;
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _miTempera = new Tempera((ConsoleColor)this.comboBox1.SelectedItem, this.textBox1.Text, sbyte.Parse(this.textBox2.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
