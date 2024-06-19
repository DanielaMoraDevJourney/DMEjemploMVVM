using DMEjemploMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMEjemploMVVM.Services
{
    public class LibroService : ILibroService
    {
        List<Libro> ILibroService.ObtenerLibro()
        {
            return new List<Libro>{
            new Libro
            {
                Titulo = "Libro1",
                Autor = "Autor 1"
            },
            new Libro
            {
                Titulo = "Libro2",
                Autor = "Autor 2"
            },
            new Libro
            {
                Titulo = "Libro3",
                Autor = "Autor 3"
            },
            new Libro
            {
                Titulo = "Libro4",
                Autor = "Autor 4"
            },
            new Libro
            {
                Titulo = "Libro5",
                Autor = "Autor 5"
            }
            };
        }
    }
}
