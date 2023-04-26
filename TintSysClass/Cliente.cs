using ClassLibrary2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Cliente
    {
        // atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime data;
        private bool ativo;
        //private List<Endereco> enderecos;
        //private List<Telefone> telefones;


        // Propriedades (Encapsulamento) getters and setters

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Data { get => data; set => data = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }

        public Cliente()
        {

        }
        public Cliente(int id, string email)
        {
            Id = id;
            Email = email;
        }

        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        // Métodos contrutores 
        public Cliente(int id, string nome, string cpf, string email, DateTime data, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;

        }
        public Cliente(string nome, string cpf, string email, DateTime data, bool ativo, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Ativo = ativo;
            Enderecos = enderecos;
            Telefones = telefones;
        }
        public Cliente(string nome, string email, bool ativo)
        {
            Nome = nome;
            Email = email;
            Ativo = ativo;
        }
        public Cliente(int id, string nome, string cpf, string email, DateTime data, bool ativo, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
            //Enderecos = enderecos;
            //Telefones = telefones;
        }

        // Métodos da Classes (inserir, alterar, consultar,por Id, por nome, etc.... )
        public void Inserir()
        {
            // cria uma variável com conexão de banco aberta
            var cmd = Banco.Abrir();
            // define o tipo de instrução MySQL a ser processada pelo serv banco dados 
            cmd.CommandType = CommandType.Text;
            // define a query sql especificada com parametros ()
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values (@nome, @cpf, @email, 'default' , 1)";
            // cria o parametro e associa ao valor
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@email", Email);
            // executa a instrução SQL na conexão
            cmd.ExecuteNonQuery();
            // obtendo o id do nível recém inserido
            cmd.CommandText = "select @@identity";
            // recupera o id na Propriedade
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexão
            Banco.Fechar(cmd);
        }
        public static Cliente ObterPorId(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where id = @id";
            cmd.Parameters.AddWithValue("@id", _id);
            var dr = cmd.ExecuteReader();
            Cliente cliente = null;
            while (dr.Read())
            {
                cliente = new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    //Endereco.Listar(dr.GetString(6)),
                    //Telefone.Listar(dr.GetString(7))
                    );
            }
            Banco.Fechar(cmd);
            return cliente;
        }
        public static Cliente ObterPorEmail(string _email)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where email = @email";
            cmd.Parameters.AddWithValue("@email", _email);
            var dr = cmd.ExecuteReader();
            Cliente cliente = null;
            while (dr.Read())
            {
                cliente = new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(3)
                    );
            }
            Banco.Fechar(cmd);
            return cliente;
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetBoolean(5),
                        Endereco.Listar(dr.GetString(6)),
                        Telefone.Listar(dr.GetString(7))));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = @nome, sigla = @sigla where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public static void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "UPDATE cliente ativo = 0 where id " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "UPDATE cliente set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public void Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from cliente where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        
    }
}