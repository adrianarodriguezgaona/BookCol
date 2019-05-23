using PE3_Adriana_Kenny.web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Models
{
    public class EditRoomsVM : Room
    {

        public List<Roomtype> Roomtypes { get; set; }
        public Room Room { get; set; }
    }
}
