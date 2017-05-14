﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15147442_ENT.Entities
{
    public class Trabajador
    {
        public int TrabajadorId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public DateTime FechaInicioContrato { get; set; }

        public TipoTrabajador TipoTrabajador { get; set; }

        public int TipoTrabajadorId { get; set; }

        public List<Evaluacion> Evaluacion { get; set; }

        public Trabajador()
        {
            Evaluacion = new List<Evaluacion>();
        }


    }
}