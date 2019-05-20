using PE3_Adriana_Kenny.web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Models
{
    public class AdminIndexVM
    {
        public List<Hotel> Hotels { get; set; }
        public long Id { get; set; }
    }
}
