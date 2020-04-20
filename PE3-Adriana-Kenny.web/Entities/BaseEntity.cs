using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public abstract class BaseEntity <TKey>
    {
        public TKey Id { get; set;}
    }
}
