using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;

namespace trab.banco
{
    internal class Banco_funcoes
    {
        private SQLiteConnection conexao;
        string pasta = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);


        public void CriarBancoDeDados()
        {
            string dbPath = System.IO.Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.Personal), "clientes.db3");
            conexao = new SQLiteConnection(dbPath);
            conexao.CreateTable<Clientes>();
        }

        public void Inserir(string cpf, string nome, string ende, string fone, string idade)
        {
            conexao.Query<Clientes>("INSERT INTO clientes (CPF, Nome,Ende,Fone,Idade) " +
                "VALUES('" + cpf + "','" + nome + "','" + ende + "'," + fone + "'," + idade + ")");

        }

        private void DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public List<Clientes> GetClientes()
        {
            return conexao.Query<Clientes>("SELECT * FROM clientes");
        }

        public void Excluir(string cpf)
        {
            conexao.Query<Clientes>("DELETE FROM clientes WHERE CPF = " + cpf);

        }

        public void Editar(string cpf, string nome, string ende, string fone, string idade)
        {
            conexao.Query<Clientes>("UPDATE clientes SET Nome = '" + nome + "', Ende = '" + ende + "', Fone = '" + fone + "', Idade = '"
                + idade + "' WHERE CPF = '" + cpf + "' ");

        }

        //PESQUISAR COMMAND
        public List<Clientes> Pesquisar(string query)
            => conexao.Query<Clientes>
            ("SELECT * FROM clientes WHERE Nome like \"%" + query.Trim() + "%\"");

    }

}

