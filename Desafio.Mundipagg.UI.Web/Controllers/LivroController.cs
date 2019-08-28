using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Desafio.Mundipagg.UI.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Desafio.Mundipagg.UI.Web.Controllers
{
    public class LivroController : Controller
    {
        // GET: Livro
        public async Task<ActionResult> Index()
        {
            var model = new List<Livro>();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/livros"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<List<Livro>>(apiResponse);
                    }
                }
            }
            catch { }
            
            return View(model);            
        }

        // GET: Livro/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var model = new Livro();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/livros/" + id))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<Livro>(apiResponse);
                    }
                }
            }
            catch { }

            return View(model);
        }

        // GET: Livro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Livro livro)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(livro), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://localhost:44394/api/v1/itens/livros", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Livro/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            var model = new Livro();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/livros/" + id))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<Livro>(apiResponse);
                    }
                }
            }
            catch { }

            return View(model);
        }

        // POST: Livro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Livro livro)
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

        // GET: Livro/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.DeleteAsync("https://localhost:44394/api/v1/itens/livros/" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch { }

            return RedirectToAction(nameof(Index));
        }

        // POST: Livro/Delete/5
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