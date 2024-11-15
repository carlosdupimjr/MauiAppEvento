using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEvento.Models
{
    public class Evento
    {
        public string NomeDoEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QntParticipantes { get; set; }
        public string LocalEvento { get; set; }
        public double ValorParticipante { get; set; }
        public int DuracaoEvento
        {
            get => DataTermino.Subtract(DataInicio).Days+1;
        }
        public double CustoEvento
        {
            get
            {
                double valor_evento = QntParticipantes * ValorParticipante;
                double total = valor_evento * DuracaoEvento;
                return (double)total;
            }
        }


    }
}