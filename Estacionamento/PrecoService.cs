using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class PrecoService
    {
        
        public decimal CalcularValor(DateTime entrada, DateTime saida)
        {
            var preco = ObterPrecoAtual(); 
            TimeSpan duracao = saida - entrada;

            if (duracao.TotalMinutes <= 30)
                return preco.ValorInicial / 2;

            double horasTotais = duracao.TotalMinutes / 60.0;
            int horasCheias = (int)horasTotais;

            double minutosExcedentes = duracao.TotalMinutes - (horasCheias * 60);

            int adicionais = minutosExcedentes <= 10 ? horasCheias - 1 : horasCheias;

            return preco.ValorInicial + (adicionais * preco.ValorAdicional); 
        }

        private Preco ObterPrecoAtual()
        {
            return new Preco { ValorInicial = 10.00m, ValorAdicional = 5.00m };
        }
    }

    public class Preco
    {
        public decimal ValorInicial { get; set; } 
        public decimal ValorAdicional { get; set; } 
    }
}

