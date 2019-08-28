using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Mundipagg.Domain.Entity;
using Desafio.Mundipagg.Domain.Repository;
using NUnit.Framework;

namespace Desafio.Mundipagg.Domain.Tests
{
    [TestFixture]
    public class DesafioMundipaggTests
    {
        Emprestimo emprestimo;
        Livro livro;

        [SetUp]
        public void setup()
        {
            emprestimo = new Emprestimo
            {
                Data = DateTime.Now,
                IdItem = "1",
                IdPessoa = "1",
                Status = StatusEmprestimo.Emprestado,
                Tipo = TipoItem.Livro
            };

            livro = new Livro
            {
                Titulo = "Bruce de Gothan",                
                Autor = "Gustavo Brum",
                Editora = "DC Comics",
                Localizacao = "Caixa 2 - Quarto",
                Status = StatusItem.Disponivel
            };
        }

        [Test]
        public void CadastrarPessoa()
        {
            var telefone = new List<Telefone>();
            telefone.Add(new Telefone
            {
                DDD = "21",
                Numero = "12345678",
                Tipo = TipoTelefone.Celular
            });

            var pessoa = new Pessoa
            {
                Nome = "Gustavo Brum Alves",
                Cpf = "12345612345",
                Email = "gustavo.alves@live.com",
                End = new Endereco
                {
                    Bairro = "Trindade",
                    Cep = "24935595",
                    Cidade = "Maricá",
                    Logradouro = "Rua José Manna Junior",
                    Complemento = "APT 2",
                    Numero = 298,
                    Uf = "RJ"
                },
                Telefones = telefone
            };

            var repository = new PessoaRepository(pessoa);

            Assert.That(pessoa, Is.Not.Null);
            Assert.That(repository.Pessoa.Nome, Is.EqualTo(pessoa.Nome));
        }

        [Test]
        public void CadastrarLivro()
        {
            var repository = new LivroRepository(livro);

            Assert.That(livro, Is.Not.Null);
            Assert.That(repository.Livro.Titulo, Is.EqualTo(livro.Titulo));
        }

        [Test]
        public void CadastrarMidia()
        {
            var midia = new Midia
            {                
                Diretor = "Lucas Albin",
                Genero = "Ação",
                Localizacao = "Gaveta do Rack",
                Status = StatusItem.Disponivel,
                Tipo = TipoMidia.DVD,
                Titulo = "Vingadores"
            };

            var repository = new MidiaRepository(midia);

            Assert.That(midia, Is.Not.Null);
            Assert.That(repository.Midia.Titulo, Is.EqualTo(midia.Titulo));
        }

        [Test]
        public void RegistarEmprestimo()
        {
            var emprestimo = new Emprestimo
            {
                Data = DateTime.Now,
                IdItem = "1",
                IdPessoa = "1",
                Status = StatusEmprestimo.Emprestado,
                Tipo = TipoItem.Livro
            };

            var repository = new EmprestimoRepository(emprestimo);

            Assert.That(emprestimo, Is.Not.Null);
            Assert.That(repository.Emprestimo.IdItem, Is.EqualTo(emprestimo.IdItem));
            Assert.That(repository.Emprestimo.Status, Is.EqualTo(emprestimo.Status));
        }

        [Test]
        public void DevolverEmprestimo()
        {
            emprestimo.Devolver();

            Assert.That(emprestimo, Is.Not.Null);
            Assert.That(emprestimo.DataDevolucao, Is.Not.Null);
            Assert.That(emprestimo.Status, Is.EqualTo(StatusEmprestimo.Devolvido));
        }

        [Test]
        public void ErroDevolverItemJaDevolvido()
        {
            emprestimo.Devolver();
            Assert.Throws<ItemJaDevolvidoException>(() => emprestimo.Devolver());
        }

        [Test]
        public void ErroEmprestarItemNaoDisponivel()
        {
            livro.Emprestar();
            Assert.Throws<ItemNaoEstaDisponivelException>(() => livro.Emprestar());
        }
    }
}
