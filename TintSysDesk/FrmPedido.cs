﻿using System;
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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grbDados.Enabled = true;
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource= Cliente.Listar();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember= "Id";

            cmbUsuario.DataSource= Usuario.Listar();
            cmbUsuario.DisplayMember= "Nome";
            cmbUsuario.ValueMember= "Id";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(
                Cliente.ObterPorId(Convert.ToInt32(cmbCliente.SelectedValue)),
                Usuario.ObterPorId(Convert.ToInt32(cmbUsuario.SelectedValue))
                );
            pedido.Inserir();
            Pedido newped = Pedido.ObterPorId(pedido.Id);
            lblStatus.Text = newped.Status + " - "+newped.HashCode;
            txtId.Text = newped.Id.ToString();

            grbDados.Enabled = false;
            grbProduto.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ItemPedido item = new ItemPedido(
               Convert.ToInt32(txtId.Text),
               Produto.ObterPorId(Convert.ToInt32(txtIdProd.Text)),
               Convert.ToDouble(txtPreco.Text),
               Convert.ToDouble(txtQuantidade.Text),
               Convert.ToDouble(txtDesconto.Text)
                   );
            item.Adicionar();
            CarregaGrid();
        }

        private void txtIdProd_TextChanged(object sender, EventArgs e)
        {
            if(txtIdProd.Text.Length > 0)
            {
                Produto produto = Produto.ObterPorId(Convert.ToInt32(txtIdProd.Text));
                if( produto != null )
                {
                    txtDescricao.Text = produto.Descricao;
                    txtPreco.Text = produto.Preco.ToString();
                    txtUnid.Text = produto.Unidade;
                }
            }
        }
        private void CarregaGrid()
        {
            dgvItens.Rows.Clear();
            List<ItemPedido> items = ItemPedido.ListarPorPedido(Convert.ToInt32(txtId.Text));
            double subTotal = 0;
            int contador = 0;
            foreach (var item in items)
            {
                dgvItens.Rows.Add();
                dgvItens.Rows[contador].Cells[0].Value = contador + 1;
                dgvItens.Rows[contador].Cells[1].Value = item.Produto.Id;
                dgvItens.Rows[contador].Cells[2].Value = item.Produto.Descricao;
                dgvItens.Rows[contador].Cells[3].Value = item.Produto.Unidade;
                dgvItens.Rows[contador].Cells[4].Value = item.Preco;
                dgvItens.Rows[contador].Cells[5].Value = item.Quantidade;
                dgvItens.Rows[contador].Cells[6].Value = item.Desconto;
                double ValorItem = item.Preco * item.Quantidade-item.Desconto;
                dgvItens.Rows[contador].Cells[7].Value = ValorItem;
                subTotal += ValorItem;
                contador++;
            }
            txtTotal.Text = subTotal.ToString();
        }

        private void grbDados_Enter(object sender, EventArgs e)
        {

        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
