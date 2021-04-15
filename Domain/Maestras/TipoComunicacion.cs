using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.Domain
{
    public class TipoComunicacion : BaseEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
