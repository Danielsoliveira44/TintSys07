using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;

namespace TintSysDesk
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                txtNome.Text,
                mktCpf.Text,
                txtEmail.Text
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                
                MessageBox.Show("Produto gravado com sucesso!");

            }
            else
                MessageBox.Show("Falha ao gravar o Produto!1");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtId.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void tpgDados_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.ObterPorEmail(Convert.ToInt32(txtEmailEnd.Text));
            if (cliente != null)
            {

                txtIdCli.Text = cliente.Id;
            }
            gpbLogin.Enabled = false;
            gpbEndereco.Enabled = true;

        }

        private void bntInserirEnd_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco(
               double.Parse(txtCep.Text),
               txtRua.Text,
               double.Parse(txtNumero.Text),
               txtComplemento.Text,
               txtBairro.Text,
               txtCidade.Text,
               txtEstado.Text,
               txtUf.Text,
               txtTipo.Text
                );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtId.Text = endereco .Id.ToString();
                MessageBox.Show("Produto gravado com sucesso!");

            }
            else
                MessageBox.Show("Falha ao gravar o Produto!1");
        }
    }
}
