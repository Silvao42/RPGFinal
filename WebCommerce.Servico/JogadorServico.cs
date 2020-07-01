using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class JogadorServico : IJogadorServico
    {
        private readonly IJogadorRepositorio _jogadorRepositorio;

        public JogadorServico(IJogadorRepositorio jogadorRepositorio)
        {
            _jogadorRepositorio = jogadorRepositorio;
        }

        public NotificationResult Excluir(Jogador entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodJogador != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _jogadorRepositorio.Remover(entidade);
                        NotificationResult.Add("Cadastro excluido com Sucesso!");

                        return NotificationResult;
                    }

                    else
                        return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
                }

                else
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Jogador> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Jogador>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Jogador ListarUm(int CodJogador)
        {
            return _jogadorRepositorio.ListarUm(CodJogador);
        }

        public NotificationResult Salvar(Jogador entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(Jogador entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodJogador != 0)

                    entidade.CodJogador = entidade.CodJogador;

                if (NotificationResult.IsValid)
                {
                    _jogadorRepositorio.Atualizar(entidade);
                    NotificationResult.Add("Cadastro Alterado com Sucesso!");

                    return NotificationResult;
                }

                else
                {
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
                }
            }
            catch (Exception)
            {
                return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

        }
    }
}
