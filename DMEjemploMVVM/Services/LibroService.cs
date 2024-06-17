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
                Titulo = "libro1",
                Autor = "autor 1"
            },
            new Libro
            {
                Titulo = "libro2",
                Autor = "autor 2"
            },
            new Libro
            {
                Titulo = "libro3",
                Autor = "autor 3"
            },
            new Libro
            {
                Titulo = "libro4",
                Autor = "autor 4"
            },
            new Libro
            {
                Titulo = "libro5",
                Autor = "autor 5"
            }
            };
        }
    }
}
