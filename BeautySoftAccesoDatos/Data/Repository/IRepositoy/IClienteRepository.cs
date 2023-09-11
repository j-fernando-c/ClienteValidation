using BeautySoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BeautySoft.AccesoDatos.Data.Repository.IRepositoy
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<SelectListItem> GetListaClientes();

        void Update(Cliente cliente);
    }
}
