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
    public class ArmaInventarioServico : IArmaInventarioServico
    {
        private readonly IArmaInventarioRepositorio _armaInventarioRepositorio;

        public ArmaInventarioServico(IArmaInventarioRepositorio armaInventarioRepositorio)
        {
            _armaInventarioRepositorio = armaInventarioRepositorio;
        }

        public NotificationResult Excluir(ArmaInventario entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma != 0 && entidade.CodJogador != 0 && entidade.CodFicha != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _armaInventarioRepositorio.Remover(entidade);
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

        public IEnumerable<ArmaInventario> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<ArmaInventario>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public ArmaInventario ListarUm(int CodFicha, int CodJogador, int CodArma)
        {
            return _armaInventarioRepositorio.ListarUm(CodFicha, CodJogador, CodArma);
        }

        public NotificationResult Salvar(ArmaInventario entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodArma != 0 && entidade.CodJogador != 0 && entidade.CodFicha != 0)
                {
                    entidade.CodArma = entidade.CodArma;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodFicha = entidade.CodFicha;

                    if (NotificationResult.IsValid)
                    {
                        _armaInventarioRepositorio.Adicionar(entidade);
                        NotificationResult.Add("Cadastrado!");
                    }

                    return NotificationResult;
                }

                else
                    return NotificationResult.Add(new NotificationError("Erro no cadastro!", NotificationErrorType.USER)); ;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public NotificationResult Atualizar(ArmaInventario entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodArma != 0 && entidade.CodJogador != 0 && entidade.CodFicha != 0)

                    entidade.CodArma = entidade.CodArma;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodFicha = entidade.CodFicha;

                if (NotificationResult.IsValid)
                {
                    _armaInventarioRepositorio.Atualizar(entidade);
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
