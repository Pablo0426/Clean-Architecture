using System.Collections.Generic;
using System.Threading.Tasks;
using MedioSocial.core.Entidades;

namespace MedioSocial.core.Interfaces
{
    public interface ILibroRepositorio
    {
        Task<IEnumerable<Libro>> GetLibro();
    }
}
