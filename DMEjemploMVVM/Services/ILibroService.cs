using DMEjemploMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMEjemploMVVM.Services
{
    public interface ILibroService
    {
        List<Libro> ObtenerLibro();
    }
}
