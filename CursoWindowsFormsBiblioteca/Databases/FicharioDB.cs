using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDBClass db;

        public FicharioDB(string Tabela)
        {
            status = true; 
            try
            {
                db = new LocalDBClass();
                tabela = Tabela;
                mensagem = "Conexão com a Tabela criada com sucesso.";
            }
            catch (Exception Ex)
            {
                status = false;
                mensagem = "Conexão com a Tabela com erro: " + Ex.Message;
            }
        }
    }
}
