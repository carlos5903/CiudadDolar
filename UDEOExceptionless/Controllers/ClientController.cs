using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using UDEOExceptionless.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UDEOExceptionless.Controllers
{
    public class CLientController1 : Controller
    {

        ClientDataAccessLayer objcliente = new ClientDataAccessLayer();

        // GET: /<controller>/  
        public ActionResult Index()
        {
            List<Cliente> lstClient = new List<Cliente>();
            lstClient = objcliente.GetAllClient().ToList();

            return View(lstClient);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                objcliente.AddEmployee(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Cliente cliente = objcliente.GetClientData(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind]Cliente cliente)
        {
            if (id != cliente.CLienteId)
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                objcliente.UpdateCliente(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }


        [HttpGet]
        public ActionResult Detalles(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Cliente cliente = objcliente.GetClientData(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Borrar(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Cliente cliente = objcliente.GetClientData(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            objcliente.DeleteClient(id);
            return RedirectToAction("Index");
        }

    }
}