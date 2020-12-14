﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAlexGonzalezMorales.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public IEnumerable<Alumno> Alumnos { get; set; }
        public string Aula { get; set; }
    }
}
