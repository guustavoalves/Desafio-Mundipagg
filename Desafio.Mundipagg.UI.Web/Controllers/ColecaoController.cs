using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Desafio.Mundipagg.UI.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Desafio.Mundipagg.UI.Web.Controllers
{
    public class ColecaoController : Controller
    {
        // GET: Colecao
        public async Task<ActionResult> Index(string order, string search, string tipo)
        {
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentTipo = tipo;

            var model = new List<Colecao>();

            try
            {

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44394/api/v1/itens"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        model = JsonConvert.DeserializeObject<List<Colecao>>(apiResponse);
                    }
                }
            }
            catch
            {
            }

            switch (tipo)
            {
                case "1":
                    model = model.Where(m => m.Tipo.ToUpper().Equals("CD")).ToList();
                    break;
                case "2":
                    model = model.Where(m => m.Tipo.ToUpper().Equals("DVD")).ToList();
                    break;
                case "3":
                    model = model.Where(m => m.Tipo.ToUpper().Equals("LIVRO")).ToList();
                    break;
            }

            if (!String.IsNullOrEmpty(search))
            {
                model = model.Where(m => m.Id.ToUpper().Contains(search.ToUpper())
                                    || m.Titulo.ToUpper().Contains(search.ToUpper())
                                    || m.Tipo.ToUpper().Contains(search.ToUpper())
                                    || m.Localizacao.ToUpper().Contains(search.ToUpper())
                                    || m.Status.ToUpper().Contains(search.ToUpper())).ToList();
            }

            switch (order)
            {
                case "1":
                    model = model.OrderBy(m => m.Id).ToList();
                    break;
                case "2":
                    model = model.OrderBy(m => m.Titulo).ToList();
                    break;
                case "3":
                    model = model.OrderBy(m => m.Tipo).ToList();
                    break;
                case "4":
                    model = model.OrderBy(m => m.Localizacao).ToList();
                    break;
                case "5":
                    model = model.OrderBy(m => m.Status).ToList();
                    break;
            }

            return View(model);
        }

        // GET: Colecao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Colecao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colecao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Colecao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Colecao/Edit/5
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

        // GET: Colecao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Colecao/Delete/5
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