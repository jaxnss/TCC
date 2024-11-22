namespace TCC
{
    public class Controlebatata
    {
        //chamo o objeto de conexao
        Conexao con = new Conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(batata batata)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {
                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into usuario(nome,preco,quantidade)values(@nome,@preco,@quantidade)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@preco", "@quantidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { batata.nome, batata.preco, batata.quantidade.ToString() };
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
        public bool editar(batata batata)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update usuario set nome=@nome,preco=@preco,quantidade=@quantidade where cod_batata=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@preco", "@quantidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { batata.nome, batata.preco, batata.quantidade.ToString() };
                //testar o insert no banco de dados
                if (con.cadastrar(batata.cod_batata, campos, valores, sql) >= 1)
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
        public bool excluir(batata batata)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from usuario where cod_batata=@id)";
                //monto o vetor de atributos da tabela usuario
                if (con.excluir(batata.cod_batata, sql) >= 1)
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
