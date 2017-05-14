﻿using System;
using A15147442_ENT.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15147442_ENT.IRepositories
{
    public interface IVentaRepository : IRepository<Venta>
    {
        IEnumerable<Venta> GetVentasWithCentroDeAtencions(int pageIndex, int pageSize);
    }
}