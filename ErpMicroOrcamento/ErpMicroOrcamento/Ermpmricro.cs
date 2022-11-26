using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ErpMicroOrcamento
{
    public partial class Ermpmricro : Form
    {
        public Ermpmricro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDoProduto, res;
            int quantidade;
            var total = new ArrayList();

            valorDoProduto = Convert.ToDouble(txtValorDoProduto.Text);
            quantidade = Convert.ToInt16(txtQuantidade.Text);

            res = quantidade * valorDoProduto;

             total.Add(res);

            int soma = 0;
       
              

         
           
            
            lbTotal.Text = Convert.ToString(total);

        }

        private void lbnomeDoProduto_Click(object sender, EventArgs e)
        {

        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            
            String nomeDoOrcamento;
            nomeDoOrcamento = txtNomeDoProduto.Text;
            double valorDoProduto , res;
            int quantidade;
            ArrayList historico = new ArrayList();
           

            nomeDoOrcamento = txtNomeDoProduto.Text;
            valorDoProduto = Convert.ToDouble(txtValorDoProduto.Text);
            quantidade = Convert.ToInt16(txtQuantidade.Text);

            res = quantidade * valorDoProduto;  
            
            lbTotal.Text = Convert.ToString(res);
  
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNomeDoProduto_TextChanged(object sender, EventArgs e)
        {
            string name;
            name = txtNomeDoProduto.Text;

            nameResultado.Text = name;
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
