using Aplicacao.Contexto;
using Aplicacao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao.Controllers
{
    public class UsuarioController : Controller
    {
        public readonly LojaDbContext _contexto;

        public UsuarioController(LojaDbContext pContexto)
        {
            _contexto = pContexto;
        }

        public IActionResult Index()
        {
            IEnumerable<Usuario> listaDeUsuarios = _contexto.Usuario;

            List<Usuario> novaListaDeUsuarios = new List<Usuario>();
            if (listaDeUsuarios.Any())
            {
                foreach (var usuario in listaDeUsuarios.ToList())
                {
                    usuario.Nivel = _contexto.Nivel.Find(usuario.NivelId);
                    novaListaDeUsuarios.Add(usuario);
                }
            }

            return View(novaListaDeUsuarios);
        }

        public IActionResult Novo()
        {
            IEnumerable<Nivel> listaDeNivel = _contexto.Nivel;

            ViewBag.ListaDeNiveis = new SelectList(listaDeNivel, "EntidadeId", "Nome");

            Usuario usuario = new Usuario
            {
                EntidadeId = Guid.NewGuid(),
                DataDeCadastro = DateTime.Now,
                Nome = "TEste123",

            };

            return View("Registro", usuario);
        }

        public IActionResult Alterar(Guid pUsuarioId)
        {
            Usuario usuario = _contexto.Usuario.Find(pUsuarioId);
            if (usuario != null)
            {
                IEnumerable<Nivel> listaDeNivel = _contexto.Nivel;

                ViewBag.ListaDeNiveis = new SelectList(listaDeNivel, "EntidadeId", "Nome");

                usuario.DataDeAtualizacao = DateTime.Now;

                return View("Registro", usuario);
            }

            return NotFound("Registro não encontrado.");
        }

        public void Teste(SelectList item)
        {

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Gravar(Usuario pUsuario)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = _contexto.Usuario.Find(pUsuario.EntidadeId);
                if (usuario != null)
                {
                    usuario.Nome = pUsuario.Nome;
                    usuario.Endereco = pUsuario.Endereco;
                    usuario.Email = pUsuario.Email;
                    usuario.Descricao = pUsuario.Descricao;
                    usuario.Observacao = pUsuario.Observacao;
                    usuario.Celular = pUsuario.Celular;
                    usuario.Telefone = pUsuario.Telefone;
                    usuario.DataDeAtualizacao = pUsuario.DataDeAtualizacao;
                    usuario.DataDeCadastro = pUsuario.DataDeCadastro;
                    usuario.Ativo = pUsuario.Ativo;
                    usuario.CpfCnp = pUsuario.CpfCnp;
                    usuario.NivelId = pUsuario.NivelId;
                    usuario.LogUsuario = pUsuario.LogUsuario;
                    usuario.LogSenha = pUsuario.LogSenha;
                    usuario.CelularOpcional = pUsuario.CelularOpcional;

                    _contexto.Usuario.Update(usuario);
                }
                else
                {
                    _contexto.Usuario.Add(pUsuario);
                }

                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        public IActionResult Excluir(Guid pUsuarioId)
        {
            Usuario usuario = _contexto.Usuario.Find(pUsuarioId);
            if (usuario != null)
            {
                _contexto.Usuario.Remove(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return NotFound("Registro não encontrado.");
        }
    }
}
