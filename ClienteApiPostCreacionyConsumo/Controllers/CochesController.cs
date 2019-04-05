using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiPostCreacionyConsumo.Models;
using ClienteApiPostCreacionyConsumo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiPostCreacionyConsumo.Controllers
{
    public class CochesController : Controller
    {
        IRepositoryApiCoches repo;
        public CochesController(IRepositoryApiCoches repo)
        {
            this.repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            List<String> marcas = await this.repo.GetMarcas();                       
            return View(marcas);
        }

        [HttpPost]
        public async Task<IActionResult> Index(String marca, String accion)
        {
            List<String> marcas = await this.repo.GetMarcas();                       
            if (accion == "buscar")
            {
                List<Coche> coches = await this.repo.GetCochesPorMarca(marca);
                ViewBag.Seleccion = coches;
            }else if (accion == "todos")
            {
                List<Coche> todosloscoches = await this.repo.GetCoches();
                ViewBag.Todos = todosloscoches;
            }
            
            return View(marcas);
        }
    }
}