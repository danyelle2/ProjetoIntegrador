﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Assinatura { get; set; }
        public string Nome { get; set; }
        public bool StatusAluno { get; set; }
        public bool StatusPagamento { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string NomeResponsavel { get; set; }
        public int IdModalidade { get; set; }
        public string StatusAlunoTexto => StatusAluno ? "Ativo" : "Inativo";



    }
}