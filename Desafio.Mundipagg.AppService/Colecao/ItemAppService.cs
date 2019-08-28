using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;
using Desafio.Mundipagg.Domain.Repository;
using Desafio.Mundipagg.AppService.DTO;

namespace Desafio.Mundipagg.AppService.Colecao
{
    public class ItemAppService
    {
        public static IEnumerable<ItemDTO> Obter()
        {
            var livros = new LivroRepository().Obter();
            var midias = new MidiaRepository().Obter();

            return ItemDTO.Criar(livros, midias);
        }

        public static IEnumerable<LivroDTO> ObterLivros()
        {            
            return LivroDTO.Criar(new LivroRepository().Obter());
        }

        public static LivroDTO ObterLivro(string id)
        {
            return LivroDTO.Criar(new LivroRepository().ObterPorId(id));
        }

        public static IEnumerable<MidiaDTO> ObterMidias()
        {                        
            return MidiaDTO.Criar(new MidiaRepository().Obter());
        }

        public static MidiaDTO ObterMidia(string id)
        {
            return MidiaDTO.Criar(new MidiaRepository().ObterPorId(id));
        }

        public static IEnumerable<EmprestimoRetornoDTO> ObterEmprestimos()
        {
            string titulo;
            var emprestimos = new EmprestimoRepository().Obter();            

            foreach (var emprestimo in emprestimos)
            {
                var pessoa = new PessoaRepository().ObterPorId(emprestimo.IdPessoa);

                if (emprestimo.Tipo == TipoItem.Livro)
                {
                    var livro = new LivroRepository().ObterPorId(emprestimo.IdItem);
                    titulo = livro.Titulo;
                }
                else
                {
                    var midia = new MidiaRepository().ObterPorId(emprestimo.IdItem);
                    titulo = midia.Titulo;
                }
                yield return EmprestimoRetornoDTO.Criar(emprestimo, pessoa, titulo);
            }            
        }

        public static EmprestimoRetornoDTO ObterEmprestimo(string id)
        {
            string titulo;
            var emprestimo = new EmprestimoRepository().ObterPoId(id);

            var pessoa = new PessoaRepository().ObterPorId(emprestimo.IdPessoa);

            if (emprestimo.Tipo == TipoItem.Livro)
            {
                var livro = new LivroRepository().ObterPorId(emprestimo.IdItem);
                titulo = livro.Titulo;
            }
            else
            {
                var midia = new MidiaRepository().ObterPorId(emprestimo.IdItem);
                titulo = midia.Titulo;
            }
            return EmprestimoRetornoDTO.Criar(emprestimo, pessoa, titulo);
        }

        public static void InserirLivro(LivroDTO livro)
        {
            var repository = new LivroRepository(LivroDTO.Criar(livro));
            repository.Inserir();
        }

        public static void InserirMidia(MidiaDTO midia)
        {
            var repository = new MidiaRepository(MidiaDTO.Criar(midia));
            repository.Inserir();
        }

        public static void AlterarLivro(string id, LivroDTO livro)
        {
            var repository = new LivroRepository(LivroDTO.Criar(livro));
            repository.Alterar(id);
        }

        public static void AlterarMidia(string id, MidiaDTO midia)
        {
            var repository = new MidiaRepository(MidiaDTO.Criar(midia));
            repository.Alterar(id);
        }

        public static void Emprestar(EmprestimoDTO emprestimo)
        {
            var repository = new EmprestimoRepository(EmprestimoDTO.Criar(emprestimo));
            repository.Inserir();
            
            if(emprestimo.TipoItem == TipoItem.Livro)
            {
                var livroReporitory = new LivroRepository();

                var livro = livroReporitory.ObterPorId(emprestimo.IdItem);
                livro.Emprestar();

                livroReporitory.Livro = livro;
                livroReporitory.Alterar(emprestimo.IdItem);
            }
            else
            {
                var midiaReporitory = new MidiaRepository();

                var midia = midiaReporitory.ObterPorId(emprestimo.IdItem);
                midia.Emprestar();

                midiaReporitory.Midia = midia;
                midiaReporitory.Alterar(emprestimo.IdItem);
            }
        }

        public static void Devolver(string id)
        {            
            var repositoriEmprestimo = new EmprestimoRepository();

            var emprestimo = repositoriEmprestimo.ObterPoId(id);
            emprestimo.Devolver();

            repositoriEmprestimo.Emprestimo = emprestimo;
            repositoriEmprestimo.Alterar(id);
            

            if (emprestimo.Tipo == TipoItem.Livro)
            {
                var livroReporitory = new LivroRepository();

                var livro = livroReporitory.ObterPorId(emprestimo.IdItem);
                livro.Devolver();

                livroReporitory.Livro = livro;
                livroReporitory.Alterar(emprestimo.IdItem);
            }
            else
            {
                var midiaReporitory = new MidiaRepository();

                var midia = midiaReporitory.ObterPorId(emprestimo.IdItem);
                midia.Devolver();

                midiaReporitory.Midia = midia;
                midiaReporitory.Alterar(emprestimo.IdItem);
            }
        }

        public static void ExcluirLivro(string id)
        {
            new LivroRepository().Excluir(id);
        }

        public static void ExcluirMidia(string id)
        {
            new MidiaRepository().Excluir(id);
        }
    }
}
