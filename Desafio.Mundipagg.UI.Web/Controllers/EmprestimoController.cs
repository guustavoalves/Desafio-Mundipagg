using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Desafio.Mundipagg.UI.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Desafio.Mundipagg.UI.Web.Controllers
{
    public class EmprestimoController : Controller
    {
        // GET: Emprestimo
        public async Task<ActionResult> Index()
        {
            var model = new List<Emprestimo>();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/emprestimos"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<List<Emprestimo>>(apiResponse);
                    }
                }
            }
            catch { }

            return View(model);
        }

        // GET: Emprestimo/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var model = new Emprestimo();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/emprestimos/" + id))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<Emprestimo>(apiResponse);
                    }
                }
            }
            catch { }

            return View(model);
        }

        public async Task<ActionResult> DetailsByColecao(string id)
        {            
            var emprestimo = new List<Emprestimo>();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/emprestimos"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        emprestimo = JsonConvert.DeserializeObject<List<Emprestimo>>(apiResponse);
                    }
                }
            }
            catch { }

            var item = emprestimo.Where(e => e.IdItem.Equals(id) && e.Situacao.ToUpper().Equals("EMPRESTADO")).ToList();

            return RedirectToAction("Details", new { id = item[0].Id });
        }

        // GET: Emprestimo/Create
        public async Task<ActionResult> Create()
        {
            var pessoa = new List<PessoaAPI>();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/pessoas"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        pessoa = JsonConvert.DeserializeObject<List<PessoaAPI>>(apiResponse);
                    }
                }
            }
            catch { }

            var colecao = new List<Colecao>();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        colecao = JsonConvert.DeserializeObject<List<Colecao>>(apiResponse);
                    }
                }
            }
            catch { }

            ViewBag.Pessoa = new SelectList(pessoa, "Id", "Nome");
            ViewBag.Item = new SelectList(colecao.Where(c => c.Status.ToUpper().Equals("DISPONÍVEL")), "Id", "Titulo");

            return View();
        }

        
        public async Task<ActionResult> CreateEmprestimo(string item, string pessoa)
        {
            try
            {
                var colecao = new List<Colecao>();

                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens"))
                        {
                            var apiResponse = await response.Content.ReadAsStringAsync();
                            colecao = JsonConvert.DeserializeObject<List<Colecao>>(apiResponse);
                        }
                    }
                }
                catch { }

                var result = colecao.Where(c => c.Id.Equals(item)).ToList();

                var emprestimo = new EmprestimoInsert
                {
                    IdItem = item,
                    IdPessoa = pessoa,
                    TipoItem = (result[0].Tipo.ToUpper() == "LIVRO") ? "3" : (result[0].Tipo.ToUpper() == "DVD") ? "2" : "1"
                };

                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        StringContent content = new StringContent(JsonConvert.SerializeObject(emprestimo), Encoding.UTF8, "application/json");

                        using (var response = await httpClient.PostAsync("https://localhost:44394/api/v1/itens/emprestimos", content))
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
                return View();
            }
        }

        // GET: Emprestimo/Edit/5
        public async Task<ActionResult> Devolver(string id)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PutAsync("https://localhost:44394/api/v1/itens/devolucoes/" + id, null))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch { }

            return RedirectToAction(nameof(Index));
        }

        // POST: Emprestimo/Edit/5
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

        // GET: Emprestimo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emprestimo/Delete/5
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