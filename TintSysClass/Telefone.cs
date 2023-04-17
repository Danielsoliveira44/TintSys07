using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TintSysClass;

namespace ClassLibrary2
{
    public class Telefone
    {
        // atributos

        private int id;
        private string numero;
        private string tipo;
        private Cliente cliente;


        // Propriedades (Encapsulamento) getters and setters
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        // Métodos contrutores 
        public Telefone()
        {

        }
        public Telefone(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;

        }
        public Telefone(int id, string numero, string tipo, Cliente cliente)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Cliente = cliente;
            
        }
        public Telefone(string numero, string tipo, Cliente cliente)
        {
            Numero = numero;
            Tipo = tipo;
            Cliente = cliente;
        }
        // Métodos da Classes (inserir, alterar, consultar,por Id, por nome, etc.... )
        public void Inserir()
        {
            // cria uma variável com conexão de banco aberta
            var cmd = Banco.Abrir();
            // define o tipo de instrução MySQL a ser processada pelo serv banco dados 
            cmd.CommandType = CommandType.Text;
            // define a query sql especificada com parametros ()
            cmd.CommandText = "insert telefones (numero, tipo, cliente_id) values (@numero, @tipo, @cliente)";
            // cria o parametro e associa ao valor
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.Parameters.AddWithValue("@cliente", Cliente.Id);
            // executa a instrução SQL na conexão
            cmd.ExecuteNonQuery();
            // obtendo o id do nível recém inserido
            cmd.CommandText = "select @@identity";
            // recupera o id na Propriedade
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexão
            Banco.Fechar(cmd);
        }
        public static Telefone ObterPorId(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from telefones where id = @id";
            cmd.Parameters.AddWithValue("@id", _id);
            var dr = cmd.ExecuteReader();
            Telefone telefone = null;
            while (dr.Read())
            {
                telefone = new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Cliente.ObterPorId(dr.GetInt32(3)
                    ));
            }
            Banco.Fechar(cmd);
            return telefone;
        }
        public static List<Telefone> Listar(string _nome = "")
        {
            List<Telefone> lista = new List<Telefone>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (_nome != string.Empty)
                cmd.CommandText = "select * from telefones like '%" + _nome + "%'";
            else
                cmd.CommandText = "select * from telefones order by numero";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Telefone(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                    )
                );
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update telefones set numero = @numero, tipo = @tipo where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}