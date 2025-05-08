using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{

    internal class ConexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "dbEstacionamento";
        private const string usuario = "root";
        private const string senha = "1IsabelaCR2";

        static public string bancoSrevidor = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha};";


    
    }
}
