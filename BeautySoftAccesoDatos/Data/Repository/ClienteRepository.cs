using BeautySoft.AccesoDatos.Data.Repository.IRepositoy;
using BeautySoft.Data;
using BeautySoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BeautySoft.AccesoDatos.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly ApplicationDbContext _db;


        public ClienteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaClientes()
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente cliente)
        {
            var objDesdeDb = _db.Cliente.FirstOrDefault(s => s.Id == cliente.Id);
            objDesdeDb.Nombre = cliente.Nombre;
            objDesdeDb.Apellido = cliente.Apellido;
            objDesdeDb.estado = cliente.estado;
            objDesdeDb.Email = cliente.Email;
            //objDesdeDb.UrlImagen = cliente.UrlImagen;

            _db.SaveChanges();
        }

    }
}

