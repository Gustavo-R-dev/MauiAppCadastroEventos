using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppCadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Requisito 2: Calcula a duração em dias usando TimeSpan
        public int DuracaoEmDias
        {
            get
            {
                // Subtrai a data de término pela data de início
                TimeSpan diferenca = DataTermino.Date - DataInicio.Date;
                // Retorna a quantidade de dias (somando 1 para incluir o próprio dia inicial, se for o caso do seu app)
                return Math.Max(1, (int)diferenca.TotalDays);
            }
        }

        // Requisito 1: Calcula o custo total do evento
        public decimal CustoTotal
        {
            get
            {
                // Custo total = Número de participantes * Custo por participante * Duração em dias (ou fixo por participante)
                // Se o custo for por participante para todo o evento:
                return NumeroParticipantes * CustoPorParticipante;
            }
        }

        // Propriedade formatada para exibir o custo em Reais (R$) bonitinho na tela de resumo
        public string CustoTotalFormatado => CustoTotal.ToString("C2");
    }
}
