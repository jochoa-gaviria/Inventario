using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.Web.Models
{
    public class ActivoViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string TipoActivo { get; }
    }
}
