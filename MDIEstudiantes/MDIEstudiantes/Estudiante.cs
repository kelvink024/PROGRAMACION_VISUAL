﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIEstudiantes
{
    public class Estudiante
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }

    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }
    }

    public static class DatosCompartidos
    {
        public static List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
}
