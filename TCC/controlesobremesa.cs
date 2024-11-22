namespace TCC
{

    public class Controlesobremesa
    {


        //chamo o objeto de conexao
        Conexao con = new Conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(sobremesa sobremesa)
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
                string[] valores = { sobremesa.nome, sobremesa.preco, sobremesa.quantidade.ToString() };
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
        public bool editar(sobremesa sobremesa)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update usuario set nome=@nome,preco=@preco,quantidade=@quantidade where cod_molho=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@preco", "@quantidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { sobremesa.nome, sobremesa.preco, sobremesa.quantidade.ToString() };
                //testar o insert no banco de dados
                if (con.cadastrar(sobremesa.cod_sobremesa, campos, valores, sql) >= 1)
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
        public bool excluir(sobremesa sobremesa)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from usuario where cod_sobremesa=@id)";
                //monto o vetor de atributos da tabela usuario
                if (con.excluir(sobremesa.cod_sobremesa, sql) >= 1)
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
