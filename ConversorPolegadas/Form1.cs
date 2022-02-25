using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ConversorPolegadas
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            double centimetros = double.Parse(txt_Valor.Text);
            double polegadas;
            polegadas = centimetros * 2.54;
            lb_Polegadas.ForeColor = Color.Green;
            
            lb_Polegadas.Text = "Equivle a " + polegadas.ToString(CultureInfo.InvariantCulture) + " Centimetos";

            lb_Centimetros.ForeColor = Color.Blue;
            lb_Centimetros.Text = "O valor " + centimetros.ToString(CultureInfo.InvariantCulture) + " em Polegadas";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
