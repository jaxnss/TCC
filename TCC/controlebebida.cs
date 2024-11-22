namespace TCC
{
    public class Controlebebida
    {
        //chamo o objeto de conexao
        Conexao con = new Conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(bebida bebida)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {
                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into usuario (nome,preco,quantidade) values(@nome,@preco,@quantidade)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@preco", "@quantidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { bebida.nome, bebida.preco, bebida.quantidade.ToString() };
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
        public bool editar(bebida bebida)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update usuario set nome=@nome,preco=@preco,quantidade=@quantidade where cod_bebida=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@preco", "@quantidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { bebida.nome, bebida.preco, bebida.quantidade.ToString() };
                //testar o insert no banco de dados
                if (con.cadastrar(bebida.cod_bebida, campos, valores, sql) >= 1)
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
        public bool excluir(bebida bebida)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from usuario where cod_bebida=@id)";
                //monto o vetor de atributos da tabela usuario
                if (con.excluir(bebida.cod_bebida, sql) >= 1)
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


    }
}



