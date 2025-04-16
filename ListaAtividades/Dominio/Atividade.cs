﻿using ListaAtividades.Repositorio;

namespace ListaAtividades.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        private readonly AtividadeRepositorio repositorio = new();

        public bool Criar()
        {
            if (!ValidarTitulo())
            {
                return false;
            }

            repositorio.Criar(Titulo);
            return true;
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId())
            {
                return false;
            }

            if (!ValidarSituacao())
            {
                return false;
            }

            var atividadeEmAndamento = BuscarAtividadesEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == novaSituacao) 
            {
                return false;
            }

            repositorio.AtualizarSituacao(Id,(int) novaSituacao);
            return true;
        }

        public Atividade BuscarAtividadesEmAndamento()
        {
            return repositorio.BuscarAtividadeEmAndamento();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return repositorio.ListarAtividadesPendentes();
        }

        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluido;
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);
        }

        private Situacao BuscarProximaSituacao()
        {
           //if (Situacao == Situacao.Pendente)
            //{
           //     return Situacao.Realizando;
           // }

           // return Situacao.Concluido;

            return Situacao == Situacao.Pendente ? Situacao.Realizando : Situacao.Concluido;
        }
    }

           
}

