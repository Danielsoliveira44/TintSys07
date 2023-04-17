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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Cliente cliente = Cliente.ObterPorEmail(txtEmailEnd.Text);
            if (cliente != null)
            {

                int idCliente = cliente.Id;
                txtIdCli.Text = idCliente.ToString();
            }
            gpbLogin.Enabled = false;
            gpbEndereco.Enabled = true;

        }

        private void bntInserirEnd_Click(object sender, EventArgs e)
        {
           
            Endereco endereco = new Endereco(
               txtCep.Text,
               txtRua.Text,
               txtNumero.Text,
               txtComplemento.Text,
               txtBairro.Text,
               txtCidade.Text,
               txtEstado.Text,
               txtUf.Text,
               txtTipo.Text,
               Cliente.ObterPorId(Convert.ToInt32(txtIdCli.Text))
                ); 
            endereco.Inserir();
            

            if (endereco.Id > 0)
            {
                txtId.Text = endereco .Id.ToString();
                MessageBox.Show("Endereço gravado com sucesso!");

            }
            else
                MessageBox.Show("Falha ao gravar o Endereço!1");
        }

        private void btnLoginTel_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.ObterPorEmail(txtLoginTel.Text);
            if (cliente != null)
            {

                int idClientes = cliente.Id;
                txtCliTel.Text = idClientes.ToString();
            }
            gpbLoginTel.Enabled = false;
            gpbTelefone.Enabled = true;
        }

        private void btnInserirTel_Click(object sender, EventArgs e)
        {
            Telefone telefone = new Telefone(
                txtNumeroTel.Text,
                txtTipoTel.Text,
                Cliente.ObterPorId(Convert.ToInt32(txtCliTel.Text))
                );
            telefone.Inserir();
            if (telefone.Id > 0)
            {
                txtId.Text = telefone.Id.ToString();
                MessageBox.Show("Telefone gravado com sucesso!");

            }
            else
                MessageBox.Show("Falha ao gravar o Telefone!1");
        }
    }
}
