using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Desafio.Mundipagg.UI.Web.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace Desafio.Mundipagg.UI.Web.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public async Task<ActionResult> Index()
        {
            var model = new List<Pessoa>();
            var result = new List<PessoaAPI>();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/pessoas"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        result = JsonConvert.DeserializeObject<List<PessoaAPI>>(apiResponse);
                    }
                }
            }
            catch { }

            foreach (var item in result)
            {
                model.Add(new Pessoa
                {
                    Cidade = item.End.Cidade,
                    Cpf = item.Cpf,
                    Email = item.Email,
                    Id = item.Id,
                    Nome = item.Nome,
                    Telefone = (item.Telefones.Count > 0) ? item.Telefones[0].DDD + item.Telefones[0].Numero : String.Empty
                });
            }            
            return View(model);
        }

        // GET: Pessoa/Details/5
        public async Task<ActionResult> Details(string id)
        {            
            var result = new PessoaAPI();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/pessoas/" + id))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        result = JsonConvert.DeserializeObject<PessoaAPI>(apiResponse);
                    }
                }
            }
            catch { }

            var model = new PessoaInsert
            {
                Cidade = result.End.Cidade,
                Cpf = result.Cpf,
                Email = result.Email,
                Nome = result.Nome,
                Bairro = result.End.Bairro,
                Cep = result.End.Cep,
                Complemento = result.End.Complemento,
                Logradouro = result.End.Logradouro,
                Numero = result.End.Numero,
                Uf = result.End.Uf,
                DddTelefone = result.Telefones[0].DDD,
                NumeroTelefone = result.Telefones[0].Numero

            };
            return View(model);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PessoaInsert pessoa)
        {
            try
            {
                var pessoaAPI = new PessoaAPI
                {
                    Cpf = pessoa.Cpf,
                    Email = pessoa.Email,
                    End = new Endereco
                    {
                        Bairro = pessoa.Bairro,
                        Cep = pessoa.Cep,
                        Cidade = pessoa.Cidade,
                        Complemento = pessoa.Complemento,
                        Logradouro = pessoa.Logradouro,
                        Numero = pessoa.Numero,
                        Uf = pessoa.Uf
                    },
                    Nome = pessoa.Nome                                         
                };

                var telefones = new List<Telefone>();
                telefones.Add(new Telefone
                {
                    DDD = pessoa.DddTelefone,
                    Numero = pessoa.NumeroTelefone,
                    Tipo = "1"
                });

                pessoaAPI.Telefones = telefones;

                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        StringContent content = new StringContent(JsonConvert.SerializeObject(pessoaAPI), Encoding.UTF8, "application/json");

                        using (var response = await httpClient.PostAsync("https://localhost:44394/api/v1/pessoas", content))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                        }
                    }
                }
                catch { }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.DeleteAsync("https://localhost:44394/api/v1/pessoas/" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch { }

            return RedirectToAction(nameof(Index));
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}