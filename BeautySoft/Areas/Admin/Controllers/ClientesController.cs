using BeautySoft.AccesoDatos.Data.Repository.IRepositoy;
using BeautySoft.Data;
using BeautySoft.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeautySoft.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientesController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;


        public ClientesController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _context = context; 
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]

        public IActionResult Create() {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contenedorTrabajo.Cliente.Add(cliente);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Cliente cliente= new Cliente();
            cliente = _contenedorTrabajo.Cliente.Get(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contenedorTrabajo.Cliente.Update(cliente);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }




        #region llamada a la api

        [HttpGet]
        public IActionResult GetAll()
        {
            //opcion 1

            return Json(new { data = _contenedorTrabajo.Cliente.GetAll() });
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var clientes = _contenedorTrabajo.Cliente.GetAll(); // Obtén todos los clientes

        //    var data = clientes.Select(c => new
        //    {
        //        Nombre = c.Nombre,
        //        Apellido = c.Apellido,
        //        Email = c.Email,
        //        Telefono = c.Telefono
        //    });

        //    return Json(new { data });
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            var sliderDesdeDb = _contenedorTrabajo.Cliente.Get(id);


            if (sliderDesdeDb == null)
            {
                return Json(new { success = false, message = "Error borrando el Cliente" });
            }

            _contenedorTrabajo.Cliente.Remove(sliderDesdeDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Cliente borrado correctamente" });
        }


        #endregion

    }
}
