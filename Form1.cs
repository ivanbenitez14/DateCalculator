using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiferenciaDeFecha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularDiferencia();
        }

        void CalcularDiferencia()
        {
            DateTime Fecha1 = dateTimePicker1.Value.Date;
            DateTime Fecha2 = dateTimePicker2.Value.Date;

            TimeSpan tSpan = Fecha1 - Fecha2;

            int Dias = tSpan.Days;

            textBox1.Text = Dias.ToString();

        }

    }
}
