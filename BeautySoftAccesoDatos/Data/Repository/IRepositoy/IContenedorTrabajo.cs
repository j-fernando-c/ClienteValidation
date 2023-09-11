using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySoft.AccesoDatos.Data.Repository.IRepositoy
{
    public interface IContenedorTrabajo : IDisposable
    {
        IClienteRepository Cliente { get; }
        //aqui deben de ir agregando los diferentes repositorios



        void Save();
    }
}
