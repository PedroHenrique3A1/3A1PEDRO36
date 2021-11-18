using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

 namespace _3A1PEDRO36

{
    class Games
    {
        public int id;
        public string nome;
        public double preco;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into games values ('{id}', '{nome}', '{preco}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM games; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM games WHERE id = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE games SET nome = '{nome}', preco = '{preco}' WHERE id = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
