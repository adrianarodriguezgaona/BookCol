using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Models
{
    public class BookingEditVM : BookingCreateVM
    {
        public long Id { get; set; }
        public List<Client> Clients { get; set; }
    }
}
