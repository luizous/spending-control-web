﻿using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.Repository
{
    public class LancamentoRepository : ILancamentoRepository<Lancamento>
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        public LancamentoRepository(Context context)
        {
            _context = context;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Lancamento l, Usuario usuario)
        {
            try
            {
                l.Usuario = usuario;
                _context.Lancamentos.Add(l);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Editar
        public bool Editar(Lancamento l)
        {
            try
            {
                _context.Lancamentos.Update(l);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region Obter
        public Lancamento Obter(int? idLancamento)
        {
            return _context.Lancamentos.Find(idLancamento);
        }
        #endregion

        #region Listar
        public List<Lancamento> Listar(int idUsuario) => _context.Lancamentos
            .Include("Categoria")
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario)
            .ToList();
        #endregion

        #region ListarPorCategoria
        public List<Lancamento> ListarPorCategoria(int idUsuario, int idCategoria) => _context.Lancamentos
            .Where(x => x.Usuario.IdUsuario == idUsuario && x.Categoria.IdCategoria == idCategoria)
            .ToList();
        #endregion

        #region ListarRecentes
        public List<Lancamento> ListarRecentes(int idUsuario) => _context.Lancamentos
            .Include("Categoria")
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario)
            .Take(10) // pega os últimos 10 registros
            .ToList();
        #endregion

        #region ListarLancamentoDia
        public List<Lancamento> ListarDia(int idUsuario) => _context.Lancamentos
            .Include("Categoria")
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataLancamento.Day == DateTime.Now.Day).ToList();
        #endregion

        #region ListarLancamentoMesAtual
        public List<Lancamento> ListarMesAtual(int idUsuario) => _context.Lancamentos
            .Include("Categoria")
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataLancamento.Month == DateTime.Now.Month)
            .ToList();
        #endregion

        #region ListarLancamentoMesPassado
        public List<Lancamento> ListarMesPassado(int idUsuario)
        {
            var mesPassado = DateTime.Now.AddMonths(-1).Month;
            var lista = _context.Lancamentos
            .Include("Categoria")
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataLancamento.Month.Equals(mesPassado))
            .ToList();
            return lista;
        }
        #endregion

        #region ListarLancamentoQuinzenal
        public List<Lancamento> ListarQuinzenal(int idUsuario)
        {
            var quinzenal = DateTime.Now.Subtract(TimeSpan.FromDays(15));
            var lista = _context.Lancamentos
            .Include("Categoria")
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataLancamento >= quinzenal &&
                        x.DataLancamento < DateTime.Now)
            .ToList();
            return lista;
        }
        #endregion
    }
}
