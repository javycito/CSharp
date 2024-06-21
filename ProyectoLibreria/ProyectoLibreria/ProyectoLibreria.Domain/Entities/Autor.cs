﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibreria.Domain.Entities
{
    public class Autor
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public List<Libro> Libros { get; set; }
        }
    }
