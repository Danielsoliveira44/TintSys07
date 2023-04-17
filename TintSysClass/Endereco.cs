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
    public class Endereco
    {
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;
        private string tipo;

        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
        }


        // Métodos contrutores 
        public Endereco() 
        {

        } // vazio
        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado,
            string uf, string tipo)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;

        }
        public Endereco(int id, string logradouro, string numero, string bairro, string cidade)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert usuarios (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo), " +
                "@cep, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @uf, @tipo) ";
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@complemento", Complemento);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@cidade", Cidade);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@uf", Uf);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public static Endereco ObterPorId(int _id)
        {
            Endereco endereco = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new Endereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9)
                    );
            }
            Banco.Fechar(cmd);
            return endereco;
        }

        public static List<Endereco> Listar(string _nome = "")
        {
            List<Endereco> lista = new List<Endereco>();

            var cmd = Banco.Abrir();
            if (_nome != string.Empty)
                cmd.CommandText = "select * from enderecos where logradouro like '%" + _nome + "%'";
            else
                cmd.CommandText = "select * from enderecos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Endereco(
                         dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }


    }
}