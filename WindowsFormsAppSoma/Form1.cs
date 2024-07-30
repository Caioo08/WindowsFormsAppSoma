using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        { 
            double n1 = double.Parse(txt_um.Text);
            double n2 = double.Parse(txt_dois.Text);
            double resultado =  n1 + n2;

            lbl_resultado.Text = resultado.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_um.Text = "";
            txt_dois.Text = "";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
