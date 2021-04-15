using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.Domain
{
    public class BaseEntity
    {
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    }
}
