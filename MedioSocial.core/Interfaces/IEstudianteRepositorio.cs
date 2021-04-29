using MedioSocial.core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedioSocial.core.Interfaces
{
    public interface IEstudianteRepositorio
    {
        Task<IEnumerable<Estudiante>> GetEstudiantes();
    }
}
