﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1PEDRO36
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.nome = txtNome.Text;
            obj.senha = txtSenha.Text;

            if (obj.Logar() == true)
            {
                Frm_games Frm_games = new Frm_games();
                Frm_games.ShowDialog();
            }
            else { MessageBox.Show("Não cadastrado!", "Erro", MessageBoxButtons.OK); }
        }
    }
}

