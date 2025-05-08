using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class movimentacao
    {
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public double Duracao { get; set; }
        public double TempoCobrado { get; set; }
        public decimal PrecoTotal { get; set; }

        public override string ToString()
        {
            return $"{Placa} - Entrada: {DataEntrada}, Saída: {DataSaida}, Valor: {PrecoTotal:C}";
        }
    }
}

