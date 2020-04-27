using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Inventario.Web.Data;

namespace Inventario.Web.Controllers
{
    public class ActivosController : Controller
    {
        public object SqlDataReader { get; private set; }

        // GET: Activos
        public ActionResult Index()
        {
            SqlConnection con = Connection.OpenConnect();
            string consulta = "  select a.LNGIDACTIVO, a.STRNOMBREACTIVO, b.STRTIPOACTIVO  from TBLACTIVO a inner "+
                " join TBLTIPOACTIVO b on a.LNGIDTIPOACTIVO = b.LNGIDTIPOACTIVO";
            SqlCommand command = new SqlCommand(
            consulta, con);
            SqlDataReader data = command.ExecuteReader();
            Connection.CloseConnect(con);
            return View(data);
        }

        // GET: Activos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Activos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Activos/Create
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

        // GET: Activos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Activos/Edit/5
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

        // GET: Activos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Activos/Delete/5
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