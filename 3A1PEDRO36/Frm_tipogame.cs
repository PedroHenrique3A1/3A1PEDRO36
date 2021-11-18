using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1PEDRO36
{
    public partial class Frm_tipogame : Form
    {
        public Frm_tipogame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_games Frm_games = new Frm_games();
            Frm_games.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tipogames obj = new Tipogames();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.tipo_midia = txtMidia.Text;
            obj.descricao = txtDescricao.Text;
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtMidia.Clear();
            txtDescricao.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Tipogames obj = new Tipogames();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.tipo_midia = txtMidia.Text;
            obj.descricao = txtDescricao.Text;
            obj.Alterar();
            MessageBox.Show("Alterado!");
            txtId.Clear();
            txtMidia.Clear();
            txtDescricao.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tipogames obj = new Tipogames();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído!");
            txtId.Clear();
            txtMidia.Clear();
            txtDescricao.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Tipogames obj = new Tipogames();
            dataGridView1.DataSource = obj.Listar();
        }
    }
}
