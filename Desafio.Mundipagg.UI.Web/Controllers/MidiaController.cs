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
    public class MidiaController : Controller
    {
        // GET: Midia
        public async Task<ActionResult> Index()
        {
            var model = new List<Midia>();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/midias"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<List<Midia>>(apiResponse);
                    }
                }
            }
            catch { }

            return View(model);
        }

        // GET: Midia/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var model = new Midia();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/midias/" + id))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<Midia>(apiResponse);
                    }
                }
            }
            catch { }

            return View(model);
        }

        // GET: Midia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Midia/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Midia midia)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(midia), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://localhost:44394/api/v1/itens/midias", content))
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

        // GET: Midia/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            var model = new Midia();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens/midias/" + id))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<Midia>(apiResponse);
                    }
                }
            }
            catch { }

            return View(model);
        }

        // POST: Midia/Edit/5
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

        // GET: Midia/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.DeleteAsync("https://localhost:44394/api/v1/itens/midias/" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch { }

            return RedirectToAction(nameof(Index));
        }

        // POST: Midia/Delete/5
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