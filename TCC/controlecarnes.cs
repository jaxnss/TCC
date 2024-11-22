using MySql.Data.MySqlClient;

namespace TCC
{
    internal class controlecarnes
    {

        Conexao con = new Conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(carnes carnes)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into usuario(nome,preco, quantidade)values(@nome,@preco,@quantidade)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@preco", "@quantidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { carnes.nome, carnes.preco, carnes.quantidade.ToString() };
                //testar o insert no banco de dados
                if (con.cadastrar(0, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }



        }
        public bool editar(carnes carnes)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update usuario set nome=@nome,preco=@preco,quantidade=@quantidade where cod_carnes=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@preco", "@quantidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { carnes.nome, carnes.preco, carnes.quantidade.ToString() };
                //testar o insert no banco de dados
                if (con.cadastrar(carnes.cod_carnes, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public bool excluir(carnes carnes)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from usuario where cod_carnes=@id)";
                //monto o vetor de atributos da tabela usuario
                if (con.excluir(carnes.cod_carnes, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return resultado;
        }
        public int logar(carnes carnes)
        {
            try
            {
                //iniciar variavel zerada
                int registro = 0;
                //preparo a consulta 
                string sql = "select cod_carnes from usuario where nome=@nome and preco=@preco";
                MySqlConnection com = con.getConexao();//abro o banco de dados
                com.Open();
                MySqlCommand cmd = new MySqlCommand(sql, com);//preparo a execução
                cmd.Parameters.AddWithValue("@email", carnes.nome);
                cmd.Parameters.AddWithValue("@senha", carnes.preco);
                registro = Convert.ToInt32(cmd.ExecuteScalar());//
                return registro;// retorna o ID

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}

