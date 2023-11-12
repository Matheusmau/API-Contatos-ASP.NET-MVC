using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dioMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace dioMVC.Controllers
{
    public class ContatoController : Controller
    {   
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context) // injecao de independencia.
        {
            _context = context;
        } 
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
            //carregar todos contatos existentes
        }

        //metodo criar
        public IActionResult Criar()
        {
            return View();
        }
    }
}