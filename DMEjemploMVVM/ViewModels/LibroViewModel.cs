using DMEjemploMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DMEjemploMVVM.ViewModels
{
    public class LibroViewModel : INotifyPropertyChanged
    {
        private Libro _libro
        { 
            get { return _libro; } 
            set { _libro = value; 
                OnPropertyChanged (nameof(Libro));
            
            }
        }
        public List<Libro> Libros { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
     
}

